Public Class managerBookingReport
    Dim db As New PBTSDataContext
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim getAllBookingQuery = From booking In db.Bookings
                                     Join ticket In db.Tickets On booking.bookingID Equals ticket.bookingID
                                     Where ticket.purchaseDateTime.Value.Date = dpDate.Value.Date
                                     Select booking

            Dim bookingReport As New bookingReport
            bookingReport.SetDataSource(getAllBookingQuery)

            CrystalReportViewer1.ReportSource = bookingReport
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        managerReport.Show()
        Me.Hide()
    End Sub
End Class