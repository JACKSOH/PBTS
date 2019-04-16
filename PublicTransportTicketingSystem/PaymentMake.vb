Public Class PaymentMake
    Dim db As New PBTSDataContext()
    Dim totalOriginalPrice As Decimal = 0
    Dim totalDiscountedPrice As Decimal = 0
    Dim discountedPrice As Decimal = 0
    Dim hasDiscount As Boolean = True
    Dim query1 As IQueryable(Of Integer)

    Private Sub PaymentMake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = From schedule In db.Schedules
                    Where schedule.scheduleID = staffBookingSchedule.scheduleID
                    Join transport In db.Transports On transport.transportID Equals (schedule.transportID)
                    Select transport.transportName, transport.licensePlate

        lblDiscount.Text = "Discounted from RM70.00"
        lblPassengerName.Text = staffBookingCustomerDetail.custname
        lblDepartureDate.Text = staffBookingSchedule.departureDate.Substring(0, 10)
        lblDepartureTime.Text = staffBookingSchedule.departureDate.Substring(11)
        lblOrigin.Text = StaffBooking.selectedOrigin
        lblDestination.Text = StaffBooking.selectedDestination
        lblCompany.Text = query.First.transportName
        lblLicensePlate.Text = query.First.licensePlate

        Try
            Dim query1 = From promote In db.promoteSchedules
                         Where promote.scheduleID = staffBookingSchedule.scheduleID
                         Select promote.discountRate

        Catch ex As Exception
            hasDiscount = False
        End Try

        If query1 Is Nothing Then
            hasDiscount = False
        End If

        For Each element In staffSeatSelection.selectedSeat
            Dim displaySeatQuery = From seat In db.Seats
                                   Where seat.scheduleID = staffBookingSchedule.scheduleID And seat.seatNumber = element
                                   Join schedule In db.Schedules On schedule.scheduleID Equals (seat.scheduleID)
                                   Join transport In db.Transports On transport.transportID Equals (schedule.transportID)
                                   Select seat.seatNumber, transport.seatPrice

            Dim price As Decimal = Decimal.Parse(displaySeatQuery.First.seatPrice.ToString)
            totalOriginalPrice = totalOriginalPrice + price

            If hasDiscount = True Then
                discountedPrice = Decimal.Parse((price * query1.First).ToString)
            Else
                discountedPrice = price
            End If
            totalDiscountedPrice = totalDiscountedPrice + discountedPrice

            dgvSeatPrice.Rows.Add(displaySeatQuery.First.seatNumber.ToString, discountedPrice.ToString("RM 0.00"))
        Next
        dgvSeatPrice.Sort(dgvSeatPrice.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        lblTotalPrice.Text = totalDiscountedPrice.ToString("0.00")

        If hasDiscount = True Then
            lblDiscount.Text = "Discounted from RM" & totalOriginalPrice
        Else
            lblDiscount.Text = "No discount"
        End If

    End Sub

    Private Sub btnGenerateTicket_Click(sender As Object, e As EventArgs) Handles btnGenerateTicket.Click

        Dim printTicket As PaymentPrintTicket
        printTicket = New PaymentPrintTicket()
        printTicket.Show()
    End Sub


    Private Sub txtCashPaid_TextChanged(sender As Object, e As EventArgs) Handles txtCashPaid.TextChanged
        Dim totalPrice As Double = Double.Parse(lblTotalPrice.Text)
        Dim cashPaid As Double = 0

        Try
            cashPaid = Double.Parse(txtCashPaid.Text)
            If totalPrice > cashPaid Then
                lblCashPaidHint.Text = "Insufficient amount"
                lblChange.Text = ""
                btnGenerateTicket.Enabled = False
            ElseIf totalPrice <= cashPaid Then
                lblCashPaidHint.Text = ""
                lblChange.Text = (cashPaid - totalPrice).ToString("0.00")
                btnGenerateTicket.Enabled = True

            End If
        Catch ex As Exception
            cashPaid = 0
            If txtCashPaid.Text = "" Then
                lblCashPaidHint.Text = ""
            Else
                lblCashPaidHint.Text = "Invalid input"
            End If
        End Try

    End Sub


End Class