
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
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\CacheFiles\")
            Hide()
        Else
            MsgBox("Dir does not exist 0x02")
            Close()
        End If
        Form1.Show()
        Hide()
    End Sub

    Private Sub ChangeCacheFolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Roaming\discord\Cache\") Then
            AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Roaming\discord\Cache\" & vbNewLine)
        End If
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\Opera Software\Opera Stable\Cache") Then
            AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\Opera Software\Opera Stable\Cache" & vbNewLine)
        End If
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\Google\Chrome\User Data\Default\Cache") Then
            AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\Google\Chrome\User Data\Default\Cache" & vbNewLine)
        End If
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\Steam\htmlcache\Cache") Then
            AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\Steam\htmlcache\Cache" & vbNewLine)
        End If
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\EpicGamesLauncher\Saved\webcache\Cache") Then
            AutoDetectListbox.Items.Add("C:\Users\" & Environment.UserName & "\AppData\Local\EpicGamesLauncher\Saved\webcache\Cache" & vbNewLine)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AutoDetectListbox.SelectedIndexChanged
        CacheFolderText.Text = AutoDetectListbox.SelectedItem.ToString
    End Sub
End Class