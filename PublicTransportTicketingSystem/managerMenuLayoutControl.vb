Public Class managerMenuLayoutControl
    Public Event managerHomeClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub showMessage()
        MessageBox.Show("This is the same page!")
    End Sub

    Private Sub btnHomeClick(sender As Object, e As EventArgs)

        ParentForm.Hide()


    End Sub
    Public Event managerReportClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnReportClick(sender As Object, e As EventArgs) Handles btnReport.Click
        ParentForm.Hide()
        managerReport.Show()

        RaiseEvent managerReportClick(sender, e)

    End Sub
    Public Event managerManageStaffClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnStaffClick(sender As Object, e As EventArgs) Handles btnManageStaff.Click
        ParentForm.Hide()
        ManagerViewStaff.Show()

        RaiseEvent managerManageStaffClick(sender, e)

    End Sub
    Public Event managerScheduleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnScheduleClick(sender As Object, e As EventArgs) Handles btnManageSchedule.Click
        ParentForm.Hide()
        ManagerManageSchedule.Show()

        RaiseEvent managerScheduleClick(sender, e)

    End Sub

    Public Event managerPromotionClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnPromotionClick(sender As Object, e As EventArgs) Handles btnManagePromotion.Click
        ParentForm.Hide()
        ManagerViewPromotion.Show()

        RaiseEvent managerPromotionClick(sender, e)

    End Sub
    Public Event managerPublicTransportClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnPTClick(sender As Object, e As EventArgs) Handles btnPublicTransport.Click
        ParentForm.Hide()
        ManagerPT.Show()

        RaiseEvent managerPublicTransportClick(sender, e)

    End Sub
    Public Event managerManageLocationClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnLocationClick(sender As Object, e As EventArgs) Handles btnManageLocation.Click
        ParentForm.Hide()
        ManagerManageLocation.Show()


        RaiseEvent managerManageLocationClick(sender, e)

    End Sub
    Public Event managerAboutClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnAboutClick(sender As Object, e As EventArgs) Handles btnAbout.Click

        RaiseEvent managerAboutClick(sender, e)

    End Sub

    Public Event managerManageAccountClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnManageAccountClick(sender As Object, e As EventArgs) Handles btnManageAccount.Click
        ParentForm.Hide()
        ManagerManageAccount.Show()

        RaiseEvent managerManageAccountClick(sender, e)




    End Sub

    Public Event managerExitClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnExitClick(sender As Object, e As EventArgs) Handles pbExit.Click
        MessageBox.Show("Logging out...", "Bye", MessageBoxButtons.OK, MessageBoxIcon.None)
        ParentForm.Hide()
        StaffIndex.Show()
        RaiseEvent managerExitClick(sender, e)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
