Public Class TranportSelection
    Public selectedType As String = "Train"

    Private Sub pbTrain_Click(sender As Object, e As EventArgs) Handles pbTrain.Click

        pbTrain.BorderStyle = BorderStyle.Fixed3D
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.FixedSingle


        selectedType = "Train"
        txtTransType.Text = "Train"

    End Sub

    Private Sub pbFerry_Click(sender As Object, e As EventArgs) Handles pbFerry.Click

        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.Fixed3D
        pbBus.BorderStyle = BorderStyle.FixedSingle
        selectedType = "Ferry"
        txtTransType.Text = "Ferry"

    End Sub

    Private Sub pbBus_Click(sender As Object, e As EventArgs) Handles pbBus.Click

        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.Fixed3D
        selectedType = "Bus"
        txtTransType.Text = "Bus"

    End Sub
    ' create even to to raise the transport change 
    Public Event TransportChange(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub txtTransType_TextChanged(sender As Object, e As EventArgs) Handles txtTransType.TextChanged
        RaiseEvent TransportChange(sender, e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblBusPromotion.ForeColor = Color.Red

    End Sub
End Class
