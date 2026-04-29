<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        grpReportType = New GroupBox()
        rdoYear = New RadioButton()
        rdoMonth = New RadioButton()
        rdoDate = New RadioButton()
        pnlDate = New Panel()
        dtpDate = New DateTimePicker()
        lblDate = New Label()
        pnlMonth = New Panel()
        nudYear_Month = New NumericUpDown()
        cmbMonth = New ComboBox()
        lblMonth = New Label()
        pnlYear = New Panel()
        nudYear_Only = New NumericUpDown()
        lblYear = New Label()
        btnGenerate = New Button()
        dgvSalesReport = New DataGridView()
        lblTotalSales = New Label()
        btnExportPDF = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grpReportType.SuspendLayout()
        pnlDate.SuspendLayout()
        pnlMonth.SuspendLayout()
        CType(nudYear_Month, ComponentModel.ISupportInitialize).BeginInit()
        pnlYear.SuspendLayout()
        CType(nudYear_Only, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSalesReport, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(993, 125)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(902, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 28)
        Label2.TabIndex = 2
        Label2.Text = "Back➡️"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(424, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 41)
        Label1.TabIndex = 1
        Label1.Text = "Sales Report"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.logos
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 99)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' grpReportType
        ' 
        grpReportType.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpReportType.AutoSize = True
        grpReportType.Controls.Add(rdoYear)
        grpReportType.Controls.Add(rdoMonth)
        grpReportType.Controls.Add(rdoDate)
        grpReportType.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpReportType.Location = New Point(41, 144)
        grpReportType.Name = "grpReportType"
        grpReportType.Size = New Size(915, 125)
        grpReportType.TabIndex = 1
        grpReportType.TabStop = False
        grpReportType.Text = "Select Report Type"
        ' 
        ' rdoYear
        ' 
        rdoYear.Anchor = AnchorStyles.None
        rdoYear.AutoSize = True
        rdoYear.Location = New Point(753, 52)
        rdoYear.Name = "rdoYear"
        rdoYear.Size = New Size(111, 35)
        rdoYear.TabIndex = 2
        rdoYear.TabStop = True
        rdoYear.Text = "By Year"
        rdoYear.UseVisualStyleBackColor = True
        ' 
        ' rdoMonth
        ' 
        rdoMonth.Anchor = AnchorStyles.None
        rdoMonth.AutoSize = True
        rdoMonth.Location = New Point(406, 52)
        rdoMonth.Name = "rdoMonth"
        rdoMonth.Size = New Size(136, 35)
        rdoMonth.TabIndex = 1
        rdoMonth.TabStop = True
        rdoMonth.Text = "By Month"
        rdoMonth.UseVisualStyleBackColor = True
        ' 
        ' rdoDate
        ' 
        rdoDate.Anchor = AnchorStyles.None
        rdoDate.AutoSize = True
        rdoDate.Location = New Point(53, 52)
        rdoDate.Name = "rdoDate"
        rdoDate.Size = New Size(116, 35)
        rdoDate.TabIndex = 0
        rdoDate.TabStop = True
        rdoDate.Text = "By Date"
        rdoDate.UseVisualStyleBackColor = True
        ' 
        ' pnlDate
        ' 
        pnlDate.Anchor = AnchorStyles.Top
        pnlDate.Controls.Add(dtpDate)
        pnlDate.Controls.Add(lblDate)
        pnlDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnlDate.Location = New Point(244, 298)
        pnlDate.Name = "pnlDate"
        pnlDate.Size = New Size(521, 63)
        pnlDate.TabIndex = 2
        pnlDate.Visible = False
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(155, 12)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 34)
        dtpDate.TabIndex = 1
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(19, 12)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(114, 28)
        lblDate.TabIndex = 0
        lblDate.Text = "Select Date"
        ' 
        ' pnlMonth
        ' 
        pnlMonth.Anchor = AnchorStyles.Top
        pnlMonth.Controls.Add(nudYear_Month)
        pnlMonth.Controls.Add(cmbMonth)
        pnlMonth.Controls.Add(lblMonth)
        pnlMonth.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnlMonth.Location = New Point(244, 310)
        pnlMonth.Name = "pnlMonth"
        pnlMonth.Size = New Size(531, 58)
        pnlMonth.TabIndex = 2
        pnlMonth.Visible = False
        ' 
        ' nudYear_Month
        ' 
        nudYear_Month.Location = New Point(360, 12)
        nudYear_Month.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        nudYear_Month.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        nudYear_Month.Name = "nudYear_Month"
        nudYear_Month.Size = New Size(150, 34)
        nudYear_Month.TabIndex = 2
        nudYear_Month.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Location = New Point(183, 15)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(151, 36)
        cmbMonth.TabIndex = 1
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(25, 14)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(133, 28)
        lblMonth.TabIndex = 0
        lblMonth.Text = "Select Month"
        ' 
        ' pnlYear
        ' 
        pnlYear.Anchor = AnchorStyles.Top
        pnlYear.Controls.Add(nudYear_Only)
        pnlYear.Controls.Add(lblYear)
        pnlYear.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnlYear.Location = New Point(244, 301)
        pnlYear.Name = "pnlYear"
        pnlYear.Size = New Size(518, 55)
        pnlYear.TabIndex = 0
        pnlYear.Visible = False
        ' 
        ' nudYear_Only
        ' 
        nudYear_Only.Location = New Point(215, 12)
        nudYear_Only.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        nudYear_Only.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        nudYear_Only.Name = "nudYear_Only"
        nudYear_Only.Size = New Size(150, 34)
        nudYear_Only.TabIndex = 2
        nudYear_Only.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(39, 14)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(110, 28)
        lblYear.TabIndex = 1
        lblYear.Text = "Select Year"
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Anchor = AnchorStyles.Top
        btnGenerate.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        btnGenerate.Location = New Point(414, 388)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(195, 41)
        btnGenerate.TabIndex = 3
        btnGenerate.Text = "Generate Report"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' dgvSalesReport
        ' 
        dgvSalesReport.AllowUserToAddRows = False
        dgvSalesReport.AllowUserToDeleteRows = False
        dgvSalesReport.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSalesReport.Location = New Point(41, 435)
        dgvSalesReport.Name = "dgvSalesReport"
        dgvSalesReport.ReadOnly = True
        dgvSalesReport.RowHeadersWidth = 51
        dgvSalesReport.Size = New Size(904, 321)
        dgvSalesReport.TabIndex = 4
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.Anchor = AnchorStyles.None
        lblTotalSales.AutoSize = True
        lblTotalSales.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSales.Location = New Point(447, 774)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New Size(124, 31)
        lblTotalSales.TabIndex = 5
        lblTotalSales.Text = "Total Sales"
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnExportPDF.AutoSize = True
        btnExportPDF.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        btnExportPDF.Location = New Point(839, 816)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(142, 41)
        btnExportPDF.TabIndex = 7
        btnExportPDF.Text = "Export PDF"
        btnExportPDF.UseVisualStyleBackColor = True
        ' 
        ' frmSalesReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.backcolor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(993, 869)
        Controls.Add(btnExportPDF)
        Controls.Add(pnlMonth)
        Controls.Add(pnlYear)
        Controls.Add(lblTotalSales)
        Controls.Add(dgvSalesReport)
        Controls.Add(btnGenerate)
        Controls.Add(pnlDate)
        Controls.Add(grpReportType)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "frmSalesReport"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grpReportType.ResumeLayout(False)
        grpReportType.PerformLayout()
        pnlDate.ResumeLayout(False)
        pnlDate.PerformLayout()
        pnlMonth.ResumeLayout(False)
        pnlMonth.PerformLayout()
        CType(nudYear_Month, ComponentModel.ISupportInitialize).EndInit()
        pnlYear.ResumeLayout(False)
        pnlYear.PerformLayout()
        CType(nudYear_Only, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSalesReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpReportType As GroupBox
    Friend WithEvents rdoYear As RadioButton
    Friend WithEvents rdoMonth As RadioButton
    Friend WithEvents rdoDate As RadioButton
    Friend WithEvents pnlDate As Panel
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents pnlMonth As Panel
    Friend WithEvents lblMonth As Label
    Friend WithEvents pnlYear As Panel
    Friend WithEvents lblYear As Label
    Friend WithEvents nudYear_Only As NumericUpDown
    Friend WithEvents btnGenerate As Button
    Friend WithEvents dgvSalesReport As DataGridView
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents nudYear_Month As NumericUpDown
    Friend WithEvents btnExportPDF As Button
End Class
