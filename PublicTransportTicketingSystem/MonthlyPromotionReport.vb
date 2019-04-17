Public Class MonthlyPromotionReport
    Dim db As New PBTSDataContext
    Public selectedType As String
    Public selectedMonth As Integer
    Private pttsDS As PTTSDataSet
    Private sTA As PTTSDataSetTableAdapters.ScheduleTableAdapter
    Private tTA As PTTSDataSetTableAdapters.TransportTableAdapter
    Private pTA As PTTSDataSetTableAdapters.PromotionTableAdapter
    Private psTA As PTTSDataSetTableAdapters.promoteScheduleTableAdapter
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim promoReport As New MonthlyPromoReport

        pttsDS = New PTTSDataSet
        sTA = New PTTSDataSetTableAdapters.ScheduleTableAdapter
        tTA = New PTTSDataSetTableAdapters.TransportTableAdapter
        pTA = New PTTSDataSetTableAdapters.PromotionTableAdapter
        psTA = New PTTSDataSetTableAdapters.promoteScheduleTableAdapter


        sTA.FillByMonth(pttsDS.Schedule, CDec(selectedMonth), CDec(2019))
        tTA.Fill(pttsDS.Transport)
        psTA.Fill(pttsDS.promoteSchedule)
        pTA.Fill(pttsDS.Promotion)

        promoReport.SetDataSource(pttsDS)

        CrystalReportViewer1.ReportSource = promoReport
        Me.CrystalReportViewer1.RefreshReport()

    End Sub
End Class