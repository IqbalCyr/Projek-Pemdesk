<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahPelanggan))
        txtNama = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtNohp = New TextBox()
        btnTmbh = New Button()
        MenuStrip1 = New MenuStrip()
        MenuAkun = New ToolStripMenuItem()
        LogOut = New ToolStripMenuItem()
        PELANGGAN = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        EditPelanggan = New ToolStripMenuItem()
        HapusPelanggan = New ToolStripMenuItem()
        DAFTARPESANAN = New ToolStripMenuItem()
        Judul = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(338, 205)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(283, 27)
        txtNama.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label1.Location = New Point(220, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nama Lengkap:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(220, 246)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 3
        Label2.Text = "No HP:"
        ' 
        ' txtNohp
        ' 
        txtNohp.Location = New Point(338, 243)
        txtNohp.Name = "txtNohp"
        txtNohp.Size = New Size(201, 27)
        txtNohp.TabIndex = 2
        ' 
        ' btnTmbh
        ' 
        btnTmbh.Location = New Point(500, 286)
        btnTmbh.Name = "btnTmbh"
        btnTmbh.Size = New Size(121, 33)
        btnTmbh.TabIndex = 4
        btnTmbh.Text = "Tambah"
        btnTmbh.UseVisualStyleBackColor = True
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
        MenuStrip1.Size = New Size(874, 38)
        MenuStrip1.TabIndex = 5
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
        PELANGGAN.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem1, EditPelanggan, HapusPelanggan})
        PELANGGAN.ForeColor = Color.White
        PELANGGAN.Name = "PELANGGAN"
        PELANGGAN.Size = New Size(171, 32)
        PELANGGAN.Text = "PELANGGAN ▾"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), Image)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(276, 32)
        ToolStripMenuItem1.Text = "Tambah Pelanggan"
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
        DAFTARPESANAN.Size = New Size(204, 32)
        DAFTARPESANAN.Text = "Tambah Pelanggan"
        ' 
        ' Judul
        ' 
        Judul.Font = New Font("Georgia", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Judul.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Judul.Location = New Point(177, 122)
        Judul.Name = "Judul"
        Judul.Size = New Size(499, 61)
        Judul.TabIndex = 6
        Judul.Text = "PURPLE LAUNDRY"
        Judul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TambahPelanggan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(874, 460)
        Controls.Add(Judul)
        Controls.Add(MenuStrip1)
        Controls.Add(btnTmbh)
        Controls.Add(Label2)
        Controls.Add(txtNohp)
        Controls.Add(Label1)
        Controls.Add(txtNama)
        ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Name = "TambahPelanggan"
        Text = "TambahPelanggan"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNohp As TextBox
    Friend WithEvents btnTmbh As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuAkun As ToolStripMenuItem
    Friend WithEvents LogOut As ToolStripMenuItem
    Friend WithEvents PELANGGAN As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditPelanggan As ToolStripMenuItem
    Friend WithEvents HapusPelanggan As ToolStripMenuItem
    Friend WithEvents DAFTARPESANAN As ToolStripMenuItem
    Friend WithEvents Judul As Label
End Class
