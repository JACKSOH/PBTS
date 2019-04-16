Public Class managerHome
    Private Sub homeClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerHomeClick
        Me.Show()
        'Me.Hide()
        'staffHome.show()
    End Sub
    Private Sub reportClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerReportClick
        Me.Hide()
        managerReport.Show()
    End Sub
    Private Sub manageStaffClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerManageStaffClick
        Me.Hide()
        ManagerViewStaff.Show()
    End Sub
    Private Sub manageScheduleClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerScheduleClick
        Me.Hide()
        ManagerManageSchedule.Show()
    End Sub
    Private Sub managePromotionClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerPromotionClick
        Me.Hide()
        ManagerViewPromotion.Show()
    End Sub
    Private Sub managePublicTransportClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerPublicTransportClick
        Me.Hide()
        ManagerPT.Show()
    End Sub
    Private Sub manageLocationClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerManageLocationClick
        Me.Hide()
        ManagerManageLocation.Show()
    End Sub
    Private Sub aboutClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerAboutClick
        MessageBox.Show("Develop by Jack Soh Boon Keat , Goh Chun Lin , Tan Yi Si , Tan Haw Man", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub manageAccountClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerManageAccountClick
        Me.Hide()
        'manageaccount
    End Sub
    Private Sub exitClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerExitClick
        End
    End Sub
End Class