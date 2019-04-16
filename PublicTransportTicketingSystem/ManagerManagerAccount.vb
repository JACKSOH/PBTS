Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions

Public Class ManagerManagerAccount
    Dim IC As String
    Dim sname As String
    Dim contact As String
    Dim email As String
    Dim password As String
    Dim SqlConnection As New SqlClient.SqlConnection
    Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tan\Desktop\PTTS\PBTS\PublicTransportTicketingSystem\PTTS.mdf;Integrated Security=True"


    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        If (radNo.Checked = True) Then
            gpChangePassword.Enabled = False
        Else
            gpChangePassword.Enabled = True
        End If
    End Sub

    Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged
        If Not (radYes.Checked = True) Then
            gpChangePassword.Enabled = False
        Else
            gpChangePassword.Enabled = True
            If Not (txtExistPassword.Text = "") Then
                txtPassword.Enabled = True
                txtConfirmPassword.Enabled = True
            Else
                txtPassword.Clear()
                txtConfirmPassword.Clear()
                txtPassword.Enabled = False
                txtConfirmPassword.Enabled = False
            End If
        End If
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        txtPassword.Enabled = True
        txtConfirmPassword.Enabled = True
        If Not (radYes.Checked = True) Then
            gpChangePassword.Enabled = False
        Else
            gpChangePassword.Enabled = True
            If Not (txtExistPassword.Text = "") Then
                txtPassword.Enabled = True
                txtConfirmPassword.Enabled = True
            Else
                txtPassword.Clear()
                txtConfirmPassword.Clear()
                txtPassword.Enabled = False
                txtConfirmPassword.Enabled = False
            End If
        End If

        IC = managerIndex.IC
        gpChangePassword.Enabled = False
        DataBind()
    End Sub

    Function encryptPassword() As String
        Dim newString As StringBuilder = New StringBuilder()

        For Each character As Char In txtPassword.Text
            If character = "Y"c Then
                newString.Append(Chr(65))
            ElseIf character = "Z"c Then
                newString.Append(Chr(66))
            ElseIf character = "y"c Then
                newString.Append(Chr(97))
            ElseIf character = "z"c Then
                newString.Append(Chr(98))
            Else
                newString.Append(Chr(Asc(character) + 2))
            End If
        Next

        Return newString.ToString()
    End Function

    Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 2,
    Optional ByVal numLower As Integer = 2,
    Optional ByVal numNumbers As Integer = 2,
    Optional ByVal numSpecial As Integer = 2) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If Not (txtPassword.Text = "") Then
            password = encryptPassword()
            If (ValidatePassword(txtPassword.Text)) Then
                lblErrorPassword.Visible = True
                lblErrorPassword.ForeColor = Color.Green
                lblErrorPassword.Text = "Password : Complex"
                txtConfirmPassword.Enabled = True
            Else
                txtConfirmPassword.Enabled = False
                lblErrorPassword.Visible = True
                lblErrorPassword.ForeColor = Color.Red
                lblErrorPassword.Text = "Password : Simple"
            End If
        Else
            txtConfirmPassword.Enabled = False
            lblErrorPassword.Visible = False
        End If
    End Sub

    Function MatchPassword(password As String, passwordConfirm As String) As Boolean
        Dim result As Boolean = True

        If (password <> passwordConfirm) Then
            result = False
        End If
        Return result
    End Function

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        If Not (txtConfirmPassword.Text = "") Then

            If (MatchPassword(txtPassword.Text, txtConfirmPassword.Text)) Then
                lblErrorConfirmPassword.Visible = True
                lblErrorConfirmPassword.Text = "Password Match"
                lblErrorConfirmPassword.ForeColor = Color.Green
            Else
                lblErrorConfirmPassword.Visible = True
                lblErrorConfirmPassword.Text = "Password Not Match"
                lblErrorConfirmPassword.ForeColor = Color.Red
            End If
        End If
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

    Private Sub ValidateCheck()

        If (txtContactNo.Text = "   -") Then
            lblErrorContact.Visible = True
            lblErrorContact.Text = "*Please fill in contact no"
        ElseIf Not (txtContactNo.Text.Length = 11) Then
            lblErrorContact.Text = "*Incorrect Format"
        Else
            lblErrorContact.Visible = False
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
    End Sub

    Private Sub DataBind()
        Try
            SqlConnection.ConnectionString = ConnectionString
            SqlConnection.Open()
            Dim command As New SqlCommand("select employeeName, employeeContactNo, employeeEmail, password from Employee where employeeIC=@IC", SqlConnection)
            command.Parameters.AddWithValue("@IC", IC)
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader

            If reader.Read Then
                lblIC.Text = IC
                lblName.Text = reader.GetString(0)
                txtContactNo.Text = reader.GetString(1)
                txtEmail.Text = reader.GetString(2)
                password = reader.GetString(3)
            End If

            SqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class