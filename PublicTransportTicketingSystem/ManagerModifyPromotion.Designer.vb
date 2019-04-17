<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerModifyPromotion
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
        Me.gbModifyPromotion = New System.Windows.Forms.GroupBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.gpDiscount = New System.Windows.Forms.GroupBox()
        Me.radFullDiscount = New System.Windows.Forms.RadioButton()
        Me.radCustomDiscount = New System.Windows.Forms.RadioButton()
        Me.nupCustomDiscount = New System.Windows.Forms.NumericUpDown()
        Me.lblErrorName = New System.Windows.Forms.Label()
        Me.txtPromotionName = New System.Windows.Forms.TextBox()
        Me.lstSchedule = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTransport = New System.Windows.Forms.Label()
        Me.lblPromotionDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPromotionID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPromotionDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbModifyPromotion.SuspendLayout()
        Me.gpDiscount.SuspendLayout()
        CType(Me.nupCustomDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbModifyPromotion
        '
        Me.gbModifyPromotion.BackColor = System.Drawing.SystemColors.Control
        Me.gbModifyPromotion.Controls.Add(Me.lblCount)
        Me.gbModifyPromotion.Controls.Add(Me.gpDiscount)
        Me.gbModifyPromotion.Controls.Add(Me.lblErrorName)
        Me.gbModifyPromotion.Controls.Add(Me.txtPromotionName)
        Me.gbModifyPromotion.Controls.Add(Me.lstSchedule)
        Me.gbModifyPromotion.Controls.Add(Me.Label6)
        Me.gbModifyPromotion.Controls.Add(Me.lblTransport)
        Me.gbModifyPromotion.Controls.Add(Me.lblPromotionDate)
        Me.gbModifyPromotion.Controls.Add(Me.Label5)
        Me.gbModifyPromotion.Controls.Add(Me.lblPromotionID)
        Me.gbModifyPromotion.Controls.Add(Me.Label3)
        Me.gbModifyPromotion.Controls.Add(Me.txtPromotionDesc)
        Me.gbModifyPromotion.Controls.Add(Me.Label2)
        Me.gbModifyPromotion.Controls.Add(Me.Label1)
        Me.gbModifyPromotion.Controls.Add(Me.btnCancel)
        Me.gbModifyPromotion.Controls.Add(Me.btnUpdate)
        Me.gbModifyPromotion.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbModifyPromotion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbModifyPromotion.Location = New System.Drawing.Point(252, 85)
        Me.gbModifyPromotion.Name = "gbModifyPromotion"
        Me.gbModifyPromotion.Size = New System.Drawing.Size(520, 482)
        Me.gbModifyPromotion.TabIndex = 0
        Me.gbModifyPromotion.TabStop = False
        Me.gbModifyPromotion.Text = "Modify Promotion"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(26, 382)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(69, 18)
        Me.lblCount.TabIndex = 54
        Me.lblCount.Text = "X record(s)"
        '
        'gpDiscount
        '
        Me.gpDiscount.Controls.Add(Me.radFullDiscount)
        Me.gpDiscount.Controls.Add(Me.radCustomDiscount)
        Me.gpDiscount.Controls.Add(Me.nupCustomDiscount)
        Me.gpDiscount.Location = New System.Drawing.Point(303, 99)
        Me.gpDiscount.Name = "gpDiscount"
        Me.gpDiscount.Size = New System.Drawing.Size(200, 117)
        Me.gpDiscount.TabIndex = 5
        Me.gpDiscount.TabStop = False
        Me.gpDiscount.Text = "Discount"
        '
        'radFullDiscount
        '
        Me.radFullDiscount.AutoSize = True
        Me.radFullDiscount.Location = New System.Drawing.Point(10, 23)
        Me.radFullDiscount.Name = "radFullDiscount"
        Me.radFullDiscount.Size = New System.Drawing.Size(127, 22)
        Me.radFullDiscount.TabIndex = 0
        Me.radFullDiscount.TabStop = True
        Me.radFullDiscount.Text = "Free Ride / Board"
        Me.radFullDiscount.UseVisualStyleBackColor = True
        '
        'radCustomDiscount
        '
        Me.radCustomDiscount.AutoSize = True
        Me.radCustomDiscount.Location = New System.Drawing.Point(10, 51)
        Me.radCustomDiscount.Name = "radCustomDiscount"
        Me.radCustomDiscount.Size = New System.Drawing.Size(140, 22)
        Me.radCustomDiscount.TabIndex = 1
        Me.radCustomDiscount.TabStop = True
        Me.radCustomDiscount.Text = "Custom Set Discount"
        Me.radCustomDiscount.UseVisualStyleBackColor = True
        '
        'nupCustomDiscount
        '
        Me.nupCustomDiscount.Enabled = False
        Me.nupCustomDiscount.Location = New System.Drawing.Point(31, 79)
        Me.nupCustomDiscount.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nupCustomDiscount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupCustomDiscount.Name = "nupCustomDiscount"
        Me.nupCustomDiscount.Size = New System.Drawing.Size(59, 24)
        Me.nupCustomDiscount.TabIndex = 2
        Me.nupCustomDiscount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupCustomDiscount.Visible = False
        '
        'lblErrorName
        '
        Me.lblErrorName.AutoSize = True
        Me.lblErrorName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorName.Location = New System.Drawing.Point(302, 68)
        Me.lblErrorName.Name = "lblErrorName"
        Me.lblErrorName.Size = New System.Drawing.Size(140, 18)
        Me.lblErrorName.TabIndex = 50
        Me.lblErrorName.Text = "*Please fill in the name"
        Me.lblErrorName.Visible = False
        '
        'txtPromotionName
        '
        Me.txtPromotionName.Location = New System.Drawing.Point(302, 41)
        Me.txtPromotionName.Name = "txtPromotionName"
        Me.txtPromotionName.Size = New System.Drawing.Size(156, 24)
        Me.txtPromotionName.TabIndex = 4
        '
        'lstSchedule
        '
        Me.lstSchedule.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSchedule.FormattingEnabled = True
        Me.lstSchedule.ItemHeight = 17
        Me.lstSchedule.Location = New System.Drawing.Point(28, 171)
        Me.lstSchedule.Name = "lstSchedule"
        Me.lstSchedule.Size = New System.Drawing.Size(229, 208)
        Me.lstSchedule.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Promotion Name"
        '
        'lblTransport
        '
        Me.lblTransport.AutoSize = True
        Me.lblTransport.Location = New System.Drawing.Point(26, 150)
        Me.lblTransport.Name = "lblTransport"
        Me.lblTransport.Size = New System.Drawing.Size(62, 18)
        Me.lblTransport.TabIndex = 1
        Me.lblTransport.Text = "Transport"
        '
        'lblPromotionDate
        '
        Me.lblPromotionDate.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotionDate.Location = New System.Drawing.Point(26, 105)
        Me.lblPromotionDate.Name = "lblPromotionDate"
        Me.lblPromotionDate.Size = New System.Drawing.Size(168, 18)
        Me.lblPromotionDate.TabIndex = 41
        Me.lblPromotionDate.Text = "Name*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 38
        '
        'lblPromotionID
        '
        Me.lblPromotionID.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotionID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPromotionID.Location = New System.Drawing.Point(26, 51)
        Me.lblPromotionID.Name = "lblPromotionID"
        Me.lblPromotionID.Size = New System.Drawing.Size(152, 19)
        Me.lblPromotionID.TabIndex = 37
        Me.lblPromotionID.Text = "Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Promotion ID"
        '
        'txtPromotionDesc
        '
        Me.txtPromotionDesc.Location = New System.Drawing.Point(302, 257)
        Me.txtPromotionDesc.Multiline = True
        Me.txtPromotionDesc.Name = "txtPromotionDesc"
        Me.txtPromotionDesc.Size = New System.Drawing.Size(206, 125)
        Me.txtPromotionDesc.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Description (Optional)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Date"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(374, 424)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(238, 424)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 36)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 579)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(246, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 36)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Update Promotion Details"
        '
        'ManagerModifyPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 579)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbModifyPromotion)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerModifyPromotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerModifyPromotion"
        Me.gbModifyPromotion.ResumeLayout(False)
        Me.gbModifyPromotion.PerformLayout()
        Me.gpDiscount.ResumeLayout(False)
        Me.gpDiscount.PerformLayout()
        CType(Me.nupCustomDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents gbModifyPromotion As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPromotionID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPromotionDesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblTransport As Label
    Friend WithEvents lblPromotionDate As Label
    Friend WithEvents lstSchedule As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nupCustomDiscount As NumericUpDown
    Friend WithEvents radCustomDiscount As RadioButton
    Friend WithEvents radFullDiscount As RadioButton
    Friend WithEvents lblErrorName As Label
    Friend WithEvents txtPromotionName As TextBox
    Friend WithEvents gpDiscount As GroupBox
    Friend WithEvents lblCount As Label
    Friend WithEvents Label4 As Label
End Class
