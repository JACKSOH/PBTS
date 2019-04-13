Imports System.Data.SqlClient

Public Class ManagerModifyPromotion
    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        lblPromotionID.Text = ManagerViewPromotion.id
        lblPromotionName.Text = ManagerViewPromotion.pname
        lblPromotionDate.Text = ManagerViewPromotion.psdate.Substring(0, 9)
        lblPromotionDate.Text += "  -  " & ManagerViewPromotion.pedate.Substring(0, 9)
        txtPromotionDesc.Text = ManagerViewPromotion.pdesc
    End Sub

    Public Sub DataBind()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            Dim db As New PBTSDataContext()

            'Dim query = From transport In db.Transports
            '            Join schedule In db.Schedules On transport.transportID Equals (schedule.transportID)
            '            Where schedule.departureDateTime.Value.Date >= ManagerCreatePromotion.startDate And schedule.departureDateTime.Value.Date <= ManagerCreatePromotion.endDate And transport.transportType = selectedTransport
            '            Select schedule.scheduleID, schedule.departureDateTime, transport.transportID, transport.transportType
            'dgvSchedule.DataSource = query
            'dgvSchedule.Columns("scheduleID").HeaderText = "Schedule"
            'dgvSchedule.Columns("departureDateTime").HeaderText = "Date"
            'dgvSchedule.Columns("transportID").HeaderText = "Transport"
            'dgvSchedule.Columns("transportType").HeaderText = "Type"
            'lblCount.Text = query.Count.ToString("0 record(s)")

            'count = query.Count - 1

        Catch ex As Exception
            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
            Me.Close()
        End Try

    End Sub
End Class