<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductManagement
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
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        dgvProducts = New DataGridView()
        Panel2 = New Panel()
        Label7 = New Label()
        txtFlavour = New TextBox()
        btnDelete = New Button()
        btnClear = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        Label9 = New Label()
        btnUploadImage = New Button()
        picCake = New PictureBox()
        chkAvailability = New CheckBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        txtCategory = New TextBox()
        txtCakeName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        ofdImage = New OpenFileDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(picCake, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RosyBrown
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1216, 125)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(458, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(318, 41)
        Label2.TabIndex = 2
        Label2.Text = "Product Management"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1125, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 28)
        Label1.TabIndex = 1
        Label1.Text = "Back➡️"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.logos
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(104, 101)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' dgvProducts
        ' 
        dgvProducts.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(12, 154)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(1193, 188)
        dgvProducts.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.AutoSize = True
        Panel2.BackColor = Color.Thistle
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtFlavour)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(btnUploadImage)
        Panel2.Controls.Add(picCake)
        Panel2.Controls.Add(chkAvailability)
        Panel2.Controls.Add(txtQuantity)
        Panel2.Controls.Add(txtPrice)
        Panel2.Controls.Add(txtCategory)
        Panel2.Controls.Add(txtCakeName)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(150, 379)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(896, 507)
        Panel2.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(58, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 28)
        Label7.TabIndex = 21
        Label7.Text = "Flavour"
        ' 
        ' txtFlavour
        ' 
        txtFlavour.Font = New Font("Segoe UI", 12F)
        txtFlavour.Location = New Point(287, 305)
        txtFlavour.Name = "txtFlavour"
        txtFlavour.Size = New Size(180, 34)
        txtFlavour.TabIndex = 20
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top
        btnDelete.AutoSize = True
        btnDelete.BackColor = Color.Red
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Font = New Font("Segoe UI Symbol", 10.2F)
        btnDelete.Location = New Point(273, 417)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 36)
        btnDelete.TabIndex = 19
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.None
        btnClear.AutoSize = True
        btnClear.BackColor = Color.Red
        btnClear.Font = New Font("Segoe UI Symbol", 10.2F)
        btnClear.Location = New Point(373, 417)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 36)
        btnClear.TabIndex = 17
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top
        btnEdit.AutoSize = True
        btnEdit.BackColor = Color.LimeGreen
        btnEdit.Cursor = Cursors.Hand
        btnEdit.Font = New Font("Segoe UI Symbol", 10.2F)
        btnEdit.Location = New Point(149, 417)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 36)
        btnEdit.TabIndex = 18
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.None
        btnAdd.AutoSize = True
        btnAdd.BackColor = Color.LimeGreen
        btnAdd.Font = New Font("Segoe UI Symbol", 10.2F)
        btnAdd.Location = New Point(49, 417)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 36)
        btnAdd.TabIndex = 16
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(382, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(169, 31)
        Label9.TabIndex = 15
        Label9.Text = "Add New Cake"
        ' 
        ' btnUploadImage
        ' 
        btnUploadImage.Anchor = AnchorStyles.None
        btnUploadImage.AutoSize = True
        btnUploadImage.BackColor = Color.LimeGreen
        btnUploadImage.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUploadImage.Location = New Point(519, 414)
        btnUploadImage.Name = "btnUploadImage"
        btnUploadImage.Size = New Size(318, 39)
        btnUploadImage.TabIndex = 14
        btnUploadImage.Text = "Upload Image"
        btnUploadImage.UseVisualStyleBackColor = False
        ' 
        ' picCake
        ' 
        picCake.Anchor = AnchorStyles.None
        picCake.Location = New Point(516, 101)
        picCake.Name = "picCake"
        picCake.Size = New Size(321, 285)
        picCake.SizeMode = PictureBoxSizeMode.StretchImage
        picCake.TabIndex = 13
        picCake.TabStop = False
        ' 
        ' chkAvailability
        ' 
        chkAvailability.Anchor = AnchorStyles.None
        chkAvailability.AutoSize = True
        chkAvailability.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkAvailability.Location = New Point(287, 359)
        chkAvailability.Name = "chkAvailability"
        chkAvailability.Size = New Size(100, 27)
        chkAvailability.TabIndex = 12
        chkAvailability.Text = "Available"
        chkAvailability.UseVisualStyleBackColor = True
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Anchor = AnchorStyles.None
        txtQuantity.Font = New Font("Segoe UI", 12F)
        txtQuantity.Location = New Point(287, 251)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(180, 34)
        txtQuantity.TabIndex = 9
        ' 
        ' txtPrice
        ' 
        txtPrice.Anchor = AnchorStyles.None
        txtPrice.Font = New Font("Segoe UI", 12F)
        txtPrice.Location = New Point(287, 201)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(180, 34)
        txtPrice.TabIndex = 8
        ' 
        ' txtCategory
        ' 
        txtCategory.Anchor = AnchorStyles.None
        txtCategory.Font = New Font("Segoe UI", 12F)
        txtCategory.Location = New Point(287, 152)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(180, 34)
        txtCategory.TabIndex = 7
        ' 
        ' txtCakeName
        ' 
        txtCakeName.Anchor = AnchorStyles.None
        txtCakeName.Font = New Font("Segoe UI", 12F)
        txtCakeName.Location = New Point(287, 101)
        txtCakeName.Name = "txtCakeName"
        txtCakeName.Size = New Size(180, 34)
        txtCakeName.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(54, 254)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 28)
        Label6.TabIndex = 3
        Label6.Text = "Quantity"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(58, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 28)
        Label5.TabIndex = 2
        Label5.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(54, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 28)
        Label4.TabIndex = 1
        Label4.Text = "Category"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(54, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 28)
        Label3.TabIndex = 0
        Label3.Text = "Name"
        ' 
        ' ofdImage
        ' 
        ofdImage.FileName = "OpenFileDialog1"
        ' 
        ' frmProductManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = My.Resources.Resources.backcolor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1216, 929)
        Controls.Add(Panel2)
        Controls.Add(dgvProducts)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "frmProductManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmProductManagement"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(picCake, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtCakeName As TextBox
    Friend WithEvents chkAvailability As CheckBox
    Friend WithEvents picCake As PictureBox
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents ofdImage As OpenFileDialog
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFlavour As TextBox
End Class
