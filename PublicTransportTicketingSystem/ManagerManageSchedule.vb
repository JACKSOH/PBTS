Public Class ManagerManageSchedule
    Public selectedType As String
    'bind data to grid view
    Private Sub bindData()
        dgvSchedule.Rows.Clear()

        Dim db As New PBTSDataContext()

        Dim sc = From sch In db.Schedules
                 Join tr In db.Transports On sch.transportID Equals tr.transportID
                 Where tr.transportType = selectedType

        Dim count As Integer = 0


        For Each sch In sc

            'get   origin name
            Dim origin As String = (From lo In db.Locations
                                    Join ori In db.LocationLists On ori.locationID Equals lo.locationID
                                    Where ori.scheduleID = sch.sch.scheduleID And ori.locationStatus.ToLower = "origin" Select lo.locationName).FirstOrDefault.ToString



            'get destination name
            Dim destination As String = (From lo In db.Locations
                                         Join dest In db.LocationLists On dest.locationID Equals lo.locationID
                                         Where dest.scheduleID = sch.sch.scheduleID And dest.locationStatus.ToLower = "destination"
                                         Select lo.locationName).FirstOrDefault.ToString

            Dim destName As String = destination.ToString
            dgvSchedule.Rows.Add(1)
            dgvSchedule.Rows(count).Cells(0).Value = sch.sch.scheduleID
            dgvSchedule.Rows(count).Cells(1).Value = origin
            dgvSchedule.Rows(count).Cells(2).Value = destName
            dgvSchedule.Rows(count).Cells(3).Value = sch.sch.departureDateTime.Value.ToShortDateString + "  " + sch.sch.departureDateTime.Value.ToShortTimeString
            dgvSchedule.Rows(count).Cells(4).Value = selectedType
            count += 1
        Next
    End Sub

    'search by origin location
    Private Sub BindDataByOrigin()
        dgvSchedule.Rows.Clear()

        Dim db As New PBTSDataContext()

        Dim sc = From sch In db.Schedules
                 Join tr In db.Transports On sch.transportID Equals tr.transportID
                 Join ori In db.LocationLists On sch.scheduleID Equals ori.scheduleID
                 Join lo In db.Locations On ori.locationID Equals lo.locationID
                 Where tr.transportType = selectedType And ori.locationStatus.ToLower = "origin" And lo.locationName.Contains(txtSearch.Text)

        Dim count As Integer = 0


        For Each sch In sc

            'get   origin name
            Dim origin As String = (From lo In db.Locations
                                    Join ori In db.LocationLists On ori.locationID Equals lo.locationID
                                    Where ori.scheduleID = sch.sch.scheduleID And ori.locationStatus.ToLower = "origin" Select lo.locationName).FirstOrDefault.ToString



            'get destination name
            Dim destination As String = (From lo In db.Locations
                                         Join dest In db.LocationLists On dest.locationID Equals lo.locationID
                                         Where dest.scheduleID = sch.sch.scheduleID And dest.locationStatus.ToLower = "destination"
                                         Select lo.locationName).FirstOrDefault.ToString

            Dim destName As String = destination.ToString
            dgvSchedule.Rows.Add(1)
            dgvSchedule.Rows(count).Cells(0).Value = sch.sch.scheduleID
            dgvSchedule.Rows(count).Cells(1).Value = origin
            dgvSchedule.Rows(count).Cells(2).Value = destName
            dgvSchedule.Rows(count).Cells(3).Value = sch.sch.departureDateTime.Value.ToShortDateString + "  " + sch.sch.departureDateTime.Value.ToShortTimeString
            dgvSchedule.Rows(count).Cells(4).Value = selectedType
            count += 1
        Next
    End Sub

    'search by date
    Private Sub BindDataByDate()
        dgvSchedule.Rows.Clear()

        Dim db As New PBTSDataContext()
        Dim searchDate As DateTime
        Try
            searchDate = dtpDate.Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim sc = From sch In db.Schedules
                 Join tr In db.Transports On sch.transportID Equals tr.transportID
                 Where tr.transportType = selectedType And sch.departureDateTime = searchDate

        Dim count As Integer = 0


        For Each sch In sc

            'get   origin name
            Dim origin As String = (From lo In db.Locations
                                    Join ori In db.LocationLists On ori.locationID Equals lo.locationID
                                    Where ori.scheduleID = sch.sch.scheduleID And ori.locationStatus.ToLower = "origin" Select lo.locationName).FirstOrDefault.ToString



            'get destination name
            Dim destination As String = (From lo In db.Locations
                                         Join dest In db.LocationLists On dest.locationID Equals lo.locationID
                                         Where dest.scheduleID = sch.sch.scheduleID And dest.locationStatus.ToLower = "destination"
                                         Select lo.locationName).FirstOrDefault.ToString

            Dim destName As String = destination.ToString
            dgvSchedule.Rows.Add(1)
            dgvSchedule.Rows(count).Cells(0).Value = sch.sch.scheduleID
            dgvSchedule.Rows(count).Cells(1).Value = origin
            dgvSchedule.Rows(count).Cells(2).Value = destName
            dgvSchedule.Rows(count).Cells(3).Value = sch.sch.departureDateTime.Value.ToShortDateString + "  " + sch.sch.departureDateTime.Value.ToShortTimeString
            dgvSchedule.Rows(count).Cells(4).Value = selectedType
            count += 1
        Next
    End Sub
    Private Sub ManagerManageSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PTTSDataSet.Schedule' table. You can move, or remove it, as needed.
        selectedType = ts.selectedType

        Dim col1 As New DataGridViewTextBoxColumn

        col1.DataPropertyName = "Schedule ID "
        col1.HeaderText = "Schedule ID"
        col1.Name = "colSche"
        Dim col2 As New DataGridViewTextBoxColumn
        col2.DataPropertyName = "Origin "
        col2.HeaderText = "Origin"
        col2.Name = "colOri"
        Dim col3 As New DataGridViewTextBoxColumn
        col3.DataPropertyName = "Destination "
        col3.HeaderText = "Destination"
        col3.Name = "colDest"
        Dim col4 As New DataGridViewTextBoxColumn
        col4.DataPropertyName = "Transport Type "
        col4.HeaderText = "Transport Type"
        col4.Name = "colTrans"
        Dim col5 As New DataGridViewTextBoxColumn
        col5.DataPropertyName = "Departure Date and Time "
        col5.HeaderText = "Departure Date and Time"
        col5.Name = "colDepart"
        dgvSchedule.Columns.Add(col1)
        dgvSchedule.Columns.Add(col2)
        dgvSchedule.Columns.Add(col3)
        dgvSchedule.Columns.Add(col5)
        dgvSchedule.Columns.Add(col4)
        bindData()


    End Sub
    Private Sub ChaneTransport() Handles ts.TransportChange
        selectedType = ts.selectedType
        bindData()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New PBTSDataContext
        Dim id As String
        Try
            id = db.Schedules.OrderByDescending(Function(s) s.scheduleID).FirstOrDefault.scheduleID.ToString
        Catch ex As Exception

        End Try
        App.table = "Schedule"
        ManagerSchduleInsert.newId = App.GenerateNextId(id)
        ManagerSchduleInsert.ShowDialog()
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        BindDataByOrigin()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        BindDataByDate()

    End Sub

    Private Sub dgvSchedule_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellDoubleClick
        ManagerManageSeat.selectedScheduleID = dgvSchedule.CurrentRow.Cells(0).Value.ToString
        ManagerManageSeat.ShowDialog()

    End Sub
End Class