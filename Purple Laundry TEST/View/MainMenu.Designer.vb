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
        ListView1 = New ListView()
        Label1 = New Label()
        Label2 = New Label()
        StatusStrip1 = New StatusStrip()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuAkun, PELANGGAN, DAFTARPESANAN})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(800, 38)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuAkun
        ' 
        MenuAkun.DropDownItems.AddRange(New ToolStripItem() {LogOut})
        MenuAkun.ForeColor = Color.White
        MenuAkun.Image = CType(resources.GetObject("MenuAkun.Image"), Image)
        MenuAkun.Name = "MenuAkun"
        MenuAkun.Size = New Size(103, 32)
        MenuAkun.Text = "AKUN"
        MenuAkun.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LogOut
        ' 
        LogOut.BackColor = Color.White
        LogOut.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        LogOut.Image = CType(resources.GetObject("LogOut.Image"), Image)
        LogOut.Name = "LogOut"
        LogOut.Size = New Size(167, 32)
        LogOut.Text = "LogOut"
        ' 
        ' PELANGGAN
        ' 
        PELANGGAN.DropDownItems.AddRange(New ToolStripItem() {TambahPelanggan, EditPelanggan, HapusPelanggan})
        PELANGGAN.ForeColor = Color.White
        PELANGGAN.Name = "PELANGGAN"
        PELANGGAN.Size = New Size(171, 32)
        PELANGGAN.Text = "PELANGGAN ▾"
        ' 
        ' TambahPelanggan
        ' 
        TambahPelanggan.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        TambahPelanggan.Image = CType(resources.GetObject("TambahPelanggan.Image"), Image)
        TambahPelanggan.Name = "TambahPelanggan"
        TambahPelanggan.Size = New Size(276, 32)
        TambahPelanggan.Text = "Tambah Pelanggan"
        ' 
        ' EditPelanggan
        ' 
        EditPelanggan.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        EditPelanggan.Image = CType(resources.GetObject("EditPelanggan.Image"), Image)
        EditPelanggan.Name = "EditPelanggan"
        EditPelanggan.Size = New Size(276, 32)
        EditPelanggan.Text = "Edit Pelanggan"
        ' 
        ' HapusPelanggan
        ' 
        HapusPelanggan.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        HapusPelanggan.Image = CType(resources.GetObject("HapusPelanggan.Image"), Image)
        HapusPelanggan.Name = "HapusPelanggan"
        HapusPelanggan.Size = New Size(276, 32)
        HapusPelanggan.Text = "Hapus Pelanggan"
        ' 
        ' DAFTARPESANAN
        ' 
        DAFTARPESANAN.ForeColor = Color.White
        DAFTARPESANAN.Name = "DAFTARPESANAN"
        DAFTARPESANAN.Size = New Size(203, 32)
        DAFTARPESANAN.Text = "DAFTAR PESANAN"
        ' 
        ' Judul
        ' 
        Judul.Font = New Font("Georgia", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Judul.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Judul.Location = New Point(0, 250)
        Judul.Name = "Judul"
        Judul.Size = New Size(800, 61)
        Judul.TabIndex = 1
        Judul.Text = "PURPLE LAUNDRY"
        Judul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(280, 322)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 53)
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
        Pesanan.Location = New Point(333, 328)
        Pesanan.Name = "Pesanan"
        Pesanan.Size = New Size(151, 46)
        Pesanan.TabIndex = 3
        Pesanan.Text = "Pesanan"
        Pesanan.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 100)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(776, 215)
        ListView1.TabIndex = 4
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 5
        Label1.Text = "Id Pesanan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(259, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 5
        Label2.Text = "Nama"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Location = New Point(0, 429)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 6
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(582, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 5
        Label3.Text = "Status"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(314, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(97, 56)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(637, 58)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(460, 58)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 9
        Button1.Text = "Cari"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 451)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(StatusStrip1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        Controls.Add(Pesanan)
        Controls.Add(PictureBox1)
        Controls.Add(Judul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
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
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
