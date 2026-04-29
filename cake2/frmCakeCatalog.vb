Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmCakeCatalog
    Dim connStr As String = "server=localhost;userid=ID;password=Your_password;database=CakeShopDB"
    Dim orderNo As String = "ORD" & Now.ToString("yyyyMMddHHmmss")
    Dim cartTable As New DataTable()

    Private isDragging As Boolean = False
    Private dragStart As Point

    Private Sub flpCakes_MouseDown(sender As Object, e As MouseEventArgs) Handles flpCakes.MouseDown
        isDragging = True
        dragStart = e.Location
    End Sub
    Private Sub flpCakes_MouseMove(sender As Object, e As MouseEventArgs) Handles flpCakes.MouseMove
        If isDragging Then
            flpCakes.AutoScrollPosition = New Point(
            -flpCakes.AutoScrollPosition.X,
            -(flpCakes.AutoScrollPosition.Y + (e.Y - dragStart.Y))
        )
        End If
    End Sub
    Private Sub flpCakes_MouseUp(sender As Object, e As MouseEventArgs) Handles flpCakes.MouseUp
        isDragging = False
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        lblOrderNo.Text = orderNo
        lblOrderDate.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
        dgvCart.DataSource = Nothing
        cartTable.Clear()
        InitCartTable()
        LoadCategories()
        LoadCakes("All")
    End Sub

    Private Sub InitCartTable()
        cartTable = New DataTable()
        cartTable.Columns.Add("Name", GetType(String))
        cartTable.Columns.Add("Quantity", GetType(Integer))
        cartTable.Columns.Add("Price", GetType(Decimal))
        cartTable.Columns.Add("Total", GetType(Decimal))
        cartTable.Columns.Add("Flavour", GetType(String))
        dgvCart.DataSource = cartTable

        If dgvCart.Columns.Contains("Remove") = False Then
            Dim btnRemove As New DataGridViewButtonColumn()
            btnRemove.Name = "Remove"
            btnRemove.HeaderText = "Remove"
            btnRemove.Text = "❌"
            btnRemove.UseColumnTextForButtonValue = True
            dgvCart.Columns.Add(btnRemove)
        End If

        dgvCart.AllowUserToAddRows = False
    End Sub

    Private Sub LoadCakes(Optional search As String = "")
        flpCakes.Controls.Clear()

        With flpCakes
            .AutoScroll = True
            .FlowDirection = FlowDirection.LeftToRight
            .WrapContents = True
        End With

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim query As String = "SELECT * FROM Cake WHERE availability = 1"
            If Not String.IsNullOrWhiteSpace(search) AndAlso search.ToLower() <> "all" Then
                query &= " AND (name LIKE @search OR category LIKE @search OR flavour LIKE @search)"
            End If

            Using cmd As New MySqlCommand(query, conn)
                If Not String.IsNullOrWhiteSpace(search) AndAlso search.ToLower() <> "all" Then
                    cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim cakePanel As New Panel()
                        cakePanel.Width = 220
                        cakePanel.Height = 270
                        cakePanel.BorderStyle = BorderStyle.FixedSingle
                        cakePanel.Margin = New Padding(10)

                        Dim img As New PictureBox()
                        Dim imgPath As String = reader("ImagePath").ToString()
                        If File.Exists(imgPath) Then
                            img.Image = Image.FromFile(imgPath)
                        End If
                        img.SizeMode = PictureBoxSizeMode.StretchImage
                        img.Width = 200
                        img.Height = 120
                        img.Top = 5
                        img.Left = 10

                        Dim lblName As New Label()
                        lblName.Text = reader("name").ToString()
                        lblName.Width = 200
                        lblName.Top = img.Bottom + 5
                        lblName.Left = 10
                        lblName.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                        Dim lblPrice As New Label()
                        lblPrice.Text = "$. " & reader("price").ToString()
                        lblPrice.Width = 200
                        lblPrice.Top = lblName.Bottom + 5
                        lblPrice.Left = 10

                        Dim lblQuantity As New Label()
                        lblQuantity.Text = "Qty: " & reader("quantity").ToString()
                        lblQuantity.Width = 200
                        lblQuantity.Top = lblPrice.Bottom + 5
                        lblQuantity.Left = 10

                        Dim lblFlavour As New Label With {
                            .Text = "Flavour: " & reader("flavour").ToString(),
                            .Width = 200,
                            .Top = lblQuantity.Bottom + 5,
                            .Left = 10
                        }

                        Dim btnAdd As New Button()
                        btnAdd.Text = "Add to Cart"
                        btnAdd.Width = 200
                        btnAdd.Height = 30
                        btnAdd.Top = lblFlavour.Bottom + 5
                        btnAdd.Left = 10
                        btnAdd.Tag = reader("cakeid").ToString()
                        btnAdd.BackColor = Color.RosyBrown
                        AddHandler btnAdd.Click, AddressOf AddToCart

                        cakePanel.Controls.Add(img)
                        cakePanel.Controls.Add(lblName)
                        cakePanel.Controls.Add(lblPrice)
                        cakePanel.Controls.Add(lblQuantity)
                        cakePanel.Controls.Add(lblFlavour)
                        cakePanel.Controls.Add(btnAdd)
                        flpCakes.Controls.Add(cakePanel)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadCategories()
        cmbCategory.Items.Clear()
        cmbCategory.Items.Add("All")

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim query As String = "SELECT DISTINCT category FROM Cake"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbCategory.Items.Add(reader("category").ToString())
                    End While
                End Using
            End Using
        End Using

        cmbCategory.SelectedIndex = 0
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadCakes(cmbCategory.SelectedItem.ToString())
    End Sub

    Private Sub AddToCart(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim cakeId As Integer = Convert.ToInt32(btn.Tag)

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM Cake WHERE cakeid = @id", conn)
            cmd.Parameters.AddWithValue("@id", cakeId)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim name As String = reader("name").ToString()
                Dim price As Decimal = Convert.ToDecimal(reader("price"))
                Dim flavour As String = reader("flavour").ToString()


                Dim row As DataRow = cartTable.NewRow()
                row("Name") = name
                row("Quantity") = 1
                row("Price") = price
                row("Total") = price
                row("Flavour") = flavour

                cartTable.Rows.Add(row)

                UpdateTotal()
            End If
        End Using
    End Sub

    Private Sub UpdateTotal()
        Dim total As Decimal = 0
        For Each row As DataRow In cartTable.Rows
            total += Convert.ToDecimal(row("Total"))
        Next
        lblTotalAmount.Text = "$ " & total.ToString("F2")
    End Sub

    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick
        If e.ColumnIndex = dgvCart.Columns("Remove").Index AndAlso e.RowIndex >= 0 Then
            dgvCart.Rows.RemoveAt(e.RowIndex)
            UpdateTotal()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadCakes(txtSearch.Text.Trim())
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        LoadCakes()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        cartTable.Clear()
        UpdateTotal()
    End Sub
    Private Sub btnBuyNow_Click(sender As Object, e As EventArgs) Handles btnBuyNow.Click
        If cartTable.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim total As Decimal = 0
        For Each row As DataRow In cartTable.Rows
            total += Convert.ToDecimal(row("Total"))
        Next

        Dim summaryForm As New frmOrder()
        summaryForm.cartTable = cartTable.Copy()
        summaryForm.totalAmount = total
        summaryForm.orderNo = orderNo
        summaryForm.Show()
        cartTable.Clear()
        UpdateTotal()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        cartTable.Clear()
        UpdateTotal()
        Me.Hide()
        Form1.Show()
    End Sub
End Class


