<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstTimeSetup
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Panel3 = New Panel()
        ProgressBar1 = New ProgressBar()
        lblStrength = New Label()
        Label5 = New Label()
        CheckBox1 = New CheckBox()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.backcolor
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(838, 740)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.AutoSize = True
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(ProgressBar1)
        Panel3.Controls.Add(lblStrength)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(CheckBox1)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(68, 176)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(730, 558)
        Panel3.TabIndex = 1
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(489, 295)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(164, 29)
        ProgressBar1.TabIndex = 10
        ' 
        ' lblStrength
        ' 
        lblStrength.AutoSize = True
        lblStrength.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStrength.Location = New Point(408, 301)
        lblStrength.Name = "lblStrength"
        lblStrength.Size = New Size(75, 23)
        lblStrength.TabIndex = 9
        lblStrength.Text = "Strength"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(178, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(391, 41)
        Label5.TabIndex = 8
        Label5.Text = "First-Time Password Setup"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(408, 388)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(148, 27)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(408, 484)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 43)
        Button2.TabIndex = 7
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(202, 484)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 43)
        Button1.TabIndex = 6
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(69, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(269, 38)
        Label4.TabIndex = 5
        Label4.Text = "Confirm Password  :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(408, 344)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(245, 38)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 16.2F)
        TextBox2.Location = New Point(408, 250)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(245, 38)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 16.2F)
        TextBox1.Location = New Point(408, 164)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(245, 38)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(69, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(312, 38)
        Label3.TabIndex = 1
        Label3.Text = "New Password        :     "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(69, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(272, 38)
        Label2.TabIndex = 0
        Label2.Text = "Username               :"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RosyBrown
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(838, 135)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logos
        PictureBox1.Location = New Point(15, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(105, 107)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' frmFirstTimeSetup
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(838, 740)
        Controls.Add(Panel1)
        Name = "frmFirstTimeSetup"
        Text = "frmFirstTimeSetup"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblStrength As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
