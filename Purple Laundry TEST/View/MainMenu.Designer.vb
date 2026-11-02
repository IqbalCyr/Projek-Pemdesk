<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        MenuStrip1 = New MenuStrip()
        MenuAkun = New ToolStripMenuItem()
        LogOut = New ToolStripMenuItem()
        PELANGGAN = New ToolStripMenuItem()
        TambahPelanggan = New ToolStripMenuItem()
        EditPelanggan = New ToolStripMenuItem()
        HapusPelanggan = New ToolStripMenuItem()
        DAFTARPESANAN = New ToolStripMenuItem()
        Judul = New Label()
        PictureBox1 = New PictureBox()
        Pesanan = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuAkun, PELANGGAN, DAFTARPESANAN})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(700, 29)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuAkun
        ' 
        MenuAkun.DropDownItems.AddRange(New ToolStripItem() {LogOut})
        MenuAkun.ForeColor = Color.White
        MenuAkun.Image = CType(resources.GetObject("MenuAkun.Image"), Image)
        MenuAkun.Name = "MenuAkun"
        MenuAkun.Size = New Size(84, 25)
        MenuAkun.Text = "AKUN"
        MenuAkun.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LogOut
        ' 
        LogOut.BackColor = Color.White
        LogOut.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        LogOut.Image = CType(resources.GetObject("LogOut.Image"), Image)
        LogOut.Name = "LogOut"
        LogOut.Size = New Size(136, 26)
        LogOut.Text = "LogOut"
        ' 
        ' PELANGGAN
        ' 
        PELANGGAN.DropDownItems.AddRange(New ToolStripItem() {TambahPelanggan, EditPelanggan, HapusPelanggan})
        PELANGGAN.ForeColor = Color.White
        PELANGGAN.Name = "PELANGGAN"
        PELANGGAN.Size = New Size(138, 25)
        PELANGGAN.Text = "PELANGGAN ▾"
        ' 
        ' TambahPelanggan
        ' 
        TambahPelanggan.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        TambahPelanggan.Image = CType(resources.GetObject("TambahPelanggan.Image"), Image)
        TambahPelanggan.Name = "TambahPelanggan"
        TambahPelanggan.Size = New Size(227, 26)
        TambahPelanggan.Text = "Tambah Pelanggan"
        ' 
        ' EditPelanggan
        ' 
        EditPelanggan.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        EditPelanggan.Image = CType(resources.GetObject("EditPelanggan.Image"), Image)
        EditPelanggan.Name = "EditPelanggan"
        EditPelanggan.Size = New Size(227, 26)
        EditPelanggan.Text = "Edit Pelanggan"
        ' 
        ' HapusPelanggan
        ' 
        HapusPelanggan.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        HapusPelanggan.Image = CType(resources.GetObject("HapusPelanggan.Image"), Image)
        HapusPelanggan.Name = "HapusPelanggan"
        HapusPelanggan.Size = New Size(227, 26)
        HapusPelanggan.Text = "Hapus Pelanggan"
        ' 
        ' DAFTARPESANAN
        ' 
        DAFTARPESANAN.ForeColor = Color.White
        DAFTARPESANAN.Name = "DAFTARPESANAN"
        DAFTARPESANAN.Size = New Size(162, 25)
        DAFTARPESANAN.Text = "DAFTAR PESANAN"
        ' 
        ' Judul
        ' 
        Judul.Font = New Font("Georgia", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Judul.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Judul.Location = New Point(0, 168)
        Judul.Name = "Judul"
        Judul.Size = New Size(700, 46)
        Judul.TabIndex = 1
        Judul.Text = "PURPLE LAUNDRY"
        Judul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(248, 211)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Pesanan
        ' 
        Pesanan.AutoSize = True
        Pesanan.Cursor = Cursors.Hand
        Pesanan.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Pesanan.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Pesanan.Location = New Point(294, 211)
        Pesanan.Name = "Pesanan"
        Pesanan.Size = New Size(122, 37)
        Pesanan.TabIndex = 3
        Pesanan.Text = "Pesanan"
        Pesanan.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(700, 338)
        Controls.Add(Pesanan)
        Controls.Add(PictureBox1)
        Controls.Add(Judul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "MainMenu"
        Text = "menu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuAkun As ToolStripMenuItem
    Friend WithEvents LogOut As ToolStripMenuItem
    Friend WithEvents PELANGGAN As ToolStripMenuItem
    Friend WithEvents TambahPelanggan As ToolStripMenuItem
    Friend WithEvents EditPelanggan As ToolStripMenuItem
    Friend WithEvents HapusPelanggan As ToolStripMenuItem
    Friend WithEvents DAFTARPESANAN As ToolStripMenuItem
    Friend WithEvents Judul As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pesanan As Label
End Class
