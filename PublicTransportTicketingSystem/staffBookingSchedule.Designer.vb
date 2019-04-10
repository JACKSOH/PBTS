<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffBookingSchedule
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
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.departureDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.SuspendLayout()
        '
        'StaffMenuLayoutControl1
        '
        Me.StaffMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StaffMenuLayoutControl1.Name = "StaffMenuLayoutControl1"
        Me.StaffMenuLayoutControl1.Size = New System.Drawing.Size(1067, 708)
        Me.StaffMenuLayoutControl1.TabIndex = 0
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.AutoGenerateColumns = False
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.departureDateTime, Me.OriginIDDataGridViewTextBoxColumn, Me.DestinationIDDataGridViewTextBoxColumn})
        Me.dgvSchedule.DataSource = Me.ScheduleBindingSource
        Me.dgvSchedule.Location = New System.Drawing.Point(315, 149)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.RowTemplate.Height = 24
        Me.dgvSchedule.Size = New System.Drawing.Size(350, 330)
        Me.dgvSchedule.TabIndex = 1
        '


        'departureDateTime
        '
        Me.departureDateTime.DataPropertyName = "departureDateTime"
        Me.departureDateTime.HeaderText = "DepartureTime"
        Me.departureDateTime.Name = "departureDateTime"
        Me.departureDateTime.ReadOnly = True
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
        'staffBookingSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 728)
        Me.Controls.Add(Me.dgvSchedule)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staffBookingSchedule"
        Me.Text = "staffBookingSchedule"
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents ScheduleBindingSource As BindingSource
    Friend WithEvents departureDateTime As DataGridViewTextBoxColumn
    Friend WithEvents OriginIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DestinationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
