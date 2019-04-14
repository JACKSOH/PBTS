Imports System.Data.SqlClient

Public Class StaffViewPromotionPart2
    Private con As New SqlConnection

    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.Load
        lblPromotionID.Text = StaffViewPromotion.id
        lblPromotionName.Text = StaffViewPromotion.pname
        lblPromotionDate.Text = StaffViewPromotion.psdate.Substring(0, 9)
        lblPromotionDate.Text += "  -  " & StaffViewPromotion.pedate.Substring(0, 9)
        lblPromotionDesc.Text = StaffViewPromotion.pdesc
        lblDiscount.Text = StaffViewPromotion.discount.ToString + "%"
        lblTransport.Text = StaffViewPromotion.transportType
        DataBind()

    End Sub

    Private Sub DataBind()
        Try
            Dim db As New PBTSDataContext()

            Dim query = From promoteSchedule In db.promoteSchedules
                        Join schedule In db.Schedules On schedule.scheduleID Equals (promoteSchedule.scheduleID)
                        Where promoteSchedule.promotionID = StaffViewPromotion.id
                        Select schedule.scheduleID, schedule.departureDateTime, schedule.arrivalDateTIme, schedule.transportID
            dgvPromotionList.DataSource = query
            dgvPromotionList.Columns("scheduleID").HeaderText = "ID"
            dgvPromotionList.Columns("departureDateTime").HeaderText = "Departure Time"
            dgvPromotionList.Columns("arrivalDateTIme").HeaderText = "Arrival Time"
            dgvPromotionList.Columns("transportID").HeaderText = "Transport"

            lblCount.Text = query.Count.ToString("0 record(s)")

        Catch ex As Exception
            MessageBox.Show("Please check database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class