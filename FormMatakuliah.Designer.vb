<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatakuliah
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
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.txtSKS = New System.Windows.Forms.TextBox()
        Me.txtNamaMatkul = New System.Windows.Forms.TextBox()
        Me.txtKodeMatkul = New System.Windows.Forms.TextBox()
        Me.lblSKS = New System.Windows.Forms.Label()
        Me.lblsemester = New System.Windows.Forms.Label()
        Me.lblNamaMatkul = New System.Windows.Forms.Label()
        Me.lblKodeMatkul = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvMatakuliah = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMatakuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA MATAKULIAH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSemester)
        Me.GroupBox1.Controls.Add(Me.txtSKS)
        Me.GroupBox1.Controls.Add(Me.txtNamaMatkul)
        Me.GroupBox1.Controls.Add(Me.txtKodeMatkul)
        Me.GroupBox1.Controls.Add(Me.lblSKS)
        Me.GroupBox1.Controls.Add(Me.lblsemester)
        Me.GroupBox1.Controls.Add(Me.lblNamaMatkul)
        Me.GroupBox1.Controls.Add(Me.lblKodeMatkul)
        Me.GroupBox1.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(65, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 219)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Matakuliah"
        '
        'cmbSemester
        '
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"2", "4", "6", "8"})
        Me.cmbSemester.Location = New System.Drawing.Point(115, 131)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(142, 24)
        Me.cmbSemester.TabIndex = 3
        '
        'txtSKS
        '
        Me.txtSKS.Location = New System.Drawing.Point(115, 171)
        Me.txtSKS.Name = "txtSKS"
        Me.txtSKS.Size = New System.Drawing.Size(142, 23)
        Me.txtSKS.TabIndex = 4
        '
        'txtNamaMatkul
        '
        Me.txtNamaMatkul.Location = New System.Drawing.Point(115, 85)
        Me.txtNamaMatkul.Name = "txtNamaMatkul"
        Me.txtNamaMatkul.Size = New System.Drawing.Size(142, 23)
        Me.txtNamaMatkul.TabIndex = 2
        '
        'txtKodeMatkul
        '
        Me.txtKodeMatkul.Location = New System.Drawing.Point(115, 42)
        Me.txtKodeMatkul.Name = "txtKodeMatkul"
        Me.txtKodeMatkul.Size = New System.Drawing.Size(142, 23)
        Me.txtKodeMatkul.TabIndex = 1
        '
        'lblSKS
        '
        Me.lblSKS.AutoSize = True
        Me.lblSKS.Location = New System.Drawing.Point(6, 174)
        Me.lblSKS.Name = "lblSKS"
        Me.lblSKS.Size = New System.Drawing.Size(31, 16)
        Me.lblSKS.TabIndex = 3
        Me.lblSKS.Text = "SKS"
        '
        'lblsemester
        '
        Me.lblsemester.AutoSize = True
        Me.lblsemester.Location = New System.Drawing.Point(6, 134)
        Me.lblsemester.Name = "lblsemester"
        Me.lblsemester.Size = New System.Drawing.Size(62, 16)
        Me.lblsemester.TabIndex = 2
        Me.lblsemester.Text = "Semester"
        '
        'lblNamaMatkul
        '
        Me.lblNamaMatkul.AutoSize = True
        Me.lblNamaMatkul.Location = New System.Drawing.Point(6, 88)
        Me.lblNamaMatkul.Name = "lblNamaMatkul"
        Me.lblNamaMatkul.Size = New System.Drawing.Size(107, 16)
        Me.lblNamaMatkul.TabIndex = 1
        Me.lblNamaMatkul.Text = "Nama Matakuliah"
        '
        'lblKodeMatkul
        '
        Me.lblKodeMatkul.AutoSize = True
        Me.lblKodeMatkul.Location = New System.Drawing.Point(6, 45)
        Me.lblKodeMatkul.Name = "lblKodeMatkul"
        Me.lblKodeMatkul.Size = New System.Drawing.Size(106, 16)
        Me.lblKodeMatkul.TabIndex = 0
        Me.lblKodeMatkul.Text = "Kode Matakuliah"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKembali)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(394, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 218)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(8, 171)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(86, 34)
        Me.btnKembali.TabIndex = 8
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(8, 121)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(86, 34)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(8, 74)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 34)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(8, 27)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(86, 34)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvMatakuliah
        '
        Me.dgvMatakuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatakuliah.Location = New System.Drawing.Point(33, 310)
        Me.dgvMatakuliah.Name = "dgvMatakuliah"
        Me.dgvMatakuliah.Size = New System.Drawing.Size(487, 150)
        Me.dgvMatakuliah.TabIndex = 3
        '
        'FormMatakuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 511)
        Me.Controls.Add(Me.dgvMatakuliah)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMatakuliah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Matakuliah"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvMatakuliah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents txtNamaMatkul As TextBox
    Friend WithEvents txtKodeMatkul As TextBox
    Friend WithEvents lblSKS As Label
    Friend WithEvents lblsemester As Label
    Friend WithEvents lblNamaMatkul As Label
    Friend WithEvents lblKodeMatkul As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMatakuliah As DataGridView
End Class
