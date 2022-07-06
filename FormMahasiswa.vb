Imports MySql.Data.MySqlClient
Public Class FormMahasiswa
    Sub ReloadData()
        txtNIM.Text = ""
        txtNamaMHS.Text = ""
        cmbFakultas.Text = ""
        cmbProdi.Text = ""
        txtAlamat.Text = ""
        cbJenis_Kelamin.Text = ""
        txtHP.Text = ""
        Call Tampil()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call OpenConnection()
        Dim InputData As String = "Insert into tb_mahasiswa values ('" & txtNIM.Text & "','" & txtNamaMHS.Text & "','" & cmbFakultas.Text & "','" & cmbProdi.Text & "','" & txtAlamat.Text & "','" & cbJenis_Kelamin.Text & "','" & txtHP.Text & "')"
        cmd = New MySqlCommand(InputData, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub

    Private Sub FormMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()
    End Sub
    Sub Tampil()
        Call OpenConnection()
        Da = New MySqlDataAdapter("select * from tb_mahasiswa", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_mahasiswa")
        dgvMahasiswa.DataSource = Ds.Tables("tb_mahasiswa")
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call OpenConnection()
        Dim Edit As String = "Update tb_mahasiswa set Nama_Mahasiswa = '" & txtNamaMHS.Text & "',Fakultas ='" & cmbFakultas.Text & "',Prodi ='" & cmbProdi.Text & "',Alamat ='" & txtAlamat.Text & "',Jenis_kelamin ='" & cbJenis_Kelamin.Text & "',Telepon ='" & txtHP.Text & "'where NIM ='" & txtNIM.Text & "'"
        cmd = New MySqlCommand(Edit, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call OpenConnection()
        Dim Hapus As String = "Delete from tb_mahasiswa where NIM = '" & txtNIM.Text & "'"
        cmd = New MySqlCommand(Hapus, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub
    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConnection()
            cmd = New MySqlCommand("select * from tb_mahasiswa where NIM='" & txtNIM.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                txtNIM.Text = Rd.Item("NIM")
                txtNamaMHS.Text = Rd.Item("Nama_Mahasiswa")
                cmbFakultas.Text = Rd.Item("Fakultas")
                cmbProdi.Text = Rd.Item("Prodi")
                txtAlamat.Text = Rd.Item("Alamat")
                cbJenis_Kelamin.Text = Rd.Item("Jenis_Kelamin")
                txtHP.Text = Rd.Item("Telepon")
            End If
        End If
    End Sub
End Class