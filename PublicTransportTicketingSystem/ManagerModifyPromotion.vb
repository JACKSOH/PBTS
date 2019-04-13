Imports System.Data.SqlClient

Public Class ManagerModifyPromotion
    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        lblPromotionID.Text = ManagerViewPromotion.id
        DataBind()
    End Sub

    Public Sub DataBind()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand

        Try
            con.ConnectionString = StaffBooking.connection
            con.Open()
            cmd.Connection = con
            Dim promotionID As String = App.GetNextPromotionId

            cmd = New SqlCommand("select promotionID, promotionName, promotionStartDate, promotionEndDate, promotionDesc from promotion where promotionID = @promotionID", con)
            cmd.Parameters.Add(New SqlParameter("promotionID", promotionID))

            Dim adapter As New SqlDataAdapter(cmd)
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader

            lblPromotionName.Text = reader.GetString(1)
            lblPromotionDate.Text = reader.GetString(2).ToString + "To " + reader.GetString(3).ToString
            txtPromotionDesc.Text = reader.GetString(4)


            'cmd.ExecuteNonQuery()
            'MessageBox.Show("Created Successfully")

            'For value As Integer = 0 To count
            '    cmd2 = New SqlCommand("insert into promoteSchedule ([promoteScheduleID],[promotionID],[scheduleID], [discountRate]) values (@promoteScheduleID, @promotionID, @scheduleID, @discountRate)", con)
            '    cmd2.Parameters.Add(New SqlParameter("promoteScheduleID", App.GetNextPromoteScheduleId))
            '    cmd2.Parameters.Add(New SqlParameter("promotionID", promotionID))
            '    cmd2.Parameters.Add(New SqlParameter("scheduleID", dgvSchedule.Rows(value).Cells(0).Value.ToString))
            '    cmd2.Parameters.Add(New SqlParameter("discountRate", ManagerCreatePromotion.discountRate))

            '    cmd2.ExecuteNonQuery()
            'Next

        Catch ex As Exception
            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
            Me.Close()
        End Try

    End Sub
End Class