Imports System.Data.OleDb

Public Class studentrecord
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source = collegefinal.mdb")
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim da As New OleDbDataAdapter("select firstname as First_Name,lastname as Last_Name,field as Branch,gender as Gender ,phonenumber as PhoneNumber,admissiondata as Admission_date,dob as DateOfBirth, address as Address from student where field ='Electronics'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New OleDbDataAdapter("select firstname as First_Name,lastname as Last_Name,field as Branch,gender as Gender ,phonenumber as PhoneNumber,admissiondata as Admission_date,dob as DateOfBirth, address as Address from student where field ='Civil'", cn)
        'Dim da As New OleDbDataAdapter("select * from student where branch ='civil'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
    End Sub

    Private Sub Studentrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim da As New OleDbDataAdapter("select firstname as First_Name,lastname as Last_Name,field as Branch,gender as Gender ,phonenumber as PhoneNumber,admissiondata as Admission_date,dob as DateOfBirth, address as Address from student where field ='Electric'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New OleDbDataAdapter("select firstname as First_Name,lastname as Last_Name,field as Branch,gender as Gender ,phonenumber as PhoneNumber,admissiondata as Admission_date,dob as DateOfBirth, address as Address from student where field ='Computer'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim da As New OleDbDataAdapter("select firstname as First_Name,lastname as Last_Name,field as Branch,gender as Gender ,phonenumber as PhoneNumber,admissiondata as Admission_date,dob as DateOfBirth, address as Address from student where field ='Mechanical'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
    End Sub
End Class