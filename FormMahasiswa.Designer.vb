<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMahasiswa
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
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.cbJenis_Kelamin = New System.Windows.Forms.ComboBox()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblJK = New System.Windows.Forms.Label()
        Me.cmbProdi = New System.Windows.Forms.ComboBox()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtNamaMHS = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblProdi = New System.Windows.Forms.Label()
        Me.lblFK = New System.Windows.Forms.Label()
        Me.lblNamaMHS = New System.Windows.Forms.Label()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvMahasiswa = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA MAHASISWA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHP)
        Me.GroupBox1.Controls.Add(Me.cbJenis_Kelamin)
        Me.GroupBox1.Controls.Add(Me.lblHP)
        Me.GroupBox1.Controls.Add(Me.lblJK)
        Me.GroupBox1.Controls.Add(Me.cmbProdi)
        Me.GroupBox1.Controls.Add(Me.cmbFakultas)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtNIM)
        Me.GroupBox1.Controls.Add(Me.txtNamaMHS)
        Me.GroupBox1.Controls.Add(Me.lblAlamat)
        Me.GroupBox1.Controls.Add(Me.lblProdi)
        Me.GroupBox1.Controls.Add(Me.lblFK)
        Me.GroupBox1.Controls.Add(Me.lblNamaMHS)
        Me.GroupBox1.Controls.Add(Me.lblNIM)
        Me.GroupBox1.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 210)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mahasiswa"
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(399, 113)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(200, 23)
        Me.txtHP.TabIndex = 9
        '
        'cbJenis_Kelamin
        '
        Me.cbJenis_Kelamin.FormattingEnabled = True
        Me.cbJenis_Kelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbJenis_Kelamin.Location = New System.Drawing.Point(399, 79)
        Me.cbJenis_Kelamin.Name = "cbJenis_Kelamin"
        Me.cbJenis_Kelamin.Size = New System.Drawing.Size(200, 24)
        Me.cbJenis_Kelamin.TabIndex = 8
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(289, 116)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(55, 16)
        Me.lblHP.TabIndex = 13
        Me.lblHP.Text = "Telepon"
        '
        'lblJK
        '
        Me.lblJK.AutoSize = True
        Me.lblJK.Location = New System.Drawing.Point(289, 79)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(87, 16)
        Me.lblJK.TabIndex = 12
        Me.lblJK.Text = "Jenis Kelamin"
        '
        'cmbProdi
        '
        Me.cmbProdi.FormattingEnabled = True
        Me.cmbProdi.Items.AddRange(New Object() {"Sistem Informasi", "Teknik Lingkungan", "PGSD", "PJKR"})
        Me.cmbProdi.Location = New System.Drawing.Point(116, 150)
        Me.cmbProdi.Name = "cmbProdi"
        Me.cmbProdi.Size = New System.Drawing.Size(144, 24)
        Me.cmbProdi.TabIndex = 4
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Items.AddRange(New Object() {"Teknik", "Pendidikan"})
        Me.cmbFakultas.Location = New System.Drawing.Point(116, 113)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(144, 24)
        Me.cmbFakultas.TabIndex = 3
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(399, 33)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 23)
        Me.txtAlamat.TabIndex = 5
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(116, 37)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(144, 23)
        Me.txtNIM.TabIndex = 1
        '
        'txtNamaMHS
        '
        Me.txtNamaMHS.Location = New System.Drawing.Point(116, 76)
        Me.txtNamaMHS.Name = "txtNamaMHS"
        Me.txtNamaMHS.Size = New System.Drawing.Size(144, 23)
        Me.txtNamaMHS.TabIndex = 2
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(289, 40)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(49, 16)
        Me.lblAlamat.TabIndex = 4
        Me.lblAlamat.Text = "Alamat"
        '
        'lblProdi
        '
        Me.lblProdi.AutoSize = True
        Me.lblProdi.Location = New System.Drawing.Point(6, 154)
        Me.lblProdi.Name = "lblProdi"
        Me.lblProdi.Size = New System.Drawing.Size(40, 16)
        Me.lblProdi.TabIndex = 3
        Me.lblProdi.Text = "Prodi"
        '
        'lblFK
        '
        Me.lblFK.AutoSize = True
        Me.lblFK.Location = New System.Drawing.Point(6, 116)
        Me.lblFK.Name = "lblFK"
        Me.lblFK.Size = New System.Drawing.Size(55, 16)
        Me.lblFK.TabIndex = 2
        Me.lblFK.Text = "Fakultas"
        '
        'lblNamaMHS
        '
        Me.lblNamaMHS.AutoSize = True
        Me.lblNamaMHS.Location = New System.Drawing.Point(6, 79)
        Me.lblNamaMHS.Name = "lblNamaMHS"
        Me.lblNamaMHS.Size = New System.Drawing.Size(104, 16)
        Me.lblNamaMHS.TabIndex = 1
        Me.lblNamaMHS.Text = "Nama Mahasiswa"
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Location = New System.Drawing.Point(6, 40)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(33, 16)
        Me.lblNIM.TabIndex = 0
        Me.lblNIM.Text = "NIM"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKembali)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(682, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 234)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(6, 194)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(86, 34)
        Me.btnKembali.TabIndex = 13
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(6, 150)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(86, 34)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(6, 98)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 34)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(6, 40)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(86, 34)
        Me.btnTambah.TabIndex = 10
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvMahasiswa
        '
        Me.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMahasiswa.Location = New System.Drawing.Point(12, 338)
        Me.dgvMahasiswa.Name = "dgvMahasiswa"
        Me.dgvMahasiswa.Size = New System.Drawing.Size(772, 150)
        Me.dgvMahasiswa.TabIndex = 3
        '
        'FormMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(808, 533)
        Me.Controls.Add(Me.dgvMahasiswa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Mahasiswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents cbJenis_Kelamin As ComboBox
    Friend WithEvents lblHP As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents cmbProdi As ComboBox
    Friend WithEvents cmbFakultas As ComboBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtNamaMHS As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents lblFK As Label
    Friend WithEvents lblNamaMHS As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMahasiswa As DataGridView
End Class
