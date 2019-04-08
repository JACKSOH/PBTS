Imports System.Data.SqlClient

Public Class StaffBooking
    Dim SqlConnection As New SqlConnection
    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SqlConnection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\boonk\source\repos\JACKSOH\PBTS\PublicTransportTicketingSystem\PTTS.mdf;Integrated Security=True"
            SqlConnection.Open()
            Dim command As New SqlCommand("select * from Location", SqlConnection)
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader

            While reader.Read
                cboOrigin.Items.Add(reader.GetString(1))
            End While

            SqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cboOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigin.SelectedIndexChanged
        Try
            SqlConnection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\boonk\source\repos\JACKSOH\PBTS\PublicTransportTicketingSystem\PTTS.mdf;Integrated Security=True"
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
End Class