Public Class TranportSelection
    Public selectedType As String

    Private Sub pbTrain_Click(sender As Object, e As EventArgs) Handles pbTrain.Click
        selectedType = "Train"
        pbTrain.BorderStyle = BorderStyle.Fixed3D
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.FixedSingle
        selectedType = "Train"
        txtTransType.Text = "Train"
    End Sub

    Private Sub pbFerry_Click(sender As Object, e As EventArgs) Handles pbFerry.Click
        selectedType = "Ferry"
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.Fixed3D
        pbBus.BorderStyle = BorderStyle.FixedSingle
        selectedType = "Ferry"
        txtTransType.Text = "Ferry"
    End Sub

    Private Sub pbBus_Click(sender As Object, e As EventArgs) Handles pbBus.Click
        selectedType = "Bus"
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.Fixed3D
        selectedType = "Bus"
        txtTransType.Text = "Bus"
    End Sub
End Class
