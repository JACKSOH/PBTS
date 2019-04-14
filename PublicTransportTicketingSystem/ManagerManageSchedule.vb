Public Class ManagerManageSchedule
    Private Sub ManagerManageSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New PBTSDataContext


    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New PBTSDataContext
        Dim id As String
        Try
            id = db.Schedules.OrderByDescending(Function(s) s.scheduleID).FirstOrDefault.scheduleID.ToString
        Catch ex As Exception

        End Try


        App.table = "Schedule"
        ManagerSchduleInsert.newId = App.GenerateNextId(id)
        ManagerSchduleInsert.ShowDialog()
    End Sub


End Class