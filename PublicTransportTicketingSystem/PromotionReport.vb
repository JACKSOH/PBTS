Public Class PromotionReport
    Dim db As New PBTSDataContext
    Dim month As Integer = Today.Month
    Dim year As Integer = Today.Year
    'Dim transport As String = managerReport.transportSelected
    Dim transport As String = "bus"
    Private pTA As PTTSDataSetTableAdapters.PromotionTableAdapter
    Private sTA As PTTSDataSetTableAdapters.ScheduleTableAdapter
    Private psTA As PTTSDataSetTableAdapters.promoteScheduleTableAdapter
    Private tTA As PTTSDataSetTableAdapters.TransportTableAdapter
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub btnShowReport_Click(sender As Object, e As EventArgs) Handles btnShowReport.Click
        Dim promoReport As New MonthlyPromotionReport
        Dim pttsDS As New PTTSDataSet
        pTA = New PTTSDataSetTableAdapters.PromotionTableAdapter
        sTA = New PTTSDataSetTableAdapters.ScheduleTableAdapter
        psTA = New PTTSDataSetTableAdapters.promoteScheduleTableAdapter
        tTA = New PTTSDataSetTableAdapters.TransportTableAdapter

        pTA.Fill(pttsDS.Promotion)
        sTA.Fill(pttsDS.Schedule)
        ' sTA.FillBy1(pttsDS.Schedule, year)
        psTA.Fill(pttsDS.promoteSchedule)
        tTA.FillBy3(pttsDS.Transport, transport)

        promoReport.SetDataSource(pttsDS)

        CrystalReportViewer1.ReportSource = promoReport
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class