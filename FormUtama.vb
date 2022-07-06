Public Class FormUtama
    Sub Locked()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        AKADEMIKToolStripMenuItem.Enabled = False
        LAPORANToolStripMenuItem.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Locked()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub DosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DosenToolStripMenuItem.Click
        FormDosen.ShowDialog()
    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MahasiswaToolStripMenuItem.Click
        FormMahasiswa.ShowDialog()
    End Sub

    Private Sub MatakuliahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatakuliahToolStripMenuItem.Click
        FormMatakuliah.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Locked()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub KHSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KHSToolStripMenuItem.Click
        FormKHS.ShowDialog()
    End Sub
End Class
