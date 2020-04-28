Imports System.Data.OleDb
Public Class addstaff
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source= collegefinal.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("insert into staff(registrationorderno,joiningdate,qualification1,experience,language1,branch,firstname,dob,nationality,religion,address,middlename,state,city,gender,contactno,lastname,pincode,emailid,idmark)values(@registrationorderno,@joiningdate,@qualification1,@experience,@language1,@branch,@firstname,@dob,@nationality,@religion,@address,@middlename,@state,@city,@gender,@contactno,@lastname,@pincode,@emailid,@idmark)", cn)
        cmd.Parameters.AddWithValue("@registrationorderno", TextBox1.Text)
        cmd.Parameters.AddWithValue("@joiningdate", DateTimePicker1.Text)
        cmd.Parameters.AddWithValue("@qualification1", TextBox2.Text)
        cmd.Parameters.AddWithValue("@experience", TextBox3.Text)
        cmd.Parameters.AddWithValue("@language1", TextBox4.Text)
        cmd.Parameters.AddWithValue("@branch", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@firstname", TextBox5.Text)
        cmd.Parameters.AddWithValue("@dob", DateTimePicker2.Text)
        cmd.Parameters.AddWithValue("@nationality", TextBox6.Text)
        cmd.Parameters.AddWithValue("@relgion", TextBox7.Text)
        cmd.Parameters.AddWithValue("@address", TextBox8.Text)
        cmd.Parameters.AddWithValue("@middlename", TextBox9.Text)
        cmd.Parameters.AddWithValue("@state", TextBox10.Text)
        cmd.Parameters.AddWithValue("@city", TextBox11.Text)
        cmd.Parameters.AddWithValue("@gender", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@contactno", TextBox12.Text)
        cmd.Parameters.AddWithValue("@lastname", TextBox13.Text)
        cmd.Parameters.AddWithValue("@pincode", TextBox14.Text)
        cmd.Parameters.AddWithValue("@emailid", TextBox15.Text)
        cmd.Parameters.AddWithValue("@idmark", TextBox16.Text)

        cn.Open()
        cmd.ExecuteNonQuery()

        MsgBox("saved")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Civil")
        ComboBox1.Items.Add("Computer")
        ComboBox1.Items.Add("E&C")
        ComboBox1.Items.Add("Electric")
        ComboBox1.Items.Add("Mechanical")

        ComboBox2.Items.Add("Male")
        ComboBox2.Items.Add("Female")
        ComboBox2.Items.Add("Other")
    End Sub
End Class