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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pbFerry = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbBus = New System.Windows.Forms.PictureBox()
        Me.pbTrain = New System.Windows.Forms.PictureBox()
        Me.lblTrainPromotion = New System.Windows.Forms.Label()
        Me.lblFerryPromotion = New System.Windows.Forms.Label()
        Me.lblBusPromotion = New System.Windows.Forms.Label()
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
        Me.btnCreatePromotionPage = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbFerry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBus.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTrainPromotion)
        Me.GroupBox1.Controls.Add(Me.lblFerryPromotion)
        Me.GroupBox1.Controls.Add(Me.lblBusPromotion)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.pbFerry)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.pbBus)
        Me.GroupBox1.Controls.Add(Me.pbTrain)
        Me.GroupBox1.Location = New System.Drawing.Point(239, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 104)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a tranport type,"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(431, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'pbFerry
        '
        Me.pbFerry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFerry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFerry.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.ferry
        Me.pbFerry.Location = New System.Drawing.Point(136, 18)
        Me.pbFerry.Name = "pbFerry"
        Me.pbFerry.Size = New System.Drawing.Size(60, 51)
        Me.pbFerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFerry.TabIndex = 20
        Me.pbFerry.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selected Transport:"
        '
        'pbBus
        '
        Me.pbBus.BackColor = System.Drawing.SystemColors.Control
        Me.pbBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBus.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.bus
        Me.pbBus.Location = New System.Drawing.Point(248, 18)
        Me.pbBus.Name = "pbBus"
        Me.pbBus.Size = New System.Drawing.Size(58, 50)
        Me.pbBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBus.TabIndex = 19
        Me.pbBus.TabStop = False
        '
        'pbTrain
        '
        Me.pbTrain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbTrain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbTrain.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.train
        Me.pbTrain.Location = New System.Drawing.Point(29, 18)
        Me.pbTrain.Name = "pbTrain"
        Me.pbTrain.Size = New System.Drawing.Size(60, 51)
        Me.pbTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTrain.TabIndex = 18
        Me.pbTrain.TabStop = False
        Me.pbTrain.Tag = "Train"
        '
        'lblTrainPromotion
        '
        Me.lblTrainPromotion.BackColor = System.Drawing.Color.Transparent
        Me.lblTrainPromotion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainPromotion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTrainPromotion.Location = New System.Drawing.Point(13, 72)
        Me.lblTrainPromotion.Name = "lblTrainPromotion"
        Me.lblTrainPromotion.Size = New System.Drawing.Size(76, 24)
        Me.lblTrainPromotion.TabIndex = 32
        Me.lblTrainPromotion.Text = "TRAIN"
        Me.lblTrainPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFerryPromotion
        '
        Me.lblFerryPromotion.BackColor = System.Drawing.Color.Transparent
        Me.lblFerryPromotion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFerryPromotion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblFerryPromotion.Location = New System.Drawing.Point(132, 72)
        Me.lblFerryPromotion.Name = "lblFerryPromotion"
        Me.lblFerryPromotion.Size = New System.Drawing.Size(75, 24)
        Me.lblFerryPromotion.TabIndex = 31
        Me.lblFerryPromotion.Text = "FERRY"
        Me.lblFerryPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBusPromotion
        '
        Me.lblBusPromotion.BackColor = System.Drawing.Color.Transparent
        Me.lblBusPromotion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusPromotion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblBusPromotion.Location = New System.Drawing.Point(244, 72)
        Me.lblBusPromotion.Name = "lblBusPromotion"
        Me.lblBusPromotion.Size = New System.Drawing.Size(66, 24)
        Me.lblBusPromotion.TabIndex = 30
        Me.lblBusPromotion.Text = "BUS"
        Me.lblBusPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'ManagerViewPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.btnCreatePromotionPage)
        Me.Controls.Add(Me.gbBus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerViewPromotion"
        Me.Text = "ManagerViewPromotion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbFerry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTrain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBus.ResumeLayout(False)
        Me.gbBus.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTrainPromotion As Label
    Friend WithEvents lblFerryPromotion As Label
    Friend WithEvents lblBusPromotion As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pbFerry As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbBus As PictureBox
    Friend WithEvents pbTrain As PictureBox
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
    Friend WithEvents btnCreatePromotionPage As Button
End Class
