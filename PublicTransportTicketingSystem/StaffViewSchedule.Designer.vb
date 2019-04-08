<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffViewSchedule
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
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pbFerry = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbBus = New System.Windows.Forms.PictureBox()
        Me.pbTrain = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ScheduleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartureDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivalDateTImeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSet = New PublicTransportTicketingSystem.PTTSDataSet()
        Me.PTTSDataSet1 = New PublicTransportTicketingSystem.PTTSDataSet1()
        Me.ScheduleTableAdapter1 = New PublicTransportTicketingSystem.PTTSDataSet1TableAdapters.ScheduleTableAdapter()
        Me.TableAdapterManager = New PublicTransportTicketingSystem.PTTSDataSet1TableAdapters.TableAdapterManager()
        Me.ScheduleTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.ScheduleTableAdapter()
        Me.PTTSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbTrain = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.De = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbFerry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTrain.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.pbFerry)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.pbBus)
        Me.GroupBox1.Controls.Add(Me.pbTrain)
        Me.GroupBox1.Location = New System.Drawing.Point(239, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a tranport type,"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(132, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'pbFerry
        '
        Me.pbFerry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFerry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFerry.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.ferry
        Me.pbFerry.Location = New System.Drawing.Point(116, 18)
        Me.pbFerry.Name = "pbFerry"
        Me.pbFerry.Size = New System.Drawing.Size(60, 51)
        Me.pbFerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFerry.TabIndex = 20
        Me.pbFerry.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selected Transport:"
        '
        'pbBus
        '
        Me.pbBus.BackColor = System.Drawing.SystemColors.Control
        Me.pbBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBus.Image = Global.PublicTransportTicketingSystem.My.Resources.Resources.bus
        Me.pbBus.Location = New System.Drawing.Point(206, 19)
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ScheduleIDDataGridViewTextBoxColumn, Me.OriginIDDataGridViewTextBoxColumn, Me.DestinationIDDataGridViewTextBoxColumn, Me.DepartureDateTimeDataGridViewTextBoxColumn, Me.ArrivalDateTImeDataGridViewTextBoxColumn, Me.TransportIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ScheduleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(239, 359)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(537, 169)
        Me.DataGridView1.TabIndex = 2
        '
        'ScheduleIDDataGridViewTextBoxColumn
        '
        Me.ScheduleIDDataGridViewTextBoxColumn.DataPropertyName = "scheduleID"
        Me.ScheduleIDDataGridViewTextBoxColumn.HeaderText = "scheduleID"
        Me.ScheduleIDDataGridViewTextBoxColumn.Name = "ScheduleIDDataGridViewTextBoxColumn"
        Me.ScheduleIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OriginIDDataGridViewTextBoxColumn
        '
        Me.OriginIDDataGridViewTextBoxColumn.DataPropertyName = "originID"
        Me.OriginIDDataGridViewTextBoxColumn.HeaderText = "originID"
        Me.OriginIDDataGridViewTextBoxColumn.Name = "OriginIDDataGridViewTextBoxColumn"
        Me.OriginIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DestinationIDDataGridViewTextBoxColumn
        '
        Me.DestinationIDDataGridViewTextBoxColumn.DataPropertyName = "destinationID"
        Me.DestinationIDDataGridViewTextBoxColumn.HeaderText = "destinationID"
        Me.DestinationIDDataGridViewTextBoxColumn.Name = "DestinationIDDataGridViewTextBoxColumn"
        Me.DestinationIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartureDateTimeDataGridViewTextBoxColumn
        '
        Me.DepartureDateTimeDataGridViewTextBoxColumn.DataPropertyName = "departureDateTime"
        Me.DepartureDateTimeDataGridViewTextBoxColumn.HeaderText = "departureDateTime"
        Me.DepartureDateTimeDataGridViewTextBoxColumn.Name = "DepartureDateTimeDataGridViewTextBoxColumn"
        Me.DepartureDateTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArrivalDateTImeDataGridViewTextBoxColumn
        '
        Me.ArrivalDateTImeDataGridViewTextBoxColumn.DataPropertyName = "arrivalDateTIme"
        Me.ArrivalDateTImeDataGridViewTextBoxColumn.HeaderText = "arrivalDateTIme"
        Me.ArrivalDateTImeDataGridViewTextBoxColumn.Name = "ArrivalDateTImeDataGridViewTextBoxColumn"
        Me.ArrivalDateTImeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransportIDDataGridViewTextBoxColumn
        '
        Me.TransportIDDataGridViewTextBoxColumn.DataPropertyName = "transportID"
        Me.TransportIDDataGridViewTextBoxColumn.HeaderText = "transportID"
        Me.TransportIDDataGridViewTextBoxColumn.Name = "TransportIDDataGridViewTextBoxColumn"
        Me.TransportIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ScheduleBindingSource
        '
        Me.ScheduleBindingSource.DataMember = "Schedule"
        Me.ScheduleBindingSource.DataSource = Me.PTTSDataSet
        '
        'PTTSDataSet
        '
        Me.PTTSDataSet.DataSetName = "PTTSDataSet"
        Me.PTTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PTTSDataSet1
        '
        Me.PTTSDataSet1.DataSetName = "PTTSDataSet1"
        Me.PTTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScheduleTableAdapter1
        '
        Me.ScheduleTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.ScheduleTableAdapter = Me.ScheduleTableAdapter1
        Me.TableAdapterManager.SeatTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PublicTransportTicketingSystem.PTTSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ScheduleTableAdapter
        '
        Me.ScheduleTableAdapter.ClearBeforeFill = True
        '
        'PTTSDataSetBindingSource
        '
        Me.PTTSDataSetBindingSource.DataSource = Me.PTTSDataSet
        Me.PTTSDataSetBindingSource.Position = 0
        '
        'gbTrain
        '
        Me.gbTrain.BackColor = System.Drawing.SystemColors.Control
        Me.gbTrain.Controls.Add(Me.DateTimePicker1)
        Me.gbTrain.Controls.Add(Me.Label8)
        Me.gbTrain.Controls.Add(Me.De)
        Me.gbTrain.Controls.Add(Me.TextBox2)
        Me.gbTrain.Controls.Add(Me.Label5)
        Me.gbTrain.Controls.Add(Me.TextBox3)
        Me.gbTrain.Controls.Add(Me.Label4)
        Me.gbTrain.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTrain.Location = New System.Drawing.Point(239, 220)
        Me.gbTrain.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTrain.Name = "gbTrain"
        Me.gbTrain.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTrain.Size = New System.Drawing.Size(537, 134)
        Me.gbTrain.TabIndex = 3
        Me.gbTrain.TabStop = False
        Me.gbTrain.Text = "Train Ticket"
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
        Me.De.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.De.ForeColor = System.Drawing.Color.Black
        Me.De.Location = New System.Drawing.Point(263, 33)
        Me.De.Name = "De"
        Me.De.Size = New System.Drawing.Size(101, 17)
        Me.De.TabIndex = 14
        Me.De.Text = "Departure date"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(131, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Destination"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(129, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(27, 54)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "Origin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "From"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(264, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(195, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'StaffViewSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.gbTrain)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffViewSchedule"
        Me.Text = "StaffViewSchedule"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbFerry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTrain.ResumeLayout(False)
        Me.gbTrain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pbFerry As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbBus As PictureBox
    Friend WithEvents pbTrain As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PTTSDataSet As PTTSDataSet
    Friend WithEvents ScheduleBindingSource As BindingSource
    Friend WithEvents ScheduleTableAdapter As PTTSDataSetTableAdapters.ScheduleTableAdapter
    Friend WithEvents PTTSDataSetBindingSource As BindingSource
    Friend WithEvents PTTSDataSet1 As PTTSDataSet1
    Friend WithEvents ScheduleTableAdapter1 As PTTSDataSet1TableAdapters.ScheduleTableAdapter
    Friend WithEvents TableAdapterManager As PTTSDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ScheduleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OriginIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DestinationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartureDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalDateTImeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransportIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gbTrain As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents De As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
End Class
