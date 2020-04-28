Imports System.Data.OleDb
Public Class newstudent
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim cmd As New OleDbCommand("insert into student(rollno,admissiondata,field,year1,section1,firstname,dob,fathername1,fatheroccupation1,nationality,religion,address,lastname,gender,relationship,annualincome,bloodgroup,phonenumber,percentage)values(@rollno,@admissiondata,@field,@year1,@section1,@firstname,@dob,@fathername1,@fatheroccupation1,@nationality,@religion,@address,@lastname,@gender,@relationship,@annualincome,@bloodgroup,@phonenumber,@percentage)", cn)
        cmd.Parameters.AddWithValue("@rollno", TextBox1.Text)
        cmd.Parameters.AddWithValue("@admissiondata", DateTimePicker1.Text)
        cmd.Parameters.AddWithValue("@field", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@year1", TextBox3.Text)
        cmd.Parameters.AddWithValue("@section1", TextBox4.Text)
        cmd.Parameters.AddWithValue("@firstname", TextBox5.Text)
        cmd.Parameters.AddWithValue("@dob", DateTimePicker2.Text)
        cmd.Parameters.AddWithValue("@fathername1", TextBox6.Text)
        cmd.Parameters.AddWithValue("@fatheroccupation1", TextBox7.Text)
        cmd.Parameters.AddWithValue("@nationality", TextBox8.Text)
        cmd.Parameters.AddWithValue("@religion", TextBox9.Text)
        cmd.Parameters.AddWithValue("@address", TextBox10.Text)
        cmd.Parameters.AddWithValue("@lastname", TextBox11.Text)
        cmd.Parameters.AddWithValue("@gender", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@relationship", ComboBox4.Text)
        cmd.Parameters.AddWithValue("@annualincome", TextBox13.Text)
        cmd.Parameters.AddWithValue("@bloodgroup", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@phonenumber", TextBox14.Text)
        cmd.Parameters.AddWithValue("@parcentage", TextBox15.Text)

        cn.Open()
        cmd.ExecuteNonQuery()

        MsgBox("saved")
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""

    End Sub

    Private Sub Newstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

End Class
