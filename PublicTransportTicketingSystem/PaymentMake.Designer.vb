<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMake
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLicensePlate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvSeatPrice = New System.Windows.Forms.DataGridView()
        Me.Seat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDepartureTime = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDepartureDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPassengerName = New System.Windows.Forms.Label()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.btnGenerateTicket = New System.Windows.Forms.Button()
        Me.lblCashPaidHint = New System.Windows.Forms.Label()
        Me.txtCashPaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSeatPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLicensePlate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dgvSeatPrice)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblCompany)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblDestination)
        Me.GroupBox2.Controls.Add(Me.lblOrigin)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblDepartureTime)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblDepartureDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblPassengerName)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(219, 479)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ticket Details"
        '
        'lblLicensePlate
        '
        Me.lblLicensePlate.BackColor = System.Drawing.SystemColors.Control
        Me.lblLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLicensePlate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLicensePlate.Location = New System.Drawing.Point(28, 301)
        Me.lblLicensePlate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLicensePlate.Name = "lblLicensePlate"
        Me.lblLicensePlate.Size = New System.Drawing.Size(160, 19)
        Me.lblLicensePlate.TabIndex = 28
        Me.lblLicensePlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(59, 283)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "License Plate"
        '
        'dgvSeatPrice
        '
        Me.dgvSeatPrice.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.dgvSeatPrice.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSeatPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSeatPrice.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvSeatPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSeatPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeatPrice.ColumnHeadersVisible = False
        Me.dgvSeatPrice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seat, Me.Price})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSeatPrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSeatPrice.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvSeatPrice.Location = New System.Drawing.Point(29, 344)
        Me.dgvSeatPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvSeatPrice.Name = "dgvSeatPrice"
        Me.dgvSeatPrice.ReadOnly = True
        Me.dgvSeatPrice.RowHeadersVisible = False
        Me.dgvSeatPrice.RowTemplate.Height = 24
        Me.dgvSeatPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvSeatPrice.Size = New System.Drawing.Size(159, 112)
        Me.dgvSeatPrice.TabIndex = 26
        '
        'Seat
        '
        Me.Seat.HeaderText = "Seat"
        Me.Seat.Name = "Seat"
        Me.Seat.ReadOnly = True
        Me.Seat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(52, 325)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 18)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Seat         Price"
        '
        'lblCompany
        '
        Me.lblCompany.BackColor = System.Drawing.SystemColors.Control
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCompany.Location = New System.Drawing.Point(28, 259)
        Me.lblCompany.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(160, 19)
        Me.lblCompany.TabIndex = 24
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(70, 240)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Company"
        '
        'lblDestination
        '
        Me.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDestination.Location = New System.Drawing.Point(28, 216)
        Me.lblDestination.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(160, 19)
        Me.lblDestination.TabIndex = 22
        Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOrigin
        '
        Me.lblOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrigin.Location = New System.Drawing.Point(28, 174)
        Me.lblOrigin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(160, 19)
        Me.lblOrigin.TabIndex = 21
        Me.lblOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(68, 197)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 18)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Destination"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(86, 154)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Origin"
        '
        'lblDepartureTime
        '
        Me.lblDepartureTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartureTime.Location = New System.Drawing.Point(28, 131)
        Me.lblDepartureTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDepartureTime.Name = "lblDepartureTime"
        Me.lblDepartureTime.Size = New System.Drawing.Size(160, 19)
        Me.lblDepartureTime.TabIndex = 18
        Me.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(52, 111)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Departure Time"
        '
        'lblDepartureDate
        '
        Me.lblDepartureDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartureDate.Location = New System.Drawing.Point(28, 89)
        Me.lblDepartureDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDepartureDate.Name = "lblDepartureDate"
        Me.lblDepartureDate.Size = New System.Drawing.Size(160, 19)
        Me.lblDepartureDate.TabIndex = 16
        Me.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(55, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Departure Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Passenger Name"
        '
        'lblPassengerName
        '
        Me.lblPassengerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPassengerName.Location = New System.Drawing.Point(28, 48)
        Me.lblPassengerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerName.Name = "lblPassengerName"
        Me.lblPassengerName.Size = New System.Drawing.Size(160, 19)
        Me.lblPassengerName.TabIndex = 12
        Me.lblPassengerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.btnCancel)
        Me.grpPayment.Controls.Add(Me.lblDiscount)
        Me.grpPayment.Controls.Add(Me.lblChange)
        Me.grpPayment.Controls.Add(Me.Label8)
        Me.grpPayment.Controls.Add(Me.Label9)
        Me.grpPayment.Controls.Add(Me.lblTotalPrice)
        Me.grpPayment.Controls.Add(Me.btnGenerateTicket)
        Me.grpPayment.Controls.Add(Me.lblCashPaidHint)
        Me.grpPayment.Controls.Add(Me.txtCashPaid)
        Me.grpPayment.Controls.Add(Me.Label5)
        Me.grpPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grpPayment.Location = New System.Drawing.Point(9, 10)
        Me.grpPayment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpPayment.Size = New System.Drawing.Size(346, 479)
        Me.grpPayment.TabIndex = 22
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Make Payment"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(27, 300)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 35)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblDiscount.Location = New System.Drawing.Point(130, 154)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(0, 13)
        Me.lblDiscount.TabIndex = 32
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Location = New System.Drawing.Point(132, 241)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(137, 19)
        Me.lblChange.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 240)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Change"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Total Price"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPrice.Location = New System.Drawing.Point(132, 132)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(137, 19)
        Me.lblTotalPrice.TabIndex = 28
        '
        'btnGenerateTicket
        '
        Me.btnGenerateTicket.Enabled = False
        Me.btnGenerateTicket.Location = New System.Drawing.Point(170, 300)
        Me.btnGenerateTicket.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerateTicket.Name = "btnGenerateTicket"
        Me.btnGenerateTicket.Size = New System.Drawing.Size(122, 35)
        Me.btnGenerateTicket.TabIndex = 25
        Me.btnGenerateTicket.Text = "Generate Ticket"
        Me.btnGenerateTicket.UseVisualStyleBackColor = True
        '
        'lblCashPaidHint
        '
        Me.lblCashPaidHint.AutoSize = True
        Me.lblCashPaidHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashPaidHint.ForeColor = System.Drawing.Color.Red
        Me.lblCashPaidHint.Location = New System.Drawing.Point(130, 210)
        Me.lblCashPaidHint.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCashPaidHint.Name = "lblCashPaidHint"
        Me.lblCashPaidHint.Size = New System.Drawing.Size(0, 13)
        Me.lblCashPaidHint.TabIndex = 22
        '
        'txtCashPaid
        '
        Me.txtCashPaid.Location = New System.Drawing.Point(132, 185)
        Me.txtCashPaid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.Size = New System.Drawing.Size(138, 23)
        Me.txtCashPaid.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cash Paid"
        '
        'PaymentMake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 499)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpPayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PaymentMake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentMake"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvSeatPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblLicensePlate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvSeatPrice As DataGridView
    Friend WithEvents Seat As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblOrigin As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDepartureTime As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblDepartureDate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPassengerName As Label
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents btnGenerateTicket As Button
    Friend WithEvents lblCashPaidHint As Label
    Friend WithEvents txtCashPaid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancel As Button
End Class
