﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffBookingCustomerDetail
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
        Me.gbCreatePromotion = New System.Windows.Forms.GroupBox()
        Me.mskContact = New System.Windows.Forms.MaskedTextBox()
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSeat = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbCreatePromotion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffMenuLayoutControl1
        '
        Me.StaffMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StaffMenuLayoutControl1.Name = "StaffMenuLayoutControl1"
        Me.StaffMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.StaffMenuLayoutControl1.TabIndex = 0
        '
        'gbCreatePromotion
        '
        Me.gbCreatePromotion.BackColor = System.Drawing.SystemColors.Control
        Me.gbCreatePromotion.Controls.Add(Me.mskContact)
        Me.gbCreatePromotion.Controls.Add(Me.mskIC)
        Me.gbCreatePromotion.Controls.Add(Me.Label7)
        Me.gbCreatePromotion.Controls.Add(Me.Label6)
        Me.gbCreatePromotion.Controls.Add(Me.txtName)
        Me.gbCreatePromotion.Controls.Add(Me.Label5)
        Me.gbCreatePromotion.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCreatePromotion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbCreatePromotion.Location = New System.Drawing.Point(285, 108)
        Me.gbCreatePromotion.Name = "gbCreatePromotion"
        Me.gbCreatePromotion.Size = New System.Drawing.Size(443, 142)
        Me.gbCreatePromotion.TabIndex = 23
        Me.gbCreatePromotion.TabStop = False
        Me.gbCreatePromotion.Text = "Customer Details"
        '
        'mskContact
        '
        Me.mskContact.Location = New System.Drawing.Point(175, 103)
        Me.mskContact.Margin = New System.Windows.Forms.Padding(2)
        Me.mskContact.Mask = "000-000 0000"
        Me.mskContact.Name = "mskContact"
        Me.mskContact.Size = New System.Drawing.Size(214, 24)
        Me.mskContact.TabIndex = 23
        Me.mskContact.ValidatingType = GetType(Integer)
        '
        'mskIC
        '
        Me.mskIC.Location = New System.Drawing.Point(175, 67)
        Me.mskIC.Margin = New System.Windows.Forms.Padding(2)
        Me.mskIC.Mask = "000000-00-0000"
        Me.mskIC.Name = "mskIC"
        Me.mskIC.Size = New System.Drawing.Size(214, 24)
        Me.mskIC.TabIndex = 22
        Me.mskIC.ValidatingType = GetType(Integer)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(18, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Customer Contact No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(18, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Customer IC"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(175, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(214, 20)
        Me.txtName.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Customer Name"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(550, 485)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnProceed
        '
        Me.btnProceed.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnProceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProceed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProceed.Location = New System.Drawing.Point(358, 485)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(100, 36)
        Me.btnProceed.TabIndex = 26
        Me.btnProceed.Text = "&PROCEED"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lblTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvSeat)
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(285, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 184)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking Details"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPrice.Location = New System.Drawing.Point(175, 145)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(213, 19)
        Me.lblTotalPrice.TabIndex = 21
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(37, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Total Price"
        '
        'dgvSeat
        '
        Me.dgvSeat.AllowUserToAddRows = False
        Me.dgvSeat.AllowUserToDeleteRows = False
        Me.dgvSeat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSeat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeat.Location = New System.Drawing.Point(32, 20)
        Me.dgvSeat.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSeat.Name = "dgvSeat"
        Me.dgvSeat.ReadOnly = True
        Me.dgvSeat.RowTemplate.Height = 24
        Me.dgvSeat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSeat.Size = New System.Drawing.Size(374, 103)
        Me.dgvSeat.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 36)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Ticket Booking"
        '
        'staffBookingCustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbCreatePromotion)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "staffBookingCustomerDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staffBookingCustomerDetail"
        Me.gbCreatePromotion.ResumeLayout(False)
        Me.gbCreatePromotion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents gbCreatePromotion As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSeat As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents mskContact As MaskedTextBox
    Friend WithEvents Label2 As Label
End Class
