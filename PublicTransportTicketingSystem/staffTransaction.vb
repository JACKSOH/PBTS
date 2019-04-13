Public Class staffTransaction
    Private Sub staffTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PTTSDataSet.Ticket' table. You can move, or remove it, as needed.
        Me.TicketTableAdapter.Fill(Me.PTTSDataSet.Ticket)
        'TODO: This line of code loads data into the 'PTTSDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.PTTSDataSet.Booking)

    End Sub

    Private Sub StaffMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles StaffMenuLayoutControl1.Load
        Dim ptts As New PTTSDataSet
        TicketTableAdapter.FillBy(ptts.Ticket)
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TicketTableAdapter.FillBy(Me.PTTSDataSet.Ticket)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.TicketTableAdapter.FillBy(Me.PTTSDataSet.Ticket)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class