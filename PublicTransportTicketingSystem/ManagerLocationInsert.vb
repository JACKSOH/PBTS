Public Class ManagerLocationInsert
    Public newId As String
    Public newPosition As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub ResetForm()
        txtPosition.Clear()
        txtName.Clear()

    End Sub
    Private Sub retrieveNewPosition()
        Dim db As New PBTSDataContext
        newPosition = CInt(db.Locations.Where(Function(o) o.locationType = ManagerManageLocation.ts.selectedType.ToString).OrderByDescending(Function(o) o.position).FirstOrDefault.position.ToString) + 1


    End Sub
    Private Sub ManagerLocationInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieveNewPosition()
        lblLocationId.Text = newId
        txtPosition.Text = newPosition.ToString
        cboType.SelectedIndex = 0
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
    Private Sub AdjustPosition(position As Integer)


        Do
            If position < newPosition Then

                Dim db As New PBTSDataContext
                Dim t As New Location
                t = db.Locations.Where(Function(o) o.locationType = cboType.Text.ToLower And o.position.Equals(position) = True).FirstOrDefault

                t.position = t.position + 1
                db.SubmitChanges()
                position += 1
            End If
        Loop While (position < newPosition)



    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim l As New Location

        l.position = Integer.Parse(txtPosition.Text)
        l.locationID = newId
        l.locationName = txtName.Text
        l.locationStatus = "Available"
        l.locationType = cboType.SelectedItem.ToString


        'move the position which conflict with new position
        AdjustPosition(CInt(txtPosition.Text))
        Dim db As New PBTSDataContext
        db.Locations.InsertOnSubmit(l)
        db.SubmitChanges()

        MessageBox.Show("New location [" + newId + "] is created.", "Successful!!")
        ResetForm()

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub txtPosition_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPosition.Validating
        Dim db As New PBTSDataContext

        Try
            Dim position As Integer = CInt(txtPosition.Text)
            If position > newPosition Then
                err.SetError(txtPosition, "The farest position currently is at " + newPosition.ToString)
                e.Cancel = True
            Else
                err.SetError(txtPosition, Nothing)
            End If

        Catch ex As Exception
            err.SetError(txtPosition, "Position is required and should contain only number!")
            e.Cancel = True
        End Try
    End Sub

    Private Sub txtPosition_TextChanged(sender As Object, e As EventArgs) Handles txtPosition.TextChanged
        Try
            If CInt(txtPosition.Text) <> newPosition Then
                lblsuggest.Visible = False
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub ManagerLocationInsert_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        retrieveNewPosition()
        lblLocationId.Text = newId
        txtPosition.Text = newPosition.ToString
        cboType.SelectedIndex = 0
    End Sub



    Private Sub cboType_MouseLeave(sender As Object, e As EventArgs) Handles cboType.MouseLeave
        Dim db As New PBTSDataContext
        newPosition = CInt(db.Locations.Where(Function(o) o.locationType = cboType.Text).OrderByDescending(Function(o) o.position).FirstOrDefault.position.ToString) + 1

        txtPosition.Text = newPosition.ToString
    End Sub
End Class