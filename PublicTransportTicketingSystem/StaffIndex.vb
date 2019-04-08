Imports System.Data.SqlClient

Public Class StaffIndex
    Dim SqlConnection As New SqlConnection
    Dim ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\boonk\source\repos\JACKSOH\PBTS\PublicTransportTicketingSystem\PTTS.mdf;Integrated Security=True"
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles BackPanel.Paint

    End Sub

    Private Sub MangerLoginToolStripMenuItem_Click(sender As Object, e As EventArgs)
        managerIndex.Show()
        Me.Close()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
    Friend Function CheckEmployeePasswordandIC(IC As String, password As String, type As String) As Boolean
        Dim checking As Boolean
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
        If txtIC.Text = "" Or txtPassword.Text = "" Then
            Return True
            MessageBox.Show("IC and password is required!", "Do not leave blank.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If txtIC.Text.Length > 12 Then
                Return True
                MessageBox.Show("IC consist 12 character", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Return True
            End If

        End If


    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'retrieve password and ic and do checking
        If ICPasswordValidation() Then
            If CheckEmployeePasswordandIC(txtIC.Text, txtPassword.Text, "staff") Then
                Me.Hide()
                StaffBooking.Show()

            Else
                MessageBox.Show("IC or password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If



    End Sub

    Private Sub StaffIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown Then
            Me.Hide()
            managerIndex.Show()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIC.TextChanged

    End Sub
End Class