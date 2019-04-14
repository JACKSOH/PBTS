Imports System.Data.SqlClient

Public Class ManagerModifyPromotion

    Private con As New SqlConnection
    Private startDate As Date
    Private endDate As Date

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        lblPromotionID.Text = ManagerViewPromotion.id
        txtPromotionName.Text = ManagerViewPromotion.pname
        lblPromotionDate.Text = ManagerViewPromotion.psdate.Substring(0, 9)
        lblPromotionDate.Text += "  -  " & ManagerViewPromotion.pedate.Substring(0, 9)
        txtPromotionDesc.Text = ManagerViewPromotion.pdesc

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
            End While
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Invalid" & ex.Message)
        End Try

    End Sub

    Public Sub UpdatePromotion()


        If (txtPromotionName.Text <> "") Then

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

            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)
            Finally
                End
            End Try

        Else
            lblErrorName.Visible = True
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdatePromotion()
    End Sub
End Class