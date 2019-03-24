Public Class StaffReservation
    Private Sub pbTrain_Click(sender As Object, e As EventArgs) Handles pbTrain.Click
        gbTrain.Text = "Train Ticket"
        pbTrain.BorderStyle = BorderStyle.Fixed3D
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.FixedSingle

    End Sub


    Private Sub pbFerry_Click(sender As Object, e As EventArgs) Handles pbFerry.Click
        gbTrain.Text = "Ferry Ticket"
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.Fixed3D
        pbBus.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pbBus_Click(sender As Object, e As EventArgs) Handles pbBus.Click
        gbTrain.Text = "Bus Ticket"
        pbTrain.BorderStyle = BorderStyle.FixedSingle
        pbFerry.BorderStyle = BorderStyle.FixedSingle
        pbBus.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        End
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click

    End Sub
End Class