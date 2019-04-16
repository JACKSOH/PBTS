<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffManageAccount
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
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.gbManagerAccount = New System.Windows.Forms.GroupBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gpChangePassword = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblErrorExisting = New System.Windows.Forms.Label()
        Me.txtExistPassword = New System.Windows.Forms.TextBox()
        Me.lblErrorConfirmPassword = New System.Windows.Forms.Label()
        Me.lblErrorPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblErrorEmail = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblErrorContact = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbManagerAccount.SuspendLayout()
        Me.gpChangePassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'StaffMenuLayoutControl1
        '
        Me.StaffMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StaffMenuLayoutControl1.Name = "StaffMenuLayoutControl1"
        Me.StaffMenuLayoutControl1.Size = New System.Drawing.Size(804, 582)
        Me.StaffMenuLayoutControl1.TabIndex = 0
        '
        'gbManagerAccount
        '
        Me.gbManagerAccount.BackColor = System.Drawing.SystemColors.Control
        Me.gbManagerAccount.Controls.Add(Me.txtContactNo)
        Me.gbManagerAccount.Controls.Add(Me.lblIC)
        Me.gbManagerAccount.Controls.Add(Me.lblName)
        Me.gbManagerAccount.Controls.Add(Me.radNo)
        Me.gbManagerAccount.Controls.Add(Me.radYes)
        Me.gbManagerAccount.Controls.Add(Me.Label10)
        Me.gbManagerAccount.Controls.Add(Me.gpChangePassword)
        Me.gbManagerAccount.Controls.Add(Me.txtEmail)
        Me.gbManagerAccount.Controls.Add(Me.lblErrorEmail)
        Me.gbManagerAccount.Controls.Add(Me.Label7)
        Me.gbManagerAccount.Controls.Add(Me.lblErrorContact)
        Me.gbManagerAccount.Controls.Add(Me.Label5)
        Me.gbManagerAccount.Controls.Add(Me.Label2)
        Me.gbManagerAccount.Controls.Add(Me.Label1)
        Me.gbManagerAccount.Controls.Add(Me.btnCancel)
        Me.gbManagerAccount.Controls.Add(Me.btnNext)
        Me.gbManagerAccount.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbManagerAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbManagerAccount.Location = New System.Drawing.Point(265, 84)
        Me.gbManagerAccount.Name = "gbManagerAccount"
        Me.gbManagerAccount.Size = New System.Drawing.Size(499, 486)
        Me.gbManagerAccount.TabIndex = 25
        Me.gbManagerAccount.TabStop = False
        Me.gbManagerAccount.Text = "Manager Account"
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(180, 95)
        Me.txtContactNo.MaxLength = 11
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(274, 24)
        Me.txtContactNo.TabIndex = 64
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Location = New System.Drawing.Point(177, 66)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(20, 18)
        Me.lblIC.TabIndex = 63
        Me.lblIC.Text = "IC"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(177, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(40, 18)
        Me.lblName.TabIndex = 62
        Me.lblName.Text = "Name"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Checked = True
        Me.radNo.Location = New System.Drawing.Point(289, 223)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(42, 22)
        Me.radNo.TabIndex = 61
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(180, 221)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(46, 22)
        Me.radYes.TabIndex = 60
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 18)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Change Password*"
        '
        'gpChangePassword
        '
        Me.gpChangePassword.BackColor = System.Drawing.SystemColors.Control
        Me.gpChangePassword.Controls.Add(Me.Label9)
        Me.gpChangePassword.Controls.Add(Me.lblErrorExisting)
        Me.gpChangePassword.Controls.Add(Me.txtExistPassword)
        Me.gpChangePassword.Controls.Add(Me.lblErrorConfirmPassword)
        Me.gpChangePassword.Controls.Add(Me.lblErrorPassword)
        Me.gpChangePassword.Controls.Add(Me.txtConfirmPassword)
        Me.gpChangePassword.Controls.Add(Me.txtPassword)
        Me.gpChangePassword.Controls.Add(Me.Label4)
        Me.gpChangePassword.Controls.Add(Me.Label3)
        Me.gpChangePassword.Enabled = False
        Me.gpChangePassword.Location = New System.Drawing.Point(30, 249)
        Me.gpChangePassword.Name = "gpChangePassword"
        Me.gpChangePassword.Size = New System.Drawing.Size(434, 179)
        Me.gpChangePassword.TabIndex = 58
        Me.gpChangePassword.TabStop = False
        Me.gpChangePassword.Text = "Set Account Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 18)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "New Password"
        '
        'lblErrorExisting
        '
        Me.lblErrorExisting.AutoSize = True
        Me.lblErrorExisting.ForeColor = System.Drawing.Color.Red
        Me.lblErrorExisting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblErrorExisting.Location = New System.Drawing.Point(158, 45)
        Me.lblErrorExisting.Name = "lblErrorExisting"
        Me.lblErrorExisting.Size = New System.Drawing.Size(170, 18)
        Me.lblErrorExisting.TabIndex = 65
        Me.lblErrorExisting.Text = "*Incorrect Existing Password"
        Me.lblErrorExisting.Visible = False
        '
        'txtExistPassword
        '
        Me.txtExistPassword.Location = New System.Drawing.Point(156, 21)
        Me.txtExistPassword.Name = "txtExistPassword"
        Me.txtExistPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtExistPassword.Size = New System.Drawing.Size(165, 24)
        Me.txtExistPassword.TabIndex = 64
        '
        'lblErrorConfirmPassword
        '
        Me.lblErrorConfirmPassword.AutoSize = True
        Me.lblErrorConfirmPassword.ForeColor = System.Drawing.Color.Red
        Me.lblErrorConfirmPassword.Location = New System.Drawing.Point(161, 144)
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
        Me.lblErrorPassword.Location = New System.Drawing.Point(158, 93)
        Me.lblErrorPassword.Name = "lblErrorPassword"
        Me.lblErrorPassword.Size = New System.Drawing.Size(148, 18)
        Me.lblErrorPassword.TabIndex = 62
        Me.lblErrorPassword.Text = "*Please fill in access key"
        Me.lblErrorPassword.Visible = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Enabled = False
        Me.txtConfirmPassword.Location = New System.Drawing.Point(156, 114)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(165, 24)
        Me.txtConfirmPassword.TabIndex = 61
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(156, 66)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(165, 24)
        Me.txtPassword.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(180, 140)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(274, 24)
        Me.txtEmail.TabIndex = 55
        '
        'lblErrorEmail
        '
        Me.lblErrorEmail.AutoSize = True
        Me.lblErrorEmail.ForeColor = System.Drawing.Color.Red
        Me.lblErrorEmail.Location = New System.Drawing.Point(177, 167)
        Me.lblErrorEmail.Name = "lblErrorEmail"
        Me.lblErrorEmail.Size = New System.Drawing.Size(120, 18)
        Me.lblErrorEmail.TabIndex = 45
        Me.lblErrorEmail.Text = "*Please fill in email"
        Me.lblErrorEmail.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Email*"
        '
        'lblErrorContact
        '
        Me.lblErrorContact.AutoSize = True
        Me.lblErrorContact.ForeColor = System.Drawing.Color.Red
        Me.lblErrorContact.Location = New System.Drawing.Point(177, 119)
        Me.lblErrorContact.Name = "lblErrorContact"
        Me.lblErrorContact.Size = New System.Drawing.Size(174, 18)
        Me.lblErrorContact.TabIndex = 42
        Me.lblErrorContact.Text = "*Please fill in contact number"
        Me.lblErrorContact.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Contact No.*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "IC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Name"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(365, 444)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Location = New System.Drawing.Point(240, 444)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 36)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Text = "&MODIFY"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(250, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 36)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Manage Account"
        '
        'StaffManageAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 582)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbManagerAccount)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffManageAccount"
        Me.Text = "StaffManageAccount"
        Me.gbManagerAccount.ResumeLayout(False)
        Me.gbManagerAccount.PerformLayout()
        Me.gpChangePassword.ResumeLayout(False)
        Me.gpChangePassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents gbManagerAccount As GroupBox
    Friend WithEvents lblIC As Label
    Friend WithEvents lblName As Label
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents gpChangePassword As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblErrorExisting As Label
    Friend WithEvents txtExistPassword As TextBox
    Friend WithEvents lblErrorConfirmPassword As Label
    Friend WithEvents lblErrorPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblErrorEmail As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblErrorContact As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
End Class
