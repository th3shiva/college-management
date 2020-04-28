Imports System.Data.OleDb
Public Class viewstaff
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")

    Private Sub Viewstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New OleDbDataAdapter("select * from staff", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "staff")
        DataGridView1.DataSource = ds.Tables("staff")
    End Sub
End Class