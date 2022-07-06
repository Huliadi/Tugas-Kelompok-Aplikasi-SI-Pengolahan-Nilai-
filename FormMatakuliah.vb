Imports MySql.Data.MySqlClient
Public Class FormMatakuliah
    Sub ReloadData()
        txtKodeMatkul.Text = ""
        txtNamaMatkul.Text = ""
        cmbSemester.Text = ""
        txtSKS.Text = ""
        Call Tampil()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call OpenConnection()
        Dim InputData As String = "Insert into tb_matakuliah values ('" & txtKodeMatkul.Text & "','" & txtNamaMatkul.Text & "','" & cmbSemester.Text & "','" & txtSKS.Text & "')"
        cmd = New MySqlCommand(InputData, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub

    Private Sub FormMatakuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()
    End Sub
    Sub Tampil()
        Call OpenConnection()
        Da = New MySqlDataAdapter("select * from tb_matakuliah", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_matakuliah")
        dgvMatakuliah.DataSource = Ds.Tables("tb_matakuliah")
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call OpenConnection()
        Dim Edit As String = "Update tb_matakuliah set Nama_Matakuliah = '" & txtNamaMatkul.Text & "',Semester ='" & cmbSemester.Text & "',Sks ='" & txtSKS.Text & "'where Kode_Matakuliah ='" & txtKodeMatkul.Text & "'"
        cmd = New MySqlCommand(Edit, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call OpenConnection()
        Dim Hapus As String = "Delete from tb_matakuliah where Kode_Matakuliah = '" & txtKodeMatkul.Text & "'"
        cmd = New MySqlCommand(Hapus, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub
    Private Sub txtKodeMatkul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeMatkul.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConnection()
            cmd = New MySqlCommand("select * from tb_matakuliah where Kode_Matakuliah='" & txtKodeMatkul.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                txtKodeMatkul.Text = Rd.Item("Kode_Matakuliah")
                txtNamaMatkul.Text = Rd.Item("Nama_Matakuliah")
                cmbSemester.Text = Rd.Item("Semester")
                txtSKS.Text = Rd.Item("Sks")
            End If
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub
End Class