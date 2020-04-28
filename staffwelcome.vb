Public Class staffwelcome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        attendance.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        viewattendance.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        buy.ShowDialog()
    End Sub


End Class