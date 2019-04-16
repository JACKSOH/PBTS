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

        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox2.Location = New System.Drawing.Point(480, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 589)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ticket Details"
        '
        'lblLicensePlate
        '
        Me.lblLicensePlate.BackColor = System.Drawing.SystemColors.Control
        Me.lblLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLicensePlate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLicensePlate.Location = New System.Drawing.Point(38, 371)
        Me.lblLicensePlate.Name = "lblLicensePlate"
        Me.lblLicensePlate.Size = New System.Drawing.Size(212, 23)
        Me.lblLicensePlate.TabIndex = 28
        Me.lblLicensePlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(79, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "License Plate"
        '
        'dgvSeatPrice
        '
        Me.dgvSeatPrice.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        Me.dgvSeatPrice.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvSeatPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSeatPrice.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvSeatPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSeatPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeatPrice.ColumnHeadersVisible = False
        Me.dgvSeatPrice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seat, Me.Price})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSeatPrice.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvSeatPrice.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvSeatPrice.Location = New System.Drawing.Point(39, 423)
        Me.dgvSeatPrice.Name = "dgvSeatPrice"
        Me.dgvSeatPrice.ReadOnly = True
        Me.dgvSeatPrice.RowHeadersVisible = False
        Me.dgvSeatPrice.RowTemplate.Height = 24
        Me.dgvSeatPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvSeatPrice.Size = New System.Drawing.Size(212, 138)
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
        Me.Label14.Location = New System.Drawing.Point(70, 400)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 24)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Seat         Price"
        '
        'lblCompany
        '
        Me.lblCompany.BackColor = System.Drawing.SystemColors.Control
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCompany.Location = New System.Drawing.Point(38, 319)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(212, 23)
        Me.lblCompany.TabIndex = 24
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(94, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 24)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Company"
        '
        'lblDestination
        '
        Me.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDestination.Location = New System.Drawing.Point(38, 266)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(212, 23)
        Me.lblDestination.TabIndex = 22
        Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOrigin
        '
        Me.lblOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrigin.Location = New System.Drawing.Point(38, 214)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(212, 23)
        Me.lblOrigin.TabIndex = 21
        Me.lblOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(91, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 24)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Destination"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(115, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 24)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Origin"
        '
        'lblDepartureTime
        '
        Me.lblDepartureTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartureTime.Location = New System.Drawing.Point(38, 161)
        Me.lblDepartureTime.Name = "lblDepartureTime"
        Me.lblDepartureTime.Size = New System.Drawing.Size(212, 23)
        Me.lblDepartureTime.TabIndex = 18
        Me.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(70, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Departure Time"
        '

        'lblDepartureDate
        '
        Me.lblDepartureDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartureDate.Location = New System.Drawing.Point(38, 109)
        Me.lblDepartureDate.Name = "lblDepartureDate"
        Me.lblDepartureDate.Size = New System.Drawing.Size(212, 23)
        Me.lblDepartureDate.TabIndex = 16
        Me.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(73, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Departure Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Passenger Name"
        '
        'lblPassengerName
        '
        Me.lblPassengerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPassengerName.Location = New System.Drawing.Point(38, 59)
        Me.lblPassengerName.Name = "lblPassengerName"
        Me.lblPassengerName.Size = New System.Drawing.Size(212, 23)
        Me.lblPassengerName.TabIndex = 12
        Me.lblPassengerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpPayment
        '
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
        Me.grpPayment.Location = New System.Drawing.Point(12, 12)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(462, 590)
        Me.grpPayment.TabIndex = 22
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Make Payment"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black

        Me.lblDiscount.Location = New System.Drawing.Point(173, 189)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(0, 17)
        Me.lblDiscount.TabIndex = 32
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Location = New System.Drawing.Point(176, 297)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(182, 23)
        Me.lblChange.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(82, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 24)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Change"

        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 24)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Total Price"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPrice.Location = New System.Drawing.Point(176, 162)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(182, 23)
        Me.lblTotalPrice.TabIndex = 28
        Me.lblTotalPrice.Text = "62.00"
        '
        'btnGenerateTicket
        '
        Me.btnGenerateTicket.Enabled = False
        Me.btnGenerateTicket.Location = New System.Drawing.Point(176, 360)
        Me.btnGenerateTicket.Name = "btnGenerateTicket"
        Me.btnGenerateTicket.Size = New System.Drawing.Size(163, 26)
        Me.btnGenerateTicket.TabIndex = 25
        Me.btnGenerateTicket.Text = "Generate Ticket"
        Me.btnGenerateTicket.UseVisualStyleBackColor = True
        '
        'lblCashPaidHint
        '
        Me.lblCashPaidHint.AutoSize = True
        Me.lblCashPaidHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashPaidHint.ForeColor = System.Drawing.Color.Red
        Me.lblCashPaidHint.Location = New System.Drawing.Point(173, 259)
        Me.lblCashPaidHint.Name = "lblCashPaidHint"
        Me.lblCashPaidHint.Size = New System.Drawing.Size(0, 17)
        Me.lblCashPaidHint.TabIndex = 22
        '
        'txtCashPaid
        '
        Me.txtCashPaid.Location = New System.Drawing.Point(176, 228)
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.Size = New System.Drawing.Size(182, 26)
        Me.txtCashPaid.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cash Paid"
        '

        'PaymentMake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 614)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpPayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
End Class
