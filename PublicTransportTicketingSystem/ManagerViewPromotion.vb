Imports System.Data.SqlClient

Public Class ManagerViewPromotion
    Private con As New SqlConnection
    Friend selectedTransport As String
    Private promotionDate As Date = Today.Date
    Private contain As String
    Friend id As String
    Friend pname As String
    Friend psdate As String
    Friend pedate As String
    Friend pdesc As String
    Friend status As String
    Friend discount As Integer
    Private activeStatus As String = "Active"
    Private deactiveStatus As String = "Deactive"


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
                        Where promotion.promotionStatus = activeStatus And (transport.transportType = selectedTransport And promotionDate >= promotion.promotionStartDate.Value.Date And promotionDate <= promotion.promotionEndDate.Value.Date)
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
        discount = Integer.Parse(dgvPromotionList.Item(6, i).Value.ToString)
        ManagerModifyPromotion.Show()
    End Sub

    Private Sub dgvPromotionList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromotionList.CellClick
        Dim i As Integer = dgvPromotionList.CurrentRow.Index
        id = dgvPromotionList.Item(0, i).Value.ToString
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Try
            If (dgvPromotionList.CurrentRow.Index >= 0) Then
                Dim result As DialogResult = MessageBox.Show("Are you sure want to modify a new promotion?", "Confirmation",
                                                      MessageBoxButtons.YesNoCancel,
                                                      MessageBoxIcon.Question)
                If (result = DialogResult.Yes) Then
                    Try
                        con.ConnectionString = StaffBooking.connection
                        con.Open()
                        Dim command As New SqlCommand("UPDATE Promotion Set promotionStatus = @promotionStatus WHERE promotionID = @promotionID", con)
                        command.Parameters.Add(New SqlParameter("promotionID", id))
                        command.Parameters.Add(New SqlParameter("promotionStatus", "Deactive"))
                        command.ExecuteNonQuery()
                        con.Close()
                        DataBindSearch()
                    Catch ex As Exception

                    End Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("No Row Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        dgvPromotionList_CellDoubleClick(Nothing, Nothing)
    End Sub
End Class