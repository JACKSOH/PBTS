﻿Public Class ManagerManageLocation

    Dim locationType1 As String
    Dim originalName As String
    Private Sub BindData()
        Dim db As New PBTSDataContext
        dgv.DataSource = db.Locations
        lblRecord.Text = dgv.Rows.Count.ToString("0 of Records found")
    End Sub
    Private Function IsDuplicatedLocation(location As String) As Boolean
        Dim db As New PBTSDataContext
        Dim r = db.Locations.Where(Function(o) o.locationType = ts.selectedType.ToLower And o.locationName = location).SingleOrDefault
        If r Is Nothing Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If btnUpdate.Text = "&Update" Then
            btnUpdate.Text = "&Save"
            btnDeleteCancel.Text = "&Cancel"
            btnAdd.Enabled = False
            dgv.ReadOnly = False
            dgv.Columns(0).ReadOnly = True ' dont allow id to modify
            dgv.Columns(2).ReadOnly = True
        Else
            ' check whether duplicated location insertd
            Dim locationName = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(1).Value.ToString
            'make sure the locatio name validate when the value is change
            If originalName <> locationName Then
                If IsDuplicatedLocation(locationName) = False Then

                    'Validate the type 
                    btnUpdate.Text = "&Update"


                    ' Update database
                    LocationBindingSource.EndEdit()
                    LocationTableAdapter1.Update(PTTSDataSet.Location)
                    btnAdd.Enabled = True
                    dgv.ReadOnly = True


                Else
                    MessageBox.Show("Duplicated Name found!" & vbNewLine & "Please make sure the name not same with others.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If


        End If
    End Sub

    Private Sub btnDeleteCancel_Click(sender As Object, e As EventArgs) Handles btnDeleteCancel.Click
        If btnDeleteCancel.Text = "&Delete" Then
            Dim db As New PBTSDataContext
            Dim yesno = MessageBox.Show("Do you really want to delete this records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If yesno = DialogResult.Yes Then

                Dim query = db.LocationLists.Any(Function(o) o.locationID = dgv.CurrentRow.Cells(0).Value.ToString)
                Try

                    If query = True Then
                        MessageBox.Show("Location is in used in other schedule , cannot be deleted!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        LocationBindingSource.EndEdit()
                        LocationBindingSource.RemoveCurrent()
                        LocationTableAdapter1.Update(PTTSDataSet.Location)
                    End If
                    'delete record and update database

                Catch ex As Exception

                End Try

            End If


        Else
            btnUpdate.Text = "&Update"
            btnDeleteCancel.Text = "&Delete"
            btnAdd.Enabled = False
            dgv.ReadOnly = True

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New PBTSDataContext
        ManagerLocationInsert.newId = App.GenerateNextId(db.Locations.OrderByDescending(Function(o) o.locationID).Select(Function(i) i.locationID).First().ToString)
        ManagerLocationInsert.ShowDialog()

    End Sub

    Private Sub ChangeTransportType() Handles ts.TransportChange
        LocationTableAdapter1.FillBy2(PTTSDataSet.Location, ts.selectedType.ToLower)
        lblRecord.Text = dgv.Rows.Count.ToString("0 of Records found")
    End Sub


    Friend Sub dgv_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgv.CellValidating
        If dgv.CurrentCell.ColumnIndex = 2 And dgv.ReadOnly = False Then

            Dim locationType As String = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(2).Value.ToString
            Try
                If locationType1.ToLower = "bus" Or locationType1.ToLower = "ferry" Or locationType1.ToLower = "train" Then
                    err.SetError(dgv, Nothing)
                Else
                    err.SetError(dgv, "Location type should only be ferry, bus and train.")

                End If
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If dgv.CurrentCell.ColumnIndex = 1 And dgv.ReadOnly = False Then
            originalName = dgv.CurrentCell.Value.ToString
        End If
    End Sub

    Private Sub ManagerManageLocation_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.LocationTableAdapter1.Fill(Me.PTTSDataSet.Location)
        dgv.ReadOnly = True
        'filter by type
        LocationTableAdapter1.FillBy2(PTTSDataSet.Location, ts.selectedType.ToLower)

    End Sub


End Class