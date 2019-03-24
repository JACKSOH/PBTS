<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffReservation
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
        Me.MenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.SuspendLayout()
        '
        'MenuLayoutControl1
        '
        Me.MenuLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.MenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuLayoutControl1.Name = "MenuLayoutControl1"
        Me.MenuLayoutControl1.Size = New System.Drawing.Size(800, 575)
        Me.MenuLayoutControl1.TabIndex = 0
        '
        'StaffReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)

        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StaffReservation"
        Me.Text = "StaffReservation"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuLayoutControl1 As staffMenuLayoutControl
End Class
