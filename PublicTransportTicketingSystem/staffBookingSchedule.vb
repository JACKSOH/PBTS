
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
                        Join schedule In db.Schedules On origin.scheduleID Equals (schedule.scheduleID)
                        Join des In db.LocationLists On des.scheduleID Equals (origin.scheduleID)
                        Where origin.locationID = originID
                        Select schedule.scheduleID

            dgvSchedule.DataSource = query
            dgvSchedule.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class