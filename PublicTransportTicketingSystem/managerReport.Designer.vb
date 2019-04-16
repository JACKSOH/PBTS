<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managerReport
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
        Dim Label1 As System.Windows.Forms.Label
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.rbDailyBook = New System.Windows.Forms.RadioButton()
        Me.gbReport = New System.Windows.Forms.GroupBox()
        Me.lblTransport = New System.Windows.Forms.Label()
        Me.rbMonthlyTransaction = New System.Windows.Forms.RadioButton()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.rbMonthlyPromotion = New System.Windows.Forms.RadioButton()
        Me.rbMonthlySchedule = New System.Windows.Forms.RadioButton()
        Me.TranportSelection1 = New PublicTransportTicketingSystem.TranportSelection()
        Me.lblDescription = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.gbReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label1.Location = New System.Drawing.Point(8, 21)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(125, 19)
        Label1.TabIndex = 10
        Label1.Text = "Selected Transport :"
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(859, 615)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'rbDailyBook
        '
        Me.rbDailyBook.AutoSize = True
        Me.rbDailyBook.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDailyBook.Location = New System.Drawing.Point(30, 86)
        Me.rbDailyBook.Name = "rbDailyBook"
        Me.rbDailyBook.Size = New System.Drawing.Size(150, 23)
        Me.rbDailyBook.TabIndex = 3
        Me.rbDailyBook.TabStop = True
        Me.rbDailyBook.Text = "Daily &Booking Report"
        Me.rbDailyBook.UseVisualStyleBackColor = True
        '
        'gbReport
        '
        Me.gbReport.Controls.Add(Me.lblTransport)
        Me.gbReport.Controls.Add(Label1)
        Me.gbReport.Controls.Add(Me.rbMonthlyTransaction)
        Me.gbReport.Controls.Add(Me.btnGenerate)
        Me.gbReport.Controls.Add(Me.rbMonthlyPromotion)
        Me.gbReport.Controls.Add(Me.rbMonthlySchedule)
        Me.gbReport.Controls.Add(Me.rbDailyBook)
        Me.gbReport.Enabled = False
        Me.gbReport.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbReport.Location = New System.Drawing.Point(373, 220)
        Me.gbReport.Name = "gbReport"
        Me.gbReport.Size = New System.Drawing.Size(301, 270)
        Me.gbReport.TabIndex = 4
        Me.gbReport.TabStop = False
        Me.gbReport.Text = "Choose ONE report Type"
        '
        'lblTransport
        '
        Me.lblTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTransport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTransport.Location = New System.Drawing.Point(6, 40)
        Me.lblTransport.Name = "lblTransport"
        Me.lblTransport.Size = New System.Drawing.Size(125, 28)
        Me.lblTransport.TabIndex = 11
        '
        'rbMonthlyTransaction
        '
        Me.rbMonthlyTransaction.AutoSize = True
        Me.rbMonthlyTransaction.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMonthlyTransaction.Location = New System.Drawing.Point(30, 173)
        Me.rbMonthlyTransaction.Name = "rbMonthlyTransaction"
        Me.rbMonthlyTransaction.Size = New System.Drawing.Size(187, 23)
        Me.rbMonthlyTransaction.TabIndex = 6
        Me.rbMonthlyTransaction.TabStop = True
        Me.rbMonthlyTransaction.Text = "Monthly &Transaction Report"
        Me.rbMonthlyTransaction.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(79, 217)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(87, 47)
        Me.btnGenerate.TabIndex = 7
        Me.btnGenerate.Text = "&Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'rbMonthlyPromotion
        '
        Me.rbMonthlyPromotion.AutoSize = True
        Me.rbMonthlyPromotion.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMonthlyPromotion.Location = New System.Drawing.Point(30, 144)
        Me.rbMonthlyPromotion.Name = "rbMonthlyPromotion"
        Me.rbMonthlyPromotion.Size = New System.Drawing.Size(180, 23)
        Me.rbMonthlyPromotion.TabIndex = 5
        Me.rbMonthlyPromotion.TabStop = True
        Me.rbMonthlyPromotion.Text = "Monthly &Promotion Report"
        Me.rbMonthlyPromotion.UseVisualStyleBackColor = True
        '
        'rbMonthlySchedule
        '
        Me.rbMonthlySchedule.AutoSize = True
        Me.rbMonthlySchedule.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMonthlySchedule.Location = New System.Drawing.Point(30, 115)
        Me.rbMonthlySchedule.Name = "rbMonthlySchedule"
        Me.rbMonthlySchedule.Size = New System.Drawing.Size(238, 23)
        Me.rbMonthlySchedule.TabIndex = 4
        Me.rbMonthlySchedule.TabStop = True
        Me.rbMonthlySchedule.Text = "Monthly T&ransport Travelling Report"
        Me.rbMonthlySchedule.UseVisualStyleBackColor = True
        '
        'TranportSelection1
        '
        Me.TranportSelection1.Location = New System.Drawing.Point(272, 101)
        Me.TranportSelection1.Name = "TranportSelection1"
        Me.TranportSelection1.Size = New System.Drawing.Size(537, 104)
        Me.TranportSelection1.TabIndex = 8
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Red
        Me.lblDescription.Location = New System.Drawing.Point(422, 493)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(229, 113)
        Me.lblDescription.TabIndex = 9
        Me.lblDescription.Text = "*Select only one report to generate"
        '
        'managerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 615)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.TranportSelection1)
        Me.Controls.Add(Me.gbReport)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "managerReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "managerReport"
        Me.gbReport.ResumeLayout(False)
        Me.gbReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
    Friend WithEvents rbDailyBook As RadioButton
    Friend WithEvents gbReport As GroupBox
    Friend WithEvents rbMonthlyTransaction As RadioButton
    Friend WithEvents rbMonthlyPromotion As RadioButton
    Friend WithEvents rbMonthlySchedule As RadioButton
    Friend WithEvents btnGenerate As Button
    Friend WithEvents TranportSelection1 As TranportSelection
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTransport As Label
End Class
