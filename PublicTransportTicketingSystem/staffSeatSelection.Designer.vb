<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffSeatSelection
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
        Me.flpSeat = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblSeatSelected = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'flpSeat
        '
        Me.flpSeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.flpSeat.Location = New System.Drawing.Point(111, 70)
        Me.flpSeat.Name = "flpSeat"
        Me.flpSeat.Size = New System.Drawing.Size(332, 402)
        Me.flpSeat.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(107, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Select your seat :"
        '
        'btnConfirm
        '
        Me.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnConfirm.Location = New System.Drawing.Point(111, 582)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(133, 44)
        Me.btnConfirm.TabIndex = 37
        Me.btnConfirm.Text = "&CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(310, 582)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 44)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblSeatSelected
        '
        Me.lblSeatSelected.AutoSize = True
        Me.lblSeatSelected.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatSelected.ForeColor = System.Drawing.Color.Black
        Me.lblSeatSelected.Location = New System.Drawing.Point(117, 494)
        Me.lblSeatSelected.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeatSelected.Name = "lblSeatSelected"
        Me.lblSeatSelected.Size = New System.Drawing.Size(148, 23)
        Me.lblSeatSelected.TabIndex = 39
        Me.lblSeatSelected.Text = "0 seat(s) selected"
        '
        'staffSeatSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 708)
        Me.Controls.Add(Me.lblSeatSelected)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.flpSeat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staffSeatSelection"
        Me.Text = "staffSeatSelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flpSeat As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblSeatSelected As Label
End Class
