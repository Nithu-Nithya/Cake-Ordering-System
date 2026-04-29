Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Mysqlx.Crud

Public Class frmSalesReport
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; user=ID; password=your_password; database=CakeShopdb;")

    Private Sub SalesReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlDate.Visible = False
        pnlMonth.Visible = False
        pnlYear.Visible = False

        cmbMonth.Items.AddRange({"January", "February", "March", "April", "May", "June",
                                 "July", "August", "September", "October", "November", "December"})
        cmbMonth.SelectedIndex = DateTime.Now.Month - 1
        nudYear_Only.Value = DateTime.Now.Year
        nudYear_Month.Value = DateTime.Now.Year
    End Sub

    Private Sub ReportType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDate.CheckedChanged, rdoMonth.CheckedChanged, rdoYear.CheckedChanged
        pnlDate.Visible = rdoDate.Checked
        pnlMonth.Visible = rdoMonth.Checked
        pnlYear.Visible = rdoYear.Checked
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim query As String = ""
        Dim cmd As New MySqlCommand()

        If rdoDate.Checked Then
            Dim selectedDate As String = dtpDate.Value.ToString("yyyy-MM-dd")
            query = "SELECT o.orderitem_id AS 'Order No', DATE_FORMAT(o.order_date, '%d-%m-%Y')  AS 'Order Date', " &
                "c.cakeid AS 'Item Code', c.name AS 'Item Name', " &
                "o.price AS 'Price', o.quantity AS 'Qty', " &
                "(o.price * o.quantity) AS 'Total' " &
                "FROM `orderitems` o " &
                "JOIN cake c ON o.cakeid = c.cakeid " &
                "WHERE DATE(o.order_date) = @date " &
                "ORDER BY o.order_date"
            cmd.Parameters.AddWithValue("@date", selectedDate)

        ElseIf rdoMonth.Checked Then
            Dim selectedMonth As Integer = cmbMonth.SelectedIndex + 1
            Dim selectedYear As Integer = nudYear_Month.Value
            query = "SELECT o.orderitem_id AS 'Order No', DATE_FORMAT(o.order_date, '%d-%m-%Y') AS 'Order Date', " &
                "c.cakeid AS 'Item Code', c.name AS 'Item Name', " &
                "o.price AS 'Price', o.quantity AS 'Qty', " &
                "(o.price * o.quantity) AS 'Total' " &
                "FROM `orderitems` o " &
                "JOIN cake c ON o.cakeid = c.cakeid " &
                "WHERE MONTH(o.order_date) = @month AND YEAR(o.order_date) = @year " &
                "ORDER BY o.order_date"
            cmd.Parameters.AddWithValue("@month", selectedMonth)
            cmd.Parameters.AddWithValue("@year", selectedYear)

        ElseIf rdoYear.Checked Then
            Dim selectedYear As Integer = nudYear_Only.Value
            query = "SELECT o.orderitem_id AS 'Order No', DATE_FORMAT(o.order_date, '%d-%m-%Y') AS 'Order Date', " &
                "c.cakeid AS 'Item Code', c.name AS 'Item Name', " &
                "o.price AS 'Price', o.quantity AS 'Qty', " &
                "(o.price * o.quantity) AS 'Total' " &
                "FROM `orderitems` o " &
                "JOIN cake c ON o.cakeid = c.cakeid " &
                "WHERE YEAR(o.order_date) = @year " &
                "ORDER BY o.order_date"
            cmd.Parameters.AddWithValue("@year", selectedYear)
        End If

        Try
            Using conn As New MySqlConnection("server=localhost; user=root; password=nithya; database=CakeShopdb;")
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = query

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvSalesReport.DataSource = dt

                Dim totalSales As Decimal = dt.AsEnumerable().Sum(Function(row) Convert.ToDecimal(row("Total")))
                lblTotalSales.Text = "Total Sales: $" & totalSales.ToString("N2")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Try
            Dim saveFile As New SaveFileDialog()
            saveFile.Filter = "PDF Files (*.pdf)|*.pdf"
            saveFile.FileName = "Sales_Report.pdf"

            If saveFile.ShowDialog() = DialogResult.OK Then
                Dim doc As New Document(PageSize.A4)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFile.FileName, FileMode.Create))
                doc.Open()

                Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD)
                Dim tableFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL)
                Dim totalFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)

                Dim title As New Paragraph("Sales Report", titleFont)
                title.Alignment = Element.ALIGN_CENTER
                doc.Add(title)
                doc.Add(New Paragraph(vbCrLf))

                Dim table As New PdfPTable(dgvSalesReport.Columns.Count)
                table.WidthPercentage = 100

                For Each column As DataGridViewColumn In dgvSalesReport.Columns
                    Dim cell As New PdfPCell(New Phrase(column.HeaderText, tableFont))
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY
                    table.AddCell(cell)
                Next

                Dim totalSales As Decimal = 0
                For Each row As DataGridViewRow In dgvSalesReport.Rows
                    If Not row.IsNewRow Then
                        For Each cell As DataGridViewCell In row.Cells
                            table.AddCell(New Phrase(cell.Value?.ToString(), tableFont))
                        Next
                        totalSales += Convert.ToDecimal(row.Cells("Total").Value)
                    End If
                Next

                doc.Add(table)
                doc.Add(New Paragraph(vbCrLf))

                Dim totalSalesText As String = "Total Sales Amount: $" & totalSales.ToString("N2")
                Dim totalParagraph As New Paragraph(totalSalesText, totalFont)
                totalParagraph.Alignment = Element.ALIGN_RIGHT
                doc.Add(totalParagraph)
                doc.Close()
                writer.Close()

                MessageBox.Show("PDF Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        frmAdminPanel.Show()
    End Sub
End Class
