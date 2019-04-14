Public Class PaymentPrintTicket
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)

        Me.PrintDocument1.Print()
        Me.Close()

    End Sub

    Private Sub lblPrice_Click(sender As Object, e As EventArgs) Handles lblPrice.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaymentPrintTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PrintDocument1.Print()
        Me.Close()
    End Sub
End Class