Module App
    Public table As String
    Public Function GenerateNextId(id As String) As String

        If id = "" Then
            Dim prefix1 As String
            Dim check As Boolean = True
            Do
                'refresh cehck 
                check = True
                prefix1 = InputBox("Please Enter the prefix for ID for." & table & vbNewLine & "E.g. sc,tr,bk....", "Creating new ID", "")
                If prefix1 = "" Then
                    MessageBox.Show("Prefix is required!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    check = False
                ElseIf prefix1.Length <> 2 Then
                    'prefix only allow 2 digit
                    MessageBox.Show("Prefix should contain 2 character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    check = False
                ElseIf IsAlpha(prefix1) <> True Then
                    MessageBox.Show("Prefix should contain only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    check = False
                End If
            Loop While check = False
            Return prefix1 + "0001"
        Else
            Dim preFix As String = id.Substring(0, 2)
            Dim postFix As Integer = CInt(id.Substring(2, 4))
            Return preFix + (postFix + 1).ToString("D4")
        End If
        table = ""
    End Function

    'check whether the string contain only alphabet
    Public Function IsAlpha(strValue As String) As Boolean

        Dim intPos As Integer

        For intPos = 1 To Len(strValue)
            Select Case Asc(Mid(strValue, intPos, 1))
                Case 65 To 90, 97 To 122
                    Return True
                Case Else
                    Return False
                    Exit For
            End Select
        Next
    End Function
End Module
