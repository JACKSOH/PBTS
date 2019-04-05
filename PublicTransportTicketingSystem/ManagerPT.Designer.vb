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
        Me.StaffMenuLayoutControl1 = New PublicTransportTicketingSystem.staffMenuLayoutControl()
        Me.SuspendLayout()
        '
        'StaffMenuLayoutControl1
        '
        Me.StaffMenuLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StaffMenuLayoutControl1.Name = "StaffMenuLayoutControl1"
        Me.StaffMenuLayoutControl1.Size = New System.Drawing.Size(1067, 708)
        Me.StaffMenuLayoutControl1.TabIndex = 0
        '
        'ManagerPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 708)
        Me.Controls.Add(Me.StaffMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerPT"
        Me.Text = "ManagerPT"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffMenuLayoutControl1 As staffMenuLayoutControl
End Class
