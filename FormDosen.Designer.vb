<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDosen
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
        Me.cmbJK = New System.Windows.Forms.ComboBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNamaDosen = New System.Windows.Forms.TextBox()
        Me.txtNIDN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblJK = New System.Windows.Forms.Label()
        Me.lblNamaDosen = New System.Windows.Forms.Label()
        Me.lblNIDN = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvDosen = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDosen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA DOSEN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbJK)
        Me.GroupBox1.Controls.Add(Me.txtHP)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtNamaDosen)
        Me.GroupBox1.Controls.Add(Me.txtNIDN)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblHP)
        Me.GroupBox1.Controls.Add(Me.lblAlamat)
        Me.GroupBox1.Controls.Add(Me.lblJK)
        Me.GroupBox1.Controls.Add(Me.lblNamaDosen)
        Me.GroupBox1.Controls.Add(Me.lblNIDN)
        Me.GroupBox1.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 287)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Dosen"
        '
        'cmbJK
        '
        Me.cmbJK.FormattingEnabled = True
        Me.cmbJK.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbJK.Location = New System.Drawing.Point(121, 127)
        Me.cmbJK.Name = "cmbJK"
        Me.cmbJK.Size = New System.Drawing.Size(135, 24)
        Me.cmbJK.TabIndex = 3
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(121, 216)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(135, 23)
        Me.txtHP.TabIndex = 5
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(121, 169)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(135, 23)
        Me.txtAlamat.TabIndex = 4
        '
        'txtNamaDosen
        '
        Me.txtNamaDosen.Location = New System.Drawing.Point(121, 87)
        Me.txtNamaDosen.Name = "txtNamaDosen"
        Me.txtNamaDosen.Size = New System.Drawing.Size(135, 23)
        Me.txtNamaDosen.TabIndex = 2
        '
        'txtNIDN
        '
        Me.txtNIDN.Location = New System.Drawing.Point(121, 42)
        Me.txtNIDN.Name = "txtNIDN"
        Me.txtNIDN.Size = New System.Drawing.Size(135, 23)
        Me.txtNIDN.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(6, 219)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(55, 16)
        Me.lblHP.TabIndex = 4
        Me.lblHP.Text = "Telepon"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(6, 172)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(49, 16)
        Me.lblAlamat.TabIndex = 3
        Me.lblAlamat.Text = "Alamat"
        '
        'lblJK
        '
        Me.lblJK.AutoSize = True
        Me.lblJK.Location = New System.Drawing.Point(6, 130)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(87, 16)
        Me.lblJK.TabIndex = 2
        Me.lblJK.Text = "Jenis Kelamin"
        '
        'lblNamaDosen
        '
        Me.lblNamaDosen.AutoSize = True
        Me.lblNamaDosen.Location = New System.Drawing.Point(6, 90)
        Me.lblNamaDosen.Name = "lblNamaDosen"
        Me.lblNamaDosen.Size = New System.Drawing.Size(79, 16)
        Me.lblNamaDosen.TabIndex = 1
        Me.lblNamaDosen.Text = "Nama Dosen"
        '
        'lblNIDN
        '
        Me.lblNIDN.AutoSize = True
        Me.lblNIDN.Location = New System.Drawing.Point(6, 45)
        Me.lblNIDN.Name = "lblNIDN"
        Me.lblNIDN.Size = New System.Drawing.Size(40, 16)
        Me.lblNIDN.TabIndex = 0
        Me.lblNIDN.Text = "NIDN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKembali)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(370, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 244)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(6, 193)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(86, 34)
        Me.btnKembali.TabIndex = 6
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(6, 142)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(86, 34)
        Me.btnHapus.TabIndex = 5
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(6, 91)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 34)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(6, 36)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(86, 34)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvDosen
        '
        Me.dgvDosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDosen.Location = New System.Drawing.Point(22, 404)
        Me.dgvDosen.Name = "dgvDosen"
        Me.dgvDosen.Size = New System.Drawing.Size(553, 120)
        Me.dgvDosen.TabIndex = 3
        '
        'FormDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(600, 550)
        Me.Controls.Add(Me.dgvDosen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Dosen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDosen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbJK As ComboBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNamaDosen As TextBox
    Friend WithEvents txtNIDN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblNamaDosen As Label
    Friend WithEvents lblNIDN As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvDosen As DataGridView
End Class
