﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffMenuLayoutControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffMenuLayoutControl))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnManageAccount = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pbExit = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pbReserve = New System.Windows.Forms.PictureBox()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.pbPurchase = New System.Windows.Forms.PictureBox()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.pbStaffPromotion = New System.Windows.Forms.PictureBox()
        Me.btnStaffPromotion = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.pbReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStaffPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.875!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.125!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.86957!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.13043!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 575)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnManageAccount)
        Me.Panel1.Controls.Add(Me.btnAbout)
        Me.Panel1.Controls.Add(Me.pbExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(223, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 74)
        Me.Panel1.TabIndex = 4
        '
        'btnManageAccount
        '
        Me.btnManageAccount.AllowDrop = True
        Me.btnManageAccount.BackColor = System.Drawing.Color.White
        Me.btnManageAccount.FlatAppearance.BorderSize = 0
        Me.btnManageAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageAccount.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnManageAccount.Location = New System.Drawing.Point(352, 12)
        Me.btnManageAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManageAccount.Name = "btnManageAccount"
        Me.btnManageAccount.Size = New System.Drawing.Size(133, 45)
        Me.btnManageAccount.TabIndex = 9
        Me.btnManageAccount.Text = "Manage Account"
        Me.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageAccount.UseVisualStyleBackColor = False
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
        Me.btnAbout.Location = New System.Drawing.Point(254, 15)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(77, 37)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About Us"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'pbExit
        '
        Me.pbExit.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.logout__1_
        Me.pbExit.Location = New System.Drawing.Point(540, 12)
        Me.pbExit.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(28, 31)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbExit.TabIndex = 4
        Me.pbExit.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 74)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(145, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Public Transport Ticketing System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.pbReserve)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReservation)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbPurchase)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnTransaction)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbStaffPromotion)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnStaffPromotion)
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 74)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(223, 501)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'pbReserve
        '
        Me.pbReserve.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pbReserve.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.reserve
        Me.pbReserve.Location = New System.Drawing.Point(10, 3)
        Me.pbReserve.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbReserve.Name = "pbReserve"
        Me.pbReserve.Size = New System.Drawing.Size(40, 38)
        Me.pbReserve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReserve.TabIndex = 5
        Me.pbReserve.TabStop = False
        '
        'btnReservation
        '
        Me.btnReservation.AllowDrop = True
        Me.btnReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnReservation.FlatAppearance.BorderSize = 0
        Me.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservation.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReservation.Location = New System.Drawing.Point(55, 2)
        Me.btnReservation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(151, 39)
        Me.btnReservation.TabIndex = 7
        Me.btnReservation.Text = "Book Ticket"
        Me.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservation.UseVisualStyleBackColor = False
        '
        'pbPurchase
        '
        Me.pbPurchase.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.purchase2
        Me.pbPurchase.Location = New System.Drawing.Point(10, 64)
        Me.pbPurchase.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbPurchase.Name = "pbPurchase"
        Me.pbPurchase.Size = New System.Drawing.Size(40, 38)
        Me.pbPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPurchase.TabIndex = 8
        Me.pbPurchase.TabStop = False
        '
        'btnTransaction
        '
        Me.btnTransaction.AllowDrop = True
        Me.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTransaction.Location = New System.Drawing.Point(55, 63)
        Me.btnTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(144, 39)
        Me.btnTransaction.TabIndex = 9
        Me.btnTransaction.Text = "Transaction History"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'pbStaffPromotion
        '
        Me.pbStaffPromotion.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources._2
        Me.pbStaffPromotion.Location = New System.Drawing.Point(10, 125)
        Me.pbStaffPromotion.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbStaffPromotion.Name = "pbStaffPromotion"
        Me.pbStaffPromotion.Size = New System.Drawing.Size(40, 38)
        Me.pbStaffPromotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStaffPromotion.TabIndex = 12
        Me.pbStaffPromotion.TabStop = False
        '
        'btnStaffPromotion
        '
        Me.btnStaffPromotion.AllowDrop = True
        Me.btnStaffPromotion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaffPromotion.FlatAppearance.BorderSize = 0
        Me.btnStaffPromotion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStaffPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffPromotion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffPromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStaffPromotion.Location = New System.Drawing.Point(55, 124)
        Me.btnStaffPromotion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStaffPromotion.Name = "btnStaffPromotion"
        Me.btnStaffPromotion.Size = New System.Drawing.Size(144, 39)
        Me.btnStaffPromotion.TabIndex = 13
        Me.btnStaffPromotion.Text = " Promotion"
        Me.btnStaffPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaffPromotion.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 186)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.AllowDrop = True
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(55, 185)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 39)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Ticket Cancellation"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'staffMenuLayoutControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "staffMenuLayoutControl"
        Me.Size = New System.Drawing.Size(800, 575)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.pbReserve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStaffPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnManageAccount As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents pbExit As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pbReserve As PictureBox
    Friend WithEvents btnReservation As Button
    Friend WithEvents pbPurchase As PictureBox
    Friend WithEvents btnTransaction As Button
    Friend WithEvents pbStaffPromotion As PictureBox
    Friend WithEvents btnStaffPromotion As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCancel As Button
End Class
