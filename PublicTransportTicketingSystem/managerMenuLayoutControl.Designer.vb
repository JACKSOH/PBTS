<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managerMenuLayoutControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(managerMenuLayoutControl))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pbReport = New System.Windows.Forms.PictureBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.pbManageStaff = New System.Windows.Forms.PictureBox()
        Me.btnManageStaff = New System.Windows.Forms.Button()
        Me.pbManageSchedule = New System.Windows.Forms.PictureBox()
        Me.btnManageSchedule = New System.Windows.Forms.Button()
        Me.pbManagePromotion = New System.Windows.Forms.PictureBox()
        Me.btnManagePromotion = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnPublicTransport = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnManageLocation = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnManageAccount = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pbExit = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManageStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManageSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManagePromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.65065!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.34935!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.52174!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.47826!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 575)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.pbReport)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReport)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbManageStaff)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnManageStaff)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbManageSchedule)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnManageSchedule)
        Me.FlowLayoutPanel1.Controls.Add(Me.pbManagePromotion)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnManagePromotion)
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox4)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPublicTransport)
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnManageLocation)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 72)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(229, 503)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'pbReport
        '
        Me.pbReport.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.report
        Me.pbReport.Location = New System.Drawing.Point(10, 3)
        Me.pbReport.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbReport.Name = "pbReport"
        Me.pbReport.Size = New System.Drawing.Size(40, 38)
        Me.pbReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReport.TabIndex = 4
        Me.pbReport.TabStop = False
        '
        'btnReport
        '
        Me.btnReport.AllowDrop = True
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReport.Location = New System.Drawing.Point(55, 2)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(144, 39)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'pbManageStaff
        '
        Me.pbManageStaff.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.reserve
        Me.pbManageStaff.Location = New System.Drawing.Point(10, 64)
        Me.pbManageStaff.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbManageStaff.Name = "pbManageStaff"
        Me.pbManageStaff.Size = New System.Drawing.Size(40, 38)
        Me.pbManageStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbManageStaff.TabIndex = 5
        Me.pbManageStaff.TabStop = False
        '
        'btnManageStaff
        '
        Me.btnManageStaff.AllowDrop = True
        Me.btnManageStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageStaff.FlatAppearance.BorderSize = 0
        Me.btnManageStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageStaff.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnManageStaff.Location = New System.Drawing.Point(55, 63)
        Me.btnManageStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManageStaff.Name = "btnManageStaff"
        Me.btnManageStaff.Size = New System.Drawing.Size(144, 39)
        Me.btnManageStaff.TabIndex = 7
        Me.btnManageStaff.Text = "Manage Staff"
        Me.btnManageStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageStaff.UseVisualStyleBackColor = True
        '
        'pbManageSchedule
        '
        Me.pbManageSchedule.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.schedule
        Me.pbManageSchedule.Location = New System.Drawing.Point(10, 125)
        Me.pbManageSchedule.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbManageSchedule.Name = "pbManageSchedule"
        Me.pbManageSchedule.Size = New System.Drawing.Size(40, 38)
        Me.pbManageSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbManageSchedule.TabIndex = 8
        Me.pbManageSchedule.TabStop = False
        '
        'btnManageSchedule
        '
        Me.btnManageSchedule.AllowDrop = True
        Me.btnManageSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageSchedule.FlatAppearance.BorderSize = 0
        Me.btnManageSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnManageSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageSchedule.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageSchedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnManageSchedule.Location = New System.Drawing.Point(55, 124)
        Me.btnManageSchedule.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManageSchedule.Name = "btnManageSchedule"
        Me.btnManageSchedule.Size = New System.Drawing.Size(144, 39)
        Me.btnManageSchedule.TabIndex = 9
        Me.btnManageSchedule.Text = "Manage Schedule"
        Me.btnManageSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageSchedule.UseVisualStyleBackColor = True
        '
        'pbManagePromotion
        '
        Me.pbManagePromotion.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources._2
        Me.pbManagePromotion.Location = New System.Drawing.Point(10, 186)
        Me.pbManagePromotion.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbManagePromotion.Name = "pbManagePromotion"
        Me.pbManagePromotion.Size = New System.Drawing.Size(40, 38)
        Me.pbManagePromotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbManagePromotion.TabIndex = 10
        Me.pbManagePromotion.TabStop = False
        '
        'btnManagePromotion
        '
        Me.btnManagePromotion.AllowDrop = True
        Me.btnManagePromotion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManagePromotion.FlatAppearance.BorderSize = 0
        Me.btnManagePromotion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnManagePromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManagePromotion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagePromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnManagePromotion.Location = New System.Drawing.Point(55, 185)
        Me.btnManagePromotion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManagePromotion.Name = "btnManagePromotion"
        Me.btnManagePromotion.Size = New System.Drawing.Size(144, 39)
        Me.btnManagePromotion.TabIndex = 11
        Me.btnManagePromotion.Text = "Manage Promotion"
        Me.btnManagePromotion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManagePromotion.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.pubic_trans
        Me.PictureBox4.Location = New System.Drawing.Point(10, 247)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'btnPublicTransport
        '
        Me.btnPublicTransport.AllowDrop = True
        Me.btnPublicTransport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPublicTransport.FlatAppearance.BorderSize = 0
        Me.btnPublicTransport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPublicTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPublicTransport.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublicTransport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPublicTransport.Location = New System.Drawing.Point(55, 246)
        Me.btnPublicTransport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPublicTransport.Name = "btnPublicTransport"
        Me.btnPublicTransport.Size = New System.Drawing.Size(164, 39)
        Me.btnPublicTransport.TabIndex = 12
        Me.btnPublicTransport.Text = "Manage Public Transport"
        Me.btnPublicTransport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPublicTransport.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.icons8_Map_Pinpoint_24px
        Me.PictureBox2.Location = New System.Drawing.Point(10, 308)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'btnManageLocation
        '
        Me.btnManageLocation.AllowDrop = True
        Me.btnManageLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageLocation.FlatAppearance.BorderSize = 0
        Me.btnManageLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnManageLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageLocation.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnManageLocation.Location = New System.Drawing.Point(55, 307)
        Me.btnManageLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManageLocation.Name = "btnManageLocation"
        Me.btnManageLocation.Size = New System.Drawing.Size(164, 39)
        Me.btnManageLocation.TabIndex = 15
        Me.btnManageLocation.Text = "Manage Location"
        Me.btnManageLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageLocation.UseVisualStyleBackColor = True
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
        Me.Panel2.Size = New System.Drawing.Size(229, 72)
        Me.Panel2.TabIndex = 6
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnManageAccount)
        Me.Panel1.Controls.Add(Me.btnAbout)
        Me.Panel1.Controls.Add(Me.pbExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(229, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 72)
        Me.Panel1.TabIndex = 10
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
        Me.btnAbout.Location = New System.Drawing.Point(259, 15)
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
        Me.pbExit.Location = New System.Drawing.Point(534, 12)
        Me.pbExit.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(28, 31)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbExit.TabIndex = 4
        Me.pbExit.TabStop = False
        '
        'managerMenuLayoutControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "managerMenuLayoutControl"
        Me.Size = New System.Drawing.Size(800, 575)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManageStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManageSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManagePromotion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnManageAccount As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents pbExit As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pbReport As PictureBox
    Friend WithEvents btnReport As Button
    Friend WithEvents pbManageStaff As PictureBox
    Friend WithEvents btnManageStaff As Button
    Friend WithEvents pbManageSchedule As PictureBox
    Friend WithEvents btnManageSchedule As Button
    Friend WithEvents pbManagePromotion As PictureBox
    Friend WithEvents btnManagePromotion As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnPublicTransport As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnManageLocation As Button
End Class
