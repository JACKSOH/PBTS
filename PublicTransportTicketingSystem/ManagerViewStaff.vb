Public Class ManagerViewStaff
    Friend staffid As String
    Friend sname As String
    Friend gender As String
    Friend sIC As String
    Friend contactNo As String
    Friend email As String
    Friend type As String = "Manager"
    Friend password As String
    Dim contain As String

    Private Sub DataBindSearch()
        Try
            Dim db As New PBTSDataContext()
            Dim query = From em In db.Employees
                        Where em.employeeID.Contains(contain) Or
                            em.employeeName.Contains(contain) Or
                            em.type.Contains(contain) Or
                            em.gender.Contains(contain)
                        Select em.employeeID, em.employeeName, em.type, em.gender
            dgvStaffList.DataSource = query
            dgvStaffList.Columns("employeeID").HeaderText = "ID"
            dgvStaffList.Columns("employeeName").HeaderText = "Name"
            dgvStaffList.Columns("type").HeaderText = "Type"
            dgvStaffList.Columns("gender").HeaderText = "Gender"
            lblCount.Text = query.Count.ToString("0 record(s)")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataBind()
        Try
            Dim db As New PBTSDataContext()
            Dim query = From em In db.Employees
                        Where em.type = type
                        Select em.employeeID, em.employeeName, em.type, em.gender
            dgvStaffList.DataSource = query
            dgvStaffList.Columns("employeeID").HeaderText = "ID"
            dgvStaffList.Columns("employeeName").HeaderText = "Name"
            dgvStaffList.Columns("type").HeaderText = "Type"
            dgvStaffList.Columns("gender").HeaderText = "Gender"
            lblCount.Text = query.Count.ToString("0 record(s)")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load
        DataBind()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not (txtSearch.Text = "") Then
            contain = txtSearch.Text
            DataBindSearch()
            Label2.Enabled = False
            radManager.Enabled = False
            radStaff.Enabled = False
        Else
            Label2.Enabled = True
            radManager.Enabled = True
            radStaff.Enabled = True
        End If
    End Sub

    Private Sub radManager_CheckedChanged(sender As Object, e As EventArgs) Handles radManager.CheckedChanged
        If (radManager.Checked) Then
            type = "Manager"
            DataBind()
        End If
    End Sub

    Private Sub radStaff_CheckedChanged(sender As Object, e As EventArgs) Handles radStaff.CheckedChanged
        If (radStaff.Checked) Then
            type = "Staff"
            DataBind()
        End If
    End Sub

    Private Sub dgvStaffList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaffList.CellDoubleClick

    End Sub
End Class