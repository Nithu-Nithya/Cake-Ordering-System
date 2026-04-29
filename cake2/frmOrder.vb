Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports System.Drawing.Printing
Imports Mysqlx.Crud

Public Class frmOrder
    Dim currentOrderId As String
    Dim customerName As String
    Dim cakeMessage As String
    Dim paymentMethod As String
    Dim yPos As Integer

    Public cartTable As DataTable
    Public totalAmount As Decimal
    Public orderNo As String
    Public orderDate As String

    Dim connStr As String = "server=localhost;userid=ID;password=your_password;database=CakeShopDB"

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCart.DataSource = cartTable
        dgvCart.ClearSelection()
        lblTotalPrice.Text = "$" & totalAmount.ToString("F2")
        Panel1.Visible = False
    End Sub

    Private Sub rbOnline_CheckedChanged(sender As Object, e As EventArgs) Handles rbOnline.CheckedChanged

        Panel1.Visible = rbOnline.Checked
    End Sub

    Private Sub rbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged
        Panel1.Visible = Not rbCash.Checked

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cartTable.Clear()
        frmCakeCatalog.Show()
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtCustomerName.Text.Trim() = "" Then
            MessageBox.Show("Please enter the customer name.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cartTable.Rows.Count = 0 Then
            MessageBox.Show("No items in the cart.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        customerName = txtCustomerName.Text.Trim()
        cakeMessage = txtCakeMessage.Text.Trim()
        paymentMethod = If(rbOnline.Checked, "Online", "Cash")
        orderDate = orderDate

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                For Each row As DataRow In cartTable.Rows
                    Dim cakeId As Integer = GetCakeIdByName(row("Name").ToString())
                    Dim quantity As Integer = Convert.ToInt32(row("Quantity"))
                    Dim price As Decimal = Convert.ToDecimal(row("Price"))

                    Dim insertCartCmd As New MySqlCommand("INSERT INTO orderitems (cakeid, quantity, price, order_date) VALUES (@cakeid, @qty, @price, @date); SELECT LAST_INSERT_ID();", conn)
                    insertCartCmd.Parameters.AddWithValue("@cakeid", cakeId)
                    insertCartCmd.Parameters.AddWithValue("@qty", quantity)
                    insertCartCmd.Parameters.AddWithValue("@price", price)
                    insertCartCmd.Parameters.AddWithValue("@date", Date.Now.Date)
                    Dim orderItemId As Integer = Convert.ToInt32(insertCartCmd.ExecuteScalar())

                    Dim insertPaymentCmd As New MySqlCommand("INSERT INTO payment (orderitem_id, totalamount, paymentmethod) VALUES (@id, @amt, @method)", conn)
                    insertPaymentCmd.Parameters.AddWithValue("@id", orderItemId)
                    insertPaymentCmd.Parameters.AddWithValue("@amt", price)
                    insertPaymentCmd.Parameters.AddWithValue("@method", paymentMethod)
                    insertPaymentCmd.ExecuteNonQuery()
                Next
            End Using

            currentOrderId = orderNo
            customerName = customerName
            cakeMessage = cakeMessage
            paymentMethod = paymentMethod
            orderDate = Date.Now

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
            MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cartTable.Clear()
            dgvCart.DataSource = Nothing
            frmCakeCatalog.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetCakeIdByName(name As String) As Integer
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT cakeid FROM Cake WHERE name = @name LIMIT 1", conn)
            cmd.Parameters.AddWithValue("@name", name)
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, Convert.ToInt32(result), 0)
        End Using
    End Function

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Consolas", 12)
        Dim boldFont As New Font("Consolas", 12, FontStyle.Bold)
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim yPos As Integer = 100
        Dim lineHeight As Integer = font.Height + 5

        Dim title As String = "Enze Pastries"
        Dim titleWidth As SizeF = e.Graphics.MeasureString(title, boldFont)
        e.Graphics.DrawString(title, boldFont, Brushes.Black, (pageWidth - titleWidth.Width) / 2, yPos)
        yPos += lineHeight * 2

        Dim infoLines As String() = {
            "Order No: " & currentOrderId,
            "Date: " & orderDate,
            "Customer: " & txtCustomerName.Text,
            "Message on Cake: " & txtCakeMessage.Text
        }

        For Each line As String In infoLines
            Dim textWidth As SizeF = e.Graphics.MeasureString(line, font)
            e.Graphics.DrawString(line, font, Brushes.Black, (pageWidth - textWidth.Width) / 2, yPos)
            yPos += lineHeight
        Next

        yPos += lineHeight

        Dim tableHeader As String = "Item                Qty     Price     Total"
        Dim tableHeaderWidth As SizeF = e.Graphics.MeasureString(tableHeader, boldFont)
        e.Graphics.DrawString(tableHeader, boldFont, Brushes.Black, (pageWidth - tableHeaderWidth.Width) / 2, yPos)
        yPos += lineHeight

        Dim divider As String = New String("-"c, 45)
        e.Graphics.DrawString(divider, font, Brushes.Black, (pageWidth - e.Graphics.MeasureString(divider, font).Width) / 2, yPos)
        yPos += lineHeight

        Dim itemDict As New Dictionary(Of String, Tuple(Of Integer, Decimal))

        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then
                Dim itemName As String = row.Cells("Name").Value.ToString()
                Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                If itemDict.ContainsKey(itemName) Then
                    Dim current = itemDict(itemName)
                    itemDict(itemName) = Tuple.Create(current.Item1 + 1, price)
                Else
                    itemDict(itemName) = Tuple.Create(1, price)
                End If
            End If
        Next

        For Each kvp In itemDict
            Dim name = kvp.Key.PadRight(20)
            Dim qty = kvp.Value.Item1.ToString().PadLeft(3)
            Dim priceStr = "$" & kvp.Value.Item2.ToString("F2").PadLeft(7)
            Dim total = kvp.Value.Item1 * kvp.Value.Item2
            Dim totalStr = "$" & total.ToString("F2").PadLeft(7)
            Dim line = $"{name}{qty}   {priceStr}   {totalStr}"

            e.Graphics.DrawString(line, font, Brushes.Black, (pageWidth - e.Graphics.MeasureString(line, font).Width) / 2, yPos)
            yPos += lineHeight
        Next

        yPos += lineHeight

        Dim grandTotalLine = "Grand Total: $" & totalAmount
        Dim totalWidth = e.Graphics.MeasureString(grandTotalLine, boldFont)
        e.Graphics.DrawString(grandTotalLine, boldFont, Brushes.Black, (pageWidth - totalWidth.Width) / 2, yPos)
        yPos += lineHeight * 2

        Dim paymentLine = "Payment Method: " & If(rbCash.Checked, "Cash", "Online")
        Dim payWidth = e.Graphics.MeasureString(paymentLine, font)
        e.Graphics.DrawString(paymentLine, font, Brushes.Black, (pageWidth - payWidth.Width) / 2, yPos)
        yPos += lineHeight * 2

        Dim footer = "Thank you for your purchase!"
        Dim footerWidth = e.Graphics.MeasureString(footer, boldFont)
        e.Graphics.DrawString(footer, boldFont, Brushes.Black, (pageWidth - footerWidth.Width) / 2, yPos)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
    End Sub
End Class