Module App

    Dim promotionCount As Integer
    Dim promotionScheduleCount As Integer
    Dim staffCount As Integer
    Public Sub getPromotionCount()
        Try
            Dim db As New PBTSDataContext()
            Dim query = From promotion In db.Promotions
            promotionCount = query.Count
        Catch ex As Exception

        End Try
    End Sub

    Public Sub getPromoteScheduleCount()
        Try
            Dim db As New PBTSDataContext()
            Dim query = From promotion In db.promoteSchedules
            promotionScheduleCount = query.Count
        Catch ex As Exception

        End Try
    End Sub

    Public Sub getStaffCount()
        Try
            Dim db As New PBTSDataContext()
            Dim query = From promotion In db.Employees
            staffCount = query.Count
        Catch ex As Exception

        End Try
    End Sub


    Public Function GetNextPromotionId() As String
        getPromotionCount()
        Return (promotionCount + 1).ToString("PR0000")
    End Function

    Public Function GetNextPromoteScheduleId() As String
        getPromoteScheduleCount()
        Return (promotionScheduleCount + 1).ToString("PS0000")
    End Function


    Public Function GetNextStaffId() As String
        getStaffCount()
        Return (staffCount + 1).ToString("EM0000")
    End Function
End Module
