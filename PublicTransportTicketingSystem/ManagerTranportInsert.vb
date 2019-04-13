Public Class ManagerTranportInsert
    Public newId As String
    Private Sub ManagerTranportInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTransId.Text = newId

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub MaskedTextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskSeatPrice.Validating
        If mskSeatPrice.Text <> "" Then
            Dim price As Decimal = CDec(mskSeatPrice.Text.Replace(" ", "0"))

            If price = 0 Then
                err.SetError(mskSeatPrice, "[Seat Price] Should more than RM 1")
                e.Cancel = True
            Else
                err.SetError(mskSeatPrice, Nothing)

            End If
        Else
            err.SetError(mskSeatPrice, "[Seat Price] is required!")
            e.Cancel = True
        End If



    End Sub

    Private Sub txtCompany_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCompany.Validating
        Dim company As String = txtCompany.Text

        If company = "" Then
            err.SetError(txtCompany, "Company name should not leave blank")
            e.Cancel = True
        Else
            err.SetError(txtCompany, Nothing)
        End If
    End Sub

    Private Sub txtPlate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPlate.Validating
        Dim plate As String = txtPlate.Text

        If plate = "" Then
            err.SetError(txtPlate, "[Licnese Plate] name should not leave blank")
            e.Cancel = True
        Else
            err.SetError(txtPlate, Nothing)
        End If
    End Sub

    Private Sub makColumn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskColumn.Validating
        Try
            Dim column As Integer = CInt(mskColumn.Text)

            If column = 0 Then
                err.SetError(mskColumn, "[Width]of the transport should less than 1")
                e.Cancel = True
            ElseIf column > 12 Then
                err.SetError(mskColumn, "[Width]of the transport should more than 12")
                e.Cancel = True
            Else
                err.SetError(mskColumn, Nothing)
            End If
        Catch ex As Exception
            err.SetError(mskColumn, "[Width] should not leave blank")
        End Try

    End Sub

    Private Sub mskRow_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskRow.Validating
        Try
            Dim row As Integer = CInt(mskRow.Text)

            If row = 0 Then
                err.SetError(mskRow, "[Width]of the transport should less than 1")
                e.Cancel = True
            ElseIf row > 50 Then
                err.SetError(mskRow, "[Width]of the transport should more than 50")
                e.Cancel = True
            Else
                err.SetError(mskRow, Nothing)
            End If
        Catch ex As Exception
            err.SetError(mskRow, "[Height] should not leave blank")
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tr As New Transport

        tr.transportID = newId
        tr.seatPrice = CDec(mskSeatPrice.Text.Replace(" ", "0"))
        tr.transportName = txtCompany.Text
        tr.transportType = cboType.SelectedItem.ToString
        tr.licensePlate = txtPlate.Text
        tr.tranportColumn = CInt(mskColumn.Text)
        tr.tranportRow = CInt(mskRow.Text)
        tr.transportStatus = "Available"

        Dim db As New PBTSDataContext
        db.Transports.InsertOnSubmit(tr)
        db.SubmitChanges()
        MessageBox.Show("New tranport [" + newId + "] is added!", "Successful")
        Me.Close()

    End Sub


    Private Sub txtPosition_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class