<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranportSelection
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTrainPromotion = New System.Windows.Forms.Label()
        Me.lblFerryPromotion = New System.Windows.Forms.Label()
        Me.lblBusPromotion = New System.Windows.Forms.Label()
        Me.txtTransType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbFerry = New System.Windows.Forms.PictureBox()
        Me.pbBus = New System.Windows.Forms.PictureBox()
        Me.pbTrain = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbFerry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTrainPromotion)
        Me.GroupBox1.Controls.Add(Me.lblFerryPromotion)
        Me.GroupBox1.Controls.Add(Me.lblBusPromotion)
        Me.GroupBox1.Controls.Add(Me.txtTransType)
        Me.GroupBox1.Controls.Add(Me.pbFerry)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.pbBus)
        Me.GroupBox1.Controls.Add(Me.pbTrain)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 104)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a tranport type,"
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
        'txtTransType
        '
        Me.txtTransType.Enabled = False
        Me.txtTransType.Location = New System.Drawing.Point(431, 18)
        Me.txtTransType.Name = "txtTransType"
        Me.txtTransType.Size = New System.Drawing.Size(100, 20)
        Me.txtTransType.TabIndex = 3
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
        'TranportSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TranportSelection"
        Me.Size = New System.Drawing.Size(537, 104)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbFerry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTrain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTrainPromotion As Label
    Friend WithEvents lblFerryPromotion As Label
    Friend WithEvents lblBusPromotion As Label
    Friend WithEvents txtTransType As TextBox
    Friend WithEvents pbFerry As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbBus As PictureBox
    Friend WithEvents pbTrain As PictureBox
End Class
