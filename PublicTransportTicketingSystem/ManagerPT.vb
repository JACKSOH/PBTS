Public Class ManagerPT

    Private Sub ManagerPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PTTSDataSet.Transport' table. You can move, or remove it, as needed.
        Me.TransportTableAdapter.Fill(Me.PTTSDataSet.Transport)


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New PBTSDataContext
        'lbltest.Text = db.Transports.OrderByDescending(Function(o) o.transportID).Select(Function(i) i.transportID).First().ToString.Substring(2, 6)
        ManagerTranportInsert.newId = App.GenerateNextId(db.Transports.OrderByDescending(Function(o) o.transportID).Select(Function(i) i.transportID).First().ToString)
        ManagerTranportInsert.ShowDialog()
    End Sub
    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.ReadOnly = True
    End Sub
    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "&Update" Then
            btnUpdate.Text = "&Save"
            btnDeleteCancel.Text = "&Cancel"
            btnAdd.Enabled = False
            dgv.ReadOnly = False

        Else
            btnUpdate.Text = "&Update"
            btnDeleteCancel.Text = "&Delete"
            'update database
            TransportBindingSource.EndEdit()
            TransportTableAdapter.Update(PTTSDataSet.Transport)

            btnAdd.Enabled = True
            dgv.ReadOnly = True
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class