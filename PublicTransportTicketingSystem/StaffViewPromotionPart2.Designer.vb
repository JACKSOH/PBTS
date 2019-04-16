<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffViewPromotionPart2
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbSchedulePromotion = New System.Windows.Forms.GroupBox()
        Me.lblTransport = New System.Windows.Forms.Label()
        Me.dgvPromotionList = New System.Windows.Forms.DataGridView()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPromotionDesc = New System.Windows.Forms.Label()
        Me.lblPromotionName = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPromotionDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPromotionID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.gbSchedulePromotion.SuspendLayout()
        CType(Me.dgvPromotionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSchedulePromotion
        '
        Me.gbSchedulePromotion.BackColor = System.Drawing.SystemColors.Control
        Me.gbSchedulePromotion.Controls.Add(Me.lblTransport)
        Me.gbSchedulePromotion.Controls.Add(Me.dgvPromotionList)
        Me.gbSchedulePromotion.Controls.Add(Me.lblDiscount)
        Me.gbSchedulePromotion.Controls.Add(Me.Label7)
        Me.gbSchedulePromotion.Controls.Add(Me.lblPromotionDesc)
        Me.gbSchedulePromotion.Controls.Add(Me.lblPromotionName)
        Me.gbSchedulePromotion.Controls.Add(Me.lblCount)
        Me.gbSchedulePromotion.Controls.Add(Me.Label6)
        Me.gbSchedulePromotion.Controls.Add(Me.lblPromotionDate)
        Me.gbSchedulePromotion.Controls.Add(Me.Label5)
        Me.gbSchedulePromotion.Controls.Add(Me.lblPromotionID)
        Me.gbSchedulePromotion.Controls.Add(Me.Label3)
        Me.gbSchedulePromotion.Controls.Add(Me.Label2)
        Me.gbSchedulePromotion.Controls.Add(Me.Label1)
        Me.gbSchedulePromotion.Controls.Add(Me.btnDone)
        Me.gbSchedulePromotion.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSchedulePromotion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbSchedulePromotion.Location = New System.Drawing.Point(12, 12)
        Me.gbSchedulePromotion.Name = "gbSchedulePromotion"
        Me.gbSchedulePromotion.Size = New System.Drawing.Size(520, 438)
        Me.gbSchedulePromotion.TabIndex = 24
        Me.gbSchedulePromotion.TabStop = False
        Me.gbSchedulePromotion.Text = "Promotion Details"
        '
        'lblTransport
        '
        Me.lblTransport.AutoSize = True
        Me.lblTransport.Location = New System.Drawing.Point(26, 193)
        Me.lblTransport.Name = "lblTransport"
        Me.lblTransport.Size = New System.Drawing.Size(61, 18)
        Me.lblTransport.TabIndex = 60
        Me.lblTransport.Text = "Schedule "
        '
        'dgvPromotionList
        '
        Me.dgvPromotionList.AllowUserToAddRows = False
        Me.dgvPromotionList.AllowUserToDeleteRows = False
        Me.dgvPromotionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPromotionList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPromotionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromotionList.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPromotionList.Location = New System.Drawing.Point(24, 214)
        Me.dgvPromotionList.Name = "dgvPromotionList"
        Me.dgvPromotionList.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvPromotionList.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPromotionList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvPromotionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPromotionList.Size = New System.Drawing.Size(386, 133)
        Me.dgvPromotionList.TabIndex = 59
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(186, 147)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(168, 18)
        Me.lblDiscount.TabIndex = 58
        Me.lblDiscount.Text = "Discount*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Discount"
        '
        'lblPromotionDesc
        '
        Me.lblPromotionDesc.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotionDesc.Location = New System.Drawing.Point(186, 118)
        Me.lblPromotionDesc.Name = "lblPromotionDesc"
        Me.lblPromotionDesc.Size = New System.Drawing.Size(317, 18)
        Me.lblPromotionDesc.TabIndex = 56
        Me.lblPromotionDesc.Text = "Desc*"
        '
        'lblPromotionName
        '
        Me.lblPromotionName.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotionName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPromotionName.Location = New System.Drawing.Point(186, 61)
        Me.lblPromotionName.Name = "lblPromotionName"
        Me.lblPromotionName.Size = New System.Drawing.Size(152, 19)
        Me.lblPromotionName.TabIndex = 55
        Me.lblPromotionName.Text = "Name*"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(25, 350)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(69, 18)
        Me.lblCount.TabIndex = 54
        Me.lblCount.Text = "X record(s)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Promotion Name"
        '
        'lblPromotionDate
        '
        Me.lblPromotionDate.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotionDate.Location = New System.Drawing.Point(186, 89)
        Me.lblPromotionDate.Name = "lblPromotionDate"
        Me.lblPromotionDate.Size = New System.Drawing.Size(317, 18)
        Me.lblPromotionDate.TabIndex = 41
        Me.lblPromotionDate.Text = "Date*"
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
        Me.lblPromotionID.Location = New System.Drawing.Point(186, 33)
        Me.lblPromotionID.Name = "lblPromotionID"
        Me.lblPromotionID.Size = New System.Drawing.Size(152, 19)
        Me.lblPromotionID.TabIndex = 37
        Me.lblPromotionID.Text = "ID*"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Description (Optional)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Date"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Lime
        Me.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDone.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDone.Location = New System.Drawing.Point(214, 376)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(100, 36)
        Me.btnDone.TabIndex = 29
        Me.btnDone.Text = "&DONE"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'StaffViewPromotionPart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 445)
        Me.Controls.Add(Me.gbSchedulePromotion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffViewPromotionPart2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffViewPromotionPart2"
        Me.gbSchedulePromotion.ResumeLayout(False)
        Me.gbSchedulePromotion.PerformLayout()
        CType(Me.dgvPromotionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSchedulePromotion As GroupBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPromotionDesc As Label
    Friend WithEvents lblPromotionName As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPromotionDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPromotionID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents lblTransport As Label
    Friend WithEvents dgvPromotionList As DataGridView
End Class
