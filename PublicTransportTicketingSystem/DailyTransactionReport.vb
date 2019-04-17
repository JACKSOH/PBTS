﻿Public Class DailyTransactionReport
    Private pttsDS As PTTSDataSet
    Private tTA As PTTSDataSetTableAdapters.TicketTableAdapter
    Public selectedMonth As Decimal
    Public selectedDay As Decimal

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        pttsDS = New PTTSDataSet
        Dim transReport As New dailyTransactionReport1
        pttsDS = New PTTSDataSet
        tTA = New PTTSDataSetTableAdapters.TicketTableAdapter
        tTA.FillBy(pttsDS.Ticket, CInt(selectedMonth), CDec(selectedDay))
        transReport.SetDataSource(pttsDS)


        CrystalReportViewer1.ReportSource = transReport

        Me.CrystalReportViewer1.RefreshReport()
    End Sub
End Class