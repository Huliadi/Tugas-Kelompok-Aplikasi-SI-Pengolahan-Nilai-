Public Class FormLogin
    Sub OpenLocked()
        FormUtama.LoginToolStripMenuItem.Enabled = False
        FormUtama.LogoutToolStripMenuItem.Enabled = True
        FormUtama.AKADEMIKToolStripMenuItem.Enabled = True
        FormUtama.LAPORANToolStripMenuItem.Enabled = True
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username atau Password tidak boleh kosong", vbCritical, "Warning")
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
        Else
            If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
                MsgBox("Login Success", MsgBoxStyle.Information, "Informasi")
                Me.Close()
                Call OpenLocked()
            Else
                MsgBox("Username atau Password anda salah", vbCritical, "Warning")
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "admin"
        txtPassword.Text = "admin"
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class