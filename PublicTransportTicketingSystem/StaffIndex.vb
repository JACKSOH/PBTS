Public Class StaffIndex
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles BackPanel.Paint

    End Sub

    Private Sub MangerLoginToolStripMenuItem_Click(sender As Object, e As EventArgs)
        managerIndex.Show()
        Me.Close()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StaffViewSchedule.Show()

        Me.Hide()

    End Sub

    Private Sub StaffIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown Then
            Me.Hide()
            managerIndex.Show()
        End If
    End Sub
End Class