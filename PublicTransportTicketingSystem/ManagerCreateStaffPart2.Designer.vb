<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerCreateStaffPart2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbCreateStaff = New System.Windows.Forms.GroupBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblErrorConfirmPassword = New System.Windows.Forms.Label()
        Me.lblErrorPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreateStaff = New System.Windows.Forms.Button()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbCreateStaff.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCreateStaff
        '
        Me.gbCreateStaff.BackColor = System.Drawing.SystemColors.Control
        Me.gbCreateStaff.Controls.Add(Me.lblType)
        Me.gbCreateStaff.Controls.Add(Me.lblName)
        Me.gbCreateStaff.Controls.Add(Me.lblUserName)
        Me.gbCreateStaff.Controls.Add(Me.Label5)
        Me.gbCreateStaff.Controls.Add(Me.GroupBox1)
        Me.gbCreateStaff.Controls.Add(Me.Label2)
        Me.gbCreateStaff.Controls.Add(Me.Label1)
        Me.gbCreateStaff.Controls.Add(Me.btnCancel)
        Me.gbCreateStaff.Controls.Add(Me.btnCreateStaff)
        Me.gbCreateStaff.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCreateStaff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbCreateStaff.Location = New System.Drawing.Point(254, 91)
        Me.gbCreateStaff.Name = "gbCreateStaff"
        Me.gbCreateStaff.Size = New System.Drawing.Size(499, 450)
        Me.gbCreateStaff.TabIndex = 24
        Me.gbCreateStaff.TabStop = False
        Me.gbCreateStaff.Text = "Add New Staff"
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(187, 106)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(285, 18)
        Me.lblType.TabIndex = 61
        Me.lblType.Text = "type"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(187, 72)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(285, 18)
        Me.lblName.TabIndex = 60
        Me.lblName.Text = "Name"
        '
        'lblUserName
        '
        Me.lblUserName.Location = New System.Drawing.Point(187, 37)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(285, 18)
        Me.lblUserName.TabIndex = 59
        Me.lblUserName.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Staff Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lblErrorConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.lblErrorPassword)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 179)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Account Password"
        '
        'lblErrorConfirmPassword
        '
        Me.lblErrorConfirmPassword.AutoSize = True
        Me.lblErrorConfirmPassword.ForeColor = System.Drawing.Color.Red
        Me.lblErrorConfirmPassword.Location = New System.Drawing.Point(160, 125)
        Me.lblErrorConfirmPassword.Name = "lblErrorConfirmPassword"
        Me.lblErrorConfirmPassword.Size = New System.Drawing.Size(148, 18)
        Me.lblErrorConfirmPassword.TabIndex = 63
        Me.lblErrorConfirmPassword.Text = "*Please fill in access key"
        Me.lblErrorConfirmPassword.Visible = False
        '
        'lblErrorPassword
        '
        Me.lblErrorPassword.AutoSize = True
        Me.lblErrorPassword.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblErrorPassword.Location = New System.Drawing.Point(156, 68)
        Me.lblErrorPassword.Name = "lblErrorPassword"
        Me.lblErrorPassword.Size = New System.Drawing.Size(148, 18)
        Me.lblErrorPassword.TabIndex = 62
        Me.lblErrorPassword.Text = "*Please fill in access key"
        Me.lblErrorPassword.Visible = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Enabled = False
        Me.txtConfirmPassword.Location = New System.Drawing.Point(159, 98)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(149, 24)
        Me.txtConfirmPassword.TabIndex = 61
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(159, 41)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(149, 24)
        Me.txtPassword.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Staff Name"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(372, 396)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnCreateStaff
        '
        Me.btnCreateStaff.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnCreateStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCreateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreateStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreateStaff.Location = New System.Drawing.Point(221, 396)
        Me.btnCreateStaff.Name = "btnCreateStaff"
        Me.btnCreateStaff.Size = New System.Drawing.Size(100, 36)
        Me.btnCreateStaff.TabIndex = 26
        Me.btnCreateStaff.Text = "&CREATE"
        Me.btnCreateStaff.UseVisualStyleBackColor = False
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(-1, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 36)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Manage Staff"
        '
        'ManagerCreateStaffPart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 573)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbCreateStaff)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerCreateStaffPart2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerCreateStaffPart2"
        Me.gbCreateStaff.ResumeLayout(False)
        Me.gbCreateStaff.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents gbCreateStaff As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCreateStaff As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblErrorConfirmPassword As Label
    Friend WithEvents lblErrorPassword As Label
    Friend WithEvents Label6 As Label
End Class
