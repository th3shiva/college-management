Imports System.Data.OleDb
Public Class viewbuy
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")

    Private Sub Viewbuy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New OleDbDataAdapter("select * from purchase", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "purchase")
        DataGridView1.DataSource = ds.Tables("purchase")
    End Sub

End Class