Imports System.Data.OleDb
Public Class buymodify
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from purchase where projectid='" & TextBox9.Text & "'", cn)
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                TextBox1.Text = dr("projectid")
                TextBox2.Text = dr("bookname")
                TextBox3.Text = dr("author")
                TextBox4.Text = dr("publisher")
                ' TextBox5.Text = dr("rate")
                TextBox6.Text = dr("quantity")
                ' TextBox7.Text = dr("vat")
                TextBox8.Text = dr("amount")

            End While
        Else
            MsgBox("sorry data is not found")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("update purchase set bookname='" & TextBox2.Text & "',author= '" & TextBox3.Text & "',publisher ='" & TextBox4.Text & "',quantity= '" & TextBox6.Text & "',amount= '" & TextBox8.Text & "' where projectid='" & TextBox1.Text & "'", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("updated")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("delete from purchase where projectid='" & TextBox1.Text & "'", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("delete")
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub
End Class