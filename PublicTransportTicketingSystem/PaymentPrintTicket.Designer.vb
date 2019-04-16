<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentPrintTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentPrintTicket))
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCarrier = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDepartureDateTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPassengerName = New System.Windows.Forms.Label()
        Me.lblTicketTitle = New System.Windows.Forms.Label()
        Me.lblTicketID = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEstimatedDuration = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGenerated = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSeat
        '
        Me.lblSeat.BackColor = System.Drawing.Color.Transparent
        Me.lblSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeat.Location = New System.Drawing.Point(139, 134)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(212, 23)
        Me.lblSeat.TabIndex = 42
        Me.lblSeat.Text = "E2"
        Me.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(85, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Seat:"
        '
        'lblCarrier
        '
        Me.lblCarrier.BackColor = System.Drawing.Color.Transparent
        Me.lblCarrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarrier.Location = New System.Drawing.Point(139, 102)
        Me.lblCarrier.Name = "lblCarrier"
        Me.lblCarrier.Size = New System.Drawing.Size(228, 23)
        Me.lblCarrier.TabIndex = 40
        Me.lblCarrier.Text = "HappyBus - WDN7012"
        Me.lblCarrier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(67, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 20)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Carrier:"
        '
        'lblDestination
        '
        Me.lblDestination.BackColor = System.Drawing.Color.Transparent
        Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.Location = New System.Drawing.Point(598, 68)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(170, 23)
        Me.lblDestination.TabIndex = 38
        Me.lblDestination.Text = "Wangsa Maju"
        Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrigin
        '
        Me.lblOrigin.BackColor = System.Drawing.Color.Transparent
        Me.lblOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigin.Location = New System.Drawing.Point(383, 68)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(170, 23)
        Me.lblOrigin.TabIndex = 37
        Me.lblOrigin.Text = "Kepong"
        Me.lblOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(712, 191)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(72, 20)
        Me.lblPrice.TabIndex = 30
        Me.lblPrice.Text = "RM32.00"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartureDateTime
        '
        Me.lblDepartureDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartureDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartureDateTime.Location = New System.Drawing.Point(563, 103)
        Me.lblDepartureDateTime.Name = "lblDepartureDateTime"
        Me.lblDepartureDateTime.Size = New System.Drawing.Size(205, 23)
        Me.lblDepartureDateTime.TabIndex = 32
        Me.lblDepartureDateTime.Text = "15/04/2019, 7:00pm"
        Me.lblDepartureDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(468, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Departure:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Passenger:"
        '
        'lblPassengerName
        '
        Me.lblPassengerName.BackColor = System.Drawing.Color.Transparent
        Me.lblPassengerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassengerName.Location = New System.Drawing.Point(139, 70)
        Me.lblPassengerName.Name = "lblPassengerName"
        Me.lblPassengerName.Size = New System.Drawing.Size(195, 23)
        Me.lblPassengerName.TabIndex = 28
        Me.lblPassengerName.Text = "John Cena"
        Me.lblPassengerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTicketTitle
        '
        Me.lblTicketTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTicketTitle.Font = New System.Drawing.Font("Cambria", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketTitle.Location = New System.Drawing.Point(233, 9)
        Me.lblTicketTitle.Name = "lblTicketTitle"
        Me.lblTicketTitle.Size = New System.Drawing.Size(343, 38)
        Me.lblTicketTitle.TabIndex = 43
        Me.lblTicketTitle.Text = "--BUS TICKET--"
        Me.lblTicketTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTicketID
        '
        Me.lblTicketID.AutoSize = True
        Me.lblTicketID.BackColor = System.Drawing.Color.Transparent
        Me.lblTicketID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTicketID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketID.Location = New System.Drawing.Point(12, 9)
        Me.lblTicketID.Name = "lblTicketID"
        Me.lblTicketID.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblTicketID.Size = New System.Drawing.Size(104, 22)
        Me.lblTicketID.TabIndex = 45
        Me.lblTicketID.Text = "B000123"
        Me.lblTicketID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDocument1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(479, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Duration:"
        '
        'lblEstimatedDuration
        '
        Me.lblEstimatedDuration.BackColor = System.Drawing.Color.Transparent
        Me.lblEstimatedDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimatedDuration.Location = New System.Drawing.Point(563, 136)
        Me.lblEstimatedDuration.Name = "lblEstimatedDuration"
        Me.lblEstimatedDuration.Size = New System.Drawing.Size(172, 23)
        Me.lblEstimatedDuration.TabIndex = 48
        Me.lblEstimatedDuration.Text = "2 hours"
        Me.lblEstimatedDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(555, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 32)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "→"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGenerated
        '
        Me.lblGenerated.AutoSize = True
        Me.lblGenerated.BackColor = System.Drawing.Color.Transparent
        Me.lblGenerated.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerated.Location = New System.Drawing.Point(12, 194)
        Me.lblGenerated.Name = "lblGenerated"
        Me.lblGenerated.Size = New System.Drawing.Size(416, 17)
        Me.lblGenerated.TabIndex = 50
        Me.lblGenerated.Text = "This ticket was generated at 12:56pm on 11/04/2019."
        Me.lblGenerated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PaymentPrintTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(950, 220)
        Me.Controls.Add(Me.lblGenerated)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEstimatedDuration)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTicketID)
        Me.Controls.Add(Me.lblTicketTitle)
        Me.Controls.Add(Me.lblSeat)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblCarrier)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.lblOrigin)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDepartureDateTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPassengerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentPrintTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentPrintTicket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSeat As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblCarrier As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblOrigin As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDepartureDateTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPassengerName As Label
    Friend WithEvents lblTicketTitle As Label
    Friend WithEvents lblTicketID As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEstimatedDuration As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGenerated As Label
End Class
