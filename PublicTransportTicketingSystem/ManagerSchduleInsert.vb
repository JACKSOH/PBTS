Public Class ManagerSchduleInsert
    Public newId As String
    Public selectedType As String = ManagerManageSchedule.TranportSelection1.selectedType


    Public Sub BindcboTranport()
        TransportTableAdapter.FillBy1(PTTSDataSet.Transport, cboType.Text)
    End Sub
    Public Sub BindcboDestinationOrigin()

        Me.LocationTableAdapter.FillBy2(PTTSDataSet.Location, cboType.Text)
        Me.LocationTableAdapter.FillBy3(PTTSDataSet.Location, cboType.Text)
    End Sub

    Private Sub ManagerSchduleInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboType.SelectedIndex = 0
        BindcboTranport()
        BindcboDestinationOrigin()
        'only allow to choose time
        dtpTime.ShowUpDown = True
        dtpTime.MinDate = DateTime.Today
        dtpDate.MaxDate = DateTime.Today.AddMonths(1)
        dtpDate.MinDate = DateTime.Today
        lblNewId.Text = App.GenerateNextId("")
        'refresh the table index
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboDestination_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboDestination.Validating
        If cboDestination.Text = cboOrigin.Text Then
            err.SetError(cboDestination, "Origin and destionation could not be same!!")
            e.Cancel = True
        Else
            err.SetError(cboDestination, Nothing)

        End If
    End Sub

    Private Sub cboOrigin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboOrigin.Validating
        If cboDestination.Text = cboOrigin.Text Then
            err.SetError(cboOrigin, "Origin and destionation could not be same!!")
            e.Cancel = True
        Else
            err.SetError(cboOrigin, Nothing)

        End If
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        BindcboDestinationOrigin()
        BindcboTranport()

    End Sub
End Class