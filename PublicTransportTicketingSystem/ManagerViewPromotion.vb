Public Class ManagerViewPromotion
    Private selectedTransport As String = "All"

    Private Sub DataBind()
        Try
            Dim db As New PBTSDataContext()

            Dim query = From transport In db.Transports
                        Join Schedule In db.Schedules On transport.transportID Equals (Schedule.transportID)
                        Join promoteSchedule In db.promoteSchedules On Schedule.scheduleID Equals (promoteSchedule.scheduleID)
                        Join promotion In db.Promotions On promoteSchedule.promotionID Equals (promotion.promotionID)
                        Where selectedTransport = "All" Or transport.transportType = selectedTransport
                        Select promotion.promotionID, promotion.promotionName, promotion.promotionStartDate, promotion.promotionEndDate, promotion.promotionDesc
            dgvPromotionList.DataSource = query
            dgvPromotionList.Columns("promotionID").HeaderText = "ID"
            dgvPromotionList.Columns("promotionName").HeaderText = "Name"
            dgvPromotionList.Columns("promotionStartDate").HeaderText = "Start Date"
            dgvPromotionList.Columns("promotionEndDate").HeaderText = "End Date"
            dgvPromotionList.Columns("promotionDesc").HeaderText = "Description"
            lblCount.Text = query.Count.ToString("0 record(s)")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        DataBind()
        'cboTransport.SelectedItem = "All"
    End Sub
End Class