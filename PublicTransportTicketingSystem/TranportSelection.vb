Public Class TranportSelection
    Private Sub pbTrain_Click(sender As Object, e As EventArgs) Handles pbTrain.Click
        pbTrain.BorderStyle = BorderStyle.Fixed3D
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pbFerry_Click(sender As Object, e As EventArgs) Handles pbFerry.Click
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.Fixed3D
        pbBus.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pbBus_Click(sender As Object, e As EventArgs) Handles pbBus.Click
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.Fixed3D
    End Sub
End Class
