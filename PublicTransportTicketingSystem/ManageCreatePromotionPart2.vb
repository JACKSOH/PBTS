Imports System.Data.SqlClient

Public Class ManageCreatePromotionPart2

    Dim SqlConnection As New SqlConnection
    Private selectedTransport As String
    Private startDate As Date = ManagerCreatePromotion.startDate.Date
    Private EndDate As Date = ManagerCreatePromotion.endDate.Date
    Private count As Integer
    Private status As String = "Pending"

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        lblPromotionName.Text = ManagerCreatePromotion.promotionName
        lblPromotionStart.Text = ManagerCreatePromotion.startDate.Date.ToString("dd/MM/yyyy")
        lblEndDate.Text = ManagerCreatePromotion.endDate.Date.ToString("dd/MM/yyyy")

        If (ManagerCreatePromotion.discountRate = 100) Then
            lblDiscountRate.Text = "Free Ride / Board "
        Else
            lblDiscountRate.Text = (ManagerCreatePromotion.discountRate).ToString + "% discount "
        End If

        DataBind(selectedTransport)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        ManagerCreatePromotion.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ManagerViewPromotion.Show()
        Me.Hide()
    End Sub

    Private Sub cboTransport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransport.SelectedIndexChanged
        selectedTransport = cboTransport.SelectedItem.ToString.ToLower
        DataBind(selectedTransport)
    End Sub

    Private Sub DataBind(t As String)
        Try
            Dim db As New PBTSDataContext()
            Dim query = From transport In db.Transports
                        Join schedule In db.Schedules On transport.transportID Equals (schedule.transportID)
                        Where schedule.departureDateTime.Value.Date >= ManagerCreatePromotion.startDate And
                        schedule.departureDateTime.Value.Date <= ManagerCreatePromotion.endDate And
                        transport.transportType = selectedTransport And
                        schedule.assignPromotionStatus = status
                        Select schedule.scheduleID, schedule.departureDateTime, transport.transportID, transport.transportType
            dgvSchedule.DataSource = query
            dgvSchedule.Columns("scheduleID").HeaderText = "Schedule"
            dgvSchedule.Columns("departureDateTime").HeaderText = "Date"
            dgvSchedule.Columns("transportID").HeaderText = "Transport"
            dgvSchedule.Columns("transportType").HeaderText = "Type"
            lblCount.Text = query.Count.ToString("0 record(s)")
            count = query.Count - 1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddPromotion.Click

        Try
            dgvSchedule.Rows(0).Cells(0).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("There is no schedule records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim result As DialogResult = MessageBox.Show("Are you sure want to create a new promotion?", "Confirmation",
                                                      MessageBoxButtons.YesNoCancel,
                                                      MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand

            Try
                con.ConnectionString = StaffBooking.connection
                con.Open()
                cmd.Connection = con
                Dim promotionID As String = App.GetNextPromotionId

                cmd = New SqlCommand("insert into promotion ([promotionID],[promotionName], [promotionStartDate], [promotionEndDate], [promotionDesc], [promotionStatus]) values (@promotionID, @promotionName, @promotionStartDate, @promotionEndDate, @promotionDesc, @promotionStatus)", con)
                cmd.Parameters.Add(New SqlParameter("promotionID", promotionID))
                cmd.Parameters.Add(New SqlParameter("promotionName", ManagerCreatePromotion.promotionName))
                cmd.Parameters.Add(New SqlParameter("promotionStartDate", ManagerCreatePromotion.startDate))
                cmd.Parameters.Add(New SqlParameter("promotionEndDate", ManagerCreatePromotion.endDate))
                cmd.Parameters.Add(New SqlParameter("promotionDesc", ManagerCreatePromotion.promotionDesc))
                cmd.Parameters.Add(New SqlParameter("promotionStatus", "Active"))

                cmd.ExecuteNonQuery()

                For value As Integer = 0 To count
                    cmd2 = New SqlCommand("insert into promoteSchedule ([promoteScheduleID],[promotionID],[scheduleID], [discountRate]) values (@promoteScheduleID, @promotionID, @scheduleID, @discountRate)", con)
                    cmd2.Parameters.Add(New SqlParameter("promoteScheduleID", App.GetNextPromoteScheduleId))
                    cmd2.Parameters.Add(New SqlParameter("promotionID", promotionID))
                    cmd2.Parameters.Add(New SqlParameter("scheduleID", dgvSchedule.Rows(value).Cells(0).Value.ToString))
                    cmd2.Parameters.Add(New SqlParameter("discountRate", ManagerCreatePromotion.discountRate))

                    cmd2.ExecuteNonQuery()
                Next

                For value As Integer = 0 To count
                    status = "Assigned"
                    cmd3 = New SqlCommand("UPDATE Schedule Set assignPromotionStatus = @assignPromotionStatus Where scheduleID = @scheduleID", con)
                    cmd3.Parameters.Add(New SqlParameter("assignPromotionStatus", status))
                    cmd3.Parameters.Add(New SqlParameter("scheduleID", dgvSchedule.Rows(value).Cells(0).Value.ToString))

                    cmd3.ExecuteNonQuery()
                Next

                MessageBox.Show("Created Successfully")

            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)
            Finally
                con.Close()
                ManagerViewPromotion.Show()
            End Try
        End If
    End Sub
End Class