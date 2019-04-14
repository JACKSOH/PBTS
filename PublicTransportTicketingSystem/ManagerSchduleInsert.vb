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
        cboType.SelectedIndex = 0
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New PBTSDataContext
        'get tranport id 1st
        Dim t As Transport = db.Transports.Where(Function(o) o.transportID = cboOrigin.SelectedValue.ToString).SingleOrDefault
        'save schedule data 1st
        Dim sc As New Schedule
        sc.scheduleID = newId
        sc.departureDateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay
        sc.estimateHours = Math.Abs(CInt(db.Locations.Where(Function(o) o.locationID = cboOrigin.SelectedValue.ToString).SingleOrDefault().position - db.Locations.Where(Function(o) o.locationID = cboDestination.SelectedValue.ToString).SingleOrDefault().position)) * 2
        sc.transportID = cboOrigin.SelectedValue.ToString

        sc.Transport = t
        sc.scheduleStatus = "Available"
        db.Schedules.InsertOnSubmit(sc)
        'db.SubmitChanges()
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

        llOri.locationID = cboDestination.SelectedValue.ToString
        llOri.locationStatus = "Origin"
        db.LocationLists.InsertOnSubmit(llOri)
        db.SubmitChanges()
        ' insert for new destination location
        Dim llDest As New LocationList
        llDest.scheduleID = newId
        Dim DestId As String = ""
        Try
            DestId = db.LocationLists.OrderByDescending(Function(o) o.locationListID).FirstOrDefault.locationListID.ToString
        Catch ex As Exception

        End Try
        App.table = "Location List"
        llDest.locationListID = App.GenerateNextId(DestId)
        llDest.locationID = cboOrigin.SelectedValue.ToString
        llDest.locationStatus = "Destination"
        db.LocationLists.InsertOnSubmit(llDest)
        db.SubmitChanges()
        MessageBox.Show("Successfully create")
        Select Case cboCreating.SelectedIndex
            Case 0
            Case 1
            Case 2
            Case Else

        End Select
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        cboCreating.Items(1) = "Weekly on " + dtpDate.Value.DayOfWeek.ToString + " (Within this month)"
    End Sub


End Class