<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerViewStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dgvStaffList = New System.Windows.Forms.DataGridView()
        Me.radStaff = New System.Windows.Forms.RadioButton()
        Me.radManager = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCreatePromotionPage = New System.Windows.Forms.Button()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvStaffList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCount)
        Me.GroupBox1.Controls.Add(Me.dgvStaffList)
        Me.GroupBox1.Controls.Add(Me.radStaff)
        Me.GroupBox1.Controls.Add(Me.radManager)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(254, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 441)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View All Staff"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(29, 400)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(69, 18)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "X record(s)"
        '
        'dgvStaffList
        '
        Me.dgvStaffList.AllowUserToOrderColumns = True
        Me.dgvStaffList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaffList.Location = New System.Drawing.Point(32, 123)
        Me.dgvStaffList.Name = "dgvStaffList"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvStaffList.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStaffList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaffList.Size = New System.Drawing.Size(442, 274)
        Me.dgvStaffList.TabIndex = 5
        '
        'radStaff
        '
        Me.radStaff.AutoSize = True
        Me.radStaff.Location = New System.Drawing.Point(282, 71)
        Me.radStaff.Name = "radStaff"
        Me.radStaff.Size = New System.Drawing.Size(52, 22)
        Me.radStaff.TabIndex = 4
        Me.radStaff.Text = "Staff"
        Me.radStaff.UseVisualStyleBackColor = True
        '
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.Location = New System.Drawing.Point(175, 71)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(76, 22)
        Me.radManager.TabIndex = 3
        Me.radManager.Text = "Manager"
        Me.radManager.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(29, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search by category"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(177, 34)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(213, 24)
        Me.txtSearch.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(280, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 36)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Manage Staff"
        '
        'btnCreatePromotionPage
        '
        Me.btnCreatePromotionPage.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnCreatePromotionPage.AutoEllipsis = True
        Me.btnCreatePromotionPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreatePromotionPage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePromotionPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCreatePromotionPage.Location = New System.Drawing.Point(515, 527)
        Me.btnCreatePromotionPage.Name = "btnCreatePromotionPage"
        Me.btnCreatePromotionPage.Size = New System.Drawing.Size(244, 28)
        Me.btnCreatePromotionPage.TabIndex = 39
        Me.btnCreatePromotionPage.Text = "&CREATE STAFF"
        Me.btnCreatePromotionPage.UseVisualStyleBackColor = False
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 567)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'ManagerViewStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 567)
        Me.Controls.Add(Me.btnCreatePromotionPage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerViewStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerViewStaff"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvStaffList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents dgvStaffList As DataGridView
    Friend WithEvents radStaff As RadioButton
    Friend WithEvents radManager As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCreatePromotionPage As Button
End Class
