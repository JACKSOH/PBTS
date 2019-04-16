﻿Imports System.Data.SqlClient

Public Class StaffBooking
    Dim SqlConnection As New SqlConnection
    Public Const connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PTTS.mdf;Integrated Security=True"
    Public retrieveLocation As String
    Public selectedDate As Date
    Public selectedOrigin As String
    Public selectedDestination As String

    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, TranportSelection1.TransportChange
        'TODO: This line of code loads data into the 'PTTSDataSet.Location' table. You can move, or remove it, as needed.
        RetrieveOrigin()

        dtpDeparture.MinDate = DateTime.Today
        dtpDeparture.MaxDate = DateTime.Today.AddMonths(1)
    End Sub
    Private Sub RetrieveOrigin()
        Try
            SqlConnection.ConnectionString = connection
            SqlConnection.Open()
            Dim command As New SqlCommand("select * from Location WHERE locationType = @type", SqlConnection)
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = TranportSelection1.txtTransType.Text.ToString
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader
            cboOrigin.Items.Clear()

            While reader.Read
                retrieveLocation = reader.GetString(1)
                cboOrigin.Items.Add(retrieveLocation)
            End While

            SqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub cboOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigin.SelectedIndexChanged
        Try
            SqlConnection.ConnectionString = connection
            SqlConnection.Open()
            Dim command As New SqlCommand("select * from Location where locationName !=@selectedOrigin and locationType = @type", SqlConnection)
            command.Parameters.Add("@selectedOrigin", SqlDbType.VarChar).Value = cboOrigin.SelectedItem
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = TranportSelection1.txtTransType.Text.ToString
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



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim selectedDateTime As DateTime = dtpDeparture.Value
        selectedDate = selectedDateTime

        If cboOrigin.SelectedIndex = -1 Then
            cboOrigin.Select()
            MessageBox.Show("Please select the Origin..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If cboDestination.SelectedIndex = -1 Then
            cboDestination.Select()
            MessageBox.Show("Please select the Destination..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If cboOrigin.SelectedIndex > -1 And cboDestination.SelectedIndex > -1 Then
            selectedOrigin = cboOrigin.SelectedItem.ToString
            selectedDestination = cboDestination.SelectedItem.ToString

            staffBookingSchedule.Show()
            Me.Hide()
        End If
    End Sub



    Private Sub TranportSelection1_Load(sender As Object, e As EventArgs) Handles TranportSelection1.TransportChange
        RetrieveOrigin()
        cboOrigin.Text = "Origin"

    End Sub

    Private Sub homeClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffHomeClick
        staffHome.ShowDialog()
        Me.Close()

    End Sub
    Private Sub bookingClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffBookingClick
        ' Me.Close()
    End Sub
    Private Sub transactionClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffTransactionClick
        Me.Close()
        staffTransaction.ShowDialog()
    End Sub
    Private Sub promotionClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffPromotionClick
        Me.Close()
        StaffViewPromotion.ShowDialog()
    End Sub
    Private Sub aboutClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffAboutClick
        MessageBox.Show("Develop by Jack Soh Boon Keat , Goh Chun Lin , Tan Yi Si , Tan Haw Man", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub manageAccountClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffManageAccountClick
        Me.Close()
        StaffManageAccount.ShowDialog()
    End Sub
    Private Sub exitClick(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.staffExitClick
        End
    End Sub

    Private Sub StaffMenuLayoutControl1_Load_1(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.Load

    End Sub
End Class