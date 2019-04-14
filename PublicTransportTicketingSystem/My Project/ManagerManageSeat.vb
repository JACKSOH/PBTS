Public Class ManagerManageSeat
    Dim count As Integer = 0
    Dim db As New PBTSDataContext()
    Public selectedSeat As New List(Of Integer)

    Private Sub ManagerManageSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class