<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffBooking
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
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.De = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.cboOrigin = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSet = New PublicTransportTicketingSystem.PTTSDataSet()
        Me.LocationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranportSelection1 = New PublicTransportTicketingSystem.TranportSelection()
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.LocationTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.LocationTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.dtpDeparture)
        Me.GroupBox1.Controls.Add(Me.cboDestination)
        Me.GroupBox1.Controls.Add(Me.cboOrigin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 213)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(494, 142)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(26, 94)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 33)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "&SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Font = New System.Drawing.Font("Tw Cen MT", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeparture.Location = New System.Drawing.Point(268, 50)
        Me.dtpDeparture.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(151, 23)
        Me.dtpDeparture.TabIndex = 16
        Me.dtpDeparture.Value = New Date(2019, 4, 12, 0, 0, 0, 0)
        '
        'cboDestination
        '
        Me.cboDestination.Font = New System.Drawing.Font("Tw Cen MT", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(129, 50)
        Me.cboDestination.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(92, 24)
        Me.cboDestination.TabIndex = 15
        Me.cboDestination.Text = "Destination"
        '
        'cboOrigin
        '
        Me.cboOrigin.Font = New System.Drawing.Font("Tw Cen MT", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigin.FormattingEnabled = True
        Me.cboOrigin.Location = New System.Drawing.Point(26, 50)
        Me.cboOrigin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboOrigin.Name = "cboOrigin"
        Me.cboOrigin.Size = New System.Drawing.Size(92, 24)
        Me.cboOrigin.TabIndex = 14
        Me.cboOrigin.Text = "Origin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(266, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Departure Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(126, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "From"
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.PTTSDataSetBindingSource
        '
        'PTTSDataSetBindingSource
        '
        Me.PTTSDataSetBindingSource.DataSource = Me.PTTSDataSet
        Me.PTTSDataSetBindingSource.Position = 0
        '
        'PTTSDataSet
        '
        Me.PTTSDataSet.DataSetName = "PTTSDataSet"
        Me.PTTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationBindingSource1
        '
        Me.LocationBindingSource1.DataMember = "Location"
        Me.LocationBindingSource1.DataSource = Me.PTTSDataSetBindingSource1
        '
        'PTTSDataSetBindingSource1
        '
        Me.PTTSDataSetBindingSource1.DataSource = Me.PTTSDataSet
        Me.PTTSDataSetBindingSource1.Position = 0
        '
        'TranportSelection1
        '
        Me.TranportSelection1.Location = New System.Drawing.Point(237, 91)
        Me.TranportSelection1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TranportSelection1.Name = "TranportSelection1"
        Me.TranportSelection1.Size = New System.Drawing.Size(537, 104)
        Me.TranportSelection1.TabIndex = 42
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
        'LocationTableAdapter
        '
        Me.LocationTableAdapter.ClearBeforeFill = True
        '
        'StaffBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TranportSelection1)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffBooking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents gbTranport As GroupBox

    Friend WithEvents Label8 As Label
    Friend WithEvents De As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label


    Friend WithEvents TranportSelection1 As TranportSelection


    Friend WithEvents ts1 As TranportSelection
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents cboOrigin As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PTTSDataSetBindingSource As BindingSource
    Friend WithEvents PTTSDataSet As PTTSDataSet
    Friend WithEvents LocationBindingSource As BindingSource
    Friend WithEvents LocationTableAdapter As PTTSDataSetTableAdapters.LocationTableAdapter
    Friend WithEvents LocationBindingSource1 As BindingSource
    Friend WithEvents PTTSDataSetBindingSource1 As BindingSource
End Class
