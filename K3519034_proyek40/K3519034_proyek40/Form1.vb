Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "ALL Files | *.*"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            System.Diagnostics.Process.Start(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
