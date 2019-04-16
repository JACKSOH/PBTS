Public Class managerIndex
    Private Sub MangerLoginToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StaffIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown Then
            Me.Hide()
            StaffIndex.Show()
        End If
    End Sub
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
        If ICPasswordValidation() Then
            If StaffIndex.CheckEmployeePasswordandIC(txtIC.Text, txtPassword.Text, "manager") Then
                MessageBox.Show("Successful login!!" & vbNewLine & "Redirecting to manager page...")
                System.Threading.Thread.Sleep(2000)
                Me.Hide()
                BigBackground.Show()

            Else
                MessageBox.Show("IC or password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class