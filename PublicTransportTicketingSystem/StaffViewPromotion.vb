Public Class StaffViewPromotion
    Private transportType As String = "Bus"
    Private activeStatus As String = "Active"
    Private contain As String
    Private today As Date = Date.Today

    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.Load
        DataBind()
    End Sub

    Private Sub DataBindSearch()
        Try
            Dim db As New PBTSDataContext()
            Dim query = From promotion In db.Promotions
                        Join promoteSchedule In db.promoteSchedules On promoteSchedule.promotionID Equals (promotion.promotionID)
                        Join schedule In db.Schedules On schedule.scheduleID Equals (promoteSchedule.scheduleID)
                        Join transport In db.Transports On transport.transportID Equals (schedule.transportID)
                        Where promotion.promotionStatus = activeStatus And (transport.transportType.Contains(contain) Or promotion.promotionID.Contains(contain) Or promotion.promotionName.Contains(contain) Or promotion.promotionStartDate.Value.Date.ToString.Contains(contain) Or promotion.promotionEndDate.Value.Date.ToString.Contains(contain))
                        Select New With {promotion.promotionID, promotion.promotionName, promotion.promotionStartDate, promotion.promotionEndDate, transport.transportType, promotion.promotionDesc, promoteSchedule.discountRate} Distinct.ToList
            dgvPromotionList.DataSource = query
            dgvPromotionList.Columns("promotionID").HeaderText = "ID"
            dgvPromotionList.Columns("promotionName").HeaderText = "Name"
            dgvPromotionList.Columns("promotionStartDate").HeaderText = "Start Date"
            dgvPromotionList.Columns("promotionEndDate").HeaderText = "End Date"
            dgvPromotionList.Columns("promotionDesc").HeaderText = "Description"
            dgvPromotionList.Columns("transportType").HeaderText = "Type"
            dgvPromotionList.Columns("discountRate").HeaderText = "Discount"
            lblCount.Text = query.Count.ToString("0 record(s)")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataBind()
        Try
            Dim db As New PBTSDataContext()

            Dim query = From promotion In db.Promotions
                        Join promoteSchedule In db.promoteSchedules On promoteSchedule.promotionID Equals (promotion.promotionID)
                        Join schedule In db.Schedules On schedule.scheduleID Equals (promoteSchedule.scheduleID)
                        Join transport In db.Transports On transport.transportID Equals (schedule.transportID)
                        Where promotion.promotionStatus = activeStatus And (transport.transportType = transportType And today >= promotion.promotionStartDate.Value.Date And today <= promotion.promotionEndDate.Value.Date)
                        Select New With {promotion.promotionID, promotion.promotionName, promotion.promotionStartDate, promotion.promotionEndDate, transport.transportType, promotion.promotionDesc, promoteSchedule.discountRate} Distinct.ToList
            dgvPromotionList.DataSource = query
            dgvPromotionList.Columns("promotionID").HeaderText = "ID"
            dgvPromotionList.Columns("promotionName").HeaderText = "Name"
            dgvPromotionList.Columns("promotionStartDate").HeaderText = "Start Date"
            dgvPromotionList.Columns("promotionEndDate").HeaderText = "End Date"
            dgvPromotionList.Columns("transportType").HeaderText = "Type"
            dgvPromotionList.Columns("promotionDesc").HeaderText = "Description"
            dgvPromotionList.Columns("discountRate").HeaderText = "Discount"

            lblCount.Text = query.Count.ToString("0 record(s)")



        Catch ex As Exception
            MessageBox.Show("Please check database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPromotion_TextChanged(sender As Object, e As EventArgs) Handles txtPromotion.TextChanged
        contain = txtPromotion.Text
        If (txtPromotion.Text = "") Then
            DataBind()
            dpPromotionDate.Enabled = True
        Else
            DataBindSearch()
            dpPromotionDate.Enabled = False
            today = Date.Today
            dpPromotionDate.Value = Date.Today
        End If
    End Sub

    Private Sub dpPromotionDate_ValueChanged(sender As Object, e As EventArgs) Handles dpPromotionDate.ValueChanged
        today = dpPromotionDate.Value.Date
        DataBind()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPromotion.Clear()
        today = Date.Today
        dpPromotionDate.Value = Date.Today
        DataBind()
    End Sub
End Class