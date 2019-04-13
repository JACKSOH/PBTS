Public Class PaymentCancel
    Dim db As New PBTSDataContext()
    Friend departureDateTime As DateTime
    Friend ticketPrice As Decimal
    Friend ticketStatus As String
    Public dayDiff As Integer

    Private Sub txtTicketID_TextChanged(sender As Object, e As EventArgs) Handles txtTicketID.TextChanged

        lblPassengerName.Text = ""
        lblDepartureDate.Text = ""
        lblDepartureTime.Text = ""
        lblCompany.Text = ""
        lblLicensePlate.Text = ""
        lblSeat.Text = ""
        lblPrice.Text = ""
        lblOrigin.Text = ""
        lblDestination.Text = ""
        lblTicketIDHint.Text = ""
        lblRefund.Text = ""
        btnCancelAndRefund.Enabled = False

        Try
            Dim query1 = From ticket In db.Tickets
                         Join booking In db.Bookings On booking.bookingID Equals ticket.bookingID
                         Join seat In db.Seats On seat.seatID Equals ticket.seatID
                         Join schedule In db.Schedules On schedule.scheduleID Equals seat.scheduleID
                         Join transport In db.Transports On transport.transportID Equals schedule.transportID
                         Join locationlist In db.LocationLists On locationlist.scheduleID Equals schedule.scheduleID
                         Join Location In db.Locations On Location.locationID Equals locationlist.locationID
                         Where ticket.ticketID = txtTicketID.Text

            For Each q In query1
                lblPassengerName.Text = q.booking.customerName
                lblDepartureDate.Text = q.schedule.departureDateTime.Value.ToShortDateString
                lblDepartureTime.Text = q.schedule.departureDateTime.Value.ToShortTimeString
                departureDateTime = q.schedule.departureDateTime.Value

                lblCompany.Text = q.transport.transportName
                lblLicensePlate.Text = q.transport.licensePlate
                lblSeat.Text = q.seat.seatNumber.ToString
                lblPrice.Text = q.ticket.ticketPrice.Value.ToString("RM0.00")
                ticketPrice = q.ticket.ticketPrice.Value
                ticketStatus = q.ticket.ticketStatus

                Try
                    If lblOrigin.Text = "" Then
                        lblOrigin.Text = db.Locations.Where(Function(o) o.locationID = q.locationlist.locationID And q.locationlist.locationStatus.ToLower = "origin").SingleOrDefault.locationName.ToString
                    End If
                    If lblDestination.Text = "" Then
                        lblDestination.Text = db.Locations.Where(Function(o) o.locationID = q.locationlist.locationID And q.locationlist.locationStatus.ToLower = "destination").SingleOrDefault.locationName.ToString
                    End If

                Catch ex As Exception

                End Try

            Next

            If lblDepartureDate.Text = "" Then
                lblTicketIDHint.Text = "Invalid Ticket ID"
                ticketStatus = "invalid"
            End If

        Catch ex As Exception
            lblTicketIDHint.Text = "Invalid Ticket ID"
        End Try

        dayDiff = (departureDateTime - DateTime.Now).Days

        If ticketStatus = "paid" Then
            If dayDiff >= 2 Then
                lblRefund.Text = (ticketPrice / 2).ToString("RM0.00")
            Else
                lblRefund.Text = "No Refund."
            End If
            btnCancelAndRefund.Enabled = True
        ElseIf ticketStatus = "invalid" Then
            lblTicketIDHint.Text = "Invalid ticket ID."
            lblRefund.Text = ""
            btnCancelAndRefund.Enabled = False
        Else
            lblTicketIDHint.Text = "Already refunded/cancelled."
            lblRefund.Text = ""
            btnCancelAndRefund.Enabled = False
        End If


    End Sub

    Private Sub btnCancelAndRefund_Click(sender As Object, e As EventArgs) Handles btnCancelAndRefund.Click
        Dim response = MessageBox.Show("Confirmed?", "Generate Ticket", MessageBoxButtons.OKCancel)
        Dim ticketStatusString As String

        If response = DialogResult.OK Then
            Dim ticketquery = From ticketq In db.Tickets
                              Where ticketq.ticketID = txtTicketID.Text
                              Select ticketq

            Dim seatquery = From seatq In db.Seats
                            Where seatq.seatID = ticketquery.First.seatID
                            Select seatq

            If dayDiff >= 2 Then
                ticketStatusString = "refunded"
            Else
                ticketStatusString = "cancelled"
            End If

            For Each s As Seat In seatquery
                s.seatStatus = "available"
                Try
                    db.SubmitChanges()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Next

            For Each t As Ticket In ticketquery
                t.ticketStatus = ticketStatusString
                Try
                    db.SubmitChanges()
                    MessageBox.Show("Updated successfully.")
                    txtTicketID.Text = ""
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Next

        End If

    End Sub

    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.Load

    End Sub
End Class