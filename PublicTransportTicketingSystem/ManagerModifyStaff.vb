Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class ManagerModifyStaff

    Friend sname As String
    Friend IC As String
    Friend email As String
    Friend contact As String
    Friend gender As String
    Friend type As String
    Private con As New SqlConnection

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (ValidateCheck()) Then
            updateStaff()
            ManagerViewStaff.Show()
            Me.Hide()
        End If
    End Sub

    Private Function ValidateCheck() As Boolean
        Dim result As Boolean = True

        If (txtName.Text = "") Then
            lblErrorName.Visible = True
            result = False
        Else
            lblErrorName.Visible = False
        End If

        If (txtContactNo.Text = "   -") Then
            lblErrorContact.Visible = True
            lblErrorContact.Text = "*Please fill in contact no"
            result = False
        ElseIf Not (txtContactNo.Text.Length = 11) Then
            lblErrorContact.Visible = True
            lblErrorContact.Text = "*Incorrect Format"
            result = False
        Else
            lblErrorContact.Visible = False
        End If

        If (txtIC.Text = "") Then
            lblErrorIC.Visible = True
            lblErrorIC.Text = "*Please fill in IC No"
            result = False
        ElseIf (txtIC.Text.Length <> 12) Then
            lblErrorIC.Visible = True
            lblErrorIC.Text = "*IC input length must be 14"
            result = False
        ElseIf (txtIC.Text.Length = 12) Then
            lblErrorIC.Visible = False
        End If

        If Not (txtEmail.Text = "") Then
            If Not (EmailAddressCheck(txtEmail.Text)) Then
                lblErrorEmail.Visible = True
                lblErrorEmail.Text = "*Wrong Email Format"
                result = False
            Else
                lblErrorEmail.Visible = False
                lblErrorEmail.Text = "*Please fill in email"
            End If
        Else
            lblErrorEmail.Visible = True
            lblErrorEmail.Text = "*Please fill in email"
            result = False
        End If

        Return result
    End Function

    Private Sub radManager_CheckedChanged(sender As Object, e As EventArgs) Handles radManager.CheckedChanged
        type = "manager"
    End Sub

    Private Sub radStaff_CheckedChanged(sender As Object, e As EventArgs) Handles radStaff.CheckedChanged
        type = "staff"
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        gender = "F"
    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        gender = "M"
    End Sub

    Private Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ManagerViewStaff.Show()
        Me.Close()
    End Sub

    Private Sub updateStaff()
        sname = txtName.Text
        IC = txtIC.Text
        email = txtEmail.Text
        contact = txtContactNo.Text

        Dim result As DialogResult = MessageBox.Show("Are you sure want to modify a new staff?", "Confirmation",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Try
                con.ConnectionString = StaffBooking.connection
                con.Open()
                Dim command As New SqlCommand("UPDATE Employee Set employeeName = @employeeName, employeeIC = @employeeIC , gender = @gender, employeeContactNo = @employeeContactNo, employeeEmail = @employeeEmail, type = @type WHERE employeeID = @employeeID", con)
                command.Parameters.Add(New SqlParameter("employeeID", ManagerViewStaff.staffid))
                command.Parameters.Add(New SqlParameter("employeeName", sname))
                command.Parameters.Add(New SqlParameter("employeeIC", IC))
                command.Parameters.Add(New SqlParameter("gender", gender))
                command.Parameters.Add(New SqlParameter("employeeContactNo", contact))
                command.Parameters.Add(New SqlParameter("employeeEmail", email))
                command.Parameters.Add(New SqlParameter("type", type))
                command.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown

        Try
            con.ConnectionString = StaffBooking.connection
            con.Open()
            Dim command As New SqlCommand("select * from Employee where employeeID = '" & ManagerViewStaff.staffid & "'", con)
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader

            If (reader.Read) Then
                txtName.Text = reader.GetString(1)
                txtIC.Text = reader.GetString(2)
                txtEmail.Text = reader.GetString(5)
                txtContactNo.Text = reader.GetString(4)


                If reader.GetString(3).ToLower.Contains("m") Then
                    radMale.Checked = True
                    radFemale.Checked = False
                Else
                    radFemale.Checked = True
                    radMale.Checked = False
                End If

                If (reader.GetString(6).ToString.Contains("manager")) Then
                    radManager.Checked = True
                Else
                    radStaff.Checked = True
                End If
            End If
            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        sname = txtName.Text
    End Sub

    Private Sub txtIC_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtIC.MaskInputRejected
        IC = txtIC.Text
    End Sub

    Private Sub txtContactNo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtContactNo.MaskInputRejected
        contact = txtContactNo.Text
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        email = txtEmail.Text
    End Sub
End Class