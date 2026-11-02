<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuatPesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuatPesanan))
        Txt_NoHp = New TextBox()
        Combo_Tipe = New ComboBox()
        Combo_Layanan = New ComboBox()
        Btn_Hitung = New Button()
        Btn_Simpan = New Button()
        Btn_Kembali = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Txt_NmPelanggan = New TextBox()
        MenuStrip1 = New MenuStrip()
        MenuAkun = New ToolStripMenuItem()
        LogOut = New ToolStripMenuItem()
        PELANGGAN = New ToolStripMenuItem()
        TambahPelanggan = New ToolStripMenuItem()
        EditPelanggan = New ToolStripMenuItem()
        HapusPelanggan = New ToolStripMenuItem()
        DAFTARPESANAN = New ToolStripMenuItem()
        Nmr_Berat = New NumericUpDown()
        Lbl_Total = New Label()
        MenuStrip1.SuspendLayout()
        CType(Nmr_Berat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Txt_NoHp
        ' 
        Txt_NoHp.Font = New Font("Segoe UI", 10F)
        Txt_NoHp.Location = New Point(12, 120)
        Txt_NoHp.Name = "Txt_NoHp"
        Txt_NoHp.Size = New Size(228, 25)
        Txt_NoHp.TabIndex = 1
        ' 
        ' Combo_Tipe
        ' 
        Combo_Tipe.Font = New Font("Segoe UI", 10F)
        Combo_Tipe.FormattingEnabled = True
        Combo_Tipe.Items.AddRange(New Object() {"Cuci Lipat", "Cuci Setrika"})
        Combo_Tipe.Location = New Point(119, 211)
        Combo_Tipe.Name = "Combo_Tipe"
        Combo_Tipe.Size = New Size(150, 25)
        Combo_Tipe.TabIndex = 3
        ' 
        ' Combo_Layanan
        ' 
        Combo_Layanan.Font = New Font("Segoe UI", 10F)
        Combo_Layanan.FormattingEnabled = True
        Combo_Layanan.Items.AddRange(New Object() {"Reguler", "Express"})
        Combo_Layanan.Location = New Point(119, 242)
        Combo_Layanan.Name = "Combo_Layanan"
        Combo_Layanan.Size = New Size(150, 25)
        Combo_Layanan.TabIndex = 4
        ' 
        ' Btn_Hitung
        ' 
        Btn_Hitung.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Btn_Hitung.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Hitung.ForeColor = Color.White
        Btn_Hitung.Location = New Point(12, 281)
        Btn_Hitung.Name = "Btn_Hitung"
        Btn_Hitung.Size = New Size(79, 33)
        Btn_Hitung.TabIndex = 6
        Btn_Hitung.Text = "HITUNG"
        Btn_Hitung.UseVisualStyleBackColor = False
        ' 
        ' Btn_Simpan
        ' 
        Btn_Simpan.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Btn_Simpan.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Simpan.ForeColor = Color.White
        Btn_Simpan.Location = New Point(12, 357)
        Btn_Simpan.Name = "Btn_Simpan"
        Btn_Simpan.Size = New Size(325, 62)
        Btn_Simpan.TabIndex = 7
        Btn_Simpan.Text = "SIMPAN"
        Btn_Simpan.UseVisualStyleBackColor = False
        ' 
        ' Btn_Kembali
        ' 
        Btn_Kembali.Font = New Font("Segoe UI", 10F)
        Btn_Kembali.Location = New Point(626, 32)
        Btn_Kembali.Name = "Btn_Kembali"
        Btn_Kembali.Size = New Size(89, 30)
        Btn_Kembali.TabIndex = 8
        Btn_Kembali.Text = "←  Kembali"
        Btn_Kembali.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 20)
        Label1.TabIndex = 9
        Label1.Text = "Nama Pelanggan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 20)
        Label2.TabIndex = 10
        Label2.Text = "No HP Pelanggan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label3.Location = New Point(12, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 20)
        Label3.TabIndex = 11
        Label3.Text = "Berat Cucian"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label4.Location = New Point(184, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 20)
        Label4.TabIndex = 12
        Label4.Text = "Kg"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label5.Location = New Point(12, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 20)
        Label5.TabIndex = 13
        Label5.Text = "Tipe Cucian"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label6.Location = New Point(12, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 20)
        Label6.TabIndex = 14
        Label6.Text = "Layanan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label7.Location = New Point(12, 327)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 20)
        Label7.TabIndex = 15
        Label7.Text = "Total Harga:"
        ' 
        ' Txt_NmPelanggan
        ' 
        Txt_NmPelanggan.Font = New Font("Segoe UI", 10F)
        Txt_NmPelanggan.Location = New Point(12, 63)
        Txt_NmPelanggan.Name = "Txt_NmPelanggan"
        Txt_NmPelanggan.Size = New Size(325, 25)
        Txt_NmPelanggan.TabIndex = 16
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuAkun, PELANGGAN, DAFTARPESANAN})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(727, 29)
        MenuStrip1.TabIndex = 17
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
        ' Nmr_Berat
        ' 
        Nmr_Berat.Location = New Point(119, 180)
        Nmr_Berat.Name = "Nmr_Berat"
        Nmr_Berat.Size = New Size(59, 23)
        Nmr_Berat.TabIndex = 18
        ' 
        ' Lbl_Total
        ' 
        Lbl_Total.AutoSize = True
        Lbl_Total.Font = New Font("Segoe UI", 11F)
        Lbl_Total.Location = New Point(119, 327)
        Lbl_Total.Name = "Lbl_Total"
        Lbl_Total.Size = New Size(17, 20)
        Lbl_Total.TabIndex = 19
        Lbl_Total.Text = "0"
        Lbl_Total.Visible = False
        ' 
        ' FormBuatPesanan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(727, 431)
        Controls.Add(Lbl_Total)
        Controls.Add(Nmr_Berat)
        Controls.Add(MenuStrip1)
        Controls.Add(Txt_NmPelanggan)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Btn_Kembali)
        Controls.Add(Btn_Simpan)
        Controls.Add(Btn_Hitung)
        Controls.Add(Combo_Layanan)
        Controls.Add(Combo_Tipe)
        Controls.Add(Txt_NoHp)
        Name = "FormBuatPesanan"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(Nmr_Berat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Txt_NoHp As TextBox
    Friend WithEvents Combo_Tipe As ComboBox
    Friend WithEvents Combo_Layanan As ComboBox
    Friend WithEvents Btn_Hitung As Button
    Friend WithEvents Btn_Simpan As Button
    Friend WithEvents Btn_Kembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_NmPelanggan As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuAkun As ToolStripMenuItem
    Friend WithEvents LogOut As ToolStripMenuItem
    Friend WithEvents PELANGGAN As ToolStripMenuItem
    Friend WithEvents TambahPelanggan As ToolStripMenuItem
    Friend WithEvents EditPelanggan As ToolStripMenuItem
    Friend WithEvents HapusPelanggan As ToolStripMenuItem
    Friend WithEvents DAFTARPESANAN As ToolStripMenuItem
    Friend WithEvents Nmr_Berat As NumericUpDown
    Friend WithEvents Lbl_Total As Label

End Class
