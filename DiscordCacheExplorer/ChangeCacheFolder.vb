
Imports System.IO

Public Class ChangeCacheFolder
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OKaybutton.Click
        If CacheFolderText.Text = Nothing Then
            MsgBox("Cache folder text is nothing!")
            Return
        End If
        My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\CacheFiles\")
        If My.Computer.FileSystem.DirectoryExists(CacheFolderText.Text) = True Then
            Form1.discacheloc = CacheFolderText.Text
            Form1.tempdiscacheloc = Application.StartupPath & "\CacheFiles\" & Split(CacheFolderText.Text, "\")(5) & "\"
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\CacheFiles\")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\CacheFiles\" & Split(CacheFolderText.Text, "\")(5))
            Hide()
        Else
            MsgBox("Dir does not exist 0x02")
            Close()
        End If
        Form1.Show()
        Hide()
        If My.Computer.FileSystem.DirectoryExists(Form1.tempdiscacheloc) Then
            Form1.CacheExplorerList.Items.Clear()

            For Each file In My.Computer.FileSystem.GetFiles(Form1.tempdiscacheloc)
                Dim filest As New FileStream(file, FileMode.Open, FileAccess.Read)
                Form1.CacheExplorerList.Items.Add(Path.GetFileName(file) & " (" & Form1.GetImageFormat(filest) & ")")
                filest.Close()
            Next
            For Each item In Form1.CacheExplorerList.Items
                Form1.CacheListBackup.Items.Add(item)
            Next
            Form1.TotalFilesLabel.Text = "Total: " & Form1.CacheExplorerList.Items.Count
        End If
    End Sub

    Private Sub ChangeCacheFolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if required dlls are missing

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\AxInterop.WMPLib.dll") = False Or My.Computer.FileSystem.FileExists(Application.StartupPath & "\Interop.WMPLib.dll") = False Then
            MsgBox("Required dll(s) missing! Exiting...", MsgBoxStyle.Critical, "CRITICAL!")
            Close()
        End If

        'If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Roaming\discord\Cache\") Then
        '    AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Roaming\discord\Cache\" & vbNewLine)
        'End If
        'If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\Opera Software\Opera Stable\Cache") Then
        '    AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\Opera Software\Opera Stable\Cache" & vbNewLine)
        'End If
        'If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\Google\Chrome\User Data\Default\Cache") Then
        '    AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\Google\Chrome\User Data\Default\Cache" & vbNewLine)
        'End If
        'If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\Steam\htmlcache\Cache") Then
        '    AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\Steam\htmlcache\Cache" & vbNewLine)
        'End If
        'If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\EpicGamesLauncher\Saved\webcache\Cache") Then
        '    AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\EpicGamesLauncher\Saved\webcache\Cache" & vbNewLine)
        'End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AutoDetectListbox.SelectedIndexChanged
        CacheFolderText.Text = AutoDetectListbox.SelectedItem.ToString
    End Sub

    Private Sub ChangeCacheFolder_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        On Error Resume Next
        Application.DoEvents()
        For Each folder In My.Computer.FileSystem.GetDirectories("C:\Users\" & Environment.UserName & "\AppData\Roaming\", FileIO.SearchOption.SearchAllSubDirectories)
            If Path.GetFileName(folder).ToLower.Contains("cache") Then
                AutoDetectListbox.Items.Add(folder)
            End If
        Next
        For Each folder In My.Computer.FileSystem.GetDirectories("C:\Users\" & Environment.UserName & "\AppData\Local\", FileIO.SearchOption.SearchAllSubDirectories)
            If Path.GetFileName(folder).ToLower.Contains("cache") Then
                AutoDetectListbox.Items.Add(folder)
            End If
        Next
        For Each item In AutoDetectListbox.Items
            BackUPList.Items.Add(item)
        Next
        Label3.Visible = False
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        AutoDetectListbox.Items.Clear()
        For Each item As String In BackUPList.Items
            If item.ToLower.Contains(FilterComboBox.Text.ToLower) Then
                AutoDetectListbox.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub Resetlistbutton_Click(sender As Object, e As EventArgs) Handles Resetlistbutton.Click
        AutoDetectListbox.Items.Clear()

        For Each item In BackUPList.Items
            AutoDetectListbox.Items.Add(item)
        Next
    End Sub

    Private Sub FilterComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FilterComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchButton.PerformClick()
        End If
    End Sub
End Class