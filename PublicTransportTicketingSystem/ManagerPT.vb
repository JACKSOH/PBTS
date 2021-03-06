﻿Public Class ManagerPT

    Private Sub ManagerPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PTTSDataSet.Transport' table. You can move, or remove it, as needed.
        Me.TransportTableAdapter.Fill(Me.PTTSDataSet.Transport)
        dgv.ReadOnly = True
        TransportTableAdapter.FillBy1(PTTSDataSet.Transport, ts.selectedType.ToLower)

        lblRecordFound.Text = dgv.Rows.Count.ToString("0 record(s) found")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New PBTSDataContext
        'lbltest.Text = db.Transports.OrderByDescending(Function(o) o.transportID).Select(Function(i) i.transportID).First().ToString.Substring(2, 6)
        ManagerTranportInsert.newId = App.GenerateNextId(db.Transports.OrderByDescending(Function(o) o.transportID).Select(Function(i) i.transportID).First().ToString)
        ManagerTranportInsert.ShowDialog()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "&Update" Then
            btnUpdate.Text = "&Save"
            btnDeleteCancel.Text = "&Cancel"
            btnAdd.Enabled = False
            dgv.ReadOnly = False
            btnDeleteCancel.Visible = True

        End If
    End Sub
    Private Sub ChangeTransportType() Handles ts.TransportChange

        TransportTableAdapter.FillBy1(PTTSDataSet.Transport, ts.selectedType.ToLower)

    End Sub


    Private Sub btnDeleteCancel_Click(sender As Object, e As EventArgs) Handles btnDeleteCancel.Click
        If btnDeleteCancel.Text = "&Cancel" Then
            btnUpdate.Text = "&Update"
            btnDeleteCancel.Text = "&Delete"
            'update database
            TransportBindingSource.EndEdit()
            TransportTableAdapter.Update(PTTSDataSet.Transport)

            btnAdd.Enabled = True
            dgv.ReadOnly = True
            btnDeleteCancel.Visible = False

        End If

    End Sub


    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        TransportTableAdapter.FillBy2(PTTSDataSet.Transport, "%" + txtSearch.Text + "%", ts.selectedType)
    End Sub




End Class