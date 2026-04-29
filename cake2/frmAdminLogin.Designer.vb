<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminLogin
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Panel2 = New Panel()
        lblCooldown = New Label()
        chkShowPassword = New CheckBox()
        Label3 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        coolDownTimer = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.LightGray
        Panel1.BackgroundImage = My.Resources.Resources.backcolor
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(843, 531)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.AutoSize = True
        Panel2.BackColor = SystemColors.Menu
        Panel2.Controls.Add(lblCooldown)
        Panel2.Controls.Add(chkShowPassword)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(137, 161)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(593, 367)
        Panel2.TabIndex = 5
        ' 
        ' lblCooldown
        ' 
        lblCooldown.Anchor = AnchorStyles.None
        lblCooldown.AutoSize = True
        lblCooldown.Location = New Point(273, 246)
        lblCooldown.Name = "lblCooldown"
        lblCooldown.Size = New Size(53, 20)
        lblCooldown.TabIndex = 1
        lblCooldown.Text = "Label4"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(458, 201)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(132, 24)
        chkShowPassword.TabIndex = 9
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(234, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 31)
        Label3.TabIndex = 8
        Label3.Text = "Admin Login"
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.Red
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Button2.Location = New Point(366, 280)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 38)
        Button2.TabIndex = 7
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.LimeGreen
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Button1.Location = New Point(129, 280)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 38)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        TextBox2.Location = New Point(251, 191)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(187, 34)
        TextBox2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Menu
        Label1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label1.Location = New Point(79, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 28)
        Label1.TabIndex = 1
        Label1.Text = "User Name :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        TextBox1.Location = New Point(251, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(187, 34)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Menu
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(79, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 28)
        Label2.TabIndex = 2
        Label2.Text = "Password   :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.RosyBrown
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(843, 126)
        Panel3.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logos
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' coolDownTimer
        ' 
        coolDownTimer.Interval = 1000
        ' 
        ' frmAdminLogin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(843, 531)
        Controls.Add(Panel1)
        Name = "frmAdminLogin"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents coolDownTimer As Timer
    Friend WithEvents lblCooldown As Label
End Class
