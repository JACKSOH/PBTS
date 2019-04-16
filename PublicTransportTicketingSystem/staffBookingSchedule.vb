
Imports System.Data.SqlClient

Public Class staffBookingSchedule
    Dim SqlConnection As New SqlConnection
    Public scheduleID As String
    Public departureDate As String 'for payment

    Dim originID As String
    Dim desID As String
    Private Sub staffBookingSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub dgvSchedule_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellDoubleClick
        scheduleID = dgvSchedule.SelectedRows(0).Cells(2).Value.ToString
        staffSeatSelection.ShowDialog()
        'Me.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        dgvSchedule.Rows.Clear()
        dgvSchedule.Columns.Clear()

    End Sub

    Private Sub bindData()
        Try
            SqlConnection.ConnectionString = StaffBooking.connection
            SqlConnection.Open()
            Dim originCommand As New SqlCommand("select * from Location where locationName =@selectedOrigin and locationType = @type", SqlConnection)
            originCommand.Parameters.Add("@selectedOrigin", SqlDbType.VarChar).Value = StaffBooking.selectedOrigin

            originCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = StaffBooking.selectedType

            Dim originAdapter As New SqlDataAdapter(originCommand)
            Dim originReader As SqlDataReader
            originReader = originCommand.ExecuteReader


            While originReader.Read
                originID = originReader.GetString(0)
            End While

            SqlConnection.Close()

            SqlConnection.Open()
            Dim desCommand As New SqlCommand("select * from Location where locationName =@selectedDestination and locationType = @type", SqlConnection)
            desCommand.Parameters.Add("@selectedDestination", SqlDbType.VarChar).Value = StaffBooking.selectedDestination

            desCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = StaffBooking.selectedType

            Dim desAdapter As New SqlDataAdapter(desCommand)
            Dim desReader As SqlDataReader
            desReader = desCommand.ExecuteReader


            While desReader.Read
                desID = desReader.GetString(0)
            End While

            SqlConnection.Close()

            MessageBox.Show(desID, originID)

            Dim db As New PBTSDataContext()

            Dim query = From origin In db.LocationLists
                        Join schedule In db.Schedules On schedule.scheduleID Equals (origin.scheduleID)
                        Join des In db.LocationLists On schedule.scheduleID Equals (des.scheduleID)
                        Join originLocation In db.Locations On originLocation.locationID Equals (origin.locationID)
                        Join desLocation In db.Locations On desLocation.locationID Equals (des.locationID)
                        Where origin.locationID = originID And origin.locationStatus.ToLower = "origin" And des.locationID = desID And schedule.departureDateTime.Value.Date = StaffBooking.selectedDate.Date
                        Select originLocation.locationName, schedule.departureDateTime, schedule.scheduleID

            MessageBox.Show(query.First.locationName)

            Dim col As New DataGridViewTextBoxColumn
            col.DataPropertyName = "Destination"
            col.HeaderText = "Destination"
            col.Name = "colDes"
            Dim i As Integer

            lblRecordFound.Text = query.Count.ToString("0 record(s) found")

            dgvSchedule.DataSource = query
            dgvSchedule.Columns("locationName").HeaderText = "Origin"
            dgvSchedule.Columns("departureDateTime").HeaderText = "Departure Date Time"
            dgvSchedule.Columns("scheduleID").HeaderText = "Schedule ID"
            dgvSchedule.Columns.Add(col)
            i = query.Count

            For i = 0 To (query.Count - 1)
                dgvSchedule.Rows(i).Cells(3).Value = StaffBooking.selectedDestination
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub staffBookingSchedule_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bindData()

    End Sub

End Class