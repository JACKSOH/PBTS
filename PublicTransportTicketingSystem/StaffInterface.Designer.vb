<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffInterface))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnStaffPromotion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.pbReserve = New System.Windows.Forms.PictureBox()
        Me.pbPurchase = New System.Windows.Forms.PictureBox()
        Me.pbStaffPromotion = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStaffPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(219, 579)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(219, 60)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Public Transport Ticketing System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHome
        '
        Me.btnHome.AllowDrop = True
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHome.Location = New System.Drawing.Point(55, 82)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(144, 39)
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
        Me.btnReservation.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReservation.Location = New System.Drawing.Point(55, 143)
        Me.btnReservation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(144, 39)
        Me.btnReservation.TabIndex = 7
        Me.btnReservation.Text = "Ticket Reservation"
        Me.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'btnTransaction
        '
        Me.btnTransaction.AllowDrop = True
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTransaction.Location = New System.Drawing.Point(55, 204)
        Me.btnTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(144, 39)
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
        Me.btnStaffPromotion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffPromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStaffPromotion.Location = New System.Drawing.Point(55, 265)
        Me.btnStaffPromotion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStaffPromotion.Name = "btnStaffPromotion"
        Me.btnStaffPromotion.Size = New System.Drawing.Size(144, 39)
        Me.btnStaffPromotion.TabIndex = 13
        Me.btnStaffPromotion.Text = " Promotion"
        Me.btnStaffPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaffPromotion.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 58)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.AllowDrop = True
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(255, 16)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 37)
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
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(352, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 45)
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
        Me.btnAbout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAbout.Location = New System.Drawing.Point(174, 16)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(77, 37)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About Us"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(14, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(114, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Promotion"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(239, 80)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(395, 39)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.logout__1_
        Me.PictureBox2.Location = New System.Drawing.Point(540, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(135, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pbHome
        '
        Me.pbHome.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.home
        Me.pbHome.Location = New System.Drawing.Point(10, 83)
        Me.pbHome.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(40, 38)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 3
        Me.pbHome.TabStop = False
        '
        'pbReserve
        '
        Me.pbReserve.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.reserve
        Me.pbReserve.Location = New System.Drawing.Point(10, 144)
        Me.pbReserve.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbReserve.Name = "pbReserve"
        Me.pbReserve.Size = New System.Drawing.Size(40, 38)
        Me.pbReserve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReserve.TabIndex = 5
        Me.pbReserve.TabStop = False
        '
        'pbPurchase
        '
        Me.pbPurchase.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.purchase2
        Me.pbPurchase.Location = New System.Drawing.Point(10, 205)
        Me.pbPurchase.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbPurchase.Name = "pbPurchase"
        Me.pbPurchase.Size = New System.Drawing.Size(40, 38)
        Me.pbPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPurchase.TabIndex = 8
        Me.pbPurchase.TabStop = False
        '
        'pbStaffPromotion
        '
        Me.pbStaffPromotion.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources._2
        Me.pbStaffPromotion.Location = New System.Drawing.Point(10, 266)
        Me.pbStaffPromotion.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbStaffPromotion.Name = "pbStaffPromotion"
        Me.pbStaffPromotion.Size = New System.Drawing.Size(40, 38)
        Me.pbStaffPromotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStaffPromotion.TabIndex = 12
        Me.pbStaffPromotion.TabStop = False
        '
        'StaffInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffInterface"
        Me.Text = "AddPromotion"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReserve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStaffPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnHome As Button
    Friend WithEvents pbHome As PictureBox
    Friend WithEvents pbReserve As PictureBox
    Friend WithEvents btnReservation As Button
    Friend WithEvents pbPurchase As PictureBox
    Friend WithEvents btnTransaction As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pbStaffPromotion As PictureBox
    Friend WithEvents btnStaffPromotion As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
