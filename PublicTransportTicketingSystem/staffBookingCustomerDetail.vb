Imports System.Text

Public Class staffBookingCustomerDetail
    Dim db As New PBTSDataContext()

    'for payment purpose

    'seat
    Public totalPrice As Decimal 'total price of seat

    'booking
    Public newId As String      'bookingid

    'ticket
    Public newtId As String     'ticketid

    Public seatid As String

    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim col1 As New DataGridViewTextBoxColumn
            col1.DataPropertyName = "SeatNumber"
            col1.HeaderText = "SeatNumber"
            col1.Name = "colSeatNumber"

            Dim col2 As New DataGridViewTextBoxColumn
            col2.DataPropertyName = "Price"
            col2.HeaderText = "Price"
            col2.Name = "colPrice"

            dgvSeat.Columns.Add(col1)
            dgvSeat.Columns.Add(col2)
            For Each element In staffSeatSelection.selectedSeat
                Dim displaySeatQuery = From seat In db.Seats
                                       Where seat.scheduleID = staffBookingSchedule.scheduleID And seat.seatNumber = element
                                       Join schedule In db.Schedules On schedule.scheduleID Equals (seat.scheduleID)
                                       Join transport In db.Transports On transport.transportID Equals (schedule.transportID)
                                       Select seat.seatNumber, transport.seatPrice

                Dim price As Decimal = Decimal.Parse(displaySeatQuery.First.seatPrice.ToString)
                totalPrice = totalPrice + price
                dgvSeat.Rows.Add(displaySeatQuery.First.seatNumber.ToString, price.ToString("RM 0.00"))
            Next
            dgvSeat.Sort(dgvSeat.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            lblTotalPrice.Text = totalPrice.ToString("RM 0.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click

        Try


            'for validating purpose
            Dim err As New StringBuilder()
            Dim ctr As Control = Nothing

            'read input
            Dim ic As String = If(mskIC.MaskCompleted, mskIC.Text, "")
            Dim contactNo As String = If(mskContact.MaskCompleted, mskContact.Text, "")
            Dim email As String = txtName.Text.Trim

            'validate ic
            If ic = "" Then
                err.AppendLine("- Invalid Customer IC")
                ctr = If(ctr, mskIC)
            End If

            'validate contact
            If contactNo = "" Then
                err.AppendLine("- Invalid Customer Contact No.")
                ctr = If(ctr, mskContact)
            End If

            'validate email
            If email = "" Then
                err.AppendLine("- Invalid email")
                ctr = If(ctr, txtName)
            End If

            'check if input error
            If err.Length > 0 Then
                MessageBox.Show(err.ToString, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ctr.Focus()
                Return
            End If



            Dim getIdQuery = From booking In db.Bookings
                             Select booking.bookingID

            Dim oldBookingID As String = getIdQuery.ToList.Last
            Dim code As Char = oldBookingID.Chars(0)
            Dim digit As Integer = Integer.Parse(oldBookingID.Substring(1, 4)) + 1
            newId = code + digit.ToString("0000")

            MessageBox.Show(newId)

            Dim book As New Booking
            book.bookingID = newId
            book.customerIC = mskIC.Text
            book.customerContactNo = mskContact.Text
            book.customerEmail = txtName.Text
            book.employeeID = "em0001"
            db.Bookings.InsertOnSubmit(book)
            Try
                db.SubmitChanges()


                For Each element In staffSeatSelection.selectedSeat
                    Dim getseatIDQuery = From seat In db.Seats
                                         Where seat.scheduleID = staffBookingSchedule.scheduleID And seat.seatNumber = element
                                         Join schedule In db.Schedules On schedule.scheduleID Equals (seat.scheduleID)
                                         Join transport In db.Transports On transport.transportID Equals (schedule.transportID)
                                         Select seat.seatID, transport.seatPrice

                    Dim getticketIdQuery = From t In db.Tickets
                                           Select t.ticketID

                    Dim sprice As Decimal = Decimal.Parse(getseatIDQuery.First.seatPrice.ToString)

                    Dim oldTicketID As String = getticketIdQuery.ToList.Last
                    Dim tcode As Char = oldTicketID.Chars(0)
                    Dim tdigit As Integer = Integer.Parse(oldTicketID.Substring(1, 4)) + 1
                    newtId = tcode + tdigit.ToString("0000")

                    seatid = getseatIDQuery.First.seatID

                    Dim ticket As New Ticket
                    ticket.ticketID = newtId
                    ticket.seatID = seatid
                    ticket.purchaseDateTime = DateTime.Now
                    ticket.ticketPrice = sprice
                    ticket.bookingID = newId
                    db.Tickets.InsertOnSubmit(ticket)
                    Try
                        db.SubmitChanges()


                        Dim seatquery = From seatq In db.Seats
                                        Where seatq.seatID = seatid
                                        Select seatq

                        For Each s As Seat In seatquery

                            s.seatStatus = "Unavailable"
                            Try
                                db.SubmitChanges()

                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                        Next


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try


                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("Successfully Book", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'go to payment page

    End Sub
End Class