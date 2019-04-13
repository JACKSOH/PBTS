<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffTransaction
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
        Me.components = New System.ComponentModel.Container()
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PTTSDataSet = New PublicTransportTicketingSystem.PTTSDataSet()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.BookingTableAdapter()
        Me.TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.TicketTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TicketBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TicketIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.employeeID, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(331, 191)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(348, 349)
        Me.DataGridView1.TabIndex = 1
        '
        'PTTSDataSet
        '
        Me.PTTSDataSet.DataSetName = "PTTSDataSet"
        Me.PTTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.PTTSDataSet
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'TicketBindingSource
        '
        Me.TicketBindingSource.DataMember = "Ticket"
        Me.TicketBindingSource.DataSource = Me.PTTSDataSet
        '
        'TicketTableAdapter
        '
        Me.TicketTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bookings"
        '
        'TicketBindingSource1
        '
        Me.TicketBindingSource1.DataMember = "Ticket"
        Me.TicketBindingSource1.DataSource = Me.PTTSDataSet
        '
        'TicketBindingSource2
        '
        Me.TicketBindingSource2.DataMember = "Ticket"
        Me.TicketBindingSource2.DataSource = Me.PTTSDataSet
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TicketIDDataGridViewTextBoxColumn, Me.TicketPriceDataGridViewTextBoxColumn, Me.TicketStatusDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TicketBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(709, 191)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(348, 349)
        Me.DataGridView2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(837, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tickets"
        '
        'TicketIDDataGridViewTextBoxColumn
        '
        Me.TicketIDDataGridViewTextBoxColumn.DataPropertyName = "ticketID"
        Me.TicketIDDataGridViewTextBoxColumn.HeaderText = "Ticket ID"
        Me.TicketIDDataGridViewTextBoxColumn.Name = "TicketIDDataGridViewTextBoxColumn"
        Me.TicketIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TicketPriceDataGridViewTextBoxColumn
        '
        Me.TicketPriceDataGridViewTextBoxColumn.DataPropertyName = "ticketPrice"
        Me.TicketPriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.TicketPriceDataGridViewTextBoxColumn.Name = "TicketPriceDataGridViewTextBoxColumn"
        Me.TicketPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TicketStatusDataGridViewTextBoxColumn
        '
        Me.TicketStatusDataGridViewTextBoxColumn.DataPropertyName = "ticketStatus"
        Me.TicketStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.TicketStatusDataGridViewTextBoxColumn.Name = "TicketStatusDataGridViewTextBoxColumn"
        Me.TicketStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "bookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "Booking ID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        Me.BookingIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'employeeID
        '
        Me.employeeID.DataPropertyName = "employeeID"
        Me.employeeID.HeaderText = "Employee ID"
        Me.employeeID.Name = "employeeID"
        Me.employeeID.ReadOnly = True
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'staffTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 728)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "staffTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staffTransaction"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PTTSDataSet As PTTSDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As PTTSDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents TicketBindingSource As BindingSource
    Friend WithEvents TicketTableAdapter As PTTSDataSetTableAdapters.TicketTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TicketBindingSource1 As BindingSource
    Friend WithEvents TicketBindingSource2 As BindingSource
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents employeeID As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TicketIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TicketPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TicketStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
