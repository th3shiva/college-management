Imports System.Data.OleDb

Public Class attendance
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source = collegefinal.mdb")
    Private Sub Attend1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Civil")
        ComboBox1.Items.Add("Computer")
        ComboBox1.Items.Add("E&C")
        ComboBox1.Items.Add("Electric")
        ComboBox1.Items.Add("Mechanical")

        ComboBox3.Items.Add("Present")
        ComboBox3.Items.Add("Absent")
        ComboBox3.Items.Add("late")
        ComboBox3.Items.Add("leave")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from student where field ='" & ComboBox1.Text & "'", cn)
        cn.Open()
        Dim fb As OleDbDataReader

        fb = cmd.ExecuteReader
        If fb.HasRows = True Then
            While fb.Read
                ListBox1.Items.Add(fb("firstname"))
            End While

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from student where firstname ='" & ListBox1.Text & "'", cn)

        cn.Open()
        Dim fb As OleDbDataReader

        fb = cmd.ExecuteReader
        If fb.HasRows = True Then
            While fb.Read
                TextBox1.Text = fb("firstname")
                TextBox2.Text = fb("rollno")

            End While
        Else
            MsgBox("records not found")
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("insert into attendance(id,uname,branch,sdate,attendance)values(@id,@uname,@branch,@sdate,@attendance)", cn)
        cmd.Parameters.AddWithValue("id", TextBox2.Text)
        cmd.Parameters.AddWithValue("uname", TextBox1.Text)
        cmd.Parameters.AddWithValue("branch", ComboBox1.Text)
        cmd.Parameters.AddWithValue("sdate", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("attendance", ComboBox3.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("saved")
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
        ComboBox3.Text = ""
        'cn.Close()

    End Sub

End Class