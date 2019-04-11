Module App

    Public Function GenerateNextId(id As String) As String
        ManagerManageLocation.txtTest.Text = id.ToString
        Dim prefix As String = id.Substring(0, 2)

        Dim postFix As Integer = CInt(id.Substring(2, 4))
        Return prefix + (postFix + 1).ToString("D4")
    End Function
End Module
