Public Class ManagerManageSeat
    Dim count As Integer = 0
    Dim db As New PBTSDataContext()
    Public selectedSeat As New List(Of Integer)
    Public selectedScheduleID As String
    Private Sub ManagerManageSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BindSeat()
        Dim seatQuery = From seat In db.Seats
                        Where seat.scheduleID = selectedScheduleID
                        Select seat.seatNumber

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

            If checkSeatQuery.First.ToString.ToLower = "unavailable" Then
                btn.BackColor = Color.Red
                btn.Enabled = False

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
End Class