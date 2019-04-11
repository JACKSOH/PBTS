Public Class ManagerCreatePromotion
    Friend discountRate As Double
    Friend endDate As Date

    Private Sub radFullDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radFullDiscount.CheckedChanged
        nupCustomDiscount.Enabled = False
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        If (radFullDiscount.Checked = True) Then
            discountRate = 1
        ElseIf (radCustomDiscount.Checked = True) Then
            discountRate = Double.Parse(nupCustomDiscount.Value.ToString) / 100
        End If

        endDate = dpPromotionStartDate.Value.AddDays(Integer.Parse(nupPromotionDuration.Value.ToString))
    End Sub

    Private Sub radCustomDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles radCustomDiscount.CheckedChanged
        nupCustomDiscount.Enabled = True
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (txtPromotionName.Text = "") Then
            ErrorName.Visible = True
        Else
            ErrorName.Visible = False
            ManageCreatePromotionPart2.Show()
            Me.Hide()
        End If
    End Sub
End Class