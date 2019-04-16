Public Class staffHome
    Private Sub homeClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffHomeClick
        Me.Show()
        'Me.Close()
        'staffHome.show()
    End Sub
    Private Sub bookingClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffBookingClick
        Me.Close()
        StaffBooking.ShowDialog()
    End Sub
    Private Sub transactionClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffTransactionClick
        Me.Close()
        staffTransaction.ShowDialog()
    End Sub
    Private Sub promotionClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffPromotionClick
        Me.Close()
        StaffViewPromotion.ShowDialog()
    End Sub
    Private Sub aboutClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffAboutClick
        MessageBox.Show("Develop by Jack Soh Boon Keat , Goh Chun Lin , Tan Yi Si , Tan Haw Man", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub manageAccountClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffManageAccountClick
        Me.Close()
        StaffManageAccount.ShowDialog()
    End Sub
    Private Sub exitClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffExitClick
        End
    End Sub

    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.Load

    End Sub
End Class