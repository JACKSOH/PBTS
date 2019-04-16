Imports System.Data.SqlClient
Imports System.Text

Public Class managerIndex
    Friend IC As String
    Friend password As String
    Friend type As String = "staff"
    Dim SqlConnection As New SqlConnection
    Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tan\Desktop\PTTS\PBTS\PublicTransportTicketingSystem\PTTS.mdf;Integrated Security=True"

    Friend Function encryptPassword() As String
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

    Friend Function CheckEmployeePasswordandIC(IC As String, password As String, type As String) As Boolean
        Dim checking As Boolean
        password = encryptPassword()
        Try
            SqlConnection.ConnectionString = ConnectionString
            SqlConnection.Open()
            Dim command As New SqlCommand("select * from Employee where employeeIC=@IC AND password=@password AND type=@type", SqlConnection)
            command.Parameters.AddWithValue("@IC", IC)
            command.Parameters.AddWithValue("@password", password)
            command.Parameters.AddWithValue("@type", type)
            Dim adapter As New SqlDataAdapter(command)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader

            If reader.Read Then
                checking = True
            Else
                checking = False
            End If

            SqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return checking

    End Function

    Private Function ICPasswordValidation() As Boolean
        'validate the ic and password field
        Dim result As Boolean = True

        If (txtIC.Text = "") Then
            lblErrorIC.Text = "*Please enter IC"
            lblErrorIC.Visible = True
            result = False
        ElseIf (txtIC.Text.Length <> 12) Then
            lblErrorIC.Text = "*IC contains 12 characters"
            lblErrorIC.Visible = True
            result = False
        Else
            lblErrorIC.Visible = False
            IC = txtIC.Text
            result = True
        End If

        If (txtPassword.Text = "") Then
            lblErrorPassword.Text = "Please enter your password"
            lblErrorPassword.Visible = True
            result = False
        Else
            password = txtPassword.Text
            lblErrorPassword.Visible = False
        End If
        Return result
    End Function


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'retrieve password and ic and do checking
        lblError.Visible = False

        If ICPasswordValidation() Then
            If CheckEmployeePasswordandIC(txtIC.Text, txtPassword.Text, "manager") Then
                Me.Hide()
                ManagerManageAccount.Show()
            Else
                lblError.Visible = True
                Return
            End If
        End If
    End Sub

    Private Sub ManagerIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown Then
            Me.Hide()
            StaffIndex.Show()
        End If
    End Sub

    Private Sub txtIC_TextChanged(sender As Object, e As EventArgs) Handles txtIC.TextChanged
        If Not (txtIC.Text = "") Then
            IC = txtIC.Text
            Label4.ForeColor = SystemColors.ButtonHighlight
            txtPassword.Enabled = True
        Else
            Label4.ForeColor = SystemColors.GrayText
            txtPassword.Enabled = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If Not (txtPassword.Text = "") Then
            lblErrorPassword.Visible = False
            lblErrorPassword.Text = "Incorrect Password"
        End If
    End Sub

    Private Sub linkToStaff_Click(sender As Object, e As EventArgs) Handles linkToStaff.Click
        lblError.Visible = False
        lblErrorIC.Visible = False
        lblErrorPassword.Visible = False
        txtIC.Clear()
        txtPassword.Clear()
        StaffIndex.Show()
        Me.Hide()
    End Sub


End Class