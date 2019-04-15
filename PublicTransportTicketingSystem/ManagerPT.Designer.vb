<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerPT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerPT))
        Me.gbTranport = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TransportNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicensePlateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranportColumnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranportRowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSet = New PublicTransportTicketingSystem.PTTSDataSet()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDeleteCancel = New System.Windows.Forms.Button()
        Me.ts = New PublicTransportTicketingSystem.TranportSelection()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.TransportTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.TransportTableAdapter()
        Me.gbTranport.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTranport
        '
        Me.gbTranport.Controls.Add(Me.PictureBox1)
        Me.gbTranport.Controls.Add(Me.Label1)
        Me.gbTranport.Controls.Add(Me.dgv)
        Me.gbTranport.Controls.Add(Me.txtSearch)
        Me.gbTranport.Controls.Add(Me.btnUpdate)
        Me.gbTranport.Controls.Add(Me.btnAdd)
        Me.gbTranport.Controls.Add(Me.btnDeleteCancel)
        Me.gbTranport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTranport.Location = New System.Drawing.Point(241, 207)
        Me.gbTranport.Name = "gbTranport"
        Me.gbTranport.Size = New System.Drawing.Size(547, 356)
        Me.gbTranport.TabIndex = 8
        Me.gbTranport.TabStop = False
        Me.gbTranport.Text = "Tranport Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(408, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(407, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Search carrier"
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
        Me.dgv.Size = New System.Drawing.Size(383, 331)
        Me.dgv.TabIndex = 5
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
        'Status
        '
        Me.Status.DataPropertyName = "transportStatus"
        Me.Status.HeaderText = "Status"
        Me.Status.MaxInputLength = 30
        Me.Status.Name = "Status"
        Me.Status.Width = 50
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
        'TransportBindingSource
        '
        Me.TransportBindingSource.DataMember = "Transport"
        Me.TransportBindingSource.DataSource = Me.PTTSDataSetBindingSource
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
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(441, 61)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 21)
        Me.txtSearch.TabIndex = 11
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
        Me.btnDeleteCancel.Location = New System.Drawing.Point(400, 323)
        Me.btnDeleteCancel.Name = "btnDeleteCancel"
        Me.btnDeleteCancel.Size = New System.Drawing.Size(59, 33)
        Me.btnDeleteCancel.TabIndex = 6
        Me.btnDeleteCancel.Text = "&Delete"
        Me.btnDeleteCancel.UseVisualStyleBackColor = False
        '
        'ts
        '
        Me.ts.Location = New System.Drawing.Point(241, 74)
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
        'TransportTableAdapter
        '
        Me.TransportTableAdapter.ClearBeforeFill = True
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TransportNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents LicensePlateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranportColumnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranportRowDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransportTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
End Class
