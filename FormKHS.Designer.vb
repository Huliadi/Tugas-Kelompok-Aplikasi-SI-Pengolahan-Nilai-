<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKHS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTahunAjaran = New System.Windows.Forms.ComboBox()
        Me.txtIDKHS = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtKodeMK = New System.Windows.Forms.TextBox()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.lblKodeMK = New System.Windows.Forms.Label()
        Me.lblTA = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNilaiUAS = New System.Windows.Forms.TextBox()
        Me.txtNilaiUTS = New System.Windows.Forms.TextBox()
        Me.txtNilaiTugas = New System.Windows.Forms.TextBox()
        Me.txtNilaiAbsen = New System.Windows.Forms.TextBox()
        Me.lblNUAS = New System.Windows.Forms.Label()
        Me.lblNUTS = New System.Windows.Forms.Label()
        Me.lblNT = New System.Windows.Forms.Label()
        Me.lblNA = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblNIA = New System.Windows.Forms.Label()
        Me.lblNilaiAngka = New System.Windows.Forms.Label()
        Me.lblNHU = New System.Windows.Forms.Label()
        Me.lblNIlaiHuruf = New System.Windows.Forms.Label()
        Me.lblKet = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.dgvKHS = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvKHS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA KHS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.txtIDKHS)
        Me.GroupBox1.Controls.Add(Me.txtNIM)
        Me.GroupBox1.Controls.Add(Me.txtKodeMK)
        Me.GroupBox1.Controls.Add(Me.lblNIM)
        Me.GroupBox1.Controls.Add(Me.lblKodeMK)
        Me.GroupBox1.Controls.Add(Me.lblTA)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 240)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data KHS"
        '
        'cmbTahunAjaran
        '
        Me.cmbTahunAjaran.FormattingEnabled = True
        Me.cmbTahunAjaran.Items.AddRange(New Object() {"2020", "2021", "2022", "2023"})
        Me.cmbTahunAjaran.Location = New System.Drawing.Point(112, 102)
        Me.cmbTahunAjaran.Name = "cmbTahunAjaran"
        Me.cmbTahunAjaran.Size = New System.Drawing.Size(150, 24)
        Me.cmbTahunAjaran.TabIndex = 2
        '
        'txtIDKHS
        '
        Me.txtIDKHS.Location = New System.Drawing.Point(112, 51)
        Me.txtIDKHS.Name = "txtIDKHS"
        Me.txtIDKHS.Size = New System.Drawing.Size(150, 23)
        Me.txtIDKHS.TabIndex = 1
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(112, 195)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(150, 23)
        Me.txtNIM.TabIndex = 4
        '
        'txtKodeMK
        '
        Me.txtKodeMK.Location = New System.Drawing.Point(112, 147)
        Me.txtKodeMK.Name = "txtKodeMK"
        Me.txtKodeMK.Size = New System.Drawing.Size(150, 23)
        Me.txtKodeMK.TabIndex = 3
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Location = New System.Drawing.Point(6, 198)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(33, 16)
        Me.lblNIM.TabIndex = 3
        Me.lblNIM.Text = "NIM"
        '
        'lblKodeMK
        '
        Me.lblKodeMK.AutoSize = True
        Me.lblKodeMK.Location = New System.Drawing.Point(6, 150)
        Me.lblKodeMK.Name = "lblKodeMK"
        Me.lblKodeMK.Size = New System.Drawing.Size(106, 16)
        Me.lblKodeMK.TabIndex = 2
        Me.lblKodeMK.Text = "Kode Matakuliah"
        '
        'lblTA
        '
        Me.lblTA.AutoSize = True
        Me.lblTA.Location = New System.Drawing.Point(6, 105)
        Me.lblTA.Name = "lblTA"
        Me.lblTA.Size = New System.Drawing.Size(86, 16)
        Me.lblTA.TabIndex = 1
        Me.lblTA.Text = "Tahun Ajaran"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 54)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(51, 16)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID KHS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNilaiUAS)
        Me.GroupBox2.Controls.Add(Me.txtNilaiUTS)
        Me.GroupBox2.Controls.Add(Me.txtNilaiTugas)
        Me.GroupBox2.Controls.Add(Me.txtNilaiAbsen)
        Me.GroupBox2.Controls.Add(Me.lblNUAS)
        Me.GroupBox2.Controls.Add(Me.lblNUTS)
        Me.GroupBox2.Controls.Add(Me.lblNT)
        Me.GroupBox2.Controls.Add(Me.lblNA)
        Me.GroupBox2.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(369, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 239)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nilai"
        '
        'txtNilaiUAS
        '
        Me.txtNilaiUAS.Location = New System.Drawing.Point(84, 196)
        Me.txtNilaiUAS.Name = "txtNilaiUAS"
        Me.txtNilaiUAS.Size = New System.Drawing.Size(150, 23)
        Me.txtNilaiUAS.TabIndex = 8
        '
        'txtNilaiUTS
        '
        Me.txtNilaiUTS.Location = New System.Drawing.Point(84, 148)
        Me.txtNilaiUTS.Name = "txtNilaiUTS"
        Me.txtNilaiUTS.Size = New System.Drawing.Size(150, 23)
        Me.txtNilaiUTS.TabIndex = 7
        '
        'txtNilaiTugas
        '
        Me.txtNilaiTugas.Location = New System.Drawing.Point(84, 103)
        Me.txtNilaiTugas.Name = "txtNilaiTugas"
        Me.txtNilaiTugas.Size = New System.Drawing.Size(150, 23)
        Me.txtNilaiTugas.TabIndex = 6
        '
        'txtNilaiAbsen
        '
        Me.txtNilaiAbsen.Location = New System.Drawing.Point(84, 52)
        Me.txtNilaiAbsen.Name = "txtNilaiAbsen"
        Me.txtNilaiAbsen.Size = New System.Drawing.Size(150, 23)
        Me.txtNilaiAbsen.TabIndex = 5
        '
        'lblNUAS
        '
        Me.lblNUAS.AutoSize = True
        Me.lblNUAS.Location = New System.Drawing.Point(6, 199)
        Me.lblNUAS.Name = "lblNUAS"
        Me.lblNUAS.Size = New System.Drawing.Size(65, 16)
        Me.lblNUAS.TabIndex = 6
        Me.lblNUAS.Text = "Nilai UAS"
        '
        'lblNUTS
        '
        Me.lblNUTS.AutoSize = True
        Me.lblNUTS.Location = New System.Drawing.Point(6, 151)
        Me.lblNUTS.Name = "lblNUTS"
        Me.lblNUTS.Size = New System.Drawing.Size(63, 16)
        Me.lblNUTS.TabIndex = 5
        Me.lblNUTS.Text = "Nilai UTS"
        '
        'lblNT
        '
        Me.lblNT.AutoSize = True
        Me.lblNT.Location = New System.Drawing.Point(6, 106)
        Me.lblNT.Name = "lblNT"
        Me.lblNT.Size = New System.Drawing.Size(72, 16)
        Me.lblNT.TabIndex = 4
        Me.lblNT.Text = "Nilai Tugas"
        '
        'lblNA
        '
        Me.lblNA.AutoSize = True
        Me.lblNA.Location = New System.Drawing.Point(6, 55)
        Me.lblNA.Name = "lblNA"
        Me.lblNA.Size = New System.Drawing.Size(75, 16)
        Me.lblNA.TabIndex = 3
        Me.lblNA.Text = "NIlai Absen"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnKembali)
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.btnTambah)
        Me.GroupBox3.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(670, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(101, 239)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proses"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(9, 189)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(86, 34)
        Me.btnKembali.TabIndex = 12
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(9, 136)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(86, 34)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(9, 87)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 34)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(9, 36)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(86, 34)
        Me.btnTambah.TabIndex = 9
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'lblNIA
        '
        Me.lblNIA.AutoSize = True
        Me.lblNIA.Location = New System.Drawing.Point(32, 335)
        Me.lblNIA.Name = "lblNIA"
        Me.lblNIA.Size = New System.Drawing.Size(61, 13)
        Me.lblNIA.TabIndex = 4
        Me.lblNIA.Text = "Nilai Angka"
        '
        'lblNilaiAngka
        '
        Me.lblNilaiAngka.Location = New System.Drawing.Point(120, 335)
        Me.lblNilaiAngka.Name = "lblNilaiAngka"
        Me.lblNilaiAngka.Size = New System.Drawing.Size(108, 13)
        Me.lblNilaiAngka.TabIndex = 5
        Me.lblNilaiAngka.Text = "-"
        '
        'lblNHU
        '
        Me.lblNHU.AutoSize = True
        Me.lblNHU.Location = New System.Drawing.Point(32, 376)
        Me.lblNHU.Name = "lblNHU"
        Me.lblNHU.Size = New System.Drawing.Size(56, 13)
        Me.lblNHU.TabIndex = 6
        Me.lblNHU.Text = "Nilai Huruf"
        '
        'lblNIlaiHuruf
        '
        Me.lblNIlaiHuruf.Location = New System.Drawing.Point(120, 376)
        Me.lblNIlaiHuruf.Name = "lblNIlaiHuruf"
        Me.lblNIlaiHuruf.Size = New System.Drawing.Size(108, 13)
        Me.lblNIlaiHuruf.TabIndex = 7
        Me.lblNIlaiHuruf.Text = "-"
        '
        'lblKet
        '
        Me.lblKet.AutoSize = True
        Me.lblKet.Location = New System.Drawing.Point(32, 415)
        Me.lblKet.Name = "lblKet"
        Me.lblKet.Size = New System.Drawing.Size(62, 13)
        Me.lblKet.TabIndex = 8
        Me.lblKet.Text = "Keterangan"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.Location = New System.Drawing.Point(120, 415)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(108, 13)
        Me.lblKeterangan.TabIndex = 9
        Me.lblKeterangan.Text = "-"
        '
        'dgvKHS
        '
        Me.dgvKHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKHS.Location = New System.Drawing.Point(264, 328)
        Me.dgvKHS.Name = "dgvKHS"
        Me.dgvKHS.Size = New System.Drawing.Size(507, 186)
        Me.dgvKHS.TabIndex = 10
        '
        'FormKHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 541)
        Me.Controls.Add(Me.dgvKHS)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblKet)
        Me.Controls.Add(Me.lblNIlaiHuruf)
        Me.Controls.Add(Me.lblNHU)
        Me.Controls.Add(Me.lblNilaiAngka)
        Me.Controls.Add(Me.lblNIA)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKHS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form KHS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvKHS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbTahunAjaran As ComboBox
    Friend WithEvents txtIDKHS As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtKodeMK As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblKodeMK As Label
    Friend WithEvents lblTA As Label
    Friend WithEvents lblID As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNilaiUAS As TextBox
    Friend WithEvents txtNilaiUTS As TextBox
    Friend WithEvents txtNilaiTugas As TextBox
    Friend WithEvents txtNilaiAbsen As TextBox
    Friend WithEvents lblNUAS As Label
    Friend WithEvents lblNUTS As Label
    Friend WithEvents lblNT As Label
    Friend WithEvents lblNA As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblNIA As Label
    Friend WithEvents lblNilaiAngka As Label
    Friend WithEvents lblNHU As Label
    Friend WithEvents lblNIlaiHuruf As Label
    Friend WithEvents lblKet As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents dgvKHS As DataGridView
End Class
