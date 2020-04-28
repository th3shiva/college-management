Imports System.Data.OleDb
Public Class viewattendance
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")

    Private Sub Viewattendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New OleDbDataAdapter("select * from attendance", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "attendance")
        DataGridView1.DataSource = ds.Tables("attendance")
    End Sub
End Class