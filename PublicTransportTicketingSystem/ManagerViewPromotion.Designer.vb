﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnCreatePromotionPage = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPromotionID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dpPromotionDate = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.gbBus = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvPromotionList = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cboTransport = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.TranportSelection1 = New PublicTransportTicketingSystem.TranportSelection()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbBus.SuspendLayout()
        CType(Me.dgvPromotionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Search"
        '
        'txtPromotionID
        '
        Me.txtPromotionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromotionID.ForeColor = System.Drawing.Color.Black
        Me.txtPromotionID.Location = New System.Drawing.Point(121, 31)
        Me.txtPromotionID.Name = "txtPromotionID"
        Me.txtPromotionID.Size = New System.Drawing.Size(249, 20)
        Me.txtPromotionID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date"
        '
        'dpPromotionDate
        '
        Me.dpPromotionDate.Location = New System.Drawing.Point(121, 61)
        Me.dpPromotionDate.MinDate = New Date(2019, 3, 24, 0, 0, 0, 0)
        Me.dpPromotionDate.Name = "dpPromotionDate"
        Me.dpPromotionDate.Size = New System.Drawing.Size(249, 24)
        Me.dpPromotionDate.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(415, 380)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "&MODIFY"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemove.Location = New System.Drawing.Point(280, 380)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 28)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "&DEACTIVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'gbBus
        '
        Me.gbBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gbBus.Controls.Add(Me.btnClear)
        Me.gbBus.Controls.Add(Me.dgvPromotionList)
        Me.gbBus.Controls.Add(Me.lblCount)
        Me.gbBus.Controls.Add(Me.cboTransport)
        Me.gbBus.Controls.Add(Me.Label1)
        Me.gbBus.Controls.Add(Me.btnRemove)
        Me.gbBus.Controls.Add(Me.btnUpdate)
        Me.gbBus.Controls.Add(Me.dpPromotionDate)
        Me.gbBus.Controls.Add(Me.Label2)
        Me.gbBus.Controls.Add(Me.txtPromotionID)
        Me.gbBus.Controls.Add(Me.Label5)
        Me.gbBus.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBus.Location = New System.Drawing.Point(252, 83)
        Me.gbBus.Name = "gbBus"
        Me.gbBus.Size = New System.Drawing.Size(536, 417)
        Me.gbBus.TabIndex = 0
        Me.gbBus.TabStop = False
        Me.gbBus.Text = "Promotion"
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(415, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 28)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvPromotionList
        '
        Me.dgvPromotionList.AllowUserToAddRows = False
        Me.dgvPromotionList.AllowUserToDeleteRows = False
        Me.dgvPromotionList.AllowUserToOrderColumns = True
        Me.dgvPromotionList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPromotionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromotionList.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPromotionList.Location = New System.Drawing.Point(29, 138)
        Me.dgvPromotionList.Name = "dgvPromotionList"
        Me.dgvPromotionList.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvPromotionList.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPromotionList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvPromotionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPromotionList.Size = New System.Drawing.Size(486, 215)
        Me.dgvPromotionList.TabIndex = 4
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Black
        Me.lblCount.Location = New System.Drawing.Point(26, 356)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(81, 17)
        Me.lblCount.TabIndex = 39
        Me.lblCount.Text = "X record(s)."
        '
        'cboTransport
        '
        Me.cboTransport.FormattingEnabled = True
        Me.cboTransport.Items.AddRange(New Object() {"Bus ", "Train", "Ferry"})
        Me.cboTransport.Location = New System.Drawing.Point(121, 98)
        Me.cboTransport.Name = "cboTransport"
        Me.cboTransport.Size = New System.Drawing.Size(249, 26)
        Me.cboTransport.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Transport"
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'TranportSelection1
        '
        Me.TranportSelection1.Location = New System.Drawing.Point(239, 96)
        Me.TranportSelection1.Name = "TranportSelection1"
        Me.TranportSelection1.Size = New System.Drawing.Size(537, 104)
        Me.TranportSelection1.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(257, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 36)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Manage Promotion"
        '
        'ManagerViewPromotion
        '
        Me.AcceptButton = Me.btnCreatePromotionPage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCreatePromotionPage)
        Me.Controls.Add(Me.gbBus)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerViewPromotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerViewPromotion"
        Me.gbBus.ResumeLayout(False)
        Me.gbBus.PerformLayout()
        CType(Me.dgvPromotionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents btnCreatePromotionPage As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPromotionID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dpPromotionDate As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents gbBus As GroupBox
    Friend WithEvents TranportSelection1 As TranportSelection
    Friend WithEvents cboTransport As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents dgvPromotionList As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
End Class
