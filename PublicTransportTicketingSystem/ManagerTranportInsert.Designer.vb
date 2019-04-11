<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerTranportInsert
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.lblTransId = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mskColumn = New System.Windows.Forms.MaskedTextBox()
        Me.mskRow = New System.Windows.Forms.MaskedTextBox()
        Me.mskSeatPrice = New System.Windows.Forms.MaskedTextBox()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transport Id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Seat Base Price( RM) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "C&ompany :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "&License Plate :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tranport Width(Column) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(235, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "&Height (Row):"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Location = New System.Drawing.Point(79, 358)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 34)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtPlate
        '
        Me.txtPlate.Location = New System.Drawing.Point(77, 273)
        Me.txtPlate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPlate.MaxLength = 10
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(116, 25)
        Me.txtPlate.TabIndex = 10
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"bus", "train", "ferry"})
        Me.cboType.Location = New System.Drawing.Point(77, 219)
        Me.cboType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(140, 27)
        Me.cboType.TabIndex = 8
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(75, 167)
        Me.txtCompany.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCompany.MaxLength = 100
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(231, 25)
        Me.txtCompany.TabIndex = 6
        '
        'lblTransId
        '
        Me.lblTransId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTransId.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransId.Location = New System.Drawing.Point(75, 67)
        Me.lblTransId.Name = "lblTransId"
        Me.lblTransId.Size = New System.Drawing.Size(142, 25)
        Me.lblTransId.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tw Cen MT Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(189, 369)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "New tranport"
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'mskColumn
        '
        Me.mskColumn.Location = New System.Drawing.Point(77, 324)
        Me.mskColumn.Mask = "00"
        Me.mskColumn.Name = "mskColumn"
        Me.mskColumn.Size = New System.Drawing.Size(40, 25)
        Me.mskColumn.TabIndex = 12
        Me.mskColumn.ValidatingType = GetType(Integer)
        '
        'mskRow
        '
        Me.mskRow.Location = New System.Drawing.Point(239, 324)
        Me.mskRow.Mask = "00"
        Me.mskRow.Name = "mskRow"
        Me.mskRow.Size = New System.Drawing.Size(40, 25)
        Me.mskRow.TabIndex = 14
        '
        'mskSeatPrice
        '
        Me.mskSeatPrice.Location = New System.Drawing.Point(77, 114)
        Me.mskSeatPrice.Mask = "0000.00"
        Me.mskSeatPrice.Name = "mskSeatPrice"
        Me.mskSeatPrice.Size = New System.Drawing.Size(65, 25)
        Me.mskSeatPrice.TabIndex = 4
        '
        'ManagerTranportInsert
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(389, 436)
        Me.Controls.Add(Me.mskSeatPrice)
        Me.Controls.Add(Me.mskRow)
        Me.Controls.Add(Me.mskColumn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTransId)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtPlate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ManagerTranportInsert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerTranportInsert"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPlate As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents lblTransId As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents mskSeatPrice As MaskedTextBox
    Friend WithEvents mskRow As MaskedTextBox
    Friend WithEvents mskColumn As MaskedTextBox
End Class
