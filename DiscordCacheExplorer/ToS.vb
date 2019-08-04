Public Class ToS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeCacheFolder.Show()
        ChangeCacheFolder.scanfolders()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ChangeCacheFolder.Close()
    End Sub
End Class