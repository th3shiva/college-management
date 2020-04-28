Public Class admin
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Hide()
        login.ShowDialog()
    End Sub

    Private Sub NewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStaffToolStripMenuItem.Click
        addstaff.ShowDialog()
    End Sub

    Private Sub ManageStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStaffToolStripMenuItem.Click
        staffmodify.ShowDialog()
    End Sub

    Private Sub ViewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStaffToolStripMenuItem.Click
        viewstaff.ShowDialog()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        newstudent.ShowDialog()
    End Sub

    Private Sub ModifyStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyStudentToolStripMenuItem.Click
        studentmodify.ShowDialog()
    End Sub

    Private Sub ViewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentToolStripMenuItem.Click
        studentrecord.ShowDialog()
    End Sub


    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibraryToolStripMenuItem.Click
        library.ShowDialog()
    End Sub

    Private Sub IssueLibrartyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueLibrartyToolStripMenuItem.Click
        library.ShowDialog()
    End Sub
    Private Sub BuyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuyToolStripMenuItem1.Click
        buy.ShowDialog()
    End Sub

    Private Sub BuyModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuyModifyToolStripMenuItem.Click
        buymodify.ShowDialog()
    End Sub

    Private Sub ViewLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLibraryToolStripMenuItem.Click
        viewlibrary.ShowDialog()
    End Sub

    Private Sub AttendanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem1.Click
        attendance.ShowDialog()
    End Sub

    Private Sub ViewAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAttendanceToolStripMenuItem.Click
        viewattendance.ShowDialog()
    End Sub


End Class

