Public Class staffHome
    Private Sub homeClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffHomeClick
        Me.Show()
        'Me.Hide()
        'staffHome.show()
    End Sub
    Private Sub bookingClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffBookingClick
        Me.Hide()
        StaffBooking.Show()
    End Sub
    Private Sub transactionClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffTransactionClick
        Me.Hide()
        staffTransaction.Show()
    End Sub
    Private Sub promotionClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffPromotionClick
        Me.Hide()
        StaffViewPromotion.Show()
    End Sub
    Private Sub aboutClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffAboutClick
        MessageBox.Show("Develop by Jack Soh Boon Keat , Goh Chun Lin , Tan Yi Si , Tan Haw Man", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub manageAccountClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffManageAccountClick
        Me.Hide()
        'manage account
    End Sub
    Private Sub exitClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffExitClick
        End
    End Sub
End Class