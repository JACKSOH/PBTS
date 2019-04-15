Public Class staffSeatSelection

    Dim count As Integer = 0
    Dim db As New PBTSDataContext()
    Public selectedSeat As New List(Of Integer)

    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim retrieveSeatQuery = From seat In db.Seats
                                Where seat.scheduleID = staffBookingSchedule.scheduleID
                                Select seat.seatNumber

        Dim i As Integer

        For i = 1 To retrieveSeatQuery.Count
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        'Dim list As New List(Of Control) = FlowLayoutPanel.Controls.ToList()
        'For Each control As Control In flpSeat.Controls
        'flpSeat.Controls.Remove(control)
        'Control.Dispose()
        'Next

        flpSeat.Controls.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        staffBookingCustomerDetail.Show()
        Me.Hide()
        staffBookingSchedule.Hide()

    End Sub
End Class