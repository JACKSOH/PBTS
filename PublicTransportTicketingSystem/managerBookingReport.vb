Public Class managerBookingReport
    Dim db As New PBTSDataContext
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim getAllBookingQuery = From booking In db.Bookings
                                     Select booking

            Dim bookingReport As New bookingReport
            bookingReport.SetDataSource(getAllBookingQuery)
            CrystalReportViewer1.ReportSource = bookingReport
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class