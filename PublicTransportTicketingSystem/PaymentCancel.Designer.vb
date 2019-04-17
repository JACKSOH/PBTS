<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentCancel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRefund = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancelAndRefund = New System.Windows.Forms.Button()
        Me.lblTicketIDHint = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTicketID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLicensePlate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDepartureTime = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDepartureDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPassengerName = New System.Windows.Forms.Label()
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRefund)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnCancelAndRefund)
        Me.GroupBox1.Controls.Add(Me.lblTicketIDHint)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTicketID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(227, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(348, 441)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cancel Payment"
        '
        'lblRefund
        '
        Me.lblRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRefund.Location = New System.Drawing.Point(115, 184)
        Me.lblRefund.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(137, 19)
        Me.lblRefund.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 181)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Refund"
        '
        'btnCancelAndRefund
        '
        Me.btnCancelAndRefund.Location = New System.Drawing.Point(107, 236)
        Me.btnCancelAndRefund.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancelAndRefund.Name = "btnCancelAndRefund"
        Me.btnCancelAndRefund.Size = New System.Drawing.Size(151, 30)
        Me.btnCancelAndRefund.TabIndex = 26
        Me.btnCancelAndRefund.Text = "Cancel and Refund"
        Me.btnCancelAndRefund.UseVisualStyleBackColor = True
        '
        'lblTicketIDHint
        '
        Me.lblTicketIDHint.AutoSize = True
        Me.lblTicketIDHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketIDHint.ForeColor = System.Drawing.Color.Red
        Me.lblTicketIDHint.Location = New System.Drawing.Point(113, 145)
        Me.lblTicketIDHint.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTicketIDHint.Name = "lblTicketIDHint"
        Me.lblTicketIDHint.Size = New System.Drawing.Size(85, 13)
        Me.lblTicketIDHint.TabIndex = 25
        Me.lblTicketIDHint.Text = "Invalid Ticket ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 120)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Ticket ID"
        '
        'txtTicketID
        '
        Me.txtTicketID.Location = New System.Drawing.Point(115, 119)
        Me.txtTicketID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTicketID.Name = "txtTicketID"
        Me.txtTicketID.Size = New System.Drawing.Size(138, 23)
        Me.txtTicketID.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLicensePlate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblSeat)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblCompany)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblDestination)
        Me.GroupBox2.Controls.Add(Me.lblOrigin)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblDepartureTime)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblDepartureDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblPassengerName)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(580, 76)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(219, 441)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ticket Details"
        '
        'lblLicensePlate
        '
        Me.lblLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLicensePlate.Location = New System.Drawing.Point(28, 302)
        Me.lblLicensePlate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLicensePlate.Name = "lblLicensePlate"
        Me.lblLicensePlate.Size = New System.Drawing.Size(160, 19)
        Me.lblLicensePlate.TabIndex = 28
        Me.lblLicensePlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(58, 284)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "License Plate"
        '
        'lblSeat
        '
        Me.lblSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeat.Location = New System.Drawing.Point(28, 344)
        Me.lblSeat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(160, 19)
        Me.lblSeat.TabIndex = 26
        Me.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(93, 325)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 18)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Seat"
        '
        'lblCompany
        '
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.Location = New System.Drawing.Point(28, 259)
        Me.lblCompany.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(160, 19)
        Me.lblCompany.TabIndex = 24
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(71, 240)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Company"
        '
        'lblDestination
        '
        Me.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDestination.Location = New System.Drawing.Point(28, 216)
        Me.lblDestination.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(160, 19)
        Me.lblDestination.TabIndex = 22
        Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOrigin
        '
        Me.lblOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrigin.Location = New System.Drawing.Point(28, 174)
        Me.lblOrigin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(160, 19)
        Me.lblOrigin.TabIndex = 21
        Me.lblOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(69, 197)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 18)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Destination"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(28, 386)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(160, 19)
        Me.lblPrice.TabIndex = 14
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(91, 366)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(86, 154)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Origin"
        '
        'lblDepartureTime
        '
        Me.lblDepartureTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartureTime.Location = New System.Drawing.Point(28, 131)
        Me.lblDepartureTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDepartureTime.Name = "lblDepartureTime"
        Me.lblDepartureTime.Size = New System.Drawing.Size(160, 19)
        Me.lblDepartureTime.TabIndex = 18
        Me.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(52, 111)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Departure Time"
        '
        'lblDepartureDate
        '
        Me.lblDepartureDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartureDate.Location = New System.Drawing.Point(28, 89)
        Me.lblDepartureDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDepartureDate.Name = "lblDepartureDate"
        Me.lblDepartureDate.Size = New System.Drawing.Size(160, 19)
        Me.lblDepartureDate.TabIndex = 16
        Me.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(55, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Departure Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Passenger Name"
        '
        'lblPassengerName
        '
        Me.lblPassengerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPassengerName.Location = New System.Drawing.Point(28, 48)
        Me.lblPassengerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerName.Name = "lblPassengerName"
        Me.lblPassengerName.Size = New System.Drawing.Size(160, 19)
        Me.lblPassengerName.TabIndex = 12
        Me.lblPassengerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StaffMenuLayoutControl1
        '
        Me.StaffMenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StaffMenuLayoutControl1.Name = "StaffMenuLayoutControl1"
        Me.StaffMenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.StaffMenuLayoutControl1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 36)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Ticket Cancellation"
        '
        'PaymentCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PaymentCancel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentCancel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblRefund As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancelAndRefund As Button
    Friend WithEvents lblTicketIDHint As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTicketID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblLicensePlate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSeat As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblOrigin As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDepartureTime As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblDepartureDate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPassengerName As Label
    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
    Friend WithEvents Label1 As Label
End Class
