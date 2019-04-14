Public Class PaymentPrintTicket

    Dim memoryImage As Bitmap

    Private Sub lblPrice_Click(sender As Object, e As EventArgs) Handles lblPrice.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaymentPrintTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaptureScreen()
        Me.PrintDocument1.Print()
        Me.Close()
    End Sub


    Private Sub CaptureScreen()
        'Dim myGraphics As Graphics = Me.CreateGraphics()
        'Dim s As Size = Me.Size
        'Dim memoryImage As Bitmap = New Bitmap(s.Width, s.Height, myGraphics)
        'Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        'memoryGraphics.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, s)

        memoryImage = New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(memoryImage, New Rectangle(0, 0, Me.Width, Me.Height))
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub
End Class