Public Class staffMenuLayoutControl
    ' create even to to raise the transport change 




    Public Event staffBookingClick(ByVal sender As Object, ByVal e As System.EventArgs)



    Private Sub btnBookingClick(sender As Object, e As EventArgs) Handles btnReservation.Click
        ParentForm.Hide()
        StaffBooking.Show()
        RaiseEvent staffBookingClick(sender, e)

    End Sub

    Public Event staffTransactionClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnTransactionClick(sender As Object, e As EventArgs) Handles btnTransaction.Click
        ParentForm.Hide()
        staffTransaction.Show()
        RaiseEvent staffTransactionClick(sender, e)

    End Sub

    Public Event staffPromotionClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnPromotionClick(sender As Object, e As EventArgs) Handles btnStaffPromotion.Click
        ParentForm.Hide()
        StaffViewPromotion.Show()
        RaiseEvent staffPromotionClick(sender, e)

    End Sub

    Public Event staffCancelClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnCancelClick(sender As Object, e As EventArgs) Handles btnCancel.Click
        ParentForm.Hide()
        PaymentCancel.Show()
        RaiseEvent staffPromotionClick(sender, e)

    End Sub

    Public Event staffAboutClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnAboutClick(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("Developed by Jack Soh Boon Keat, Goh Chun Lin, Tan Yi Si and Tan Haw Man")
        RaiseEvent staffAboutClick(sender, e)

    End Sub

    Public Event staffManageAccountClick(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub btnManageAccountClick(sender As Object, e As EventArgs) Handles btnManageAccount.Click
        ParentForm.Hide()
        StaffManageAccount.Show()
        RaiseEvent staffManageAccountClick(sender, e)

    End Sub

    Public Event staffExitClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btnExitClick(sender As Object, e As EventArgs) Handles pbExit.Click
        MessageBox.Show("Log out")
        ParentForm.Hide()
        StaffIndex.Show()

        RaiseEvent staffExitClick(sender, e)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
