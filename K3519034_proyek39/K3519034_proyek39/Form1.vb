Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Myconnection As System.Data.OleDb.OleDbConnection
            Dim dataset As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = "E:\\[TUGAS UNS]\\Semester 4\\Pem Desk"

            Myconnection = New System.Data.OleDb.OleDbConnection("Provide=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select = from [Sheet1$]", Myconnection)

            dataset = New System.Data.DataSet
            MyCommand.Fill(dataset)
            DataGridView1.DataSource = dataset.Tables(0)

            Myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class
