Imports System.Data.OleDb
Public Class viewlibrary
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")

    Private Sub Viewlibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New OleDbDataAdapter("select * from issue", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "issue")
        DataGridView1.DataSource = ds.Tables("issue")
    End Sub
End Class