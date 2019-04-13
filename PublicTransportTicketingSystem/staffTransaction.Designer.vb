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
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.TicketTableAdapter()
        Me.TicketIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(323, 174)
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
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "bookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "bookingID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        Me.BookingIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "customerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 132
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "totalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalPriceDataGridViewTextBoxColumn.Width = 96
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TicketIDDataGridViewTextBoxColumn, Me.SeatIDDataGridViewTextBoxColumn, Me.PurchaseDateTimeDataGridViewTextBoxColumn, Me.TicketPriceDataGridViewTextBoxColumn, Me.TicketStatusDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TicketBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(724, 174)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(317, 349)
        Me.DataGridView2.TabIndex = 2
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
        'TicketIDDataGridViewTextBoxColumn
        '
        Me.TicketIDDataGridViewTextBoxColumn.DataPropertyName = "ticketID"
        Me.TicketIDDataGridViewTextBoxColumn.HeaderText = "ticketID"
        Me.TicketIDDataGridViewTextBoxColumn.Name = "TicketIDDataGridViewTextBoxColumn"
        '
        'SeatIDDataGridViewTextBoxColumn
        '
        Me.SeatIDDataGridViewTextBoxColumn.DataPropertyName = "seatID"
        Me.SeatIDDataGridViewTextBoxColumn.HeaderText = "seatID"
        Me.SeatIDDataGridViewTextBoxColumn.Name = "SeatIDDataGridViewTextBoxColumn"
        '
        'PurchaseDateTimeDataGridViewTextBoxColumn
        '
        Me.PurchaseDateTimeDataGridViewTextBoxColumn.DataPropertyName = "purchaseDateTime"
        Me.PurchaseDateTimeDataGridViewTextBoxColumn.HeaderText = "purchaseDateTime"
        Me.PurchaseDateTimeDataGridViewTextBoxColumn.Name = "PurchaseDateTimeDataGridViewTextBoxColumn"
        '
        'TicketPriceDataGridViewTextBoxColumn
        '
        Me.TicketPriceDataGridViewTextBoxColumn.DataPropertyName = "ticketPrice"
        Me.TicketPriceDataGridViewTextBoxColumn.HeaderText = "ticketPrice"
        Me.TicketPriceDataGridViewTextBoxColumn.Name = "TicketPriceDataGridViewTextBoxColumn"
        '
        'TicketStatusDataGridViewTextBoxColumn
        '
        Me.TicketStatusDataGridViewTextBoxColumn.DataPropertyName = "ticketStatus"
        Me.TicketStatusDataGridViewTextBoxColumn.HeaderText = "ticketStatus"
        Me.TicketStatusDataGridViewTextBoxColumn.Name = "TicketStatusDataGridViewTextBoxColumn"
        '
        'staffTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 708)
        Me.Controls.Add(Me.DataGridView2)
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
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PTTSDataSet As PTTSDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As PTTSDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TicketBindingSource As BindingSource
    Friend WithEvents TicketTableAdapter As PTTSDataSetTableAdapters.TicketTableAdapter
    Friend WithEvents TicketIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TicketPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TicketStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
