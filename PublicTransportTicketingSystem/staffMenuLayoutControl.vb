Public Class staffMenuLayoutControl
    ' create even to to raise the transport change 
    Public Event staffHomeClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnHomeClick(sender As Object, e As EventArgs) Handles btnHome.Click
        RaiseEvent staffHomeClick(sender, e)

    End Sub

    Public Event staffBookingClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnBookingClick(sender As Object, e As EventArgs) Handles btnReservation.Click
        RaiseEvent staffBookingClick(sender, e)

    End Sub

    Public Event staffTransactionClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnTransactionClick(sender As Object, e As EventArgs) Handles btnTransaction.Click
        RaiseEvent staffTransactionClick(sender, e)

    End Sub

    Public Event staffPromotionClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnPromotionClick(sender As Object, e As EventArgs) Handles btnStaffPromotion.Click
        RaiseEvent staffPromotionClick(sender, e)

    End Sub

    Public Event staffAboutClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnAboutClick(sender As Object, e As EventArgs) Handles btnAbout.Click
        RaiseEvent staffAboutClick(sender, e)

    End Sub

    Public Event staffContactClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnContactClick(sender As Object, e As EventArgs) Handles btnContact.Click
        RaiseEvent staffContactClick(sender, e)

    End Sub
    Public Event staffManageAccountClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnManageAccountClick(sender As Object, e As EventArgs) Handles btnManageAccount.Click
        RaiseEvent staffManageAccountClick(sender, e)

    End Sub

    Public Event staffExitClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnExitClick(sender As Object, e As EventArgs) Handles pbExit.Click
        RaiseEvent staffExitClick(sender, e)

    End Sub
End Class
