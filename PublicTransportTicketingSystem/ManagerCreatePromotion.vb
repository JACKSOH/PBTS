﻿Public Class ManagerCreatePromotion
    Friend discountRate As Double
    Friend endDate As Date
    Friend promotionName As String
    Friend promotionDesc As String
    Friend startDate As Date
    Dim days As Integer
    Dim customDiscount As Double

    Private Sub radFullDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radFullDiscount.CheckedChanged
        nupCustomDiscount.Enabled = False
        discountRate = 100
    End Sub

    Private Sub radCustomDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radCustomDiscount.CheckedChanged
        nupCustomDiscount.Enabled = True
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (txtPromotionName.Text = "") Then
            ErrorName.Visible = True
        Else
            promotionName = txtPromotionName.Text
            promotionDesc = txtPromotionDesc.Text
            ErrorName.Visible = False
            ManageCreatePromotionPart2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dpPromotionStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dpPromotionStartDate.ValueChanged
        dpPromotionStartDate.MinDate = Date.Today
        startDate = dpPromotionStartDate.Value
    End Sub

    Private Sub nupPromotionDuration_ValueChanged(sender As Object, e As EventArgs) Handles nupPromotionDuration.ValueChanged
        days = Integer.Parse(nupPromotionDuration.Value.ToString)
        endDate = dpPromotionStartDate.Value.Date.AddDays(days)
    End Sub

    Private Sub nupCustomDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nupCustomDiscount.ValueChanged
        customDiscount = Double.Parse(nupCustomDiscount.Value.ToString)
        discountRate = customDiscount
    End Sub
End Class