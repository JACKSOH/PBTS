Public Class managerScheduleReport
    Dim db As New PBTSDataContext
    Public selectedType As String
    Public selectedMonth As Integer
    Private pttsDS As PTTSDataSet
    Private sTA As PTTSDataSetTableAdapters.ScheduleTableAdapter
    Private tTA As PTTSDataSetTableAdapters.TransportTableAdapter
    Private seTA As PTTSDataSetTableAdapters.SeatTableAdapter
    Private loTA As PTTSDataSetTableAdapters.LocationTableAdapter
    Private lo1TA As PTTSDataSetTableAdapters.Location1TableAdapter
    Private llTA As PTTSDataSetTableAdapters.LocationListTableAdapter

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load


        Dim schReport As New MonthlyTransportTraverllingReport

        pttsDS = New PTTSDataSet
        sTA = New PTTSDataSetTableAdapters.ScheduleTableAdapter
        tTA = New PTTSDataSetTableAdapters.TransportTableAdapter
        seTA = New PTTSDataSetTableAdapters.SeatTableAdapter

        'Fill the dataset
        sTA.FillByMonth(pttsDS.Schedule, CDec(selectedMonth), CDec(2019))
        tTA.FillByType(pttsDS.Transport, selectedType)
        seTA.Fill(pttsDS.Seat)

        'assign to report
        schReport.SetDataSource(pttsDS)

        CrystalReportViewer1.ReportSource = schReport



        Me.CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class