

Public Class managerReport
    Private Sub managerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbMonthlyTransaction_CheckedChanged(sender As Object, e As EventArgs) Handles rbMonthlyTransaction.CheckedChanged
        If rbMonthlyTransaction.Checked Then
            lblDescription.Text = "To view how many transaction made within today."
        End If
    End Sub

    Private Sub rbMonthlyPromotion_CheckedChanged(sender As Object, e As EventArgs) Handles rbMonthlyPromotion.CheckedChanged
        If rbMonthlyPromotion.Checked Then
            lblDescription.Text = "Report that show how promotion stand for."
        End If
    End Sub

    Private Sub tbDailySchedule_CheckedChanged(sender As Object, e As EventArgs) Handles tbDailySchedule.CheckedChanged
        If rbMonthlyTransaction.Checked Then
            lblDescription.Text = "Generate to know what schedule is assigned today."
        End If
    End Sub

    Private Sub rbDailyBook_CheckedChanged(sender As Object, e As EventArgs) Handles rbDailyBook.CheckedChanged
        If rbMonthlyTransaction.Checked Then
            lblDescription.Text = "Report that tells customer booking transaction during today."
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblTransport.Click
        If rbMonthlyTransaction.Checked Then
            lblDescription.Text = "To view how many transaction made within today."
        End If
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load


    End Sub
    Public Sub ChangeTransport() Handles TranportSelection1.TransportChange
        lblTransport.Text = TranportSelection1.selectedType

    End Sub

    'Create the event to triggered user control 
    'Start here
    Private Sub CloseForm()
        Me.Close()
    End Sub
    Private Sub showMessage()
        MessageBox.Show("This is the same page!")
    End Sub
    Private Sub btnHomeClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerHomeClick



    End Sub

    Private Sub btnReportClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerReportClick


    End Sub


    Private Sub btnStaffClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerManageStaffClick



    End Sub


    Private Sub btnScheduleClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerScheduleClick

    End Sub
    Private Sub btnPromotionClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerPromotionClick

    End Sub

    Private Sub btnPTClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerPublicTransportClick

    End Sub

    Private Sub btnLocationClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerManageLocationClick

    End Sub

    Private Sub btnAboutClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerAboutClick

    End Sub

    Private Sub btnManageAccountClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerManageAccountClick

    End Sub

    Private Sub btnExitClick(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.managerHomeClick

    End Sub
    'End Here
End Class