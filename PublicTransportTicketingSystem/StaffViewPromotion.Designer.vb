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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbBus = New System.Windows.Forms.GroupBox()
        Me.dpPromotionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPromotionList = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.txtPromotion = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TranportSelection1 = New PublicTransportTicketingSystem.TranportSelection()
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbBus.SuspendLayout()
        CType(Me.dgvPromotionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBus
        '
        Me.gbBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gbBus.Controls.Add(Me.dpPromotionDate)
        Me.gbBus.Controls.Add(Me.Label1)
        Me.gbBus.Controls.Add(Me.dgvPromotionList)
        Me.gbBus.Controls.Add(Me.lblCount)
        Me.gbBus.Controls.Add(Me.txtPromotion)
        Me.gbBus.Controls.Add(Me.btnClear)
        Me.gbBus.Controls.Add(Me.Label5)
        Me.gbBus.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.gbBus.Location = New System.Drawing.Point(244, 207)
        Me.gbBus.Name = "gbBus"
        Me.gbBus.Size = New System.Drawing.Size(536, 345)
        Me.gbBus.TabIndex = 40
        Me.gbBus.TabStop = False
        Me.gbBus.Text = "Promotion"
        '
        'dpPromotionDate
        '
        Me.dpPromotionDate.Location = New System.Drawing.Point(89, 56)
        Me.dpPromotionDate.MinDate = New Date(2019, 3, 24, 0, 0, 0, 0)
        Me.dpPromotionDate.Name = "dpPromotionDate"
        Me.dpPromotionDate.Size = New System.Drawing.Size(283, 24)
        Me.dpPromotionDate.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Date"
        '
        'dgvPromotionList
        '
        Me.dgvPromotionList.AllowUserToAddRows = False
        Me.dgvPromotionList.AllowUserToDeleteRows = False
        Me.dgvPromotionList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPromotionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromotionList.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPromotionList.Location = New System.Drawing.Point(21, 92)
        Me.dgvPromotionList.Name = "dgvPromotionList"
        Me.dgvPromotionList.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvPromotionList.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPromotionList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvPromotionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPromotionList.Size = New System.Drawing.Size(490, 219)
        Me.dgvPromotionList.TabIndex = 47
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Black
        Me.lblCount.Location = New System.Drawing.Point(22, 314)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(81, 17)
        Me.lblCount.TabIndex = 46
        Me.lblCount.Text = "X record(s)."
        '
        'txtPromotion
        '
        Me.txtPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromotion.ForeColor = System.Drawing.Color.Black
        Me.txtPromotion.Location = New System.Drawing.Point(89, 30)
        Me.txtPromotion.Name = "txtPromotion"
        Me.txtPromotion.Size = New System.Drawing.Size(283, 20)
        Me.txtPromotion.TabIndex = 45
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Search"
        '
        'TranportSelection1
        '
        Me.TranportSelection1.Location = New System.Drawing.Point(243, 87)
        Me.TranportSelection1.Margin = New System.Windows.Forms.Padding(4)
        Me.TranportSelection1.Name = "TranportSelection1"
        Me.TranportSelection1.Size = New System.Drawing.Size(537, 104)
        Me.TranportSelection1.TabIndex = 43
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(263, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 36)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "View Promotion"
        '
        'StaffViewPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TranportSelection1)
        Me.Controls.Add(Me.gbBus)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffViewPromotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffViewPromotion"
        Me.gbBus.ResumeLayout(False)
        Me.gbBus.PerformLayout()
        CType(Me.dgvPromotionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBus As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents TranportSelection1 As TranportSelection
    Friend WithEvents txtPromotion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents dgvPromotionList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dpPromotionDate As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
