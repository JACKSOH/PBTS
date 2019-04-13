Public Class ManagerManageLocation
    Dim db As New PBTSDataContext
    Private Sub BindData()

        dgv.DataSource = db.Locations
    End Sub
    Private Sub ManagerManageLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PTTSDataSet1.Location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter1.Fill(Me.PTTSDataSet.Location)

        dgv.ReadOnly = True

        txtTest.Text = ts.selectedType.ToString



    End Sub



    Private Sub ManagerMenuLayoutControl1_Load(sender As Object, e As EventArgs) Handles ManagerMenuLayoutControl1.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "&Update" Then
            btnUpdate.Text = "&Save"
            btnDeleteCancel.Text = "&Cancel"
            btnAdd.Enabled = False
            dgv.ReadOnly = False

        Else
            btnUpdate.Text = "&Update"
            btnDeleteCancel.Text = "&Delete"
            'update database
            LocationBindingSource.EndEdit()
            LocationTableAdapter1.Update(PTTSDataSet.Location)

            btnAdd.Enabled = True
            dgv.ReadOnly = True
        End If
    End Sub

    Private Sub btnDeleteCancel_Click(sender As Object, e As EventArgs) Handles btnDeleteCancel.Click
        If btnDeleteCancel.Text = "&Delete" Then
            Dim yesno = MessageBox.Show("Do you really want to delete this records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If yesno = DialogResult.Yes Then
                'delete record and update database
                LocationBindingSource.EndEdit()
                LocationBindingSource.RemoveCurrent()
                LocationTableAdapter1.Update(PTTSDataSet.Location)
            End If


        Else
            btnUpdate.Text = "&Update"
            btnDeleteCancel.Text = "&Delete"
            btnAdd.Enabled = False
            dgv.ReadOnly = True

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New PBTSDataContext
        'lbltest.Text = db.Transports.OrderByDescending(Function(o) o.transportID).Select(Function(i) i.transportID).First().ToString.Substring(2, 6)
        ManagerLocationInsert.newId = App.GenerateNextId(db.Locations.OrderByDescending(Function(o) o.locationID).Select(Function(i) i.locationID).First().ToString)
        ManagerLocationInsert.ShowDialog()

    End Sub

    Private Sub ChangeTranport() Handles ts.TransportChange
        txtTest.Text = ts.selectedType.ToString
    End Sub




End Class