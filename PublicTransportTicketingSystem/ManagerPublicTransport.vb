Public Class ManagerPublicTransport
    Private Sub pbTrain_Click(sender As Object, e As EventArgs) Handles pbTrain.Click
        gbBus.Text = "Train"
        pbTrain.BorderStyle = BorderStyle.Fixed3D
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.FixedSingle

    End Sub


    Private Sub pbFerry_Click(sender As Object, e As EventArgs) Handles pbFerry.Click
        gbBus.Text = "Ferry"
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.Fixed3D
        pbBus.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pbBus_Click(sender As Object, e As EventArgs) Handles pbBus.Click
        gbBus.Text = "Bus"
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub gbBus_Enter(sender As Object, e As EventArgs) Handles gbBus.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ManagerCreatePT.Show()
        Me.Close()
    End Sub
End Class