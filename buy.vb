Imports System.Data.OleDb
Public Class buy
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("insert into purchase(projectid,bookname,author,publisher,quantity,amount)values(@projectid,@bookname,@author,@publisher,@quantity,@amount)", cn)

        cmd.Parameters.AddWithValue("@projetid", TextBox1.Text)
        cmd.Parameters.AddWithValue("@bookname", TextBox2.Text)
        cmd.Parameters.AddWithValue("@author", TextBox3.Text)
        cmd.Parameters.AddWithValue("@pubisher", TextBox4.Text)
        cmd.Parameters.AddWithValue("@quantity", TextBox6.Text)
        cmd.Parameters.AddWithValue("@amount", TextBox8.Text)

        cn.Open()
        cmd.ExecuteNonQuery()

        MsgBox("saved")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""

    End Sub
End Class