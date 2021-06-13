Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim index As Integer = 0
        While index < RichTextBox1.Text.LastIndexOf(TextBox1.Text)
            RichTextBox1.Find(TextBox1.Text, index, RichTextBox1.TextLength, RichTextBoxFinds.None)
            RichTextBox1.SelectionBackColor = Color.Red
            index = RichTextBox1.Text.IndexOf(TextBox1.Text, index) + 1
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
