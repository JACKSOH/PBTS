Imports System.Data.SqlClient

Public Class StaffBooking
    Dim SqlConnection As New SqlConnection
    Public Const connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chunl\OneDrive\Desktop\PBTS\PublicTransportTicketingSystem\PTTS.mdf;Integrated Security=True"
    Public retrieveLocation As String
    Public selectedDate As Date
    Public selectedOrigin As String
    Public selectedDestination As String

    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SqlConnection.ConnectionString = connection
            SqlConnection.Open()
            Dim command As New SqlCommand("select * from Location", SqlConnection)
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader

            While reader.Read
                retrieveLocation = reader.GetString(1)
                cboOrigin.Items.Add(retrieveLocation)
            End While

            SqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        dtpDeparture.MinDate = DateTime.Today
        dtpDeparture.MaxDate = DateTime.Today.AddMonths(1)
    End Sub

    Private Sub cboOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigin.SelectedIndexChanged
        Try
            SqlConnection.ConnectionString = connection
            SqlConnection.Open()
            Dim command As New SqlCommand("select * from Location where locationName !=@selectedOrigin", SqlConnection)
            command.Parameters.Add("@selectedOrigin", SqlDbType.VarChar).Value = cboOrigin.SelectedItem
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader
            cboDestination.Items.Clear()
            cboDestination.Text = "Destination"
            cboDestination.SelectedItem = False

            While reader.Read
                cboDestination.Items.Add(reader.GetString(1))
            End While

            SqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub TranportSelection1_Load(sender As Object, e As EventArgs) Handles TranportSelection1.MouseClick


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        If cboOrigin.SelectedIndex = -1 Then
            cboOrigin.Select()
            MessageBox.Show("Please select the Origin..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If cboDestination.SelectedIndex = -1 Then
            cboDestination.Select()
            MessageBox.Show("Please select the Destination..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If cboDestination.SelectedIndex > -1 And cboOrigin.SelectedIndex > -1 Then
            Dim selectedDateTime As DateTime = dtpDeparture.Value
            selectedDate = selectedDateTime.Date
            selectedOrigin = cboOrigin.SelectedItem.ToString
            selectedDestination = cboDestination.SelectedItem.ToString

            staffBookingSchedule.Show()
            Me.Hide()
        End If

    End Sub
End Class