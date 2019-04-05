Public Class ManagerCreatePT
    Private Sub pbTrain_Click(sender As Object, e As EventArgs) Handles pbTrain.Click
        gbBus.Text = "Create New Train"
        pbTrain.BorderStyle = BorderStyle.Fixed3D
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.FixedSingle

    End Sub


    Private Sub pbFerry_Click(sender As Object, e As EventArgs) Handles pbFerry.Click
        gbBus.Text = "Create New Ferry"
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.Fixed3D
        pbBus.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pbBus_Click(sender As Object, e As EventArgs) Handles pbBus.Click
        gbBus.Text = "Create New Bus"
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.Fixed3D
    End Sub
End Class