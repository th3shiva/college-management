Imports System.Data.OleDb
Public Class library
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("insert into issue(studentid,name1,course,dateofissue,bookname,author,action1)values(@studentid,@name1,@course,@dateofissue,@bookname,@author,@action1)", cn)
        cmd.Parameters.AddWithValue("@studentid", TextBox1.Text)
        cmd.Parameters.AddWithValue("@name1", TextBox5.Text)
        cmd.Parameters.AddWithValue("@course", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@dateofissue", DateTimePicker1.Text)
        cmd.Parameters.AddWithValue("@bookname", TextBox3.Text)
        cmd.Parameters.AddWithValue("@author", TextBox4.Text)
        cmd.Parameters.AddWithValue("@action1", ComboBox1.Text)
        cn.Open()
        cmd.ExecuteNonQuery()

        MsgBox("saved")
        TextBox1.Text = ""
        TextBox5.Text = ""
        ComboBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Library_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Issue")
        ComboBox1.Items.Add("Return")
        ComboBox2.Items.Add("Civil")
        ComboBox2.Items.Add("Computer")
        ComboBox2.Items.Add("E&C")
        ComboBox2.Items.Add("Electric")
        ComboBox2.Items.Add("Mechanical")
    End Sub
End Class