<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPesanan
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
        Panel1 = New Panel()
        Panel7 = New Panel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Label10 = New Label()
        Label4 = New Label()
        DT_TanggalSelesai = New DateTimePicker()
        DT_TanggalMasuk = New DateTimePicker()
        Label9 = New Label()
        Lbl_TotalHarga = New Label()
        Combo_Tipe = New ComboBox()
        Label5 = New Label()
        Label7 = New Label()
        Combo_Layanan = New ComboBox()
        Label6 = New Label()
        Label3 = New Label()
        Btn_Hitung = New Button()
        Nmr_Berat = New NumericUpDown()
        Panel5 = New Panel()
        Panel3 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label11 = New Label()
        Label8 = New Label()
        Txt_NmPelanggan = New TextBox()
        Label1 = New Label()
        Txt_HpPealnggan = New TextBox()
        Label2 = New Label()
        Panel6 = New Panel()
        Panel8 = New Panel()
        Btn_Bersih = New Button()
        Btn_Simpan = New Button()
        Panel9 = New Panel()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(Nmr_Berat, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Panel1.Location = New Point(99, 16)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1247, 940)
        Panel1.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(23, 0)
        Panel7.Margin = New Padding(3, 4, 3, 4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1262, 28)
        Panel7.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Panel9)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1285, 972)
        Panel2.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(DT_TanggalSelesai)
        Panel4.Controls.Add(DT_TanggalMasuk)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Lbl_TotalHarga)
        Panel4.Controls.Add(Combo_Tipe)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Combo_Layanan)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Btn_Hitung)
        Panel4.Controls.Add(Nmr_Berat)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(546, 28)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(728, 673)
        Panel4.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label10.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label10.Location = New Point(370, 301)
        Label10.Name = "Label10"
        Label10.Size = New Size(169, 31)
        Label10.TabIndex = 20
        Label10.Text = "Tanggal Selesai"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label4.Location = New Point(40, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 31)
        Label4.TabIndex = 19
        Label4.Text = "Tanggal Masuk"
        ' 
        ' DT_TanggalSelesai
        ' 
        DT_TanggalSelesai.Enabled = False
        DT_TanggalSelesai.Font = New Font("Calibri", 11.25F)
        DT_TanggalSelesai.Location = New Point(370, 337)
        DT_TanggalSelesai.Margin = New Padding(3, 4, 3, 4)
        DT_TanggalSelesai.Name = "DT_TanggalSelesai"
        DT_TanggalSelesai.Size = New Size(251, 30)
        DT_TanggalSelesai.TabIndex = 18
        ' 
        ' DT_TanggalMasuk
        ' 
        DT_TanggalMasuk.Enabled = False
        DT_TanggalMasuk.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DT_TanggalMasuk.Location = New Point(40, 337)
        DT_TanggalMasuk.Margin = New Padding(3, 4, 3, 4)
        DT_TanggalMasuk.Name = "DT_TanggalMasuk"
        DT_TanggalMasuk.Size = New Size(251, 30)
        DT_TanggalMasuk.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(190), CByte(46), CByte(221))
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Dock = DockStyle.Top
        Label9.Font = New Font("Calibri", 18F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(930, 39)
        Label9.TabIndex = 16
        Label9.Text = "Data Layanan                                                                                                          "
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Lbl_TotalHarga
        ' 
        Lbl_TotalHarga.AutoSize = True
        Lbl_TotalHarga.Font = New Font("Calibri", 40F, FontStyle.Bold)
        Lbl_TotalHarga.Location = New Point(43, 552)
        Lbl_TotalHarga.Name = "Lbl_TotalHarga"
        Lbl_TotalHarga.Size = New Size(216, 82)
        Lbl_TotalHarga.TabIndex = 13
        Lbl_TotalHarga.Text = "Label8"
        Lbl_TotalHarga.Visible = False
        ' 
        ' Combo_Tipe
        ' 
        Combo_Tipe.Font = New Font("Calibri", 13F, FontStyle.Bold)
        Combo_Tipe.FormattingEnabled = True
        Combo_Tipe.Location = New Point(40, 101)
        Combo_Tipe.Margin = New Padding(3, 4, 3, 4)
        Combo_Tipe.Name = "Combo_Tipe"
        Combo_Tipe.Size = New Size(172, 35)
        Combo_Tipe.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label5.Location = New Point(40, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 31)
        Label5.TabIndex = 7
        Label5.Text = "Tipe Cucian"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label7.Location = New Point(35, 505)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 31)
        Label7.TabIndex = 12
        Label7.Text = "Total Harga:"
        ' 
        ' Combo_Layanan
        ' 
        Combo_Layanan.Font = New Font("Calibri", 13F, FontStyle.Bold)
        Combo_Layanan.FormattingEnabled = True
        Combo_Layanan.Items.AddRange(New Object() {"Express", "Reguler"})
        Combo_Layanan.Location = New Point(370, 101)
        Combo_Layanan.Margin = New Padding(3, 4, 3, 4)
        Combo_Layanan.Name = "Combo_Layanan"
        Combo_Layanan.Size = New Size(138, 35)
        Combo_Layanan.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label6.Location = New Point(370, 72)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 31)
        Label6.TabIndex = 9
        Label6.Text = "Layanan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label3.Location = New Point(40, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 31)
        Label3.TabIndex = 4
        Label3.Text = "Berat Cucian (Kg)"
        ' 
        ' Btn_Hitung
        ' 
        Btn_Hitung.Location = New Point(35, 415)
        Btn_Hitung.Margin = New Padding(3, 4, 3, 4)
        Btn_Hitung.Name = "Btn_Hitung"
        Btn_Hitung.Size = New Size(206, 52)
        Btn_Hitung.TabIndex = 11
        Btn_Hitung.Text = "HITUNG"
        Btn_Hitung.UseVisualStyleBackColor = True
        ' 
        ' Nmr_Berat
        ' 
        Nmr_Berat.Font = New Font("Calibri", 13F)
        Nmr_Berat.Location = New Point(40, 224)
        Nmr_Berat.Margin = New Padding(3, 4, 3, 4)
        Nmr_Berat.Name = "Nmr_Berat"
        Nmr_Berat.Size = New Size(173, 34)
        Nmr_Berat.TabIndex = 5
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(463, 28)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(83, 673)
        Panel5.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(LinkLabel1)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Txt_NmPelanggan)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Txt_HpPealnggan)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(23, 28)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(440, 673)
        Panel3.TabIndex = 16
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Calibri", 9.75F)
        LinkLabel1.Location = New Point(257, 200)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(140, 21)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Tambah pelanggan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(15, 200)
        Label11.Name = "Label11"
        Label11.Size = New Size(265, 21)
        Label11.TabIndex = 5
        Label11.Text = "*Jika nama pelanggan tidak ada, klik:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(190), CByte(46), CByte(221))
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Dock = DockStyle.Top
        Label8.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(520, 39)
        Label8.TabIndex = 4
        Label8.Text = "Data Pelanggan                                            "
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Txt_NmPelanggan
        ' 
        Txt_NmPelanggan.Font = New Font("Calibri", 13F, FontStyle.Bold)
        Txt_NmPelanggan.Location = New Point(14, 108)
        Txt_NmPelanggan.Margin = New Padding(3, 4, 3, 4)
        Txt_NmPelanggan.Name = "Txt_NmPelanggan"
        Txt_NmPelanggan.Size = New Size(402, 34)
        Txt_NmPelanggan.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label1.Location = New Point(14, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 31)
        Label1.TabIndex = 0
        Label1.Text = "Nama Pelanggan"
        ' 
        ' Txt_HpPealnggan
        ' 
        Txt_HpPealnggan.Font = New Font("Calibri", 13F, FontStyle.Bold)
        Txt_HpPealnggan.Location = New Point(15, 295)
        Txt_HpPealnggan.Margin = New Padding(3, 4, 3, 4)
        Txt_HpPealnggan.Name = "Txt_HpPealnggan"
        Txt_HpPealnggan.Size = New Size(236, 34)
        Txt_HpPealnggan.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label2.Location = New Point(15, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 31)
        Label2.TabIndex = 2
        Label2.Text = "No HP Pelanggan"
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Right
        Panel6.Location = New Point(1274, 28)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(11, 673)
        Panel6.TabIndex = 19
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Btn_Bersih)
        Panel8.Controls.Add(Btn_Simpan)
        Panel8.Dock = DockStyle.Bottom
        Panel8.Location = New Point(23, 701)
        Panel8.Margin = New Padding(3, 4, 3, 4)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1262, 271)
        Panel8.TabIndex = 20
        ' 
        ' Btn_Bersih
        ' 
        Btn_Bersih.FlatStyle = FlatStyle.Flat
        Btn_Bersih.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Btn_Bersih.Location = New Point(568, 8)
        Btn_Bersih.Margin = New Padding(3, 4, 3, 4)
        Btn_Bersih.Name = "Btn_Bersih"
        Btn_Bersih.Size = New Size(171, 52)
        Btn_Bersih.TabIndex = 14
        Btn_Bersih.Text = "BERSIH"
        Btn_Bersih.UseVisualStyleBackColor = True
        ' 
        ' Btn_Simpan
        ' 
        Btn_Simpan.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Btn_Simpan.FlatAppearance.BorderSize = 0
        Btn_Simpan.FlatStyle = FlatStyle.Flat
        Btn_Simpan.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Btn_Simpan.ForeColor = Color.White
        Btn_Simpan.Location = New Point(1064, 8)
        Btn_Simpan.Margin = New Padding(3, 4, 3, 4)
        Btn_Simpan.Name = "Btn_Simpan"
        Btn_Simpan.Size = New Size(171, 52)
        Btn_Simpan.TabIndex = 15
        Btn_Simpan.Text = "SIMPAN"
        Btn_Simpan.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.Dock = DockStyle.Left
        Panel9.Location = New Point(0, 0)
        Panel9.Margin = New Padding(3, 4, 3, 4)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(23, 972)
        Panel9.TabIndex = 21
        ' 
        ' FormPesanan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1536, 972)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormPesanan"
        Text = "FormPesanan"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(Nmr_Berat, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel8.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_NmPelanggan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_HpPealnggan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Nmr_Berat As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Combo_Tipe As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Combo_Layanan As ComboBox
    Friend WithEvents Btn_Hitung As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Lbl_TotalHarga As Label
    Friend WithEvents Btn_Bersih As Button
    Friend WithEvents Btn_Simpan As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DT_TanggalMasuk As DateTimePicker
    Friend WithEvents DT_TanggalSelesai As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
