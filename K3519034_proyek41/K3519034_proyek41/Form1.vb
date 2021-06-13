Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PDF Files |*.pdf"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            AxAcroPDF1.src = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub AxAcroPDF1_Enter(sender As Object, e As EventArgs) Handles AxAcroPDF1.Enter

    End Sub
End Class
