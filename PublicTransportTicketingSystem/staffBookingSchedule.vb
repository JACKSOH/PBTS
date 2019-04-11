
Imports System.Data.SqlClient

Public Class staffBookingSchedule
    Dim SqlConnection As New SqlConnection


    Dim originID As String
    Dim desID As String
    Private Sub staffBookingSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SqlConnection.ConnectionString = StaffBooking.connection
            SqlConnection.Open()
            Dim originCommand As New SqlCommand("select * from Location where locationName =@selectedOrigin", SqlConnection)
            originCommand.Parameters.Add("@selectedOrigin", SqlDbType.VarChar).Value = StaffBooking.selectedOrigin
            Dim originAdapter As New SqlDataAdapter(originCommand)
            Dim originReader As SqlDataReader
            originReader = originCommand.ExecuteReader


            While originReader.Read
                originID = originReader.GetString(0)
                MessageBox.Show(originID)
            End While

            SqlConnection.Close()

            SqlConnection.Open()
            Dim desCommand As New SqlCommand("select * from Location where locationName =@selectedDestination", SqlConnection)
            desCommand.Parameters.Add("@selectedDestination", SqlDbType.VarChar).Value = StaffBooking.selectedDestination
            Dim desAdapter As New SqlDataAdapter(desCommand)
            Dim desReader As SqlDataReader
            desReader = desCommand.ExecuteReader


            While desReader.Read
                desID = desReader.GetString(0)
                MessageBox.Show(desID)
            End While

            SqlConnection.Close()

            Dim db As New PBTSDataContext()

            Dim query = From origin In db.LocationLists
                        Where origin.locationID = originID
                        Join schedule In db.Schedules On schedule.scheduleID Equals (origin.scheduleID)
                        Join des In db.LocationLists On des.scheduleID Equals (origin.scheduleID)
                        Join originLocation In db.Locations On originLocation.locationID Equals (origin.locationID)
                        Join desLocation In db.Locations On desLocation.locationID Equals (des.locationID)
                        Select originLocation.locationName, schedule.departureDateTime, schedule.arrivalDateTIme

            Dim dt As New DataTable
            '' Create 3 typed columns in the DataTable.
            dt.Columns.Add("Origin", GetType(String))
            dt.Columns.Add("Departure Date", GetType(Date))
            dt.Columns.Add("Arrival Date", GetType(Date))



            dt.LoadDataRow(New Object() {query.First.locationName, query.First.departureDateTime, query.First.arrivalDateTIme}, True)
            dgvSchedule.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.Load

    End Sub
End Class