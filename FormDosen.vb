Imports MySql.Data.MySqlClient
Public Class FormDosen
    Sub ReloadData()
        txtNIDN.Text = ""
        txtNamaDosen.Text = ""
        txtAlamat.Text = ""
        cmbJK.Text = ""
        txtHP.Text = ""
        Call Tampil()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call OpenConnection()
        Dim InputData As String = "Insert into tb_dosen (NIDN, Nama_Dosen, Jenis_Kelamin, Alamat, Telepon) values('" & txtNIDN.Text & "','" & txtNamaDosen.Text & "','" & cmbJK.Text & "','" & txtAlamat.Text & "','" & txtHP.Text & "')"
        cmd = New MySqlCommand(InputData, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil")
        Call ReloadData()
    End Sub

    Private Sub FormDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()
    End Sub
    Sub Tampil()
        Call OpenConnection()
        Da = New MySqlDataAdapter("select * from tb_dosen", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_dosen")
        dgvDosen.DataSource = Ds.Tables("tb_dosen")
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call OpenConnection()
        Dim Edit As String = "Update tb_dosen set Nama_Dosen = '" & txtNamaDosen.Text & "',Jenis_kelamin ='" & cmbJK.Text & "',Alamat ='" & txtAlamat.Text & "',Telepon ='" & txtHP.Text & "'where NIDN ='" & txtNIDN.Text & "'"
        cmd = New MySqlCommand(Edit, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call OpenConnection()
        Dim Hapus As String = "Delete from tb_dosen where NIDN = '" & txtNIDN.Text & "'"
        cmd = New MySqlCommand(Hapus, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub
    Private Sub txtNIDN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIDN.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConnection()
            cmd = New MySqlCommand("select * from tb_dosen where NIDN='" & txtNIDN.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                txtNIDN.Text = Rd.Item("NIDN")
                txtNamaDosen.Text = Rd.Item("Nama_Dosen")
                cmbJK.Text = Rd.Item("Jenis_kelamin")
                txtAlamat.Text = Rd.Item("Alamat")
                txtHP.Text = Rd.Item("Telepon")
            End If
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub
End Class