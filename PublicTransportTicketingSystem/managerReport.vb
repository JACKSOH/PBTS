

Public Class managerReport
    Private Sub managerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbMonthlyTransaction_CheckedChanged(sender As Object, e As EventArgs) Handles rbDailyTransaction.CheckedChanged
        If rbDailyTransaction.Checked Then
            lblDescription.Text = "To view how many transaction made within today."
        End If
    End Sub

    Private Sub rbMonthlyPromotion_CheckedChanged(sender As Object, e As EventArgs) Handles rbMonthlyPromotion.CheckedChanged
        If rbMonthlyPromotion.Checked Then
            lblDescription.Text = "Report that show how promotion stand for."
        End If
    End Sub

    Private Sub tbDailySchedule_CheckedChanged(sender As Object, e As EventArgs) Handles rbMonthlySchedule.CheckedChanged
        If rbDailyTransaction.Checked Then
            lblDescription.Text = "Generate to know what schedule is assigned today."
        End If
    End Sub

    Private Sub rbDailyBook_CheckedChanged(sender As Object, e As EventArgs) Handles rbDailyBook.CheckedChanged
        If rbDailyTransaction.Checked Then
            lblDescription.Text = "Report that tells customer booking transaction during today."
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblTransport.Click
        If rbDailyTransaction.Checked Then
            lblDescription.Text = "To view how many transaction made within today."
        End If
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load


    End Sub
    Public Sub ChangeTransport() Handles TranportSelection1.TransportChange
        lblTransport.Text = TranportSelection1.selectedType
        gbReport.Enabled = True
    End Sub

    'Create the event to triggered user control 
    'Start here
    Private Sub CloseForm()
        Me.Close()
    End Sub
    Private Sub showMessage()
        MessageBox.Show("This is the same page!")
    End Sub


    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If rbDailyBook.Checked Then
            managerBookingReport.Show()
        ElseIf rbMonthlySchedule.Checked Then
            Dim month As String
            Do
                month = InputBox("Please enter the a month(1-12).")
                If month = "" Or CInt(month) = 0 Or CInt(month) > 12 Then
                    MessageBox.Show("Please enter a proper month. E.g (1-12).", "Error")
                End If
            Loop While month = "" Or CInt(month) = 0 Or CInt(month) > 12
            managerScheduleReport.selectedMonth = CInt(month)
            managerScheduleReport.selectedType = TranportSelection1.selectedType
            managerScheduleReport.ShowDialog()
        ElseIf rbMonthlyPromotion.Checked Then
            Dim month As String
            Do
                month = InputBox("Please enter the a month(1-12).")
                If month = "" Or CInt(month) = 0 Or CInt(month) > 12 Then
                    MessageBox.Show("Please enter a proper month. E.g (1-12).", "Error")
                End If
            Loop While month = "" Or CInt(month) = 0 Or CInt(month) > 12
            MonthlyPromotionReport.selectedMonth = CInt(month)
            MonthlyPromotionReport.ShowDialog()
        ElseIf rbDailyTransaction.Checked Then
            Dim month As String
            Dim day As String
            Do
                month = InputBox("Please enter the month(1-12).")
                If month = "" Or CInt(month) = 0 Or CInt(month) > 12 Then
                    MessageBox.Show("Please enter a proper month. E.g (1-12).", "Error")
                End If
            Loop While month = "" Or CInt(month) = 0 Or CInt(month) > 12
            Do
                day = InputBox("Please enter the day(1-31).")
                If day = "" Or CInt(day) = 0 Or CInt(day) > 31 Then
                    MessageBox.Show("Please enter a proper day. E.g (1-31).", "Error")
                End If
            Loop While day = "" Or CInt(day) = 0 Or CInt(day) > 31
            ManagerTransactionReport.selectedDay = CDec(day)
            ManagerTransactionReport.selectedMonth = CDec(month)
            ManagerTransactionReport.ShowDialog()
        End If
    End Sub
    'End Here
End Class