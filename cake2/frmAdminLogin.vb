Imports MySql.Data.MySqlClient

Public Class frmAdminLogin

    Dim connStr As String = "server=localhost;userid=ID;password=your_Password;database=CakeShopDB"

    Dim loginAttempts As Integer = 0
    Dim cooldownSeconds As Integer = 30

    Private Function IsFirstTimeSetup() As Boolean
        Dim count As Integer = 0
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM Admin"
                Dim cmd As New MySqlCommand(query, conn)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            Catch ex As Exception
                MessageBox.Show("Error checking admin record: " & ex.Message)
            End Try
        End Using
        Return (count = 0)
    End Function

    Private Sub frmAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        lblCooldown.Visible = False

        If IsFirstTimeSetup() Then
            Dim setupForm As New frmFirstTimeSetup()
            setupForm.ShowDialog()

            If IsFirstTimeSetup() Then
                MessageBox.Show("Admin password setup was not completed. The application will now exit.")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If loginAttempts >= 3 Then
            MessageBox.Show("Too many failed attempts. Please wait " & cooldownSeconds & " seconds.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Button1.Enabled = False
            lblCooldown.Visible = True
            lblCooldown.Text = "Try again in: " & cooldownSeconds & "s"
            coolDownTimer.Start()
            Return
        End If

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM admin WHERE username = @username AND password = @password"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim())
                cmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim())

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    loginAttempts = 0
                    lblCooldown.Visible = False
                    MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    frmAdminPanel.Show()
                Else
                    loginAttempts += 1
                    MessageBox.Show("Invalid credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    If loginAttempts >= 3 Then
                        Button1.Enabled = False
                        lblCooldown.Visible = True
                        lblCooldown.Text = "Try again in: " & cooldownSeconds & "s"
                        coolDownTimer.Start()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub

    Private Sub coolDownTimer_Tick(sender As Object, e As EventArgs) Handles coolDownTimer.Tick
        cooldownSeconds -= 1
        lblCooldown.Text = "Try again in: " & cooldownSeconds & "s"

        If cooldownSeconds <= 0 Then
            coolDownTimer.Stop()
            Button1.Enabled = True
            lblCooldown.Visible = False
            cooldownSeconds = 30
            loginAttempts = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub
End Class
