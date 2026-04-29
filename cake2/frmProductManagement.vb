Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmProductManagement

    Private connStr As String = "server=localhost;userid=ID;password=your_password;database=cakeshopdb"
    Private conn As New MySqlConnection(connStr)

    Private selectedImagePath As String = ""

    Private Sub frmProductManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            conn.Open()
            Dim query As String = "SELECT cakeid, name, category, price, quantity, availability, flavour, ImagePath FROM cake"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvProducts.DataSource = dt
            If dgvProducts.Columns.Contains("cakeid") Then
                dgvProducts.Columns("cakeid").Visible = False
            End If
            If dgvProducts.Columns.Contains("ImagePath") Then
                dgvProducts.Columns("ImagePath").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        ofdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofdImage.ShowDialog() = DialogResult.OK Then
            selectedImagePath = ofdImage.FileName
            picCake.Image = Image.FromFile(selectedImagePath)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO cake (name, category, price, quantity, availability,flavour,  ImagePath) " &
                                  "VALUES (@Name, @Category, @Price, @Quantity, @Availability,@Flavour,  @ImagePath)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Name", txtCakeName.Text.Trim())
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim())
            cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()))
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text.Trim())
            cmd.Parameters.AddWithValue("@Availability", chkAvailability.Checked)
            cmd.Parameters.AddWithValue("@Flavour", txtFlavour.Text.Trim())

            cmd.Parameters.AddWithValue("@ImagePath", selectedImagePath)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Cake added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error adding cake: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            LoadProducts()
        End Try
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            txtCakeName.Text = row.Cells("name").Value.ToString()
            txtCategory.Text = row.Cells("category").Value.ToString()
            txtPrice.Text = row.Cells("price").Value.ToString()
            txtQuantity.Text = row.Cells("quantity").Value.ToString()
            chkAvailability.Checked = Convert.ToBoolean(row.Cells("availability").Value)
            txtFlavour.Text = row.Cells("flavour").Value.ToString()

            If row.Cells("ImagePath").Value IsNot Nothing Then
                Dim path As String = row.Cells("ImagePath").Value.ToString()
                If File.Exists(path) Then
                    picCake.Image = Image.FromFile(path)
                    selectedImagePath = path
                Else
                    picCake.Image = Nothing
                    selectedImagePath = ""
                End If
            Else
                picCake.Image = Nothing
                selectedImagePath = ""
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvProducts.SelectedRows(0)
            Dim cakeID As Integer = Convert.ToInt32(row.Cells("cakeid").Value)

            Try
                conn.Open()
                Dim query As String = "UPDATE cake SET name=@Name, category=@Category, price=@Price, " &
                                      "quantity=@Quantity, availability=@Availability, flavour=@Flavour, ImagePath=@ImagePath " &
                                      "WHERE cakeid=@CakeID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", txtCakeName.Text.Trim())
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim())
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()))
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text.Trim())
                cmd.Parameters.AddWithValue("@Availability", chkAvailability.Checked)
                cmd.Parameters.AddWithValue("@Flavour", txtFlavour.Text.Trim())
                cmd.Parameters.AddWithValue("@ImagePath", selectedImagePath)
                cmd.Parameters.AddWithValue("@CakeID", cakeID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Cake updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No records were updated. Please check your input.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating cake: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                LoadProducts()
            End Try
        Else
            MessageBox.Show("Please select a cake to edit.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvProducts.SelectedRows(0)
            Dim cakeID As Integer = Convert.ToInt32(row.Cells("cakeid").Value)

            If MessageBox.Show("Are you sure you want to delete this cake?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM cake WHERE cakeid=@CakeID"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CakeID", cakeID)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Cake deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error deleting cake: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                    LoadProducts()
                End Try
            End If
        Else
            MessageBox.Show("Please select a cake to delete.")
        End If

        txtCakeName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtFlavour.Clear()

        chkAvailability.Checked = False
        picCake.Image = Nothing
        selectedImagePath = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCakeName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtFlavour.Clear()

        chkAvailability.Checked = False
        picCake.Image = Nothing
        selectedImagePath = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Me.Hide()
        frmAdminPanel.Show()
    End Sub
End Class
