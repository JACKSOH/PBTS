<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerManageLocation
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.LocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSet = New PublicTransportTicketingSystem.PTTSDataSet()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.LocationTableAdapter1 = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.LocationTableAdapter()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDeleteCancel = New System.Windows.Forms.Button()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.ts = New PublicTransportTicketingSystem.TranportSelection()
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocationIDDataGridViewTextBoxColumn, Me.LocationNameDataGridViewTextBoxColumn, Me.LocationTypeDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.LocationBindingSource
        Me.dgv.Location = New System.Drawing.Point(255, 225)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(413, 300)
        Me.dgv.TabIndex = 1
        '
        'LocationIDDataGridViewTextBoxColumn
        '
        Me.LocationIDDataGridViewTextBoxColumn.DataPropertyName = "locationID"
        Me.LocationIDDataGridViewTextBoxColumn.HeaderText = "locationID"
        Me.LocationIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LocationIDDataGridViewTextBoxColumn.Name = "LocationIDDataGridViewTextBoxColumn"
        '
        'LocationNameDataGridViewTextBoxColumn
        '
        Me.LocationNameDataGridViewTextBoxColumn.DataPropertyName = "locationName"
        Me.LocationNameDataGridViewTextBoxColumn.HeaderText = "locationName"
        Me.LocationNameDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.LocationNameDataGridViewTextBoxColumn.Name = "LocationNameDataGridViewTextBoxColumn"
        Me.LocationNameDataGridViewTextBoxColumn.Width = 120
        '
        'LocationTypeDataGridViewTextBoxColumn
        '
        Me.LocationTypeDataGridViewTextBoxColumn.DataPropertyName = "locationType"
        Me.LocationTypeDataGridViewTextBoxColumn.HeaderText = "locationType"
        Me.LocationTypeDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.LocationTypeDataGridViewTextBoxColumn.Name = "LocationTypeDataGridViewTextBoxColumn"
        Me.LocationTypeDataGridViewTextBoxColumn.Width = 150
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
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(674, 359)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(79, 25)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'LocationTableAdapter1
        '
        Me.LocationTableAdapter1.ClearBeforeFill = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAdd.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(674, 297)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 25)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDeleteCancel
        '
        Me.btnDeleteCancel.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCancel.Location = New System.Drawing.Point(674, 500)
        Me.btnDeleteCancel.Name = "btnDeleteCancel"
        Me.btnDeleteCancel.Size = New System.Drawing.Size(81, 25)
        Me.btnDeleteCancel.TabIndex = 4
        Me.btnDeleteCancel.Text = "&Delete"
        Me.btnDeleteCancel.UseVisualStyleBackColor = True
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(688, 225)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(100, 20)
        Me.txtTest.TabIndex = 6
        '
        'ts
        '
        Me.ts.Location = New System.Drawing.Point(251, 96)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(537, 104)
        Me.ts.TabIndex = 5
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'ManagerManageLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.ts)
        Me.Controls.Add(Me.btnDeleteCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerManageLocation"
        Me.RightToLeftLayout = True
        Me.Text = "ManagerManageLocation"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PTTSDataSetBindingSource As BindingSource
    Friend WithEvents PTTSDataSet As PTTSDataSet
    Friend WithEvents LocationTableAdapter1 As PTTSDataSetTableAdapters.LocationTableAdapter
    Friend WithEvents LocationBindingSource As BindingSource
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDeleteCancel As Button
    Friend WithEvents LocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ts As TranportSelection
    Friend WithEvents txtTest As TextBox
End Class
