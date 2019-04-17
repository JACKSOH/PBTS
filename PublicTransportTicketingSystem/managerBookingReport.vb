Public Class managerBookingReport
    Dim db As New PBTSDataContext
    Private pttsDS As PTTSDataSet
    Private bta As PTTSDataSetTableAdapters.BookingTableAdapter
    Private sta As PTTSDataSetTableAdapters.ScheduleTableAdapter
    Private tta As PTTSDataSetTableAdapters.TicketTableAdapter
    Private trta As PTTSDataSetTableAdapters.TransportTableAdapter
    Private seta As PTTSDataSetTableAdapters.SeatTableAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bindData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        managerReport.Show()
        Me.Hide()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
    Private Sub bindData()
        Dim bookingRep As New bookingReport

        pttsDS = New PTTSDataSet
        bta = New PTTSDataSetTableAdapters.BookingTableAdapter
        sta = New PTTSDataSetTableAdapters.ScheduleTableAdapter
        tta = New PTTSDataSetTableAdapters.TicketTableAdapter
        trta = New PTTSDataSetTableAdapters.TransportTableAdapter
        seta = New PTTSDataSetTableAdapters.SeatTableAdapter
        'Fill the dataset
        'bta.FillByDate(pttsDS.Booking, dpDate.Value.Date)
        bta.Fill(pttsDS.Booking)
        sta.Fill(pttsDS.Schedule)
        tta.Fill(pttsDS.Ticket)
        trta.Fill(pttsDS.Transport)
        seta.Fill(pttsDS.Seat)

        'assign to report
        bookingRep.SetDataSource(pttsDS)

        CrystalReportViewer1.ReportSource = bookingRep



        Me.CrystalReportViewer1.RefreshReport()
    End Sub
End Class