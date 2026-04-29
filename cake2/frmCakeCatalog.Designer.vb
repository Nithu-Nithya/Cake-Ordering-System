<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCakeCatalog
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
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        lblOrderNo = New Label()
        lblOrderDate = New Label()
        txtSearch = New TextBox()
        flpCakes = New FlowLayoutPanel()
        dgvCart = New DataGridView()
        btnBuyNow = New Button()
        lblTotalAmount = New Label()
        btnRefresh = New Button()
        btnCancelOrder = New Button()
        btnSearch = New Button()
        cmbCategory = New ComboBox()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RosyBrown
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1330, 125)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(1239, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 28)
        Label3.TabIndex = 1
        Label3.Text = "Back➡️"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F)
        Label1.Location = New Point(27, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 25)
        Label1.TabIndex = 1
        Label1.Text = "Order No     :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F)
        Label2.Location = New Point(27, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 25)
        Label2.TabIndex = 2
        Label2.Text = "Order Date  :"
        ' 
        ' lblOrderNo
        ' 
        lblOrderNo.AutoSize = True
        lblOrderNo.Font = New Font("Segoe UI", 10.8F)
        lblOrderNo.Location = New Point(155, 143)
        lblOrderNo.Name = "lblOrderNo"
        lblOrderNo.Size = New Size(63, 25)
        lblOrderNo.TabIndex = 3
        lblOrderNo.Text = "Label3"
        ' 
        ' lblOrderDate
        ' 
        lblOrderDate.AutoSize = True
        lblOrderDate.Font = New Font("Segoe UI", 10.8F)
        lblOrderDate.Location = New Point(155, 178)
        lblOrderDate.Name = "lblOrderDate"
        lblOrderDate.Size = New Size(63, 25)
        lblOrderDate.TabIndex = 4
        lblOrderDate.Text = "Label4"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(12, 222)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(540, 34)
        txtSearch.TabIndex = 5
        ' 
        ' flpCakes
        ' 
        flpCakes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        flpCakes.AutoScroll = True
        flpCakes.Location = New Point(12, 262)
        flpCakes.Name = "flpCakes"
        flpCakes.Size = New Size(985, 343)
        flpCakes.TabIndex = 6
        ' 
        ' dgvCart
        ' 
        dgvCart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.Location = New Point(825, 222)
        dgvCart.Name = "dgvCart"
        dgvCart.RowHeadersWidth = 51
        dgvCart.Size = New Size(493, 334)
        dgvCart.TabIndex = 7
        ' 
        ' btnBuyNow
        ' 
        btnBuyNow.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnBuyNow.AutoSize = True
        btnBuyNow.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuyNow.Location = New Point(825, 562)
        btnBuyNow.Name = "btnBuyNow"
        btnBuyNow.Size = New Size(243, 43)
        btnBuyNow.TabIndex = 8
        btnBuyNow.Text = "Order"
        btnBuyNow.UseVisualStyleBackColor = True
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.Location = New Point(1127, 158)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(133, 50)
        lblTotalAmount.TabIndex = 9
        lblTotalAmount.Text = "         0"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.AutoSize = True
        btnRefresh.BackColor = Color.Transparent
        btnRefresh.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(950, 222)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(47, 35)
        btnRefresh.TabIndex = 10
        btnRefresh.Text = "🔃"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnCancelOrder
        ' 
        btnCancelOrder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancelOrder.AutoSize = True
        btnCancelOrder.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnCancelOrder.Location = New Point(1074, 562)
        btnCancelOrder.Name = "btnCancelOrder"
        btnCancelOrder.Size = New Size(244, 43)
        btnCancelOrder.TabIndex = 11
        btnCancelOrder.Text = "Cancel"
        btnCancelOrder.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Transparent
        btnSearch.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(558, 224)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(33, 34)
        btnSearch.TabIndex = 12
        btnSearch.Text = "🔍"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Font = New Font("Segoe UI", 12F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(755, 220)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(189, 36)
        cmbCategory.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F)
        Label4.Location = New Point(597, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 25)
        Label4.TabIndex = 14
        Label4.Text = "Filter by Category"
        ' 
        ' frmCakeCatalog
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1330, 617)
        Controls.Add(Label4)
        Controls.Add(cmbCategory)
        Controls.Add(btnSearch)
        Controls.Add(btnCancelOrder)
        Controls.Add(btnRefresh)
        Controls.Add(lblTotalAmount)
        Controls.Add(btnBuyNow)
        Controls.Add(dgvCart)
        Controls.Add(flpCakes)
        Controls.Add(txtSearch)
        Controls.Add(lblOrderDate)
        Controls.Add(lblOrderNo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "frmCakeCatalog"
        Text = "frmCakeCatalog"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOrderNo As Label
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents flpCakes As FlowLayoutPanel
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents btnBuyNow As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label4 As Label

End Class
