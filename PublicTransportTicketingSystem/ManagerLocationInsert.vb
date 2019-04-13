Public Class ManagerLocationInsert
    Public newId As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ManagerLocationInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLocationId.Text = newId
    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Try
            Dim name As String = txtName.Text.Replace(" ", "")

            If name.Length <= 0 Then
                err.SetError(txtName, "Name could not leave blank!")
            Else
                err.SetError(txtName, Nothing)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim lo As Location

        lo.locationID = newId
        lo.locationName = txtName.Text
        lo.locationStatus = "Available"
        lo.locationType = cboType.SelectedItem.ToString
        Dim db As New PBTSDataContext
        db.Locations.InsertOnSubmit(lo)
        db.SubmitChanges()

        MessageBox.Show("New location [" + newId + "] is created.", "Successful!!")
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class