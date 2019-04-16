Public Class managerMenuLayoutControl
    Public Event managerHomeClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnHomeClick(sender As Object, e As EventArgs) Handles btnHome.Click
        RaiseEvent managerHomeClick(sender, e)

    End Sub
    Public Event managerReportClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnReportClick(sender As Object, e As EventArgs) Handles btnReport.Click
        RaiseEvent managerReportClick(sender, e)

    End Sub
    Public Event managerManageStaffClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnStaffClick(sender As Object, e As EventArgs) Handles btnManageStaff.Click
        RaiseEvent managerManageStaffClick(sender, e)

    End Sub
    Public Event managerScheduleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnScheduleClick(sender As Object, e As EventArgs) Handles btnManageSchedule.Click
        RaiseEvent managerScheduleClick(sender, e)

    End Sub

    Public Event managerPromotionClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnPromotionClick(sender As Object, e As EventArgs) Handles btnManagePromotion.Click
        RaiseEvent managerPromotionClick(sender, e)

    End Sub
    Public Event managerPublicTransportClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnPTClick(sender As Object, e As EventArgs) Handles btnPublicTransport.Click
        RaiseEvent managerPublicTransportClick(sender, e)

    End Sub
    Public Event managerManageLocationClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnLocationClick(sender As Object, e As EventArgs) Handles btnManageLocation.Click
        RaiseEvent managerManageLocationClick(sender, e)

    End Sub
    Public Event managerAboutClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnAboutClick(sender As Object, e As EventArgs) Handles btnAbout.Click
        RaiseEvent managerAboutClick(sender, e)

    End Sub

    Public Event managerManageAccountClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnManageAccountClick(sender As Object, e As EventArgs) Handles btnManageAccount.Click
        RaiseEvent managerManageAccountClick(sender, e)

    End Sub

    Public Event managerExitClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnExitClick(sender As Object, e As EventArgs) Handles pbExit.Click
        RaiseEvent managerExitClick(sender, e)

    End Sub
End Class
