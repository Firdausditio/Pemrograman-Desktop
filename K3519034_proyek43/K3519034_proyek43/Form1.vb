Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("TEST.txt", True)
        file.WriteLine("this is my youtube tutorial")
        file.Close()

    End Sub
End Class