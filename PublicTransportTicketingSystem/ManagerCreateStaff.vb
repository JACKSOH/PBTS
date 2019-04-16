Imports System.Text.RegularExpressions

Public Class ManagerCreateStaff
    Friend sname As String
    Friend IC As String
    Friend email As String
    Friend contact As String
    Friend gender As String
    Friend type As String

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        Debug.Print(txtContactNo.Text)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ValidateCheck()
        sname = txtName.Text
        IC = txtIC.Text
        email = txtEmail.Text
        contact = txtContactNo.Text
        ManagerCreateStaffPart2.Show()
        Me.Hide()
    End Sub

    Private Sub ValidateCheck()
        If (txtName.Text = "") Then
            lblErrorName.Visible = True
        Else
            lblErrorName.Visible = False
        End If

        If (txtContactNo.Text = "   -") Then
            lblErrorContact.Visible = True
            lblErrorContact.Text = "*Please fill in contact no"
        ElseIf Not (txtContactNo.Text.Length = 11) Then
            lblErrorContact.Text = "*Incorrect Format"
        Else
            lblErrorContact.Visible = False
        End If

        If (txtIC.Text = "") Then
            lblErrorIC.Visible = True
            lblErrorIC.Text = "*Please fill in IC No"
        ElseIf (txtIC.Text.Length <> 12) Then
            lblErrorIC.Visible = True
            lblErrorIC.Text = "*IC input length must be 14"
        ElseIf (txtIC.Text.Length = 12) Then
            lblErrorIC.Visible = False
        End If

        If (radManager.Checked) Then
            If (txtAccessKey.Text = "") Then
                lblErrorAccess.Visible = True
                lblErrorAccess.Text = "*Please fill in access key"
            ElseIf (txtAccessKey.Text <> "admin123") Then
                lblErrorAccess.Visible = True
                lblErrorAccess.Text = "Incorrect Access Key"
            End If
        End If

        If Not (txtEmail.Text = "") Then
            If Not (EmailAddressCheck(txtEmail.Text)) Then
                lblErrorEmail.Visible = True
                lblErrorEmail.Text = "*Wrong Email Format"
            Else
                lblErrorEmail.Visible = False
                lblErrorEmail.Text = "*Please fill in email"
            End If
        Else
            lblErrorEmail.Visible = True
            lblErrorEmail.Text = "*Please fill in email"
        End If

        If (txtAccessKey.Text = "") Then
            lblErrorAccess.Enabled = True
            lblErrorAccess.Text = "Please fill in access key"
        Else
            lblErrorAccess.Enabled = True
        End If
    End Sub

    Private Sub radManager_CheckedChanged(sender As Object, e As EventArgs) Handles radManager.CheckedChanged
        type = "Manager"
        txtAccessKey.Enabled = True
        Label9.Enabled = True
    End Sub

    Private Sub radStaff_CheckedChanged(sender As Object, e As EventArgs) Handles radStaff.CheckedChanged
        type = "Staff"
        txtAccessKey.Enabled = False
        lblErrorAccess.Visible = False
        Label9.Enabled = False
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
        End
    End Sub

    Private Sub txtAccessKey_TextChanged(sender As Object, e As EventArgs) Handles txtAccessKey.TextChanged
        If (radManager.Checked) Then
            If (txtAccessKey.Text <> "admin123") Then
                lblErrorAccess.Enabled = True
                lblErrorAccess.Visible = True
                lblErrorAccess.Text = "Incorrect Access Key"
            Else
                lblErrorAccess.Visible = False
            End If
        End If
    End Sub

End Class