<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarPesanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDaftarPesanan))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Btn_Cari = New Button()
        Label3 = New Label()
        Txt_CariNama = New TextBox()
        Btn_Ubah = New Button()
        Combo_Status = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Txt_IdTransaksi = New TextBox()
        ListView1 = New ListView()
        Kolom_Id = New ColumnHeader()
        Kolom_Pelanggan = New ColumnHeader()
        Kolom_Kasir = New ColumnHeader()
        Kolom_Berat = New ColumnHeader()
        Kolom_total = New ColumnHeader()
        Kolom_TglMasuk = New ColumnHeader()
        Kolom_TglSelesai = New ColumnHeader()
        Kolom_Layanan = New ColumnHeader()
        Kolom_Status = New ColumnHeader()
        Kolom_TglAmbil = New ColumnHeader()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(20, 649)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(20, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1055, 21)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1056, 21)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(19, 628)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Btn_Cari)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Txt_CariNama)
        Panel4.Controls.Add(Btn_Ubah)
        Panel4.Controls.Add(Combo_Status)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Txt_IdTransaksi)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(20, 21)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1036, 261)
        Panel4.TabIndex = 3
        ' 
        ' Btn_Cari
        ' 
        Btn_Cari.BackColor = Color.White
        Btn_Cari.FlatStyle = FlatStyle.Flat
        Btn_Cari.ForeColor = Color.Black
        Btn_Cari.Image = CType(resources.GetObject("Btn_Cari.Image"), Image)
        Btn_Cari.Location = New Point(311, 227)
        Btn_Cari.Name = "Btn_Cari"
        Btn_Cari.Size = New Size(28, 28)
        Btn_Cari.TabIndex = 24
        Btn_Cari.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label3.Location = New Point(7, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 24)
        Label3.TabIndex = 23
        Label3.Text = "Cari"
        ' 
        ' Txt_CariNama
        ' 
        Txt_CariNama.Font = New Font("Calibri", 13F, FontStyle.Bold)
        Txt_CariNama.Location = New Point(56, 226)
        Txt_CariNama.Name = "Txt_CariNama"
        Txt_CariNama.Size = New Size(283, 29)
        Txt_CariNama.TabIndex = 22
        ' 
        ' Btn_Ubah
        ' 
        Btn_Ubah.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Btn_Ubah.FlatAppearance.BorderSize = 0
        Btn_Ubah.FlatStyle = FlatStyle.Flat
        Btn_Ubah.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Btn_Ubah.ForeColor = Color.White
        Btn_Ubah.Location = New Point(278, 120)
        Btn_Ubah.Name = "Btn_Ubah"
        Btn_Ubah.Size = New Size(80, 39)
        Btn_Ubah.TabIndex = 17
        Btn_Ubah.Text = "UBAH"
        Btn_Ubah.UseVisualStyleBackColor = False
        ' 
        ' Combo_Status
        ' 
        Combo_Status.Font = New Font("Calibri", 13F, FontStyle.Bold)
        Combo_Status.FormattingEnabled = True
        Combo_Status.Items.AddRange(New Object() {"Proses", "Selesai", "Batal"})
        Combo_Status.Location = New Point(104, 126)
        Combo_Status.Name = "Combo_Status"
        Combo_Status.Size = New Size(168, 29)
        Combo_Status.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label2.Location = New Point(25, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 24)
        Label2.TabIndex = 7
        Label2.Text = "Status"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label1.Location = New Point(25, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 24)
        Label1.TabIndex = 6
        Label1.Text = "ID Transaksi"
        ' 
        ' Txt_IdTransaksi
        ' 
        Txt_IdTransaksi.Font = New Font("Calibri", 13F, FontStyle.Bold)
        Txt_IdTransaksi.Location = New Point(25, 63)
        Txt_IdTransaksi.Name = "Txt_IdTransaksi"
        Txt_IdTransaksi.Size = New Size(178, 29)
        Txt_IdTransaksi.TabIndex = 4
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Kolom_Id, Kolom_Pelanggan, Kolom_Kasir, Kolom_Berat, Kolom_total, Kolom_TglMasuk, Kolom_TglSelesai, Kolom_Layanan, Kolom_Status, Kolom_TglAmbil})
        ListView1.Dock = DockStyle.Fill
        ListView1.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.Location = New Point(20, 282)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1036, 367)
        ListView1.TabIndex = 4
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Kolom_Id
        ' 
        Kolom_Id.Text = "ID"
        Kolom_Id.Width = 35
        ' 
        ' Kolom_Pelanggan
        ' 
        Kolom_Pelanggan.Text = "Nama Pelanggan"
        Kolom_Pelanggan.Width = 175
        ' 
        ' Kolom_Kasir
        ' 
        Kolom_Kasir.Text = "Kasir"
        Kolom_Kasir.Width = 100
        ' 
        ' Kolom_Berat
        ' 
        Kolom_Berat.DisplayIndex = 4
        Kolom_Berat.Text = "Berat"
        Kolom_Berat.Width = 50
        ' 
        ' Kolom_total
        ' 
        Kolom_total.DisplayIndex = 5
        Kolom_total.Text = "Total"
        Kolom_total.Width = 110
        ' 
        ' Kolom_TglMasuk
        ' 
        Kolom_TglMasuk.DisplayIndex = 6
        Kolom_TglMasuk.Text = "Tgl Masuk"
        Kolom_TglMasuk.Width = 160
        ' 
        ' Kolom_TglSelesai
        ' 
        Kolom_TglSelesai.DisplayIndex = 7
        Kolom_TglSelesai.Text = "Tgl Selesai"
        Kolom_TglSelesai.Width = 160
        ' 
        ' Kolom_Layanan
        ' 
        Kolom_Layanan.DisplayIndex = 3
        Kolom_Layanan.Text = "Layanan"
        Kolom_Layanan.Width = 110
        ' 
        ' Kolom_Status
        ' 
        Kolom_Status.Text = "Status"
        Kolom_Status.Width = 75
        ' 
        ' Kolom_TglAmbil
        ' 
        Kolom_TglAmbil.Text = "Tgl Ambil"
        Kolom_TglAmbil.Width = 160
        ' 
        ' FormDaftarPesanan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1075, 649)
        Controls.Add(ListView1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDaftarPesanan"
        Text = "FormDaftarPesanan"
        WindowState = FormWindowState.Maximized
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Kolom_Id As ColumnHeader
    Friend WithEvents Kolom_Pelanggan As ColumnHeader
    Friend WithEvents Kolom_Kasir As ColumnHeader
    Friend WithEvents Kolom_Berat As ColumnHeader
    Friend WithEvents Kolom_total As ColumnHeader
    Friend WithEvents Kolom_TglMasuk As ColumnHeader
    Friend WithEvents Kolom_TglSelesai As ColumnHeader
    Friend WithEvents Kolom_Layanan As ColumnHeader
    Friend WithEvents Kolom_Status As ColumnHeader
    Friend WithEvents Kolom_TglAmbil As ColumnHeader
    Friend WithEvents Txt_IdTransaksi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Combo_Status As ComboBox
    Friend WithEvents Btn_Ubah As Button
    Friend WithEvents Btn_Cari As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_CariNama As TextBox
End Class
