<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerViewPromotion
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.btnCreatePromotionPage = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionSchedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promoteDateRange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promotionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPromotionID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dpPromotionDate = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.gbBus = New System.Windows.Forms.GroupBox()
        Me.TranportSelection1 = New PublicTransportTicketingSystem.TranportSelection()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBus.SuspendLayout()
        Me.SuspendLayout()
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'btnCreatePromotionPage
        '
        Me.btnCreatePromotionPage.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnCreatePromotionPage.AutoEllipsis = True
        Me.btnCreatePromotionPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreatePromotionPage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePromotionPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCreatePromotionPage.Location = New System.Drawing.Point(532, 526)
        Me.btnCreatePromotionPage.Name = "btnCreatePromotionPage"
        Me.btnCreatePromotionPage.Size = New System.Drawing.Size(244, 28)
        Me.btnCreatePromotionPage.TabIndex = 38
        Me.btnCreatePromotionPage.Text = "CREATE PROMOTION"
        Me.btnCreatePromotionPage.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.promotionID, Me.promoteDateRange, Me.eventName, Me.PromotionSchedule, Me.Discount})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(494, 133)
        Me.DataGridView1.TabIndex = 0
        '
        'Discount
        '
        Me.Discount.HeaderText = "Discount"
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        Me.Discount.Width = 80
        '
        'PromotionSchedule
        '
        Me.PromotionSchedule.HeaderText = "Schedule"
        Me.PromotionSchedule.Name = "PromotionSchedule"
        Me.PromotionSchedule.ReadOnly = True
        '
        'eventName
        '
        Me.eventName.HeaderText = "Event Name"
        Me.eventName.Name = "eventName"
        Me.eventName.ReadOnly = True
        Me.eventName.Width = 120
        '
        'promoteDateRange
        '
        Me.promoteDateRange.HeaderText = "Date"
        Me.promoteDateRange.Name = "promoteDateRange"
        Me.promoteDateRange.ReadOnly = True
        Me.promoteDateRange.Width = 80
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
        'txtPromotionID
        '
        Me.txtPromotionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromotionID.ForeColor = System.Drawing.Color.Black
        Me.txtPromotionID.Location = New System.Drawing.Point(145, 65)
        Me.txtPromotionID.Name = "txtPromotionID"
        Me.txtPromotionID.Size = New System.Drawing.Size(214, 20)
        Me.txtPromotionID.TabIndex = 9
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
        'dpPromotionDate
        '
        Me.dpPromotionDate.Location = New System.Drawing.Point(145, 25)
        Me.dpPromotionDate.MinDate = New Date(2019, 3, 24, 0, 0, 0, 0)
        Me.dpPromotionDate.Name = "dpPromotionDate"
        Me.dpPromotionDate.Size = New System.Drawing.Size(214, 24)
        Me.dpPromotionDate.TabIndex = 12
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
        Me.gbBus.Location = New System.Drawing.Point(240, 223)
        Me.gbBus.Name = "gbBus"
        Me.gbBus.Size = New System.Drawing.Size(536, 297)
        Me.gbBus.TabIndex = 27
        Me.gbBus.TabStop = False
        Me.gbBus.Text = "Bus Promotion"
        '
        'TranportSelection1
        '
        Me.TranportSelection1.Location = New System.Drawing.Point(239, 96)
        Me.TranportSelection1.Name = "TranportSelection1"
        Me.TranportSelection1.Size = New System.Drawing.Size(537, 104)
        Me.TranportSelection1.TabIndex = 39
        '
        'ManagerViewPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.TranportSelection1)
        Me.Controls.Add(Me.btnCreatePromotionPage)
        Me.Controls.Add(Me.gbBus)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerViewPromotion"
        Me.Text = "ManagerViewPromotion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBus.ResumeLayout(False)
        Me.gbBus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents btnCreatePromotionPage As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents promotionID As DataGridViewTextBoxColumn
    Friend WithEvents promoteDateRange As DataGridViewTextBoxColumn
    Friend WithEvents eventName As DataGridViewTextBoxColumn
    Friend WithEvents PromotionSchedule As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPromotionID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dpPromotionDate As DateTimePicker
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents gbBus As GroupBox
    Friend WithEvents TranportSelection1 As TranportSelection
End Class
