Imports System.Data.OleDb
Public Class login
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source = collegefinal.mdb")
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = "0" Then
            If cn.State = 1 Then cn.Close()
            Dim cmd As New OleDbCommand("Select * from admin where username='" & TextBox1.Text & "' and password ='" & TextBox2.Text & "'", cn)
            cn.Open()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Hide()
                admin.Show()
            Else
                MessageBox.Show("login fail")
            End If
        End If
        If ComboBox1.SelectedIndex = "1" Then
            If cn.State = 1 Then cn.Close()
            Dim cmd As New OleDbCommand("Select * from staff where firstname='" & TextBox1.Text & "' and pincode ='" & TextBox2.Text & "'", cn)
            cn.Open()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then

                staffwelcome.Show()
            Else
                MsgBox("sorry data is not found")
            End If
        End If

    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        addstaff.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Staff")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class
