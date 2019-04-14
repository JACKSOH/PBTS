Public Class ManagerSchduleInsert
    Public newId As String
    Public selectedType As String = ManagerManageSchedule.TranportSelection1.selectedType


    Public Sub BindcboTranport()
        TransportTableAdapter.FillBy1(PTTSDataSet.Transport, cboType.Text)
    End Sub
    Public Sub BindcboDestinationOrigin()

        Me.LocationTableAdapter.FillBy2(PTTSDataSet.Location, cboType.Text)
        Me.LocationTableAdapter.FillBy3(PTTSDataSet.Location, cboType.Text)
    End Sub

    Private Sub ManagerSchduleInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNewId.Text = newId
        cboType.SelectedIndex = 0
        cboCreating.SelectedIndex = 0

        BindcboTranport()
        BindcboDestinationOrigin()
        'only allow to choose time
        dtpTime.ShowUpDown = True
        dtpTime.MinDate = DateTime.Today
        dtpDate.MaxDate = DateTime.Today.AddMonths(1)
        dtpDate.MinDate = DateTime.Today

        'refresh the table index
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboDestination_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboDestination.Validating
        If cboDestination.Text = cboOrigin.Text Then
            err.SetError(cboDestination, "Origin and destionation could not be same!!")
            e.Cancel = True
        Else
            err.SetError(cboDestination, Nothing)

        End If
    End Sub

    Private Sub cboOrigin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboOrigin.Validating
        If cboDestination.Text = cboOrigin.Text Then
            err.SetError(cboOrigin, "Origin and destionation could not be same!!")
            e.Cancel = True
        Else
            err.SetError(cboOrigin, Nothing)

        End If
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        BindcboDestinationOrigin()
        BindcboTranport()

    End Sub
    'Create schdule within a month
    Private Sub CreateSchduleWithinMonth()

        'set max date and targeted datetime
        Dim MaxDate As DateTime = DateTime.Now.AddMonths(1)
        Dim TargetDateTime As DateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay
        Do

            'Craete Schedule
            Dim db As New PBTSDataContext

            'get tranport id 1st
            Dim t As Transport = db.Transports.Where(Function(o) o.transportID = cboCarrier.SelectedValue.ToString).SingleOrDefault
            'save schedule data 1st
            Dim sc As New Schedule
            sc.scheduleID = newId
            sc.departureDateTime = TargetDateTime
            sc.estimateHours = Math.Abs(CInt(db.Locations.Where(Function(o) o.locationID = cboOrigin.SelectedValue.ToString).SingleOrDefault().position - db.Locations.Where(Function(o) o.locationID = cboDestination.SelectedValue.ToString).SingleOrDefault().position)) * 2
            sc.transportID = cboCarrier.SelectedValue.ToString
            sc.scheduleStatus = "Available"
            db.Schedules.InsertOnSubmit(sc)

            'insert for new origin location
            Dim llOri As New LocationList
            llOri.scheduleID = newId
            Dim OriId As String = ""
            Try
                OriId = db.LocationLists.OrderByDescending(Function(o) o.locationListID).FirstOrDefault.locationListID.ToString
            Catch ex As Exception

            End Try
            App.table = "Location List"
            llOri.locationListID = App.GenerateNextId(OriId)
            MessageBox.Show(llOri.locationListID)
            llOri.locationID = cboDestination.SelectedValue.ToString
            llOri.locationStatus = "Origin"
            db.LocationLists.InsertOnSubmit(llOri)
            db.SubmitChanges()

            Dim db1 As New PBTSDataContext

            ' insert for new destination location
            Dim llDest As New LocationList
            llDest.scheduleID = newId
            Dim DestId As String = ""
            Try
                DestId = db1.LocationLists.OrderByDescending(Function(o) o.locationListID).FirstOrDefault.locationListID.ToString
            Catch ex As Exception

            End Try
            App.table = "Location List"
            llDest.locationListID = App.GenerateNextId(DestId)
            MessageBox.Show(llDest.locationListID)
            llDest.locationID = cboOrigin.SelectedValue.ToString
            llDest.locationStatus = "Destination"
            db1.LocationLists.InsertOnSubmit(llDest)
            db1.SubmitChanges()

            'Create Seat 
            Dim totalSeat As Integer = CInt(t.tranportRow * t.tranportColumn)
            Dim s(0 To totalSeat - 1) As Seat
            Dim newSeatId As String = ""
            Dim count As Integer = 1
            For Each i As Seat In s
                Try
                    If newSeatId = "" Then
                        newSeatId = db.Seats.OrderByDescending(Function(o) o.seatID).FirstOrDefault.seatID.ToString
                    End If

                Catch ex As Exception

                End Try
                i = New Seat()

                App.table = " Seats"
                i.seatID = App.GenerateNextId(newSeatId)
                i.Schedule = sc
                i.scheduleID = sc.scheduleID
                i.seatNumber = count
                i.seatStatus = "available"

                newSeatId = i.seatID
                Dim newSeat As Seat = i
                db.Seats.InsertOnSubmit(newSeat)
                db.SubmitChanges()


                count += 1
                'change the schedule id to next
                newId = App.GenerateNextId(newId)
            Next




            TargetDateTime = TargetDateTime.AddDays(7)

        Loop While TargetDateTime < MaxDate
        MessageBox.Show("Schedule has been created within this month", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'schdule does not repeat
    Private Sub CreateScheduleOnce()
        Dim db As New PBTSDataContext

        'get tranport id 1st
        Dim t As Transport = db.Transports.Where(Function(o) o.transportID = cboCarrier.SelectedValue.ToString).SingleOrDefault
        Dim targetDateTime As DateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay
        'save schedule data 1st
        Dim sc As New Schedule
        sc.scheduleID = newId
        sc.departureDateTime = targetDateTime
        sc.estimateHours = Math.Abs(CInt(db.Locations.Where(Function(o) o.locationID = cboOrigin.SelectedValue.ToString).SingleOrDefault().position - db.Locations.Where(Function(o) o.locationID = cboDestination.SelectedValue.ToString).SingleOrDefault().position)) * 2
        sc.transportID = cboCarrier.SelectedValue.ToString
        sc.scheduleStatus = "Available"
        db.Schedules.InsertOnSubmit(sc)

        'insert for new origin location
        Dim llOri As New LocationList
        llOri.scheduleID = newId
        Dim OriId As String = ""
        Try
            OriId = db.LocationLists.OrderByDescending(Function(o) o.locationListID).FirstOrDefault.locationListID.ToString
        Catch ex As Exception

        End Try
        App.table = "Location List"
        llOri.locationListID = App.GenerateNextId(OriId)
        MessageBox.Show(llOri.locationListID)
        llOri.locationID = cboDestination.SelectedValue.ToString
        llOri.locationStatus = "Origin"
        db.LocationLists.InsertOnSubmit(llOri)
        db.SubmitChanges()

        Dim db1 As New PBTSDataContext

        ' insert for new destination location
        Dim llDest As New LocationList
        llDest.scheduleID = newId
        Dim DestId As String = ""
        Try
            DestId = db1.LocationLists.OrderByDescending(Function(o) o.locationListID).FirstOrDefault.locationListID.ToString
        Catch ex As Exception

        End Try
        App.table = "Location List"
        llDest.locationListID = App.GenerateNextId(DestId)
        MessageBox.Show(llDest.locationListID)
        llDest.locationID = cboOrigin.SelectedValue.ToString
        llDest.locationStatus = "Destination"
        db1.LocationLists.InsertOnSubmit(llDest)
        db1.SubmitChanges()

        'Create Seat 
        Dim totalSeat As Integer = CInt(t.tranportRow * t.tranportColumn)
        Dim s(0 To totalSeat - 1) As Seat
        Dim newSeatId As String = ""
        Dim count As Integer = 1
        For Each i As Seat In s
            Try
                If newSeatId = "" Then
                    newSeatId = db.Seats.OrderByDescending(Function(o) o.seatID).FirstOrDefault.seatID.ToString
                End If

            Catch ex As Exception

            End Try
            i = New Seat()

            App.table = " Seats"
            i.seatID = App.GenerateNextId(newSeatId)
            i.Schedule = sc
            i.scheduleID = sc.scheduleID
            i.seatNumber = count
            i.seatStatus = "available"

            newSeatId = i.seatID
            Dim newSeat As Seat = i
            db.Seats.InsertOnSubmit(newSeat)
            db.SubmitChanges()


            count += 1
        Next

        MessageBox.Show("Successfully create")
    End Sub

    'schedule repeat this week
    Private Sub CreateScheduleWithinWeek()
        Dim MaxDate As DateTime = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay).AddDays(7)
        Dim TargetDateTime As DateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay
        Do

            'Craete Schedule
            Dim db As New PBTSDataContext

            'get tranport id 1st
            Dim t As Transport = db.Transports.Where(Function(o) o.transportID = cboCarrier.SelectedValue.ToString).SingleOrDefault
            'save schedule data 1st
            Dim sc As New Schedule
            sc.scheduleID = newId
            sc.departureDateTime = TargetDateTime
            sc.estimateHours = Math.Abs(CInt(db.Locations.Where(Function(o) o.locationID = cboOrigin.SelectedValue.ToString).SingleOrDefault().position - db.Locations.Where(Function(o) o.locationID = cboDestination.SelectedValue.ToString).SingleOrDefault().position)) * 2
            sc.transportID = cboCarrier.SelectedValue.ToString
            sc.scheduleStatus = "Available"
            db.Schedules.InsertOnSubmit(sc)

            'insert for new origin location
            Dim llOri As New LocationList
            llOri.scheduleID = newId
            Dim OriId As String = ""
            Try
                OriId = db.LocationLists.OrderByDescending(Function(o) o.locationListID).FirstOrDefault.locationListID.ToString
            Catch ex As Exception

            End Try
            App.table = "Location List"
            llOri.locationListID = App.GenerateNextId(OriId)
            MessageBox.Show(llOri.locationListID)
            llOri.locationID = cboDestination.SelectedValue.ToString
            llOri.locationStatus = "Origin"
            db.LocationLists.InsertOnSubmit(llOri)
            db.SubmitChanges()
            ' insert for new destination location
            Dim db1 As New PBTSDataContext


            Dim llDest As New LocationList
            llDest.scheduleID = newId
            Dim DestId As String = ""
            Try
                DestId = db1.LocationLists.OrderByDescending(Function(o) o.locationListID).FirstOrDefault.locationListID.ToString
            Catch ex As Exception

            End Try
            App.table = "Location List"
            llDest.locationListID = App.GenerateNextId(DestId)
            MessageBox.Show(llDest.locationListID)
            llDest.locationID = cboOrigin.SelectedValue.ToString
            llDest.locationStatus = "Destination"
            db1.LocationLists.InsertOnSubmit(llDest)
            db1.SubmitChanges()

            'Create Seat 
            Dim totalSeat As Integer = CInt(t.tranportRow * t.tranportColumn)
            Dim s(0 To totalSeat - 1) As Seat
            Dim newSeatId As String = ""
            Dim count As Integer = 1
            For Each i As Seat In s
                Try
                    If newSeatId = "" Then
                        newSeatId = db.Seats.OrderByDescending(Function(o) o.seatID).FirstOrDefault.seatID.ToString
                    End If

                Catch ex As Exception

                End Try
                i = New Seat()

                App.table = " Seats"
                i.seatID = App.GenerateNextId(newSeatId)
                i.Schedule = sc
                i.scheduleID = sc.scheduleID
                i.seatNumber = count
                i.seatStatus = "available"

                newSeatId = i.seatID
                Dim newSeat As Seat = i
                db.Seats.InsertOnSubmit(newSeat)
                db.SubmitChanges()
                ' new schedule ID
                newId = App.GenerateNextId(newId)
                count += 1
            Next




            TargetDateTime = TargetDateTime.AddDays(1)
        Loop While TargetDateTime < MaxDate

        MessageBox.Show("Schedule hass been created for a week.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboOrigin.SelectedValue.ToString = cboDestination.SelectedValue.ToString Then
            MessageBox.Show("Destionation and Origin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            err.SetError(cboDestination, Nothing)
            Select Case cboCreating.SelectedIndex
                Case 1
                    CreateSchduleWithinMonth()
                Case 2
                    CreateScheduleWithinWeek()
                Case Else
                    CreateScheduleOnce()
            End Select
        End If

    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        cboCreating.Items(1) = "Weekly on " + dtpDate.Value.DayOfWeek.ToString + " (Within this month)"
    End Sub

    Private Sub cboCreating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCreating.SelectedIndexChanged
        test.Text = cboOrigin.SelectedValue.ToString()
    End Sub
End Class