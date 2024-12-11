Imports MySql.Data.MySqlClient
Imports Windows.Win32.System
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim cmd As New MySqlCommand("SELECT * FROM useraccount WHERE Username=@Username AND Password=@Password", conn)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        adapter.SelectCommand = cmd
        adapter.Fill(table)

        Try
            conn.Open()
            Dim EntryPoint As Object = cmd.ExecuteScalar()
            If EntryPoint IsNot Nothing Then
                MsgBox("Login successful!", MsgBoxStyle.Information, "Add Student")
                Me.Hide()
                Home.Show()
            Else
                MsgBox("Invalid username or password.", MsgBoxStyle.Critical, "Add Student")
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = False Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Select Case sender.Name
                Case "txtUsername"
                    txtPassword.Focus()
                Case "txtPassword"
                    btnLogin.PerformClick()
            End Select
        End If
    End Sub
End Class