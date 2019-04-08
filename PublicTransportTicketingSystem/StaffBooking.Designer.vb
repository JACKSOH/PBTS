<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffBooking
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
        Me.gbTranport = New System.Windows.Forms.GroupBox()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.cboOrigin = New System.Windows.Forms.ComboBox()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.De = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ts1 = New PublicTransportTicketingSystem.TranportSelection()
        Me.gbTranport.SuspendLayout()
        Me.SuspendLayout()
        '
        'StaffMenuLayoutControl1
        '
        Me.StaffMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StaffMenuLayoutControl1.Name = "StaffMenuLayoutControl1"
        Me.StaffMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.StaffMenuLayoutControl1.TabIndex = 0
        '
        'gbTranport
        '
        Me.gbTranport.BackColor = System.Drawing.SystemColors.Control
        Me.gbTranport.Controls.Add(Me.cboDestination)
        Me.gbTranport.Controls.Add(Me.cboOrigin)
        Me.gbTranport.Controls.Add(Me.dtpDeparture)
        Me.gbTranport.Controls.Add(Me.Label8)
        Me.gbTranport.Controls.Add(Me.De)
        Me.gbTranport.Controls.Add(Me.Label5)
        Me.gbTranport.Controls.Add(Me.Label4)
        Me.gbTranport.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTranport.Location = New System.Drawing.Point(237, 212)
        Me.gbTranport.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTranport.Name = "gbTranport"
        Me.gbTranport.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTranport.Size = New System.Drawing.Size(537, 134)
        Me.gbTranport.TabIndex = 41
        Me.gbTranport.TabStop = False
        Me.gbTranport.Text = "Train Ticket"
        '
        'cboDestination
        '
        Me.cboDestination.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(133, 54)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(94, 27)
        Me.cboDestination.TabIndex = 19
        Me.cboDestination.Text = "Destination"
        '
        'cboOrigin
        '
        Me.cboOrigin.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigin.FormattingEnabled = True
        Me.cboOrigin.Location = New System.Drawing.Point(18, 54)
        Me.cboOrigin.Name = "cboOrigin"
        Me.cboOrigin.Size = New System.Drawing.Size(94, 27)
        Me.cboOrigin.TabIndex = 18
        Me.cboOrigin.Text = "Origin"
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeparture.Location = New System.Drawing.Point(264, 54)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(195, 22)
        Me.dtpDeparture.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(263, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 16
        '
        'De
        '
        Me.De.AutoSize = True
        Me.De.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.De.ForeColor = System.Drawing.Color.Black
        Me.De.Location = New System.Drawing.Point(263, 33)
        Me.De.Name = "De"
        Me.De.Size = New System.Drawing.Size(108, 19)
        Me.De.TabIndex = 14
        Me.De.Text = "Departure date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(129, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "From"
        '
        'ts1
        '
        Me.ts1.Location = New System.Drawing.Point(237, 91)
        Me.ts1.Name = "ts1"
        Me.ts1.Size = New System.Drawing.Size(537, 104)
        Me.ts1.TabIndex = 42
        '
        'StaffBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.ts1)
        Me.Controls.Add(Me.gbTranport)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffBooking"
        Me.Text = "StaffBooking"
        Me.gbTranport.ResumeLayout(False)
        Me.gbTranport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents gbTranport As GroupBox
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents De As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents cboOrigin As ComboBox
    Friend WithEvents ts1 As TranportSelection
End Class
