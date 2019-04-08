<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffViewPromotion
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCreatePromotionPage = New System.Windows.Forms.Button()
        Me.gbBus = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dpPromotionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPromotionID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.promotionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promoteDateRange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionSchedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.TranportSelection1 = New PublicTransportTicketingSystem.TranportSelection()
        Me.gbBus.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreatePromotionPage
        '
        Me.btnCreatePromotionPage.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnCreatePromotionPage.AutoEllipsis = True
        Me.btnCreatePromotionPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreatePromotionPage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePromotionPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCreatePromotionPage.Location = New System.Drawing.Point(535, 522)
        Me.btnCreatePromotionPage.Name = "btnCreatePromotionPage"
        Me.btnCreatePromotionPage.Size = New System.Drawing.Size(244, 28)
        Me.btnCreatePromotionPage.TabIndex = 41
        Me.btnCreatePromotionPage.Text = "CREATE PROMOTION"
        Me.btnCreatePromotionPage.UseVisualStyleBackColor = False
        '
        'gbBus
        '
        Me.gbBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gbBus.Controls.Add(Me.btnRemove)
        Me.gbBus.Controls.Add(Me.btnUpdate)
        Me.gbBus.Controls.Add(Me.btnClear)
        Me.gbBus.Controls.Add(Me.dpPromotionDate)
        Me.gbBus.Controls.Add(Me.Label2)
        Me.gbBus.Controls.Add(Me.txtPromotionID)
        Me.gbBus.Controls.Add(Me.Label5)
        Me.gbBus.Controls.Add(Me.DataGridView1)
        Me.gbBus.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.gbBus.Location = New System.Drawing.Point(243, 219)
        Me.gbBus.Name = "gbBus"
        Me.gbBus.Size = New System.Drawing.Size(536, 297)
        Me.gbBus.TabIndex = 40
        Me.gbBus.TabStop = False
        Me.gbBus.Text = "Bus Promotion"
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemove.Location = New System.Drawing.Point(282, 253)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 28)
        Me.btnRemove.TabIndex = 36
        Me.btnRemove.Text = "&REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(415, 253)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "&MODIFY"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(415, 25)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "&CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dpPromotionDate
        '
        Me.dpPromotionDate.Location = New System.Drawing.Point(145, 25)
        Me.dpPromotionDate.MinDate = New Date(2019, 3, 24, 0, 0, 0, 0)
        Me.dpPromotionDate.Name = "dpPromotionDate"
        Me.dpPromotionDate.Size = New System.Drawing.Size(214, 24)
        Me.dpPromotionDate.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date"
        '
        'txtPromotionID
        '
        Me.txtPromotionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromotionID.ForeColor = System.Drawing.Color.Black
        Me.txtPromotionID.Location = New System.Drawing.Point(145, 65)
        Me.txtPromotionID.Name = "txtPromotionID"
        Me.txtPromotionID.Size = New System.Drawing.Size(214, 20)
        Me.txtPromotionID.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Promotion ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.promotionID, Me.promoteDateRange, Me.eventName, Me.PromotionSchedule, Me.Discount})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(494, 133)
        Me.DataGridView1.TabIndex = 0
        '
        'promotionID
        '
        Me.promotionID.Frozen = True
        Me.promotionID.HeaderText = "ID"
        Me.promotionID.MaxInputLength = 10
        Me.promotionID.Name = "promotionID"
        Me.promotionID.ReadOnly = True
        Me.promotionID.Width = 70
        '
        'promoteDateRange
        '
        Me.promoteDateRange.HeaderText = "Date"
        Me.promoteDateRange.Name = "promoteDateRange"
        Me.promoteDateRange.ReadOnly = True
        Me.promoteDateRange.Width = 80
        '
        'eventName
        '
        Me.eventName.HeaderText = "Event Name"
        Me.eventName.Name = "eventName"
        Me.eventName.ReadOnly = True
        Me.eventName.Width = 120
        '
        'PromotionSchedule
        '
        Me.PromotionSchedule.HeaderText = "Schedule"
        Me.PromotionSchedule.Name = "PromotionSchedule"
        Me.PromotionSchedule.ReadOnly = True
        '
        'Discount
        '
        Me.Discount.HeaderText = "Discount"
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        Me.Discount.Width = 80
        '
        'StaffMenuLayoutControl1
        '
        Me.StaffMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StaffMenuLayoutControl1.Name = "StaffMenuLayoutControl1"
        Me.StaffMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.StaffMenuLayoutControl1.TabIndex = 42
        '
        'TranportSelection1
        '
        Me.TranportSelection1.Location = New System.Drawing.Point(243, 90)
        Me.TranportSelection1.Name = "TranportSelection1"
        Me.TranportSelection1.Size = New System.Drawing.Size(537, 104)
        Me.TranportSelection1.TabIndex = 43
        '
        'StaffViewPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.TranportSelection1)
        Me.Controls.Add(Me.btnCreatePromotionPage)
        Me.Controls.Add(Me.gbBus)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffViewPromotion"
        Me.Text = "StaffViewPromotion"
        Me.gbBus.ResumeLayout(False)
        Me.gbBus.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreatePromotionPage As Button
    Friend WithEvents gbBus As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dpPromotionDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPromotionID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents promotionID As DataGridViewTextBoxColumn
    Friend WithEvents promoteDateRange As DataGridViewTextBoxColumn
    Friend WithEvents eventName As DataGridViewTextBoxColumn
    Friend WithEvents PromotionSchedule As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents TranportSelection1 As TranportSelection
End Class
