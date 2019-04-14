Public Class ManagerViewPromotion
    Friend selectedTransport As String
    Private promotionDate As Date = Today.Date
    Private contain As String
    Friend id As String
    Friend pname As String
    Friend psdate As String
    Friend pedate As String
    Friend pdesc As String
    Friend status As String



    Private Sub DataBindSearch()
        Try
            Dim db As New PBTSDataContext()
            Dim query = From promotion In db.Promotions
                        Join promoteSchedule In db.promoteSchedules On promoteSchedule.promotionID Equals (promotion.promotionID)
                        Join schedule In db.Schedules On schedule.scheduleID Equals (promoteSchedule.scheduleID)
                        Join transport In db.Transports On transport.transportID Equals (schedule.transportID)
                        Where transport.transportType.Contains(contain) Or promotion.promotionID.Contains(contain) Or promotion.promotionDesc.Contains(contain) Or promotion.promotionStartDate.Value.Date.ToString.Contains(contain) Or promotion.promotionEndDate.Value.Date.ToString.Contains(contain)
                        Select promotion.promotionID, promotion.promotionName, promotion.promotionStartDate, promotion.promotionEndDate, promotion.promotionDesc, transport.transportType
            dgvPromotionList.DataSource = query
            dgvPromotionList.Columns("promotionID").HeaderText = "ID"
            dgvPromotionList.Columns("promotionName").HeaderText = "Name"
            dgvPromotionList.Columns("promotionStartDate").HeaderText = "Start Date"
            dgvPromotionList.Columns("promotionEndDate").HeaderText = "End Date"
            dgvPromotionList.Columns("promotionDesc").HeaderText = "Description"
            dgvPromotionList.Columns("transportType").HeaderText = "Type"
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
                        Where transport.transportType = selectedTransport And promotionDate >= promotion.promotionStartDate.Value.Date And promotionDate <= promotion.promotionEndDate.Value.Date
                        Select promotion.promotionID, promotion.promotionName, promotion.promotionStartDate, promotion.promotionEndDate, transport.transportType, promotion.promotionDesc
            dgvPromotionList.DataSource = query
            dgvPromotionList.Columns("promotionID").HeaderText = "ID"
            dgvPromotionList.Columns("promotionName").HeaderText = "Name"
            dgvPromotionList.Columns("promotionStartDate").HeaderText = "Start Date"
            dgvPromotionList.Columns("promotionEndDate").HeaderText = "End Date"
            dgvPromotionList.Columns("transportType").HeaderText = "Type"
            dgvPromotionList.Columns("promotionDesc").HeaderText = "Description"

            lblCount.Text = query.Count.ToString("0 record(s)")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        cboTransport.SelectedIndex = 0
        dpPromotionDate.MinDate = Today.Date
        DataBind()
    End Sub

    Private Sub cboTransport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransport.SelectedIndexChanged
        selectedTransport = cboTransport.SelectedItem.ToString
        DataBind()
    End Sub

    Private Sub dpPromotionDate_ValueChanged(sender As Object, e As EventArgs) Handles dpPromotionDate.ValueChanged
        promotionDate = dpPromotionDate.Value.Date
        DataBind()
    End Sub

    Private Sub txtPromotionID_TextChanged(sender As Object, e As EventArgs) Handles txtPromotionID.TextChanged
        If (txtPromotionID.Text = "") Then
            dpPromotionDate.Enabled = True
            cboTransport.Enabled = True
            DataBind()
        Else
            dpPromotionDate.Enabled = False
            cboTransport.Enabled = False
            contain = txtPromotionID.Text
            dgvPromotionList.Rows.Clear()
            DataBindSearch()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPromotionID.Clear()
        dpPromotionDate.Value = Today.Date
        cboTransport.SelectedIndex = 0
        dpPromotionDate.Enabled = True
        cboTransport.Enabled = True
        DataBind()
    End Sub

    Private Sub btnCreatePromotionPage_Click(sender As Object, e As EventArgs) Handles btnCreatePromotionPage.Click
        ManagerCreatePromotion.Show()
        Me.Hide()
    End Sub

    Private Sub dgvPromotionList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromotionList.CellDoubleClick
        Dim i As Integer = dgvPromotionList.CurrentRow.Index
        id = dgvPromotionList.Item(0, i).Value.ToString
        pname = dgvPromotionList.Item(1, i).Value.ToString
        psdate = dgvPromotionList.Item(2, i).Value.ToString
        pedate = dgvPromotionList.Item(3, i).Value.ToString
        pdesc = dgvPromotionList.Item(5, i).Value.ToString
        ManagerModifyPromotion.Show()
    End Sub
End Class