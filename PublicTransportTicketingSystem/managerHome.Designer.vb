﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managerHome
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
        Me.ManagerMenuLayoutControl1 = New PublicTransportTicketingSystem.managerMenuLayoutControl()
        Me.SuspendLayout()
        '
        'ManagerMenuLayoutControl1
        '
        Me.ManagerMenuLayoutControl1.Location = New System.Drawing.Point(-4, 3)
        Me.ManagerMenuLayoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ManagerMenuLayoutControl1.Name = "ManagerMenuLayoutControl1"
        Me.ManagerMenuLayoutControl1.Size = New System.Drawing.Size(1067, 708)
        Me.ManagerMenuLayoutControl1.TabIndex = 0
        '
        'managerHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 724)
        Me.Controls.Add(Me.ManagerMenuLayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "managerHome"
        Me.Text = "managerHome"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerMenuLayoutControl1 As managerMenuLayoutControl
End Class