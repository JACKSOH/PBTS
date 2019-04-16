<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managerIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(managerIndex))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackPanel = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.linkToStaff = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblErrorIC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblErrorPassword = New System.Windows.Forms.Label()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 63)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(62, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(135, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Public Transport Ticketing System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackPanel
        '
        Me.BackPanel.BackColor = System.Drawing.Color.Black
        Me.BackPanel.Controls.Add(Me.lblError)
        Me.BackPanel.Controls.Add(Me.Panel1)
        Me.BackPanel.Controls.Add(Me.linkToStaff)
        Me.BackPanel.Controls.Add(Me.txtPassword)
        Me.BackPanel.Controls.Add(Me.lblErrorIC)
        Me.BackPanel.Controls.Add(Me.Label2)
        Me.BackPanel.Controls.Add(Me.lblErrorPassword)
        Me.BackPanel.Controls.Add(Me.txtIC)
        Me.BackPanel.Controls.Add(Me.btnLogin)
        Me.BackPanel.Controls.Add(Me.Label3)
        Me.BackPanel.Controls.Add(Me.Label4)
        Me.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackPanel.Location = New System.Drawing.Point(0, 0)
        Me.BackPanel.Name = "BackPanel"
        Me.BackPanel.Size = New System.Drawing.Size(387, 370)
        Me.BackPanel.TabIndex = 6
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.LightCoral
        Me.lblError.Location = New System.Drawing.Point(102, 107)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(188, 27)
        Me.lblError.TabIndex = 20
        Me.lblError.Text = "*Incorrect IC or Password"
        Me.lblError.Visible = False
        '
        'linkToStaff
        '
        Me.linkToStaff.AutoSize = True
        Me.linkToStaff.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkToStaff.ForeColor = System.Drawing.Color.NavajoWhite
        Me.linkToStaff.Location = New System.Drawing.Point(206, 268)
        Me.linkToStaff.Name = "linkToStaff"
        Me.linkToStaff.Size = New System.Drawing.Size(59, 17)
        Me.linkToStaff.TabIndex = 19
        Me.linkToStaff.Text = "I'm Staff"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(106, 218)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(159, 20)
        Me.txtPassword.TabIndex = 15
        '
        'lblErrorIC
        '
        Me.lblErrorIC.AutoSize = True
        Me.lblErrorIC.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorIC.ForeColor = System.Drawing.Color.LightCoral
        Me.lblErrorIC.Location = New System.Drawing.Point(104, 177)
        Me.lblErrorIC.Name = "lblErrorIC"
        Me.lblErrorIC.Size = New System.Drawing.Size(84, 17)
        Me.lblErrorIC.TabIndex = 18
        Me.lblErrorIC.Text = "*Incorrect IC"
        Me.lblErrorIC.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(104, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "IC"
        '
        'lblErrorPassword
        '
        Me.lblErrorPassword.AutoSize = True
        Me.lblErrorPassword.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorPassword.ForeColor = System.Drawing.Color.LightCoral
        Me.lblErrorPassword.Location = New System.Drawing.Point(104, 241)
        Me.lblErrorPassword.Name = "lblErrorPassword"
        Me.lblErrorPassword.Size = New System.Drawing.Size(127, 17)
        Me.lblErrorPassword.TabIndex = 17
        Me.lblErrorPassword.Text = "*Incorrect Password"
        Me.lblErrorPassword.Visible = False
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(105, 154)
        Me.txtIC.MaxLength = 12
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(160, 20)
        Me.txtIC.TabIndex = 12
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(152, 306)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(77, 29)
        Me.btnLogin.TabIndex = 16
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(114, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Manager Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(104, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Password"
        '
        'Timer1
        '
        '
        'managerIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 370)
        Me.Controls.Add(Me.BackPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "managerIndex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "managerIndex"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackPanel.ResumeLayout(False)
        Me.BackPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackPanel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblError As Label
    Friend WithEvents linkToStaff As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblErrorIC As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblErrorPassword As Label
    Friend WithEvents txtIC As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
