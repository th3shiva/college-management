Imports System.Data.OleDb
Public Class staffmodify
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("update staff set joiningdate='" & DateTimePicker1.Text & "',qualification1= '" & TextBox2.Text & "',experience ='" & TextBox4.Text & "',language1= '" & TextBox4.Text & "',branch= '" & ComboBox1.Text & "',firstname= '" & TextBox5.Text & "',dob= '" & DateTimePicker2.Text & "',nationality= '" & TextBox6.Text & "',religion= '" & TextBox7.Text & "',address= '" & TextBox8.Text & "',middlename= '" & TextBox9.Text & "',state= '" & TextBox10.Text & "',city= '" & TextBox11.Text & "',gender= '" & ComboBox2.Text & "',contactno= '" & TextBox12.Text & "',lastname= '" & TextBox13.Text & "',pincode= '" & TextBox14.Text & "',emailid= '" & TextBox15.Text & "',idmark= '" & TextBox16.Text & "' where registrationorderno='" & TextBox1.Text & "'", cn)


        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("updated")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from staff where registrationorderno='" & TextBox17.Text & "'", cn)


        cn.Open()

        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read

                TextBox1.Text = dr("registrationorderno")
                DateTimePicker1.Text = dr("joiningdate")
                TextBox2.Text = dr("qualification1")
                TextBox3.Text = dr("experience")
                TextBox4.Text = dr("language1")
                ComboBox1.Text = dr("branch")
                TextBox5.Text = dr("firstname")
                DateTimePicker2.Text = dr("dob")
                TextBox6.Text = dr("nationality")
                TextBox7.Text = dr("religion")
                TextBox8.Text = dr("address")
                TextBox9.Text = dr("middlename")
                TextBox10.Text = dr("state")
                TextBox11.Text = dr("city")
                ComboBox2.Text = dr("gender")
                TextBox12.Text = dr("contactno")
                TextBox13.Text = dr("lastname")
                TextBox14.Text = dr("pincode")
                TextBox15.Text = dr("emailid")
                TextBox16.Text = dr("idmark")

            End While
        Else
            MsgBox("sorry data is not found")
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("delete from staff where registrationorderno='" & TextBox1.Text & "'", cn)


        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("delete")
        TextBox2.Text = ""

        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

End Class