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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentMake))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDepartureTime = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Seat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDepartureDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLicensePlate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPassengerName = New System.Windows.Forms.Label()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnGenerateTicket = New System.Windows.Forms.Button()
        Me.lblCashPaidHint = New System.Windows.Forms.Label()
        Me.txtCashPaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnStaffPromotion = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.pbReserve = New System.Windows.Forms.PictureBox()
        Me.pbPurchase = New System.Windows.Forms.PictureBox()
        Me.pbStaffPromotion = New System.Windows.Forms.PictureBox()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStaffPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        '
        'lblOrigin
        '
        Me.lblOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrigin.Location = New System.Drawing.Point(38, 214)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(212, 23)
        Me.lblOrigin.TabIndex = 21
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
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Location = New System.Drawing.Point(176, 268)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(182, 23)
        Me.lblChange.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(82, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 24)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Change"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seat, Me.Price})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(39, 423)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(212, 138)
        Me.DataGridView1.TabIndex = 26
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
        'lblDepartureDate
        '
        Me.lblDepartureDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartureDate.Location = New System.Drawing.Point(38, 109)
        Me.lblDepartureDate.Name = "lblDepartureDate"
        Me.lblDepartureDate.Size = New System.Drawing.Size(212, 23)
        Me.lblDepartureDate.TabIndex = 16
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLicensePlate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
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
        Me.GroupBox2.Location = New System.Drawing.Point(763, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 589)
        Me.GroupBox2.TabIndex = 21
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
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.lblDiscount)
        Me.grpPayment.Controls.Add(Me.lblChange)
        Me.grpPayment.Controls.Add(Me.Label8)
        Me.grpPayment.Controls.Add(Me.Label9)
        Me.grpPayment.Controls.Add(Me.lblPrice)
        Me.grpPayment.Controls.Add(Me.btnGenerateTicket)
        Me.grpPayment.Controls.Add(Me.lblCashPaidHint)
        Me.grpPayment.Controls.Add(Me.txtCashPaid)
        Me.grpPayment.Controls.Add(Me.Label5)
        Me.grpPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grpPayment.Location = New System.Drawing.Point(295, 78)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(462, 590)
        Me.grpPayment.TabIndex = 20
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Make Payment"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblDiscount.Location = New System.Drawing.Point(173, 185)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(172, 17)
        Me.lblDiscount.TabIndex = 32
        Me.lblDiscount.Text = "Discounted from RM40.00"
        Me.lblDiscount.Visible = False
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
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(176, 162)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(182, 23)
        Me.lblPrice.TabIndex = 28
        '
        'btnGenerateTicket
        '
        Me.btnGenerateTicket.Location = New System.Drawing.Point(176, 331)
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
        Me.lblCashPaidHint.Location = New System.Drawing.Point(173, 238)
        Me.lblCashPaidHint.Name = "lblCashPaidHint"
        Me.lblCashPaidHint.Size = New System.Drawing.Size(126, 17)
        Me.lblCashPaidHint.TabIndex = 22
        Me.lblCashPaidHint.Text = "Insufficient amount"
        Me.lblCashPaidHint.Visible = False
        '
        'txtCashPaid
        '
        Me.txtCashPaid.Location = New System.Drawing.Point(176, 212)
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.Size = New System.Drawing.Size(182, 26)
        Me.txtCashPaid.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cash Paid"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnAbout)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(293, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 71)
        Me.Panel1.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.AllowDrop = True
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(340, 20)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 46)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Contact Us"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(469, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 55)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Manage Account"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.AllowDrop = True
        Me.btnAbout.BackColor = System.Drawing.Color.White
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAbout.Location = New System.Drawing.Point(232, 20)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(103, 46)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About Us"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.logout__1_
        Me.PictureBox2.Location = New System.Drawing.Point(720, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(13, 4, 4, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(19, 23)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(128, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Payment"
        '
        'btnTransaction
        '
        Me.btnTransaction.AllowDrop = True
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTransaction.Location = New System.Drawing.Point(73, 969)
        Me.btnTransaction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(192, 48)
        Me.btnTransaction.TabIndex = 9
        Me.btnTransaction.Text = "Transaction History"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnStaffPromotion
        '
        Me.btnStaffPromotion.AllowDrop = True
        Me.btnStaffPromotion.FlatAppearance.BorderSize = 0
        Me.btnStaffPromotion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStaffPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffPromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStaffPromotion.Location = New System.Drawing.Point(73, 1045)
        Me.btnStaffPromotion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStaffPromotion.Name = "btnStaffPromotion"
        Me.btnStaffPromotion.Size = New System.Drawing.Size(192, 48)
        Me.btnStaffPromotion.TabIndex = 13
        Me.btnStaffPromotion.Text = " Promotion"
        Me.btnStaffPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaffPromotion.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.AllowDrop = True
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHome.Location = New System.Drawing.Point(73, 817)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(192, 48)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnReservation
        '
        Me.btnReservation.AllowDrop = True
        Me.btnReservation.FlatAppearance.BorderSize = 0
        Me.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReservation.Location = New System.Drawing.Point(73, 893)
        Me.btnReservation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(192, 48)
        Me.btnReservation.TabIndex = 7
        Me.btnReservation.Text = "Ticket Reservation"
        Me.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(13, 12, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Public Transport Ticketing System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 716)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(292, 74)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(180, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(7, 12, 7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 59)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbHome)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHome)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbReserve)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReservation)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbPurchase)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnTransaction)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbStaffPromotion)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnStaffPromotion)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, -2)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(292, 713)
        Me.FlowLayoutPanel1.TabIndex = 18
        '
        'pbHome
        '
        Me.pbHome.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.home
        Me.pbHome.Location = New System.Drawing.Point(13, 819)
        Me.pbHome.Margin = New System.Windows.Forms.Padding(13, 4, 4, 25)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(53, 47)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 3
        Me.pbHome.TabStop = False
        '
        'pbReserve
        '
        Me.pbReserve.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.reserve
        Me.pbReserve.Location = New System.Drawing.Point(13, 895)
        Me.pbReserve.Margin = New System.Windows.Forms.Padding(13, 4, 4, 25)
        Me.pbReserve.Name = "pbReserve"
        Me.pbReserve.Size = New System.Drawing.Size(53, 47)
        Me.pbReserve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReserve.TabIndex = 5
        Me.pbReserve.TabStop = False
        '
        'pbPurchase
        '
        Me.pbPurchase.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.purchase2
        Me.pbPurchase.Location = New System.Drawing.Point(13, 971)
        Me.pbPurchase.Margin = New System.Windows.Forms.Padding(13, 4, 4, 25)
        Me.pbPurchase.Name = "pbPurchase"
        Me.pbPurchase.Size = New System.Drawing.Size(53, 47)
        Me.pbPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPurchase.TabIndex = 8
        Me.pbPurchase.TabStop = False
        '
        'pbStaffPromotion
        '
        Me.pbStaffPromotion.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources._2
        Me.pbStaffPromotion.Location = New System.Drawing.Point(13, 1047)
        Me.pbStaffPromotion.Margin = New System.Windows.Forms.Padding(13, 4, 4, 25)
        Me.pbStaffPromotion.Name = "pbStaffPromotion"
        Me.pbStaffPromotion.Size = New System.Drawing.Size(53, 47)
        Me.pbStaffPromotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStaffPromotion.TabIndex = 12
        Me.pbStaffPromotion.TabStop = False
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(4, 4)
        Me.ManagerMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(1067, 708)
        Me.ManagerMenuLayoutControl1.TabIndex = 14
        '
        'PaymentMake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 708)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentMake"
        Me.Text = "PaymentMake"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReserve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStaffPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblOrigin As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDepartureTime As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Seat As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents lblDepartureDate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPassengerName As Label
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnGenerateTicket As Button
    Friend WithEvents lblCashPaidHint As Label
    Friend WithEvents txtCashPaid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnStaffPromotion As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pbHome As PictureBox
    Friend WithEvents pbReserve As PictureBox
    Friend WithEvents pbPurchase As PictureBox
    Friend WithEvents pbStaffPromotion As PictureBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblLicensePlate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
End Class
