Imports System.IO
Imports System.Text


'Notes
'Add a check to see if the file doesnt have a . on it
'check if folder has cache on it.
'Refine detection of file format
'Add sep folders for each program
Public Class Form1
    Public discacheloc = "" '"C:\Users\" & Environment.UserName & "\AppData\Roaming\discord\Cache\"
    Public tempdiscacheloc = Application.StartupPath & "\CacheFiles\"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(tempdiscacheloc) Then
            CacheExplorerList.Items.Clear()

            For Each file In My.Computer.FileSystem.GetFiles(tempdiscacheloc)
                Dim filest As New FileStream(file, FileMode.Open, FileAccess.Read)
                CacheExplorerList.Items.Add(Path.GetFileName(file) & " (" & GetImageFormat(filest) & ")")
                filest.Close()
            Next
            For Each item In CacheExplorerList.Items
                CacheListBackup.Items.Add(item)
            Next
        Else
            'If FolderBrowserDialog1.ShowDialog <> DialogResult.Cancel Then
            'discacheloc = FolderBrowserDialog1.SelectedPath
            'If My.Computer.FileSystem.DirectoryExists(discacheloc) Then
            '    My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\CacheFiles\")
            '    For Each file In My.Computer.FileSystem.GetFiles(tempdiscacheloc)
            '        ListBox1.Items.Add(Path.GetFileName(file) & " (" & GetImageFormat(New FileStream(file, FileMode.Open, FileAccess.Read)) & ")")
            '    Next
            '    For Each item In ListBox1.Items
            '        ListBox2.Items.Add(item)
            '    Next
            'Else
            '    MsgBox("0x02, Dir does not exist, exiting.")
            '    Close()
            'End If
            'End If
            ChangeCacheFolder.Show()
        End If
        TotalFilesLabel.Text = "Total: " & CacheExplorerList.Items.Count
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CacheExplorerList.SelectedIndexChanged
        LoadImage()
    End Sub

    Private Sub LoadImage()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()

        If OverrideCheck.Checked = True Then
            If OpenTypeCheck.Text = "Plain Text" Then
                PlainTextBox.Visible = True
                AxWindowsMediaPlayer1.Visible = False
                Try
                    PlainTextBox.LoadFile(tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0), RichTextBoxStreamType.PlainText)
                Catch ex1 As Exception
                    ImageDisplay.Image = ImageDisplay.ErrorImage
                End Try
                Dim filesize As New FileInfo(tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0))
            ElseIf OpenTypeCheck.Text = "Image" Then
                Try
                    PlainTextBox.Visible = False
                    AxWindowsMediaPlayer1.Visible = False
                    Dim filestre As New FileStream(tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0), FileMode.Open, FileAccess.Read)
                    ImageDisplay.Image = Image.FromStream(filestre)
                Catch ex As Exception
                    ImageDisplay.Image = ImageDisplay.ErrorImage
                End Try
            ElseIf OpenTypeCheck.Text = "Video" Then
                AxWindowsMediaPlayer1.Visible = True
                PlainTextBox.Visible = False
                AxWindowsMediaPlayer1.URL = tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0)
                If AutoPlayCheck.Checked Then
                    AutoPlayTimer.Start()
                Else
                    AutoPlayTimer.Stop()
                End If
            End If
        Else
            ImageDisplay.Visible = True
            'MsgBox(ListBox1.SelectedItem.ToString.Split("("c)(1).Remove(ListBox1.SelectedItem.ToString.Split("("c)(1).Length - 1))
            Dim selectedfile = (CacheExplorerList.SelectedItem.ToString.Split("("c)(1).Remove(CacheExplorerList.SelectedItem.ToString.Split("("c)(1).Length - 1))
            If selectedfile = ".png" Or selectedfile = ".gif" Or selectedfile = ".jpg" Or selectedfile = ".jpeg" Or selectedfile = ".bmp" Or selectedfile = ".wmf" Then
                Try
                    AxWindowsMediaPlayer1.Ctlcontrols.stop()
                    PlainTextBox.Visible = False
                    AxWindowsMediaPlayer1.Visible = False
                    Dim filestrea As New FileStream(tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0), FileMode.Open, FileAccess.Read)
                    ImageDisplay.Image = Image.FromStream(filestrea)

                Catch ex As Exception
                    ImageDisplay.Image = ImageDisplay.ErrorImage
                End Try
                AutoPlayTimer.Stop()
            ElseIf selectedfile = ".mp4" Or selectedfile = ".webm" Then
                AxWindowsMediaPlayer1.Visible = True
                PlainTextBox.Visible = False
                AxWindowsMediaPlayer1.URL = tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0)
                If AutoPlayCheck.Checked Then
                    AutoPlayTimer.Start()
                Else
                    AutoPlayTimer.Stop()
                End If
            ElseIf selectedfile = ".unknown" Then
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                AxWindowsMediaPlayer1.URL = Nothing
                PlainTextBox.Visible = True
                AxWindowsMediaPlayer1.Visible = False
                Try
                    If My.Computer.FileSystem.FileExists(Application.StartupPath & "\settings.ini") Then
                        PlainTextBox.LoadFile(tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0), RichTextBoxStreamType.PlainText)
                    Else
                        Dim msg = MsgBox("Warning! Loading .unknown files in plain text may take awhile depending on the file size. Are you sure you want to load it? Press Cancel to load and never show up again.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Warning!")
                        If msg = MsgBoxResult.Yes Then
                            PlainTextBox.LoadFile(tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0), RichTextBoxStreamType.PlainText)
                        ElseIf msg = MsgBoxResult.Cancel Then
                            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\settings.ini", "", False)
                        End If
                    End If
                Catch ex1 As Exception
                    ImageDisplay.Image = ImageDisplay.ErrorImage
                End Try
                AutoPlayTimer.Stop()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ScanCachebutton.Click
        CacheExplorerList.Items.Clear()
        Label3.Visible = True
        Application.DoEvents()

        For Each file In My.Computer.FileSystem.GetFiles(discacheloc)
            On Error Resume Next
            My.Computer.FileSystem.CopyFile(file, tempdiscacheloc & Path.GetFileName(file), True)
            Threading.Thread.Sleep(5)
        Next
        For Each file In My.Computer.FileSystem.GetFiles(tempdiscacheloc)
            Dim filestrea As New FileStream(file, FileMode.Open, FileAccess.Read)
            CacheExplorerList.Items.Add(Path.GetFileName(file) & " (" & GetImageFormat(filestrea) & ")")
            filestrea.Close()
        Next
        CacheListBackup.Items.Clear()
        For Each item In CacheExplorerList.Items
            CacheListBackup.Items.Add(item)
        Next
        TotalFilesLabel.Text = "Total: " & CacheExplorerList.Items.Count
        Label3.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExportButt.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        For Each item In CacheExplorerList.SelectedItems
            Dim FileToSaveAs As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, SaveFileDialog1.FileName & item.ToString)
            Dim selectedfile = (item.ToString.Split("("c)(1).Remove(item.ToString.Split("("c)(1).Length - 1))
            Dim filestream As New FileStream(tempdiscacheloc & item.ToString.Split("("c)(0), FileMode.Open, FileAccess.Read)
                My.Computer.FileSystem.CopyFile(tempdiscacheloc & item.ToString.Split("("c)(0), FileToSaveAs & GetImageFormat(filestream))
            filestream.Close()
        Next


    End Sub

    Public Enum ImageFormat
        bmp
        jpeg
        gif
        tiff
        png
        unknown
    End Enum

    'Yes I know this code is probably sloppy or isn't efficient.
    Public Shared Function GetImageFormat(ByVal stream As FileStream)
        Dim bmp = Encoding.ASCII.GetBytes("BM")
        Dim gif = Encoding.ASCII.GetBytes("GIF")
        Dim mpeg = Encoding.ASCII.GetBytes("ID3")
        Dim png = New Byte() {137, 80, 78, 71}
        Dim tiff = New Byte() {73, 73, 42}
        Dim tiff2 = New Byte() {77, 77, 42}
        Dim jpeg = New Byte() {255, 216, 255, 224}
        Dim jpeg2 = New Byte() {255, 216, 255, 225}
        Dim buffer = New Byte(37) {}
        stream.Read(buffer, 0, buffer.Length)
        If bmp.SequenceEqual(buffer.Take(bmp.Length)) Then Return ".bmp"
        If gif.SequenceEqual(buffer.Take(gif.Length)) Then Return ".gif"
        If png.SequenceEqual(buffer.Take(png.Length)) Then Return ".png"
        If tiff.SequenceEqual(buffer.Take(tiff.Length)) Then Return ".tiff"
        If tiff2.SequenceEqual(buffer.Take(tiff2.Length)) Then Return ".tiff"
        If jpeg.SequenceEqual(buffer.Take(jpeg.Length)) Then Return ".jpeg"
        If jpeg2.SequenceEqual(buffer.Take(jpeg2.Length)) Then Return ".jpeg"
        If mpeg.SequenceEqual(buffer.Take(mpeg.Length)) Then Return ".mpeg"
        If My.Computer.FileSystem.ReadAllBytes(stream.Name)(6) = Nothing And My.Computer.FileSystem.ReadAllBytes(stream.Name)(10) = Nothing Then Return ".webm"
        If My.Computer.FileSystem.ReadAllBytes(stream.Name)(0) = Nothing Then Return ".mp4"
        Return ".unknown"
    End Function
    Public Function FileMatches(folderPath As String, filePattern As String, phrase As String) As Boolean
        For Each fileName As String In Directory.GetFiles(folderPath, filePattern)
            If fileName.Contains(phrase) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DeleteALLbutton.Click
        If MsgBox("Are you sure you want to delete all cache files? You should close discord before this operation. (This will increase the time it will take for an image to load after)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            Dim totaldelete = 0
            Dim faildelete = 0
            For Each file In My.Computer.FileSystem.GetFiles(discacheloc)
                Try
                    My.Computer.FileSystem.DeleteFile(file)
                    totaldelete += 1
                Catch ex As Exception
                    faildelete += 1
                End Try
            Next
            MsgBox("A total of " & totaldelete & " were successfully deleted, Here is the total of files that can't get deleted: " & faildelete)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SecureDeleteButton.Click
        If MsgBox("Are you sure you want to securely delete all cache files? You should close discord and this might take awhile for this operation. (This will increase the time it will take for an image to load after)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            Dim totaldelete = 0
            Dim faildelete = 0
            For Each file In My.Computer.FileSystem.GetFiles(discacheloc)
                Try
                    For i As Integer = 0 To 5
                        My.Computer.FileSystem.WriteAllText(file, "", False)
                    Next
                    My.Computer.FileSystem.DeleteFile(file)
                    totaldelete += 1
                Catch ex As Exception
                    faildelete += 1
                End Try
            Next
            MsgBox("A total of " & totaldelete & " were successfully deleted, Here is the total of files that can't get deleted: " & faildelete)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles AutoPlayTimer.Tick
        AxWindowsMediaPlayer1.uiMode = "full"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles AutoPlayCheck.CheckedChanged
        If AutoPlayCheck.Checked Then
            AutoPlayTimer.Start()
        Else
            AutoPlayTimer.Stop()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ClearCacheButton.Click
        If ImageDisplay.Image Is Nothing Then
        Else
            ImageDisplay.Image.Dispose()
        End If

        For Each file In My.Computer.FileSystem.GetFiles(tempdiscacheloc)
            My.Computer.FileSystem.DeleteFile(file)
        Next
        CacheExplorerList.Items.Clear()
        TotalFilesLabel.Text = "Total: " & CacheExplorerList.Items.Count
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        CacheExplorerList.Items.Clear()
        For Each item As String In CacheListBackup.Items
            If item.Contains(FilterComboBox.Text) Then
                CacheExplorerList.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Resetlistbutton.Click
        CacheExplorerList.Items.Clear()

        For Each item In CacheListBackup.Items
            CacheExplorerList.Items.Add(item)
        Next
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles FilterComboBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            SearchButton.PerformClick()
        End If
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        ImageDisplay.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub CenterImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterImageToolStripMenuItem.Click
        ImageDisplay.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        ImageDisplay.SizeMode = PictureBoxSizeMode.Normal
    End Sub

    Private Sub StretchImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StretchImageToolStripMenuItem.Click
        ImageDisplay.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ChangeCacheFoldButton.Click
        ChangeCacheFolder.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ChangeCacheFolder.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.Show()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles OverrideCheck.CheckedChanged
        OpenTypeCheck.Enabled = OverrideCheck.Checked
    End Sub
End Class
