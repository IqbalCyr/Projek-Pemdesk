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
        BtnCari = New Button()
        Label3 = New Label()
        txtCari = New TextBox()
        BtnUbah = New Button()
        cmbStatus = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        txtIDTransaksi = New TextBox()
        lvPesanan = New ListView()
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
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(23, 865)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(23, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1206, 28)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1207, 28)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(22, 837)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(BtnCari)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(txtCari)
        Panel4.Controls.Add(BtnUbah)
        Panel4.Controls.Add(cmbStatus)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(txtIDTransaksi)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(23, 28)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1184, 348)
        Panel4.TabIndex = 3
        ' 
        ' BtnCari
        ' 
        BtnCari.BackColor = Color.White
        BtnCari.FlatStyle = FlatStyle.Flat
        BtnCari.ForeColor = Color.Black
        BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), Image)
        BtnCari.Location = New Point(355, 298)
        BtnCari.Margin = New Padding(3, 4, 3, 4)
        BtnCari.Name = "BtnCari"
        BtnCari.Size = New Size(32, 37)
        BtnCari.TabIndex = 24
        BtnCari.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label3.Location = New Point(8, 301)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 31)
        Label3.TabIndex = 23
        Label3.Text = "Cari"
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Calibri", 13F, FontStyle.Bold)
        txtCari.Location = New Point(64, 301)
        txtCari.Margin = New Padding(3, 4, 3, 4)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(323, 34)
        txtCari.TabIndex = 22
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        BtnUbah.FlatAppearance.BorderSize = 0
        BtnUbah.FlatStyle = FlatStyle.Flat
        BtnUbah.Font = New Font("Calibri", 12F, FontStyle.Bold)
        BtnUbah.ForeColor = Color.White
        BtnUbah.Location = New Point(318, 160)
        BtnUbah.Margin = New Padding(3, 4, 3, 4)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(91, 52)
        BtnUbah.TabIndex = 17
        BtnUbah.Text = "UBAH"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Calibri", 13F, FontStyle.Bold)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Proses", "Selesai", "Batal"})
        cmbStatus.Location = New Point(119, 168)
        cmbStatus.Margin = New Padding(3, 4, 3, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(191, 35)
        cmbStatus.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label2.Location = New Point(29, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 31)
        Label2.TabIndex = 7
        Label2.Text = "Status"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label1.Location = New Point(29, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 31)
        Label1.TabIndex = 6
        Label1.Text = "ID Transaksi"
        ' 
        ' txtIDTransaksi
        ' 
        txtIDTransaksi.Font = New Font("Calibri", 13F, FontStyle.Bold)
        txtIDTransaksi.Location = New Point(29, 84)
        txtIDTransaksi.Margin = New Padding(3, 4, 3, 4)
        txtIDTransaksi.Name = "txtIDTransaksi"
        txtIDTransaksi.Size = New Size(203, 34)
        txtIDTransaksi.TabIndex = 4
        ' 
        ' lvPesanan
        ' 
        lvPesanan.Columns.AddRange(New ColumnHeader() {Kolom_Id, Kolom_Pelanggan, Kolom_Kasir, Kolom_Berat, Kolom_total, Kolom_TglMasuk, Kolom_TglSelesai, Kolom_Layanan, Kolom_Status, Kolom_TglAmbil})
        lvPesanan.Dock = DockStyle.Fill
        lvPesanan.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lvPesanan.Location = New Point(23, 376)
        lvPesanan.Margin = New Padding(3, 4, 3, 4)
        lvPesanan.Name = "lvPesanan"
        lvPesanan.Size = New Size(1184, 489)
        lvPesanan.TabIndex = 4
        lvPesanan.UseCompatibleStateImageBehavior = False
        lvPesanan.View = View.Details
        ' 
        ' Kolom_Id
        ' 
        Kolom_Id.Text = "ID"
        Kolom_Id.Width = 35
        ' 
        ' Kolom_Pelanggan
        ' 
        Kolom_Pelanggan.Text = "Pelanggan"
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
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1229, 865)
        Controls.Add(lvPesanan)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents lvPesanan As ListView
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
    Friend WithEvents txtIDTransaksi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnCari As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCari As TextBox
End Class
