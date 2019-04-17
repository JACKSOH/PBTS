<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerCreateStaff
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
        Me.gbCreateStaff = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.MaskedTextBox()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblErrorAccess = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAccessKey = New System.Windows.Forms.TextBox()
        Me.radStaff = New System.Windows.Forms.RadioButton()
        Me.radManager = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblErrorEmail = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblErrorContact = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblErrorIC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblErrorName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbCreateStaff.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCreateStaff
        '
        Me.gbCreateStaff.BackColor = System.Drawing.SystemColors.Control
        Me.gbCreateStaff.Controls.Add(Me.GroupBox1)
        Me.gbCreateStaff.Controls.Add(Me.txtEmail)
        Me.gbCreateStaff.Controls.Add(Me.txtIC)
        Me.gbCreateStaff.Controls.Add(Me.txtContactNo)
        Me.gbCreateStaff.Controls.Add(Me.Label10)
        Me.gbCreateStaff.Controls.Add(Me.lblErrorAccess)
        Me.gbCreateStaff.Controls.Add(Me.Label9)
        Me.gbCreateStaff.Controls.Add(Me.txtAccessKey)
        Me.gbCreateStaff.Controls.Add(Me.radStaff)
        Me.gbCreateStaff.Controls.Add(Me.radManager)
        Me.gbCreateStaff.Controls.Add(Me.Label8)
        Me.gbCreateStaff.Controls.Add(Me.lblErrorEmail)
        Me.gbCreateStaff.Controls.Add(Me.Label7)
        Me.gbCreateStaff.Controls.Add(Me.lblErrorContact)
        Me.gbCreateStaff.Controls.Add(Me.Label5)
        Me.gbCreateStaff.Controls.Add(Me.lblErrorIC)
        Me.gbCreateStaff.Controls.Add(Me.Label2)
        Me.gbCreateStaff.Controls.Add(Me.lblErrorName)
        Me.gbCreateStaff.Controls.Add(Me.txtName)
        Me.gbCreateStaff.Controls.Add(Me.Label1)
        Me.gbCreateStaff.Controls.Add(Me.btnCancel)
        Me.gbCreateStaff.Controls.Add(Me.btnNext)
        Me.gbCreateStaff.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCreateStaff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbCreateStaff.Location = New System.Drawing.Point(265, 93)
        Me.gbCreateStaff.Name = "gbCreateStaff"
        Me.gbCreateStaff.Size = New System.Drawing.Size(499, 470)
        Me.gbCreateStaff.TabIndex = 0
        Me.gbCreateStaff.TabStop = False
        Me.gbCreateStaff.Text = "Add New Staff"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 42)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Checked = True
        Me.radFemale.Location = New System.Drawing.Point(22, 14)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(65, 22)
        Me.radFemale.TabIndex = 0
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(166, 14)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(54, 22)
        Me.radMale.TabIndex = 1
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(161, 296)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(314, 24)
        Me.txtEmail.TabIndex = 12
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(160, 177)
        Me.txtIC.Mask = "000000000000"
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(313, 24)
        Me.txtIC.TabIndex = 8
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(161, 237)
        Me.txtContactNo.Mask = "000-0000000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(313, 24)
        Me.txtContactNo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Gender*"
        '
        'lblErrorAccess
        '
        Me.lblErrorAccess.AutoSize = True
        Me.lblErrorAccess.Enabled = False
        Me.lblErrorAccess.ForeColor = System.Drawing.Color.Red
        Me.lblErrorAccess.Location = New System.Drawing.Point(157, 97)
        Me.lblErrorAccess.Name = "lblErrorAccess"
        Me.lblErrorAccess.Size = New System.Drawing.Size(148, 18)
        Me.lblErrorAccess.TabIndex = 50
        Me.lblErrorAccess.Text = "*Please fill in access key"
        Me.lblErrorAccess.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(28, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Access Key*"
        '
        'txtAccessKey
        '
        Me.txtAccessKey.Location = New System.Drawing.Point(159, 70)
        Me.txtAccessKey.Name = "txtAccessKey"
        Me.txtAccessKey.Size = New System.Drawing.Size(314, 24)
        Me.txtAccessKey.TabIndex = 4
        '
        'radStaff
        '
        Me.radStaff.AutoSize = True
        Me.radStaff.Location = New System.Drawing.Point(328, 33)
        Me.radStaff.Name = "radStaff"
        Me.radStaff.Size = New System.Drawing.Size(52, 22)
        Me.radStaff.TabIndex = 2
        Me.radStaff.Text = "Staff"
        Me.radStaff.UseVisualStyleBackColor = True
        '
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.Checked = True
        Me.radManager.Location = New System.Drawing.Point(160, 33)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(76, 22)
        Me.radManager.TabIndex = 1
        Me.radManager.TabStop = True
        Me.radManager.Text = "Manager"
        Me.radManager.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Type*"
        '
        'lblErrorEmail
        '
        Me.lblErrorEmail.AutoSize = True
        Me.lblErrorEmail.ForeColor = System.Drawing.Color.Red
        Me.lblErrorEmail.Location = New System.Drawing.Point(157, 320)
        Me.lblErrorEmail.Name = "lblErrorEmail"
        Me.lblErrorEmail.Size = New System.Drawing.Size(120, 18)
        Me.lblErrorEmail.TabIndex = 45
        Me.lblErrorEmail.Text = "*Please fill in email"
        Me.lblErrorEmail.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Email*"
        '
        'lblErrorContact
        '
        Me.lblErrorContact.AutoSize = True
        Me.lblErrorContact.ForeColor = System.Drawing.Color.Red
        Me.lblErrorContact.Location = New System.Drawing.Point(158, 261)
        Me.lblErrorContact.Name = "lblErrorContact"
        Me.lblErrorContact.Size = New System.Drawing.Size(174, 18)
        Me.lblErrorContact.TabIndex = 42
        Me.lblErrorContact.Text = "*Please fill in contact number"
        Me.lblErrorContact.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contact No.*"
        '
        'lblErrorIC
        '
        Me.lblErrorIC.AutoSize = True
        Me.lblErrorIC.ForeColor = System.Drawing.Color.Red
        Me.lblErrorIC.Location = New System.Drawing.Point(158, 204)
        Me.lblErrorIC.Name = "lblErrorIC"
        Me.lblErrorIC.Size = New System.Drawing.Size(101, 18)
        Me.lblErrorIC.TabIndex = 39
        Me.lblErrorIC.Text = "*Please fill in IC"
        Me.lblErrorIC.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "IC*"
        '
        'lblErrorName
        '
        Me.lblErrorName.AutoSize = True
        Me.lblErrorName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorName.Location = New System.Drawing.Point(158, 151)
        Me.lblErrorName.Name = "lblErrorName"
        Me.lblErrorName.Size = New System.Drawing.Size(119, 18)
        Me.lblErrorName.TabIndex = 36
        Me.lblErrorName.Text = "*Please fill in name"
        Me.lblErrorName.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(161, 124)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(314, 24)
        Me.txtName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name*"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(374, 414)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Location = New System.Drawing.Point(239, 414)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 36)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(-1, -1)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(278, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 36)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Manage Staff"
        '
        'ManagerCreateStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbCreateStaff)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerCreateStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerCreateStaff"
        Me.gbCreateStaff.ResumeLayout(False)
        Me.gbCreateStaff.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents gbCreateStaff As GroupBox
    Friend WithEvents lblErrorAccess As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAccessKey As TextBox
    Friend WithEvents radStaff As RadioButton
    Friend WithEvents radManager As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents lblErrorEmail As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblErrorContact As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblErrorIC As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblErrorName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtContactNo As MaskedTextBox
    Friend WithEvents txtIC As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
End Class
