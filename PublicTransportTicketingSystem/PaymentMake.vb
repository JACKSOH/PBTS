Public Class PaymentMake
    Private Sub PaymentMake_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGenerateTicket_Click(sender As Object, e As EventArgs) Handles btnGenerateTicket.Click
        Dim printTicket As PaymentPrintTicket
        printTicket = New PaymentPrintTicket()
        printTicket.Show()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class