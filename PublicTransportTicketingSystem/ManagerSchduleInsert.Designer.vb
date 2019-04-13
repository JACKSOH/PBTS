<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerSchduleInsert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerSchduleInsert))
        Me.label = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCarrier = New System.Windows.Forms.ComboBox()
        Me.TransportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTTSDataSet = New PublicTransportTicketingSystem.PTTSDataSet()
        Me.cboOrigin = New System.Windows.Forms.ComboBox()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.LocationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNewId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LocationTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.LocationTableAdapter()
        Me.test = New System.Windows.Forms.TextBox()
        Me.TransportTableAdapter = New PublicTransportTicketingSystem.PTTSDataSetTableAdapters.TransportTableAdapter()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(105, 41)
        Me.label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(132, 19)
        Me.label.TabIndex = 0
        Me.label.Text = "New Schedule ID :"
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(310, 275)
        Me.dtpTime.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTime.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(128, 25)
        Me.dtpTime.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pick a tranport Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Origin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pick a Departure Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Destination"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"bus", "ferry", "train"})
        Me.cboType.Location = New System.Drawing.Point(109, 136)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 27)
        Me.cboType.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Pick a Carrier"
        '
        'cboCarrier
        '
        Me.cboCarrier.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TransportBindingSource, "transportID", True))
        Me.cboCarrier.DataSource = Me.TransportBindingSource
        Me.cboCarrier.DisplayMember = "transportName"
        Me.cboCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCarrier.FormattingEnabled = True
        Me.cboCarrier.Location = New System.Drawing.Point(291, 136)
        Me.cboCarrier.Name = "cboCarrier"
        Me.cboCarrier.Size = New System.Drawing.Size(351, 27)
        Me.cboCarrier.TabIndex = 10
        '
        'TransportBindingSource
        '
        Me.TransportBindingSource.DataMember = "Transport"
        Me.TransportBindingSource.DataSource = Me.PTTSDataSet
        '
        'PTTSDataSet
        '
        Me.PTTSDataSet.DataSetName = "PTTSDataSet"
        Me.PTTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboOrigin
        '
        Me.cboOrigin.DataSource = Me.LocationBindingSource
        Me.cboOrigin.DisplayMember = "locationName"
        Me.cboOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigin.FormattingEnabled = True
        Me.cboOrigin.Location = New System.Drawing.Point(109, 188)
        Me.cboOrigin.Name = "cboOrigin"
        Me.cboOrigin.Size = New System.Drawing.Size(202, 27)
        Me.cboOrigin.TabIndex = 11
        Me.cboOrigin.ValueMember = "locationID"
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.PTTSDataSet
        '
        'cboDestination
        '
        Me.cboDestination.DataSource = Me.LocationBindingSource1
        Me.cboDestination.DisplayMember = "locationName"
        Me.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(409, 188)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(220, 27)
        Me.cboDestination.TabIndex = 12
        Me.cboDestination.ValueMember = "locationID"
        '
        'LocationBindingSource1
        '
        Me.LocationBindingSource1.DataMember = "Location"
        Me.LocationBindingSource1.DataSource = Me.PTTSDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(334, 197)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lblNewId
        '
        Me.lblNewId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewId.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewId.Location = New System.Drawing.Point(105, 60)
        Me.lblNewId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewId.Name = "lblNewId"
        Me.lblNewId.Size = New System.Drawing.Size(143, 30)
        Me.lblNewId.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(306, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Time"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(109, 275)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(161, 25)
        Me.dtpDate.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Does not repeat", "Weekly on X (within this month)", "Everyday on this week"})
        Me.ComboBox1.Location = New System.Drawing.Point(109, 340)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(239, 27)
        Me.ComboBox1.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(105, 318)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Created for :"
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tw Cen MT Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(202, 397)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(109, 386)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 34)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'LocationTableAdapter
        '
        Me.LocationTableAdapter.ClearBeforeFill = True
        '
        'test
        '
        Me.test.Location = New System.Drawing.Point(504, 306)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(100, 25)
        Me.test.TabIndex = 36
        '
        'TransportTableAdapter
        '
        Me.TransportTableAdapter.ClearBeforeFill = True
        '
        'ManagerSchduleInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 468)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNewId)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboDestination)
        Me.Controls.Add(Me.cboOrigin)
        Me.Controls.Add(Me.cboCarrier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.label)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ManagerSchduleInsert"
        Me.Text = "ManagerSchduleInsert"
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label As Label
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCarrier As ComboBox
    Friend WithEvents cboOrigin As ComboBox
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNewId As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents err As ErrorProvider
    Friend WithEvents PTTSDataSet As PTTSDataSet
    Friend WithEvents LocationBindingSource As BindingSource
    Friend WithEvents LocationTableAdapter As PTTSDataSetTableAdapters.LocationTableAdapter
    Friend WithEvents LocationBindingSource1 As BindingSource
    Friend WithEvents test As TextBox
    Friend WithEvents TransportBindingSource As BindingSource
    Friend WithEvents TransportTableAdapter As PTTSDataSetTableAdapters.TransportTableAdapter
End Class
