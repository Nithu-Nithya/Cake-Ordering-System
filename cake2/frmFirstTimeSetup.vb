Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmFirstTimeSetup

    Dim connStr As String = "server=localhost;userid=ID;password=Your_password;database=CakeShopDB"

    Private Sub frmFirstTimeSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        TextBox3.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
        TextBox3.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()
        Dim confirmPassword As String = TextBox3.Text.Trim()

        If username = "" Then
            MessageBox.Show("Please enter a username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not ValidatePasswordRules(password) Then
            MessageBox.Show("Password must be 6-12 characters, include at least one uppercase letter, and one special character.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        SaveAdminCredentials(username, password)
    End Sub

    Private Sub SaveAdminCredentials(username As String, newPassword As String)
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "INSERT INTO Admin (Username, Password) VALUES (@Username, @Password)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", newPassword)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Admin account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error setting up admin account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Password Text Changed Event - Dynamic Strength Indicator
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim password As String = TextBox2.Text
        Dim strength As Integer = GetPasswordStrengthScore(password)

        ProgressBar1.Value = strength
        UpdateProgressBarColor(ProgressBar1, strength)

        If strength < 40 Then
            lblStrength.Text = "Weak"
            lblStrength.ForeColor = Color.Red
        ElseIf strength < 70 Then
            lblStrength.Text = "Medium"
            lblStrength.ForeColor = Color.Orange
        Else
            lblStrength.Text = "Strong"
            lblStrength.ForeColor = Color.Green
        End If

        ShowPasswordTips(password)
    End Sub

    Private Function GetPasswordStrengthScore(password As String) As Integer
        Dim score As Integer = 0

        If password.Length >= 6 Then score += 30
        If password.Length >= 10 Then score += 10

        ' Uppercase points
        If password.Any(AddressOf Char.IsUpper) Then score += 30

        ' Special character points
        If password.Any(Function(ch) "!@#$%^&*()_+-=[]{}|;:',.<>?/`~".Contains(ch)) Then score += 30

        ' Cap score
        If score > 100 Then score = 100

        Return score
    End Function

    ' Update Progress Bar Color
    Private Sub UpdateProgressBarColor(pb As ProgressBar, score As Integer)
        If score < 40 Then
            pb.ForeColor = Color.Red
        ElseIf score < 70 Then
            pb.ForeColor = Color.Orange
        Else
            pb.ForeColor = Color.Green
        End If
    End Sub

    ' Show dynamic password tips
    Private Sub ShowPasswordTips(password As String)
        Dim tip As String = ""

        If password.Length < 6 Or password.Length > 12 Then
            tip &= "Password should be 6-12 characters long." & vbCrLf
        End If

        If Not password.Any(AddressOf Char.IsUpper) Then
            tip &= "Add at least one uppercase letter." & vbCrLf
        End If

        If Not password.Any(Function(ch) "!@#$%^&*()_+-=[]{}|;:',.<>?/`~".Contains(ch)) Then
            tip &= "Add at least one special character." & vbCrLf
        End If

        If tip = "" Then
            tip = "Good password!"
        End If

        ToolTip1.SetToolTip(TextBox2, tip)
    End Sub

    Private Function ValidatePasswordRules(password As String) As Boolean
        If password.Length < 6 Or password.Length > 12 Then Return False

        If Not password.Any(AddressOf Char.IsUpper) Then Return False

        If Not password.Any(Function(ch) "!@#$%^&*()_+-=[]{}|;:',.<>?/`~".Contains(ch)) Then Return False

        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Application.Exit()
    End Sub
End Class
