Public Class ManagerCreatePromotion
    Friend discountRate As Integer
    Friend endDate As Date
    Friend promotionName As String
    Friend promotionDesc As String
    Friend startDate As Date
    Dim days As Integer
    Dim customDiscount As Integer = 1
    Dim count As Integer

    Private Sub radFullDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radFullDiscount.CheckedChanged
        nupCustomDiscount.Enabled = False
        discountRate = 100
    End Sub

    Private Sub radCustomDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radCustomDiscount.CheckedChanged
        nupCustomDiscount.Enabled = True
        discountRate = customDiscount
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If (txtPromotionName.Text = "") Then
            ErrorName.Visible = True
        Else
            If (radCustomDiscount.Checked) Then
                radCustomDiscount_CheckedChanged(Nothing, Nothing)
                nupCustomDiscount_ValueChanged(Nothing, Nothing)
            End If

            dpPromotionStartDate_ValueChanged(Nothing, Nothing)
            nupPromotionDuration_ValueChanged(Nothing, Nothing)
                promotionName = txtPromotionName.Text
                promotionDesc = txtPromotionDesc.Text
                ErrorName.Visible = False
                endDate = startDate
            endDate = endDate.AddDays(days)

            If (DataBind(startDate, endDate) = False) Then
                MessageBox.Show("There is no schedule records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ManageCreatePromotionPart2.Show()
            txtPromotionName.Clear()
            txtPromotionDesc.Clear()
            dpPromotionStartDate.Value = Date.Today
            dpPromotionStartDate.MinDate = Date.Today
            startDate = dpPromotionStartDate.Value
            nupCustomDiscount.Value = 1
            radFullDiscount.Checked = True
            nupPromotionDuration.Value = 1
            Me.Hide()
            End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ManagerViewPromotion.Show()
        Me.Hide()
    End Sub

    Private Sub dpPromotionStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dpPromotionStartDate.ValueChanged, dpPromotionStartDate.GotFocus
        startDate = dpPromotionStartDate.Value
    End Sub

    Private Sub nupPromotionDuration_ValueChanged(sender As Object, e As EventArgs) Handles nupPromotionDuration.ValueChanged
        days = Integer.Parse(nupPromotionDuration.Value.ToString)
    End Sub

    Private Sub nupCustomDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nupCustomDiscount.ValueChanged
        customDiscount = Integer.Parse(nupCustomDiscount.Value.ToString)
        discountRate = customDiscount
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        txtPromotionName.Clear()
        txtPromotionDesc.Clear()
        dpPromotionStartDate.MinDate = Date.Today
        startDate = dpPromotionStartDate.Value
        nupCustomDiscount.Value = 1
        radFullDiscount.Checked = True
        nupPromotionDuration.Value = 1

    End Sub

    Private Function DataBind(start As Date, endD As Date) As Boolean
        Dim result As Boolean = False
        Try
            Dim db As New PBTSDataContext()
            Dim query = From transport In db.Transports
                        Join schedule In db.Schedules On transport.transportID Equals (schedule.transportID)
                        Where schedule.departureDateTime.Value.Date >= start And
                        schedule.departureDateTime.Value.Date <= endD And
                        schedule.assignPromotionStatus = "pending"
            count = query.Count

            If (count > 0) Then
                result = True
            End If

        Catch ex As Exception

        End Try
        Return result
    End Function
End Class