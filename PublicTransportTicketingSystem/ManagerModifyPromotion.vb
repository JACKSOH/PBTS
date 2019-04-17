Imports System.Data.SqlClient

Public Class ManagerModifyPromotion

    Private con As New SqlConnection
    Private startDate As Date
    Private endDate As Date
    Private discount As Integer
    Private count As Integer

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Shown, MyBase.Load
        Try
            con.ConnectionString = StaffBooking.connection
            con.Open()
            Dim command As New SqlCommand("select * from Promotion where PromotionID = '" & ManagerViewPromotion.id & "'", con)
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader

            If (reader.Read) Then
                lblPromotionID.Text = reader.GetString(0)
                txtPromotionName.Text = reader.GetString(1)
                lblPromotionDate.Text = reader.GetDateTime(2).Date.ToString
                lblPromotionDate.Text += "  -  " & reader.GetDateTime(3).Date.ToString
                txtPromotionDesc.Text = reader.GetString(4)

            End If
            con.Close()
        Catch ex As Exception

        End Try

        lblTransport.Text = ManagerViewPromotion.transportType + "Schedule"
        lstSchedule.Enabled = False

        Try
            Dim db As New PBTSDataContext()

            Dim query = From promoteSchedule In db.promoteSchedules
                        Where promoteSchedule.promotionID = ManagerViewPromotion.id
                        Select promoteSchedule.discountRate
            discount = query.FirstOrDefault.Value

        Catch ex As Exception
            MessageBox.Show("Please check database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If (discount < 100) Then
            radCustomDiscount.Checked = True
            nupCustomDiscount.Value = discount
            nupCustomDiscount.Visible = True
            nupCustomDiscount.Enabled = True
        Else
            nupCustomDiscount.Enabled = False
            radFullDiscount.Checked = True
        End If

        SearchPromotion()
    End Sub

    Public Sub SearchPromotion()
        Try
            con.ConnectionString = StaffBooking.connection
            con.Open()
            Dim command As New SqlCommand("select * from Promotion where promotionID = '" & ManagerViewPromotion.id & "'", con)
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader

            If (reader.Read) Then
                startDate = reader.GetDateTime(2)
                endDate = reader.GetDateTime(3)
            End If
            con.Close()

            con.Open()
            Dim command1 As New SqlCommand("select * from PromoteSchedule where promotionID = '" & ManagerViewPromotion.id & "'", con)
            Dim adapter1 As New SqlDataAdapter(command1)
            Dim reader1 As SqlDataReader
            reader1 = command1.ExecuteReader

            While (reader1.Read)
                lstSchedule.Items.Add(reader1.GetString(2))
                count += 1
            End While
            con.Close()
            lblCount.Text = count.ToString("0 record(s)")

        Catch ex As Exception
            MessageBox.Show("Invalid" & ex.Message)
        End Try

    End Sub

    Public Sub UpdatePromotion()

        If (txtPromotionName.Text <> "") Then

            Dim result As DialogResult = MessageBox.Show("Are you sure want to modify a new promotion?", "Confirmation",
                                                      MessageBoxButtons.YesNoCancel,
                                                      MessageBoxIcon.Question)
            If (result = DialogResult.Yes) Then
                Try
                    con.ConnectionString = StaffBooking.connection
                    con.Open()
                    Dim command As New SqlCommand("UPDATE Promotion Set promotionName = @promotionName, promotionStartDate = @promotionStartDate, promotionEndDate = @promotionEndDate , promotionDesc = @promotionDesc, promotionStatus = @promotionStatus WHERE promotionID = @promotionID", con)
                    command.Parameters.Add(New SqlParameter("promotionID", ManagerViewPromotion.id))
                    command.Parameters.Add(New SqlParameter("promotionName", txtPromotionName.Text))
                    command.Parameters.Add(New SqlParameter("promotionStartDate", startDate))
                    command.Parameters.Add(New SqlParameter("promotionEndDate", endDate))
                    command.Parameters.Add(New SqlParameter("promotionDesc", txtPromotionDesc.Text))
                    command.Parameters.Add(New SqlParameter("promotionStatus", "Active"))
                    command.ExecuteNonQuery()
                    con.Close()

                    con.ConnectionString = StaffBooking.connection
                    con.Open()
                    Dim command1 As New SqlCommand("UPDATE promoteSchedule Set discountRate = @discountRate Where promotionID = @promotionID", con)
                    command1.Parameters.Add(New SqlParameter("discountRate", discount))
                    command1.Parameters.Add(New SqlParameter("promotionID", ManagerViewPromotion.id))
                    command1.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Promotion Details Updated Successfully", "Successful",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information)


                Catch ex As Exception
                    MessageBox.Show("Invalid" & ex.Message)
                Finally

                End Try
            End If
        Else
            lblErrorName.Visible = True
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdatePromotion()
        Me.Close()
        ManagerViewPromotion.Show()
    End Sub

    Private Sub radFullDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radFullDiscount.CheckedChanged
        discount = 100
    End Sub

    Private Sub radCustomDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radCustomDiscount.CheckedChanged
        discount = Integer.Parse(nupCustomDiscount.Value.ToString)
        nupCustomDiscount.Visible = True
        nupCustomDiscount.Enabled = True
    End Sub

    Private Sub nupCustomDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nupCustomDiscount.ValueChanged
        discount = Integer.Parse(nupCustomDiscount.Value.ToString)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        ManagerViewPromotion.Show()
    End Sub
End Class