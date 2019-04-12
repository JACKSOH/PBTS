Imports System.Data.SqlClient

Public Class ManageCreatePromotionPart2

    Dim SqlConnection As New SqlConnection
    Dim selectedTransport As String

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        lblPromotionName.Text = ManagerCreatePromotion.promotionName
        lblPromotionStart.Text = ManagerCreatePromotion.startDate.ToString
        lblEndDate.Text = ManagerCreatePromotion.endDate.ToString

        If (ManagerCreatePromotion.discountRate = 100) Then
            lblDiscountRate.Text = "Free Ride / Board "
        Else
            lblDiscountRate.Text = (ManagerCreatePromotion.discountRate).ToString + "% discount "
        End If

        DataBind(selectedTransport)


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ManagerCreatePromotion.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub cboTransport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransport.SelectedIndexChanged
        selectedTransport = cboTransport.SelectedItem.ToString.ToLower
        DataBind(selectedTransport)
    End Sub

    Private Sub DataBind(t As String)
        Try
            Dim db As New PBTSDataContext()

            Dim query = From transport In db.Transports
                        Where transport.transportType = selectedTransport
                        Join schedule In db.Schedules On transport.transportID Equals (schedule.transportID)
                        Select schedule.scheduleID, schedule.departureDateTime, transport.transportID, transport.transportType
            dgvSchedule.DataSource = query
            lblCount.Text = query.Count.ToString("0 record(s)")
        Catch ex As Exception

        End Try
    End Sub
End Class