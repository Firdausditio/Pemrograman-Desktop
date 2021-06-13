Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("https://mdr-corporation.com/assets/img/about.jpeg", "D:/gambar.jpeg")
    End Sub
End Class
