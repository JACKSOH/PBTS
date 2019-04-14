Public Class ManagerCreatePromotion
    Friend discountRate As Integer
    Friend endDate As Date
    Friend promotionName As String
    Friend promotionDesc As String
    Friend startDate As Date
    Dim days As Integer
    Dim customDiscount As Integer = 1

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
            promotionName = txtPromotionName.Text
            promotionDesc = txtPromotionDesc.Text
            ErrorName.Visible = False
            endDate = startDate
            endDate = endDate.AddDays(days)
            ManageCreatePromotionPart2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        ManagerViewPromotion.Show()
    End Sub

    Private Sub dpPromotionStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dpPromotionStartDate.ValueChanged
        dpPromotionStartDate.MinDate = Date.Today
        startDate = dpPromotionStartDate.Value
    End Sub

    Private Sub nupPromotionDuration_ValueChanged(sender As Object, e As EventArgs) Handles nupPromotionDuration.ValueChanged
        days = Integer.Parse(nupPromotionDuration.Value.ToString)
    End Sub

    Private Sub nupCustomDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nupCustomDiscount.ValueChanged
        customDiscount = Integer.Parse(nupCustomDiscount.Value.ToString)
        discountRate = customDiscount
    End Sub
End Class