Imports MySql.Data.MySqlClient
Public Class FormKHS
    Sub ReloadData()
        txtIDKHS.Text = ""
        cmbTahunAjaran.Text = ""
        txtKodeMK.Text = ""
        txtNIM.Text = ""
        txtNilaiAbsen.Text = ""
        txtNilaiTugas.Text = ""
        txtNilaiUTS.Text = ""
        txtNilaiUAS.Text = ""
        Call Tampil()
    End Sub
    Sub Tambah()
        lblNilaiAngka.Text = Val(txtNilaiAbsen.Text) * 0.2 + Val(txtNilaiTugas.Text) * 0.2 + Val(txtNilaiUTS.Text) * 0.3 + (txtNilaiUAS.Text) * 0.3
        If lblNilaiAngka.Text >= 90 Then
            lblNIlaiHuruf.Text = "A"
            lblKeterangan.Text = "Sangat Memuaskan"
        ElseIf lblNilaiAngka.Text >= 80 Then
            lblNIlaiHuruf.Text = "B"
            lblKeterangan.Text = "Baik"
        ElseIf lblNilaiAngka.Text >= 65 Then
            lblNIlaiHuruf.Text = "C"
            lblKeterangan.Text = "Cukup"
        Else
            lblNIlaiHuruf.Text = "E"
            lblKeterangan.Text = "Tidak Lulus"
        End If
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call OpenConnection()
        Dim InputData As String = "Insert into tb_khs values ('" & txtIDKHS.Text & "','" & cmbTahunAjaran.Text & "','" & txtKodeMK.Text & "','" & txtNIM.Text & "','" & txtNilaiAbsen.Text & "','" & txtNilaiTugas.Text & "','" & txtNilaiUTS.Text & "','" & txtNilaiUAS.Text & "')"
        cmd = New MySqlCommand(InputData, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
        Call Tambah()
    End Sub

    Private Sub FormKHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()
    End Sub
    Sub Tampil()
        Call OpenConnection()
        Da = New MySqlDataAdapter("select * from tb_khs", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_khs")
        dgvKHS.DataSource = Ds.Tables("tb_khs")
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call OpenConnection()
        Dim Edit As String = "Update tb_khs set Kode_Matakuliah = '" & txtKodeMK.Text & "',Tahun_Ajaran ='" & cmbTahunAjaran.Text & "',NIM ='" & txtNIM.Text & "',Nilai_Absen ='" & txtNilaiAbsen.Text & "',Nilai_Tugas ='" & txtNilaiTugas.Text & "',Nilai_UTS ='" & txtNilaiUTS.Text & "',Nilai_UAS ='" & txtNilaiUAS.Text & "'where ID_KHS ='" & txtIDKHS.Text & "'"
        cmd = New MySqlCommand(Edit, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call OpenConnection()
        Dim Hapus As String = "Delete from tb_khs where ID_KHS = '" & txtIDKHS.Text & "'"
        cmd = New MySqlCommand(Hapus, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub
    Private Sub txtIDKHS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDKHS.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConnection()
            cmd = New MySqlCommand("select * from tb_khs where ID_KHS='" & txtIDKHS.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                txtIDKHS.Text = Rd.Item("ID_KHS")
                cmbTahunAjaran.Text = Rd.Item("Tahun_Ajaran")
                txtKodeMK.Text = Rd.Item("Kode_Matakuliah")
                txtNIM.Text = Rd.Item("NIM")
                txtNilaiAbsen.Text = Rd.Item("NIlai_Absen")
                txtNilaiTugas.Text = Rd.Item("Nilai_Tugas")
                txtNilaiUTS.Text = Rd.Item("Nilai_UTS")
                txtNilaiUAS.Text = Rd.Item("Nilai_UAS")
            End If
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub
End Class