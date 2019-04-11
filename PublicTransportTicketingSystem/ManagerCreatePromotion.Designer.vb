<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerCreatePromotion
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
        Me.gbCreatePromotion = New System.Windows.Forms.GroupBox()
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.txtPromotionDesc = New System.Windows.Forms.TextBox()
        Me.txtPromotionName = New System.Windows.Forms.TextBox()
        Me.gbPromotionDate = New System.Windows.Forms.GroupBox()
        Me.gpDiscountRate = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dpPromotionStartDate = New System.Windows.Forms.DateTimePicker()
        Me.nupPromotionDuration = New System.Windows.Forms.NumericUpDown()
        Me.radFullDiscount = New System.Windows.Forms.RadioButton()
        Me.radCustomDiscount = New System.Windows.Forms.RadioButton()
        Me.nupCustomDiscount = New System.Windows.Forms.NumericUpDown()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.gbCreatePromotion.SuspendLayout()
        Me.gbPromotionDate.SuspendLayout()
        Me.gpDiscountRate.SuspendLayout()
        CType(Me.nupPromotionDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCustomDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCreatePromotion
        '
        Me.gbCreatePromotion.BackColor = System.Drawing.SystemColors.Control
        Me.gbCreatePromotion.Controls.Add(Me.ErrorName)
        Me.gbCreatePromotion.Controls.Add(Me.txtPromotionDesc)
        Me.gbCreatePromotion.Controls.Add(Me.txtPromotionName)
        Me.gbCreatePromotion.Controls.Add(Me.gbPromotionDate)
        Me.gbCreatePromotion.Controls.Add(Me.gpDiscountRate)
        Me.gbCreatePromotion.Controls.Add(Me.Label2)
        Me.gbCreatePromotion.Controls.Add(Me.Label1)
        Me.gbCreatePromotion.Controls.Add(Me.btnCancel)
        Me.gbCreatePromotion.Controls.Add(Me.btnNext)
        Me.gbCreatePromotion.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCreatePromotion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbCreatePromotion.Location = New System.Drawing.Point(266, 92)
        Me.gbCreatePromotion.Name = "gbCreatePromotion"
        Me.gbCreatePromotion.Size = New System.Drawing.Size(499, 440)
        Me.gbCreatePromotion.TabIndex = 22
        Me.gbCreatePromotion.TabStop = False
        Me.gbCreatePromotion.Text = "Add New Promotion"
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(157, 62)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(181, 18)
        Me.ErrorName.TabIndex = 36
        Me.ErrorName.Text = "*Please fill in promotion name"
        Me.ErrorName.Visible = False
        '
        'txtPromotionDesc
        '
        Me.txtPromotionDesc.Location = New System.Drawing.Point(160, 91)
        Me.txtPromotionDesc.Multiline = True
        Me.txtPromotionDesc.Name = "txtPromotionDesc"
        Me.txtPromotionDesc.Size = New System.Drawing.Size(314, 70)
        Me.txtPromotionDesc.TabIndex = 35
        '
        'txtPromotionName
        '
        Me.txtPromotionName.Location = New System.Drawing.Point(160, 35)
        Me.txtPromotionName.Name = "txtPromotionName"
        Me.txtPromotionName.Size = New System.Drawing.Size(314, 24)
        Me.txtPromotionName.TabIndex = 34
        '
        'gbPromotionDate
        '
        Me.gbPromotionDate.Controls.Add(Me.nupPromotionDuration)
        Me.gbPromotionDate.Controls.Add(Me.dpPromotionStartDate)
        Me.gbPromotionDate.Controls.Add(Me.Label5)
        Me.gbPromotionDate.Controls.Add(Me.Label4)
        Me.gbPromotionDate.Location = New System.Drawing.Point(16, 180)
        Me.gbPromotionDate.Name = "gbPromotionDate"
        Me.gbPromotionDate.Size = New System.Drawing.Size(232, 159)
        Me.gbPromotionDate.TabIndex = 33
        Me.gbPromotionDate.TabStop = False
        Me.gbPromotionDate.Text = "Date"
        '
        'gpDiscountRate
        '
        Me.gpDiscountRate.Controls.Add(Me.nupCustomDiscount)
        Me.gpDiscountRate.Controls.Add(Me.radCustomDiscount)
        Me.gpDiscountRate.Controls.Add(Me.radFullDiscount)
        Me.gpDiscountRate.Location = New System.Drawing.Point(270, 190)
        Me.gpDiscountRate.Name = "gpDiscountRate"
        Me.gpDiscountRate.Size = New System.Drawing.Size(204, 159)
        Me.gpDiscountRate.TabIndex = 32
        Me.gpDiscountRate.TabStop = False
        Me.gpDiscountRate.Text = "Discount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Description (Optional)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Name*"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(374, 378)
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
        Me.btnNext.Location = New System.Drawing.Point(238, 378)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 36)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Starting Date*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Duration (Days)*"
        '
        'dpPromotionStartDate
        '
        Me.dpPromotionStartDate.Location = New System.Drawing.Point(6, 54)
        Me.dpPromotionStartDate.MinDate = New Date(2019, 4, 11, 0, 0, 0, 0)
        Me.dpPromotionStartDate.Name = "dpPromotionStartDate"
        Me.dpPromotionStartDate.Size = New System.Drawing.Size(217, 24)
        Me.dpPromotionStartDate.TabIndex = 39
        Me.dpPromotionStartDate.Value = New Date(2019, 4, 11, 12, 30, 3, 0)
        '
        'nupPromotionDuration
        '
        Me.nupPromotionDuration.Location = New System.Drawing.Point(9, 114)
        Me.nupPromotionDuration.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nupPromotionDuration.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupPromotionDuration.Name = "nupPromotionDuration"
        Me.nupPromotionDuration.Size = New System.Drawing.Size(59, 24)
        Me.nupPromotionDuration.TabIndex = 40
        Me.nupPromotionDuration.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'radFullDiscount
        '
        Me.radFullDiscount.AutoSize = True
        Me.radFullDiscount.Checked = True
        Me.radFullDiscount.Location = New System.Drawing.Point(18, 44)
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
        Me.radCustomDiscount.Location = New System.Drawing.Point(18, 82)
        Me.radCustomDiscount.Name = "radCustomDiscount"
        Me.radCustomDiscount.Size = New System.Drawing.Size(112, 22)
        Me.radCustomDiscount.TabIndex = 1
        Me.radCustomDiscount.Text = "Custom Set (%)"
        Me.radCustomDiscount.UseVisualStyleBackColor = True
        '
        'nupCustomDiscount
        '
        Me.nupCustomDiscount.Enabled = False
        Me.nupCustomDiscount.Location = New System.Drawing.Point(38, 110)
        Me.nupCustomDiscount.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nupCustomDiscount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupCustomDiscount.Name = "nupCustomDiscount"
        Me.nupCustomDiscount.Size = New System.Drawing.Size(59, 24)
        Me.nupCustomDiscount.TabIndex = 41
        Me.nupCustomDiscount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'ManagerCreatePromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.gbCreatePromotion)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerCreatePromotion"
        Me.Text = "ManagerCreatePromotion"
        Me.gbCreatePromotion.ResumeLayout(False)
        Me.gbCreatePromotion.PerformLayout()
        Me.gbPromotionDate.ResumeLayout(False)
        Me.gbPromotionDate.PerformLayout()
        Me.gpDiscountRate.ResumeLayout(False)
        Me.gpDiscountRate.PerformLayout()
        CType(Me.nupPromotionDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCustomDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents gbCreatePromotion As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents ErrorName As Label
    Friend WithEvents txtPromotionDesc As TextBox
    Friend WithEvents txtPromotionName As TextBox
    Friend WithEvents gbPromotionDate As GroupBox
    Friend WithEvents gpDiscountRate As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nupPromotionDuration As NumericUpDown
    Friend WithEvents dpPromotionStartDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nupCustomDiscount As NumericUpDown
    Friend WithEvents radCustomDiscount As RadioButton
    Friend WithEvents radFullDiscount As RadioButton
End Class
