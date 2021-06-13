Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox_pass.Text = "12345") Then
            Form2.Show()
        Else
            MessageBox.Show("Password Salah")

        End If
    End Sub
End Class
