Imports System.Text
Imports System.Data.SqlClient

Public Class ManagerCreateStaffPart2
    Dim staffid As String
    Dim sname As String
    Dim gender As String
    Dim sIC As String
    Dim contactNo As String
    Dim email As String
    Dim type As String
    Dim password As String
    Dim epassword As String

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

    Sub TestValidatePassword()
        Dim password As String = ""
        ' Demonstrate that "Password" is not complex.
        MsgBox(password & " is complex: " & ValidatePassword(password))

        password = "Z9f%a>2kQ"
        ' Demonstrate that "Z9f%a>2kQ" is not complex.
        MsgBox(password & " is complex: " & ValidatePassword(password))
    End Sub

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

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        Dim oldId As String = ""
        Dim db As New PBTSDataContext
        Try
            oldId = db.Employees.OrderByDescending(Function(o) o.employeeID).FirstOrDefault.employeeID.ToString
        Catch ex As Exception

        End Try
        lblUserName.Text = App.GenerateNextId(oldId)
        lblName.Text = ManagerCreateStaff.sname
        lblType.Text = ManagerCreateStaff.type
    End Sub

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

    Private Sub btnCreateStaff_Click(sender As Object, e As EventArgs) Handles btnCreateStaff.Click
        Dim db As New PBTSDataContext
        If (ValidatePassword(txtPassword.Text)) Then
            If (MatchPassword(txtPassword.Text, txtConfirmPassword.Text)) Then

                staffid = App.GenerateNextId(db.Employees.OrderByDescending(Function(o) o.employeeID).FirstOrDefault.employeeID.ToString)
                sname = ManagerCreateStaff.sname
                type = ManagerCreateStaff.type
                gender = ManagerCreateStaff.gender
                sIC = ManagerCreateStaff.IC
                contactNo = ManagerCreateStaff.contact
                email = ManagerCreateStaff.email

                Dim result As DialogResult = MessageBox.Show("Are you sure want to create a new staff?", "Confirmation",
                                                      MessageBoxButtons.YesNoCancel,
                                                      MessageBoxIcon.Question)

                If (result = DialogResult.Yes) Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd2 As New SqlCommand
                    Dim cmd3 As New SqlCommand

                    Try
                        con.ConnectionString = StaffBooking.connection
                        con.Open()
                        cmd.Connection = con
                        'Dim promotionID As String = App.GenerateNextId(db.Promotions.OrderByDescending(Function(o) o.promotionID).FirstOrDefault.promotionID.ToString)

                        cmd = New SqlCommand("insert into Employee ([employeeID], [employeeName], [employeeIC], [gender], [employeeContactNo], [employeeEmail], [type], [password]) values (@employeeID, @employeeName, @employeeIC, @gender, @employeeContactNo, @employeeEmail, @type, @password)", con)
                        cmd.Parameters.Add(New SqlParameter("employeeID", staffid))
                        cmd.Parameters.Add(New SqlParameter("employeeName", sname))
                        cmd.Parameters.Add(New SqlParameter("employeeIC", sIC))
                        cmd.Parameters.Add(New SqlParameter("gender", gender))
                        cmd.Parameters.Add(New SqlParameter("employeeContactNo", contactNo))
                        cmd.Parameters.Add(New SqlParameter("employeeEmail", email))
                        cmd.Parameters.Add(New SqlParameter("type", type))
                        cmd.Parameters.Add(New SqlParameter("password", password))

                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Created Successfully")

                    Catch ex As Exception
                        MessageBox.Show("Invalid" & ex.Message)
                    Finally
                        con.Close()
                        ManagerViewPromotion.Show()
                    End Try
                End If
            End If
        End If
    End Sub
End Class