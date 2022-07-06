<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AKADEMIKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatakuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KHSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERToolStripMenuItem, Me.AKADEMIKToolStripMenuItem, Me.LAPORANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1090, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.USERToolStripMenuItem.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.user_icon
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(49, 36)
        Me.USERToolStripMenuItem.Text = "USER"
        Me.USERToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.icon_login
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.icon_logout
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(108, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.icon_exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AKADEMIKToolStripMenuItem
        '
        Me.AKADEMIKToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosenToolStripMenuItem, Me.MahasiswaToolStripMenuItem, Me.MatakuliahToolStripMenuItem, Me.KHSToolStripMenuItem})
        Me.AKADEMIKToolStripMenuItem.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AKADEMIKToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.unu
        Me.AKADEMIKToolStripMenuItem.Name = "AKADEMIKToolStripMenuItem"
        Me.AKADEMIKToolStripMenuItem.Size = New System.Drawing.Size(84, 36)
        Me.AKADEMIKToolStripMenuItem.Text = "AKADEMIK"
        Me.AKADEMIKToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DosenToolStripMenuItem
        '
        Me.DosenToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.dosen
        Me.DosenToolStripMenuItem.Name = "DosenToolStripMenuItem"
        Me.DosenToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DosenToolStripMenuItem.Text = "Dosen"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.Mahasiswa
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        '
        'MatakuliahToolStripMenuItem
        '
        Me.MatakuliahToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.buku
        Me.MatakuliahToolStripMenuItem.Name = "MatakuliahToolStripMenuItem"
        Me.MatakuliahToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.MatakuliahToolStripMenuItem.Text = "Matakuliah"
        '
        'KHSToolStripMenuItem
        '
        Me.KHSToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.nilai
        Me.KHSToolStripMenuItem.Name = "KHSToolStripMenuItem"
        Me.KHSToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.KHSToolStripMenuItem.Text = "KHS"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDosenToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAPORANToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.laporan_dosen
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(77, 36)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        Me.LAPORANToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LaporanDosenToolStripMenuItem
        '
        Me.LaporanDosenToolStripMenuItem.Image = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.laporan_dosen1
        Me.LaporanDosenToolStripMenuItem.Name = "LaporanDosenToolStripMenuItem"
        Me.LaporanDosenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.LaporanDosenToolStripMenuItem.Text = "Laporan Dosen"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_SI_Pengolahan_Nilai_Berbasis_Desktop.My.Resources.Resources.maxresdefault
        Me.ClientSize = New System.Drawing.Size(1090, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "Form Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents USERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AKADEMIKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DosenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatakuliahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KHSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDosenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
