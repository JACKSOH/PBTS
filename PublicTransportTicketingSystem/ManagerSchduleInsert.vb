Public Class ManagerSchduleInsert
    Public newId As String
    Public selectedType As String = ManagerManageSchedule.TranportSelection1.selectedType
    Public selectedIndex As Integer

    Private Sub ManagerSchduleInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PTTSDataSet.Location' table. You can move, or remove it, as needed.
        'Me.LocationTableAdapter.Fill(Me.PTTSDataSet.Location)
        Me.LocationTableAdapter.FillBy2(PTTSDataSet.Location, selectedType)
        'To avoid the exception
        selectedIndex += 1
        '  cboOrigin.SelectedIndex = 1
        Me.LocationTableAdapter.FillBy3(PTTSDataSet.Location, selectedType)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDeparture.ValueChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub cboOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigin.SelectedIndexChanged







    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.LocationTableAdapter.Fill(Me.PTTSDataSet.Location)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillToolStripButton1.Click
        Try
            Me.LocationTableAdapter.Fill(Me.PTTSDataSet.Location)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ManagerSchduleInsert_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        test.Text += "a"
    End Sub
End Class