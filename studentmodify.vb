Imports System.Data.OleDb
Public Class studentmodify
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cn.State = 1 Then cn.Close()
        'Dim cmd As New OleDbCommand("update student set field = '" & TextBox2.Text & "' where rollno1='" & TextBox1.Text & "'", cn)

        Dim cmd As New OleDbCommand("update student set admissiondata ='" & DateTimePicker1.Text & "',field = '" & ComboBox3.Text & "',year1 ='" & TextBox3.Text & "',firstname ='" & TextBox5.Text & "',dob ='" & DateTimePicker2.Text & "',fathername1 ='" & TextBox6.Text & "',fatheroccupation1 ='" & TextBox7.Text & "',nationality ='" & TextBox8.Text & "',religion ='" & TextBox9.Text & "',address ='" & TextBox10.Text & "',lastname ='" & TextBox11.Text & "',gender ='" & ComboBox1.Text & "',relationship ='" & ComboBox4.Text & "',annualincome ='" & TextBox13.Text & "',bloodgroup ='" & ComboBox2.Text & "',phonenumber ='" & TextBox14.Text & "',percentage ='" & TextBox15.Text & "' where rollno= '" & TextBox1.Text & "'", cn)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("updated")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select  * from student where rollno='" & TextBox16.Text & "'", cn)

        cn.Open()

        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read

                TextBox1.Text = dr("rollno")
                DateTimePicker1.Text = dr("admissiondata")
                ComboBox3.Text = dr("field")
                TextBox3.Text = dr("year1")

                TextBox5.Text = dr("firstname")
                DateTimePicker2.Text = dr("dob")
                TextBox6.Text = dr("fathername1")
                TextBox7.Text = dr("fatheroccupation1")
                TextBox8.Text = dr("nationality")
                TextBox9.Text = dr("religion")
                TextBox10.Text = dr("address")
                TextBox11.Text = dr("lastname")
                ComboBox1.Text = dr("gender")
                ComboBox4.Text = dr("relationship")
                TextBox13.Text = dr("annualincome")
                ComboBox2.Text = dr("bloodgroup")
                TextBox14.Text = dr("phonenumber")
                TextBox15.Text = dr("percentage")

            End While
        Else
            MsgBox("sorry data is not found")
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If cn.State = 1 Then cn.Close()

        Dim cmd As New OleDbCommand("delete from student where rollno='" & TextBox1.Text & "'", cn)


        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("deleted")



    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cn.State = 1 Then cn.Close()
        'Dim cmd As New OleDbCommand("update student set field = '" & TextBox2.Text & "' where rollno1='" & TextBox1.Text & "'", cn)

        Dim cmd As New OleDbCommand("update student set admissiondata ='" & DateTimePicker1.Text & "',field = '" & ComboBox3.Text & "',year1 ='" & TextBox3.Text & "',firstname ='" & TextBox5.Text & "',dob ='" & DateTimePicker2.Text & "',fathername1 ='" & TextBox6.Text & "',fatheroccupation1 ='" & TextBox7.Text & "',nationality ='" & TextBox8.Text & "',religion ='" & TextBox9.Text & "',address ='" & TextBox10.Text & "',lastname ='" & TextBox11.Text & "',gender ='" & ComboBox1.Text & "',relationship ='" & ComboBox4.Text & "',annualincome ='" & TextBox13.Text & "',bloodgroup ='" & ComboBox2.Text & "',phonenumber ='" & TextBox14.Text & "',percentage ='" & TextBox15.Text & "' where rollno= '" & TextBox1.Text & "'", cn)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("updated")
    End Sub

    Private Sub Studentmodify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox3.Items.Add("Civil")
        ComboBox3.Items.Add("Computer")
        ComboBox3.Items.Add("E&C")
        ComboBox3.Items.Add("Electric")
        ComboBox3.Items.Add("Mechanical")


        ComboBox2.Items.Add("A+")
        ComboBox2.Items.Add("A-")
        ComboBox2.Items.Add("B+")
        ComboBox2.Items.Add("B-")
        ComboBox2.Items.Add("AB+")
        ComboBox2.Items.Add("AB-")
        ComboBox2.Items.Add("O+")
        ComboBox2.Items.Add("O-")

        ComboBox1.Items.Add("Male")
        ComboBox1.Items.Add("Female")
        ComboBox1.Items.Add("Other")

        ComboBox4.Items.Add("Single")
        ComboBox4.Items.Add("Married")
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class