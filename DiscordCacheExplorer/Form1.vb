Imports System.IO
Imports System.Text


'Notes
'Add a check to see if the file doesnt have a . on it
'check if folder has cache on it.
'Refine detection of file format
'Add sep folders for each program Done
'Fix bug that prevents deletion of a file that is currently in use by the program
'Remove unknown filter when being excluded
'Add all cached cache folders in app location, use boolean, overwrite tempdiscache
'Delete Selected
Public Class Form1
    Public discacheloc = "" '"C:\Users\" & Environment.UserName & "\AppData\Roaming\discord\Cache\"
    Public tempdiscacheloc = Application.StartupPath & "\CacheFiles\"
    Public closeform = False
    ReadOnly programver = 1.4
    ReadOnly filestrea As FileStream
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildInformationLabel.Text = "v " & programver & " - LunarHunter"
        Application.DoEvents()
        If My.Computer.FileSystem.DirectoryExists(tempdiscacheloc) Then
            CacheExplorerList.Items.Clear()

            For Each file In My.Computer.FileSystem.GetFiles(tempdiscacheloc)
                Dim filestrea As New FileStream(file, FileMode.Open, FileAccess.Read)
                CacheExplorerList.Items.Add(Path.GetFileName(file) & " (" & GetFileFormat(filestrea) & ")")
                filestrea.Close()
            Next
            For Each item In CacheExplorerList.Items
                CacheListBackup.Items.Add(item)
            Next
        Else
            ChangeCacheFolder.Show()
        End If
        TotalFilesLabel.Text = "Total: " & CacheExplorerList.Items.Count
        BackgroundWorker1.RunWorkerAsync()
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
            ElseIf OpenTypeCheck.Text = "Image" Then
                Try
                    PlainTextBox.Visible = False
                    AxWindowsMediaPlayer1.Visible = False
                    Dim filestrea As New FileStream(tempdiscacheloc & CacheExplorerList.SelectedItem.ToString.Split("("c)(0), FileMode.Open, FileAccess.Read)
                    ImageDisplay.Image = Image.FromStream(filestrea)
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
        ImageDisplay.Image = Nothing
        CacheExplorerList.Items.Clear()
        Label3.Visible = True
        ProgressBar1.Visible = True
        Application.DoEvents()
        Dim filenum = 0
        Dim totalfilenum = Directory.GetFiles(discacheloc, "*.*").Count
        ProgressBar1.Maximum = totalfilenum
        For Each file In My.Computer.FileSystem.GetFiles(discacheloc)
            On Error Resume Next
            My.Computer.FileSystem.CopyFile(file, tempdiscacheloc & Path.GetFileName(file), True)
            filenum += 1
            Label3.Text = "Please wait... Files Copied: " & filenum & " out of " & totalfilenum
            ProgressBar1.Value = filenum
            Application.DoEvents()
        Next
        For Each file In My.Computer.FileSystem.GetFiles(tempdiscacheloc)
            Dim filestrea As New FileStream(file, FileMode.Open, FileAccess.Read)
            CacheExplorerList.Items.Add(Path.GetFileName(file) & " (" & GetFileFormat(filestrea) & ")")
            filestrea.Close()
        Next
        CacheListBackup.Items.Clear()
        For Each item In CacheExplorerList.Items
            CacheListBackup.Items.Add(item)
        Next
        TotalFilesLabel.Text = "Total: " & CacheExplorerList.Items.Count
        Label3.Visible = False
        ProgressBar1.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExportButt.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        For Each item In CacheExplorerList.SelectedItems
            Dim FileToSaveAs As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, SaveFileDialog1.FileName & item.ToString)
            Dim selectedfile = (item.ToString.Split("("c)(1).Remove(item.ToString.Split("("c)(1).Length - 1))
            Dim filestrea As New FileStream(tempdiscacheloc & item.ToString.Split("("c)(0), FileMode.Open, FileAccess.Read)
            My.Computer.FileSystem.CopyFile(tempdiscacheloc & item.ToString.Split("("c)(0), FileToSaveAs & GetFileFormat(filestrea))
            filestrea.Close()
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

    'Needs improvement
    Public Shared Function GetFileFormat(ByVal stream As FileStream)
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
        If My.Computer.FileSystem.ReadAllBytes(stream.Name)(0) = Nothing And My.Computer.FileSystem.ReadAllBytes(stream.Name)(1) = Nothing And My.Computer.FileSystem.ReadAllBytes(stream.Name)(2) = Nothing Then Return ".mp4"
        Return ".unknown"
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DeleteALLbutton.Click
        If MsgBox("Are you sure you want to delete all selected cache files? You should close discord before this operation. (This will increase the time it will take for an image to load after)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            Dim totaldelete = 0
            Dim faildelete = 0
            For Each file In My.Computer.FileSystem.GetFiles(discacheloc)
                For Each selecteditem In CacheExplorerList.SelectedItem.ToString.Split("("c)(0)
                    'MsgBox("DEBUG: " & file & selecteditem)
                    If file.Contains(selecteditem) Then
                        Try
                            My.Computer.FileSystem.DeleteFile(file)
                            totaldelete += 1
                        Catch ex As Exception
                            faildelete += 1
                        End Try
                    End If
                Next
            Next
            MsgBox("A total of " & totaldelete & " were successfully deleted, Here is the total of files that can't get deleted: " & faildelete)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SecureDeleteButton.Click
        If MsgBox("Are you sure you want to securely delete all selected cache files? You should close discord and this might take awhile for this operation. (This will increase the time it will take for an image to load after)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            Dim totaldelete = 0
            Dim faildelete = 0
            For Each file In My.Computer.FileSystem.GetFiles(discacheloc)
                For Each selecteditem In CacheExplorerList.SelectedItem.ToString.Split("("c)(0)
                    'MsgBox("DEBUG: " & file & selecteditem)
                    If file.Contains(selecteditem) Then
                        Try
                            For i As Integer = 0 To 5
                                My.Computer.FileSystem.WriteAllText(file, "", False)
                            Next
                            My.Computer.FileSystem.DeleteFile(file)
                            totaldelete += 1
                        Catch ex As Exception
                            faildelete += 1
                        End Try
                    End If
                Next
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
        For Each file In My.Computer.FileSystem.GetFiles(tempdiscacheloc)
            On Error Resume Next
            My.Computer.FileSystem.DeleteFile(file)
        Next

        CacheExplorerList.Items.Clear()
        TotalFilesLabel.Text = "Total: " & CacheExplorerList.Items.Count
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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.Show()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles OverrideCheck.CheckedChanged
        OpenTypeCheck.Enabled = OverrideCheck.Checked
    End Sub

    Private Sub FilterComboBox_TextUpdate(sender As Object, e As EventArgs) Handles FilterComboBox.TextUpdate, FilterComboBox.SelectedIndexChanged
        CacheExplorerList.Items.Clear()
        For Each item As String In CacheListBackup.Items
            If item.Contains(FilterComboBox.Text) Then
                If CheckBox1.Checked = True And item.Contains(".unknown") Then
                    'dont add
                Else
                    CacheExplorerList.Items.Add(item)
                End If
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CacheExplorerList.Items.Clear()
            For Each item As String In CacheListBackup.Items
                If item.Contains(".unknown") Then
                Else
                    CacheExplorerList.Items.Add(item)
                End If
            Next
        Else
            CacheExplorerList.Items.Clear()
            For Each item As String In CacheListBackup.Items
                CacheExplorerList.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        closeform = True
        ChangeCacheFolder.Close()
        Application.Exit()
    End Sub

    Private Sub UpdateAvailable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UpdateAvailable.LinkClicked
        Dim url As String = "https://sourceforge.net/projects/cacheexplorer/"
        Process.Start(url)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create("https://raw.githubusercontent.com/lloyd99901/CacheExplorer/master/README.md")
            Dim response As Net.HttpWebResponse = request.GetResponse()
            Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
            e.Result = sr.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            If e.Result.Contains("Current Version: v" & programver) Then
            Else
                UpdateAvailable.Visible = True
            End If
        Catch ex As Exception
            UnableUpdates.Visible = True
        End Try

    End Sub

End Class
