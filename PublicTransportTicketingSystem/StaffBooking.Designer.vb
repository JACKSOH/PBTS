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
        Me.gbTrain = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.cboOrigin = New System.Windows.Forms.ComboBox()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.De = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TranportSelection1 = New PublicTransportTicketingSystem.TranportSelection()
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.gbTrain.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTrain
        '
        Me.gbTrain.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gbTrain.Controls.Add(Me.btnSearch)
        Me.gbTrain.Controls.Add(Me.cboDestination)
        Me.gbTrain.Controls.Add(Me.cboOrigin)
        Me.gbTrain.Controls.Add(Me.dtpDeparture)
        Me.gbTrain.Controls.Add(Me.Label8)
        Me.gbTrain.Controls.Add(Me.De)
        Me.gbTrain.Controls.Add(Me.Label5)
        Me.gbTrain.Controls.Add(Me.Label4)
        Me.gbTrain.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrain.Location = New System.Drawing.Point(316, 261)
        Me.gbTrain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbTrain.Name = "gbTrain"
        Me.gbTrain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbTrain.Size = New System.Drawing.Size(716, 165)
        Me.gbTrain.TabIndex = 41
        Me.gbTrain.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(24, 114)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(133, 34)
        Me.btnSearch.TabIndex = 43
        Me.btnSearch.Text = "&SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cboDestination
        '
        Me.cboDestination.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(177, 66)
        Me.cboDestination.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(124, 31)
        Me.cboDestination.TabIndex = 19
        Me.cboDestination.Text = "Destination"
        '
        'cboOrigin
        '
        Me.cboOrigin.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigin.FormattingEnabled = True
        Me.cboOrigin.Location = New System.Drawing.Point(24, 66)
        Me.cboOrigin.Margin = New System.Windows.Forms.Padding(4)
        Me.cboOrigin.Name = "cboOrigin"
        Me.cboOrigin.Size = New System.Drawing.Size(124, 31)
        Me.cboOrigin.TabIndex = 18
        Me.cboOrigin.Text = "Origin"
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeparture.Location = New System.Drawing.Point(352, 66)
        Me.dtpDeparture.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(259, 25)
        Me.dtpDeparture.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(351, 95)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 22)
        Me.Label8.TabIndex = 16
        '
        'De
        '
        Me.De.AutoSize = True
        Me.De.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.De.ForeColor = System.Drawing.Color.Black
        Me.De.Location = New System.Drawing.Point(351, 41)
        Me.De.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.De.Name = "De"
        Me.De.Size = New System.Drawing.Size(135, 23)
        Me.De.TabIndex = 14
        Me.De.Text = "Departure date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(172, 41)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "From"
        '
        'TranportSelection1
        '
        Me.TranportSelection1.Location = New System.Drawing.Point(316, 112)
        Me.TranportSelection1.Margin = New System.Windows.Forms.Padding(5)
        Me.TranportSelection1.Name = "TranportSelection1"
        Me.TranportSelection1.Size = New System.Drawing.Size(716, 128)
        Me.TranportSelection1.TabIndex = 42
        '
        'StaffMenuLayoutControl1
        '
        Me.StaffMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StaffMenuLayoutControl1.Name = "StaffMenuLayoutControl1"
        Me.StaffMenuLayoutControl1.Size = New System.Drawing.Size(1067, 708)
        Me.StaffMenuLayoutControl1.TabIndex = 0
        '
        'StaffBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 708)
        Me.Controls.Add(Me.TranportSelection1)
        Me.Controls.Add(Me.gbTrain)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StaffBooking"
        Me.Text = "StaffBooking"
        Me.gbTrain.ResumeLayout(False)
        Me.gbTrain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents gbTrain As GroupBox
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents De As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents cboOrigin As ComboBox
    Friend WithEvents TranportSelection1 As TranportSelection
    Friend WithEvents btnSearch As Button
End Class
