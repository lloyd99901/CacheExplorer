Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox1.DeselectAll()
    End Sub
End Class