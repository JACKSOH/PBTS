<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerPT
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
        Me.gbTranport = New System.Windows.Forms.GroupBox()
        Me.lbltest = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TransportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDeleteCancel = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicensePlateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranportColumnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranportRowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PTTSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSet = New PublicTransportTicketingSystem.PTTSDataSet()
        Me.TransportTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.TransportTableAdapter()
        Me.ts = New PublicTransportTicketingSystem.TranportSelection()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.gbTranport.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTranport
        '
        Me.gbTranport.Controls.Add(Me.lbltest)
        Me.gbTranport.Controls.Add(Me.dgv)
        Me.gbTranport.Controls.Add(Me.btnUpdate)
        Me.gbTranport.Controls.Add(Me.btnAdd)
        Me.gbTranport.Controls.Add(Me.btnDeleteCancel)
        Me.gbTranport.Location = New System.Drawing.Point(241, 207)
        Me.gbTranport.Name = "gbTranport"
        Me.gbTranport.Size = New System.Drawing.Size(547, 356)
        Me.gbTranport.TabIndex = 8
        Me.gbTranport.TabStop = False
        Me.gbTranport.Text = "Tranport Details"
        '
        'lbltest
        '
        Me.lbltest.AutoSize = True
        Me.lbltest.Location = New System.Drawing.Point(443, 74)
        Me.lbltest.Name = "lbltest"
        Me.lbltest.Size = New System.Drawing.Size(39, 13)
        Me.lbltest.TabIndex = 7
        Me.lbltest.Text = "Label1"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransportNameDataGridViewTextBoxColumn, Me.Status, Me.LicensePlateDataGridViewTextBoxColumn, Me.TranportColumnDataGridViewTextBoxColumn, Me.TranportRowDataGridViewTextBoxColumn, Me.TransportTypeDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.TransportBindingSource
        Me.dgv.Location = New System.Drawing.Point(19, 19)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(385, 303)
        Me.dgv.TabIndex = 5
        '
        'TransportBindingSource
        '
        Me.TransportBindingSource.DataMember = "Transport"
        Me.TransportBindingSource.DataSource = Me.PTTSDataSetBindingSource
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(400, 239)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(81, 38)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(400, 196)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 37)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDeleteCancel
        '
        Me.btnDeleteCancel.BackColor = System.Drawing.Color.Red
        Me.btnDeleteCancel.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteCancel.Location = New System.Drawing.Point(345, 317)
        Me.btnDeleteCancel.Name = "btnDeleteCancel"
        Me.btnDeleteCancel.Size = New System.Drawing.Size(59, 33)
        Me.btnDeleteCancel.TabIndex = 6
        Me.btnDeleteCancel.Text = "&Delete"
        Me.btnDeleteCancel.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.Status.DataPropertyName = "transportStatus"
        Me.Status.HeaderText = "Status"
        Me.Status.MaxInputLength = 30
        Me.Status.Name = "Status"
        Me.Status.Width = 50
        '
        'TransportNameDataGridViewTextBoxColumn
        '
        Me.TransportNameDataGridViewTextBoxColumn.DataPropertyName = "transportName"
        Me.TransportNameDataGridViewTextBoxColumn.HeaderText = "Carrier"
        Me.TransportNameDataGridViewTextBoxColumn.MaxInputLength = 30
        Me.TransportNameDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.TransportNameDataGridViewTextBoxColumn.Name = "TransportNameDataGridViewTextBoxColumn"
        Me.TransportNameDataGridViewTextBoxColumn.Width = 120
        '
        'LicensePlateDataGridViewTextBoxColumn
        '
        Me.LicensePlateDataGridViewTextBoxColumn.DataPropertyName = "licensePlate"
        Me.LicensePlateDataGridViewTextBoxColumn.HeaderText = "Plate"
        Me.LicensePlateDataGridViewTextBoxColumn.MaxInputLength = 10
        Me.LicensePlateDataGridViewTextBoxColumn.MinimumWidth = 50
        Me.LicensePlateDataGridViewTextBoxColumn.Name = "LicensePlateDataGridViewTextBoxColumn"
        Me.LicensePlateDataGridViewTextBoxColumn.Width = 50
        '
        'TranportColumnDataGridViewTextBoxColumn
        '
        Me.TranportColumnDataGridViewTextBoxColumn.DataPropertyName = "tranportColumn"
        Me.TranportColumnDataGridViewTextBoxColumn.HeaderText = "Seat Column"
        Me.TranportColumnDataGridViewTextBoxColumn.MaxInputLength = 2
        Me.TranportColumnDataGridViewTextBoxColumn.MinimumWidth = 50
        Me.TranportColumnDataGridViewTextBoxColumn.Name = "TranportColumnDataGridViewTextBoxColumn"
        Me.TranportColumnDataGridViewTextBoxColumn.Width = 50
        '
        'TranportRowDataGridViewTextBoxColumn
        '
        Me.TranportRowDataGridViewTextBoxColumn.DataPropertyName = "tranportRow"
        Me.TranportRowDataGridViewTextBoxColumn.HeaderText = "Seat Row"
        Me.TranportRowDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.TranportRowDataGridViewTextBoxColumn.MinimumWidth = 50
        Me.TranportRowDataGridViewTextBoxColumn.Name = "TranportRowDataGridViewTextBoxColumn"
        Me.TranportRowDataGridViewTextBoxColumn.Width = 50
        '
        'TransportTypeDataGridViewTextBoxColumn
        '
        Me.TransportTypeDataGridViewTextBoxColumn.DataPropertyName = "transportType"
        Me.TransportTypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TransportTypeDataGridViewTextBoxColumn.MaxInputLength = 30
        Me.TransportTypeDataGridViewTextBoxColumn.MinimumWidth = 70
        Me.TransportTypeDataGridViewTextBoxColumn.Name = "TransportTypeDataGridViewTextBoxColumn"
        Me.TransportTypeDataGridViewTextBoxColumn.Width = 70
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
        'TransportTableAdapter
        '
        Me.TransportTableAdapter.ClearBeforeFill = True
        '
        'ts
        '
        Me.ts.Location = New System.Drawing.Point(241, 90)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(547, 104)
        Me.ts.TabIndex = 6
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'ManagerPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.gbTranport)
        Me.Controls.Add(Me.ts)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ManagerPT"
        Me.Text = "ManagerPT"
        Me.gbTranport.ResumeLayout(False)
        Me.gbTranport.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents PTTSDataSetBindingSource As BindingSource
    Friend WithEvents PTTSDataSet As PTTSDataSet
    Friend WithEvents ts As TranportSelection
    Friend WithEvents gbTranport As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents TransportBindingSource As BindingSource
    Friend WithEvents TransportTableAdapter As PTTSDataSetTableAdapters.TransportTableAdapter
    Friend WithEvents btnDeleteCancel As Button
    Friend WithEvents lbltest As Label
    Friend WithEvents TransportNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents LicensePlateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranportColumnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranportRowDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransportTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
