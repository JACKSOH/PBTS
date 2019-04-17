Public Class ManagerManageSeat1
    Dim count As Integer = 0
    Dim db As New PBTSDataContext()
    Public selectedSeat As New List(Of Integer)
    Public selectedScheduleID As String
    Public selectedTranportID As String

    Private Sub ManagerManageSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BindSeat()
    End Sub
    Private Sub BindSeat()
        Dim transportColumn As Integer
        Dim transportRow As Integer
        Try
            transportColumn = CInt(db.Transports.Where(Function(o) o.transportID = selectedTranportID).FirstOrDefault.tranportColumn)
            transportRow = CInt(db.Transports.Where(Function(o) o.transportID = selectedTranportID).FirstOrDefault.tranportRow)

        Catch ex As Exception

        End Try
        MessageBox.Show(transportColumn.ToString)

        Dim seatQuery = From seat In db.Seats
                        Where seat.scheduleID = selectedScheduleID
                        Select seat.seatNumber

        Dim s As Integer = 0
        For i As Integer = 1 To seatQuery.Count
            Dim btn As New Button
            AddHandler btn.Click, AddressOf btnClick

            btn.Width = 50
            btn.Height = 50
            btn.BackColor = Color.White
            btn.Text = i.ToString
            btn.Visible = True
            flpSeat.Controls.Add(btn)
            Dim checkSeatQuery = From seat In db.Seats
                                 Where seat.scheduleID = staffBookingSchedule.scheduleID And seat.seatNumber = i
                                 Select seat.seatStatus
            Try
                If checkSeatQuery.FirstOrDefault.ToString.ToLower = "unavailable" Then
                    btn.BackColor = Color.Red
                    btn.Enabled = False
                End If
            Catch ex As Exception

            End Try
            s += 1
            If s = transportColumn Then
                flpSeat.SetFlowBreak(btn, True)
                s = 0
            End If
        Next

    End Sub
    Private Sub btnClick(sender As Object, e As EventArgs)
        Dim Btn As Button
        Btn = CType(sender, Button)
        Dim checkSeat As Boolean
        If Btn.BackColor = Color.Green Then
            checkSeat = True
        ElseIf Btn.BackColor = Color.White Then
            checkSeat = False
        End If

        If checkSeat = False Then
            Btn.BackColor = Color.Green
            checkSeat = True
            count = count + 1
            selectedSeat.Add(Integer.Parse(Btn.Text))
            lblSeatSelected.Text = count.ToString("0 seat(s) selected")
        Else
            Btn.BackColor = Color.White
            checkSeat = False
            count = count - 1
            selectedSeat.Remove(Integer.Parse(Btn.Text))
            lblSeatSelected.Text = count.ToString("0 seat(s) selected")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        MessageBox.Show("successful")
        Try
            For Each element In selectedSeat
                Dim seatquery = From seat In db.Seats
                                Where seat.scheduleID = selectedScheduleID And seat.seatNumber = element
                                Select seat


                For Each s As Seat In seatquery

                    s.seatStatus = "unavailable"
                    Try
                        db.SubmitChanges()
                        MessageBox.Show("successful")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class