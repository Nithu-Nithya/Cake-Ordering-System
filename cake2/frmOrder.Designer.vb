<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
    Inherits System.Windows.Forms.Form
    Private lblTitle As Label
    Private dgvCart As DataGridView
    Private txtCustomerName As TextBox
    Private txtCakeMessage As TextBox
    Private lblTotalPrice As Label
    Private lblCustomerName As Label
    Private lblCakeMessage As Label
    Private panelTop As Panel
    Private panelBottom As Panel

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrder))
        lblTitle = New Label()
        dgvCart = New DataGridView()
        txtCustomerName = New TextBox()
        txtCakeMessage = New TextBox()
        lblTotalPrice = New Label()
        lblCustomerName = New Label()
        lblCakeMessage = New Label()
        panelTop = New Panel()
        panelBottom = New Panel()
        Label1 = New Label()
        lblPaymentMethod = New Label()
        rbCash = New RadioButton()
        rbOnline = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        pbScanner = New PictureBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1 = New Panel()
        Button3 = New Button()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        panelTop.SuspendLayout()
        panelBottom.SuspendLayout()
        CType(pbScanner, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(290, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Cake Order Summary"
        ' 
        ' dgvCart
        ' 
        dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCart.BackgroundColor = Color.WhiteSmoke
        dgvCart.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCart.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvCart.DefaultCellStyle = DataGridViewCellStyle2
        dgvCart.EnableHeadersVisualStyles = False
        dgvCart.Location = New Point(30, 80)
        dgvCart.Name = "dgvCart"
        dgvCart.ReadOnly = True
        dgvCart.RowHeadersWidth = 51
        dgvCart.Size = New Size(600, 300)
        dgvCart.TabIndex = 1
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Font = New Font("Segoe UI", 10F)
        txtCustomerName.Location = New Point(650, 105)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(200, 30)
        txtCustomerName.TabIndex = 3
        ' 
        ' txtCakeMessage
        ' 
        txtCakeMessage.Font = New Font("Segoe UI", 10F)
        txtCakeMessage.Location = New Point(650, 175)
        txtCakeMessage.Name = "txtCakeMessage"
        txtCakeMessage.Size = New Size(200, 30)
        txtCakeMessage.TabIndex = 5
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.AutoSize = True
        lblTotalPrice.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTotalPrice.ForeColor = Color.DarkGreen
        lblTotalPrice.Location = New Point(676, 245)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(147, 32)
        lblTotalPrice.TabIndex = 6
        lblTotalPrice.Text = "Total: ₹0.00"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Font = New Font("Segoe UI", 10F)
        lblCustomerName.Location = New Point(650, 80)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(139, 23)
        lblCustomerName.TabIndex = 2
        lblCustomerName.Text = "Customer Name:"
        ' 
        ' lblCakeMessage
        ' 
        lblCakeMessage.AutoSize = True
        lblCakeMessage.Font = New Font("Segoe UI", 10F)
        lblCakeMessage.Location = New Point(650, 150)
        lblCakeMessage.Name = "lblCakeMessage"
        lblCakeMessage.Size = New Size(122, 23)
        lblCakeMessage.TabIndex = 4
        lblCakeMessage.Text = "Cake Message:"
        ' 
        ' panelTop
        ' 
        panelTop.BackColor = Color.RosyBrown
        panelTop.Controls.Add(lblTitle)
        panelTop.Dock = DockStyle.Top
        panelTop.Location = New Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Size = New Size(900, 60)
        panelTop.TabIndex = 0
        ' 
        ' panelBottom
        ' 
        panelBottom.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        panelBottom.Controls.Add(Label1)
        panelBottom.Dock = DockStyle.Bottom
        panelBottom.Location = New Point(0, 570)
        panelBottom.Name = "panelBottom"
        panelBottom.Size = New Size(900, 30)
        panelBottom.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(265, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(410, 20)
        Label1.TabIndex = 0
        Label1.Text = "© 2025 Cake Ordering System | Thank you for your purchase!"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI", 10F)
        lblPaymentMethod.Location = New Point(650, 302)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(145, 23)
        lblPaymentMethod.TabIndex = 0
        lblPaymentMethod.Text = "Payment Method:"
        ' 
        ' rbCash
        ' 
        rbCash.AutoSize = True
        rbCash.Checked = True
        rbCash.Font = New Font("Segoe UI", 10F)
        rbCash.Location = New Point(659, 328)
        rbCash.Name = "rbCash"
        rbCash.Size = New Size(68, 27)
        rbCash.TabIndex = 1
        rbCash.TabStop = True
        rbCash.Text = "Cash"
        ' 
        ' rbOnline
        ' 
        rbOnline.AutoSize = True
        rbOnline.Font = New Font("Segoe UI", 10F)
        rbOnline.Location = New Point(659, 355)
        rbOnline.Name = "rbOnline"
        rbOnline.Size = New Size(152, 27)
        rbOnline.TabIndex = 2
        rbOnline.Text = "Online Payment"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(650, 397)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 40)
        Button1.TabIndex = 10
        Button1.Text = "Cancel Order"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(650, 453)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 40)
        Button2.TabIndex = 11
        Button2.Text = "Pay"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' pbScanner
        ' 
        pbScanner.Anchor = AnchorStyles.None
        pbScanner.Image = My.Resources.Resources.scanner
        pbScanner.Location = New Point(50, 57)
        pbScanner.Name = "pbScanner"
        pbScanner.Size = New Size(231, 219)
        pbScanner.SizeMode = PictureBoxSizeMode.StretchImage
        pbScanner.TabIndex = 12
        pbScanner.TabStop = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.AutoSize = True
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(pbScanner)
        Panel1.Location = New Point(301, 150)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(329, 310)
        Panel1.TabIndex = 13
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(292, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(34, 29)
        Button3.TabIndex = 13
        Button3.Text = "❌"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmOrder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(900, 600)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblPaymentMethod)
        Controls.Add(rbCash)
        Controls.Add(rbOnline)
        Controls.Add(panelTop)
        Controls.Add(dgvCart)
        Controls.Add(lblCustomerName)
        Controls.Add(txtCustomerName)
        Controls.Add(lblCakeMessage)
        Controls.Add(txtCakeMessage)
        Controls.Add(lblTotalPrice)
        Controls.Add(panelBottom)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OrderForm"
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        panelBottom.ResumeLayout(False)
        panelBottom.PerformLayout()
        CType(pbScanner, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents rbOnline As RadioButton
    Friend WithEvents Label1 As Label
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Friend WithEvents pbScanner As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
End Class
