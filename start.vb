Public Class start
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            login.Show()
            Me.Hide()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 25
        End If

    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class