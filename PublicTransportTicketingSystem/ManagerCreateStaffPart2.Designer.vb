<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerCreateStaffPart2
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
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.gbCreateStaff = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblErrorAccess = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreateStaff = New System.Windows.Forms.Button()
        Me.gbCreateStaff.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(-1, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'gbCreateStaff
        '
        Me.gbCreateStaff.BackColor = System.Drawing.SystemColors.Control
        Me.gbCreateStaff.Controls.Add(Me.Label8)
        Me.gbCreateStaff.Controls.Add(Me.Label7)
        Me.gbCreateStaff.Controls.Add(Me.Label6)
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
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(187, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(285, 18)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "type"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(187, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 18)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Name"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(187, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(285, 18)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Username"
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
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblErrorAccess)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 179)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Account Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(160, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 18)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "*Please fill in access key"
        Me.Label9.Visible = False
        '
        'lblErrorAccess
        '
        Me.lblErrorAccess.AutoSize = True
        Me.lblErrorAccess.Enabled = False
        Me.lblErrorAccess.ForeColor = System.Drawing.Color.Red
        Me.lblErrorAccess.Location = New System.Drawing.Point(156, 68)
        Me.lblErrorAccess.Name = "lblErrorAccess"
        Me.lblErrorAccess.Size = New System.Drawing.Size(148, 18)
        Me.lblErrorAccess.TabIndex = 62
        Me.lblErrorAccess.Text = "*Please fill in access key"
        Me.lblErrorAccess.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(159, 98)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 24)
        Me.TextBox2.TabIndex = 61
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 24)
        Me.TextBox1.TabIndex = 60
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
        'ManagerCreateStaffPart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 573)
        Me.Controls.Add(Me.gbCreateStaff)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerCreateStaffPart2"
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblErrorAccess As Label
End Class
