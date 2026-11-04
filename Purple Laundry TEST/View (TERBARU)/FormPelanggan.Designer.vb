<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelanggan))
        Panel1 = New Panel()
        ListView1 = New ListView()
        Kolom_ID = New ColumnHeader()
        Kolom_Nama = New ColumnHeader()
        Kolom_nomor = New ColumnHeader()
        Panel4 = New Panel()
        Panel6 = New Panel()
        Btn_Cari = New Button()
        Label1 = New Label()
        Label3 = New Label()
        Txt_NmPelanggan = New TextBox()
        Label2 = New Label()
        Btn_Ubah = New Button()
        Txt_HpPealnggan = New TextBox()
        Btn_Hapus = New Button()
        Btn_Simpan = New Button()
        Txt_CariNama = New TextBox()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ListView1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1328, 690)
        Panel1.TabIndex = 0
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Kolom_ID, Kolom_Nama, Kolom_nomor})
        ListView1.Dock = DockStyle.Fill
        ListView1.Location = New Point(20, 246)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1021, 444)
        ListView1.TabIndex = 24
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Kolom_ID
        ' 
        Kolom_ID.Text = "ID"
        ' 
        ' Kolom_Nama
        ' 
        Kolom_Nama.Text = "Nama Pelanggan"
        Kolom_Nama.Width = 250
        ' 
        ' Kolom_nomor
        ' 
        Kolom_nomor.Text = "Nomor HP"
        Kolom_nomor.Width = 200
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(1041, 246)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(287, 444)
        Panel4.TabIndex = 23
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Btn_Cari)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(Txt_NmPelanggan)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(Btn_Ubah)
        Panel6.Controls.Add(Txt_HpPealnggan)
        Panel6.Controls.Add(Btn_Hapus)
        Panel6.Controls.Add(Btn_Simpan)
        Panel6.Controls.Add(Txt_CariNama)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(20, 21)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1308, 225)
        Panel6.TabIndex = 22
        ' 
        ' Btn_Cari
        ' 
        Btn_Cari.BackColor = Color.White
        Btn_Cari.FlatStyle = FlatStyle.Flat
        Btn_Cari.ForeColor = Color.Black
        Btn_Cari.Image = CType(resources.GetObject("Btn_Cari.Image"), Image)
        Btn_Cari.Location = New Point(982, 191)
        Btn_Cari.Name = "Btn_Cari"
        Btn_Cari.Size = New Size(28, 28)
        Btn_Cari.TabIndex = 21
        Btn_Cari.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label1.Location = New Point(14, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 24)
        Label1.TabIndex = 2
        Label1.Text = "Nama Pelanggan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label3.Location = New Point(678, 195)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 24)
        Label3.TabIndex = 20
        Label3.Text = "Cari"
        ' 
        ' Txt_NmPelanggan
        ' 
        Txt_NmPelanggan.Font = New Font("Calibri", 13.0F, FontStyle.Bold)
        Txt_NmPelanggan.Location = New Point(14, 35)
        Txt_NmPelanggan.Name = "Txt_NmPelanggan"
        Txt_NmPelanggan.Size = New Size(352, 29)
        Txt_NmPelanggan.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label2.Location = New Point(568, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 24)
        Label2.TabIndex = 4
        Label2.Text = "No HP Pelanggan"
        ' 
        ' Btn_Ubah
        ' 
        Btn_Ubah.BackColor = Color.White
        Btn_Ubah.FlatStyle = FlatStyle.Flat
        Btn_Ubah.ForeColor = Color.Black
        Btn_Ubah.Location = New Point(14, 115)
        Btn_Ubah.Name = "Btn_Ubah"
        Btn_Ubah.Size = New Size(150, 39)
        Btn_Ubah.TabIndex = 18
        Btn_Ubah.Text = "UBAH"
        Btn_Ubah.UseVisualStyleBackColor = False
        ' 
        ' Txt_HpPealnggan
        ' 
        Txt_HpPealnggan.Font = New Font("Calibri", 13.0F, FontStyle.Bold)
        Txt_HpPealnggan.Location = New Point(568, 35)
        Txt_HpPealnggan.Name = "Txt_HpPealnggan"
        Txt_HpPealnggan.Size = New Size(207, 29)
        Txt_HpPealnggan.TabIndex = 5
        ' 
        ' Btn_Hapus
        ' 
        Btn_Hapus.BackColor = Color.White
        Btn_Hapus.FlatStyle = FlatStyle.Flat
        Btn_Hapus.ForeColor = Color.Red
        Btn_Hapus.Location = New Point(14, 160)
        Btn_Hapus.Name = "Btn_Hapus"
        Btn_Hapus.Size = New Size(150, 39)
        Btn_Hapus.TabIndex = 17
        Btn_Hapus.Text = "HAPUS"
        Btn_Hapus.UseVisualStyleBackColor = False
        ' 
        ' Btn_Simpan
        ' 
        Btn_Simpan.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Btn_Simpan.FlatAppearance.BorderSize = 0
        Btn_Simpan.FlatStyle = FlatStyle.Flat
        Btn_Simpan.ForeColor = Color.White
        Btn_Simpan.Location = New Point(301, 160)
        Btn_Simpan.Name = "Btn_Simpan"
        Btn_Simpan.Size = New Size(150, 39)
        Btn_Simpan.TabIndex = 16
        Btn_Simpan.Text = "SIMPAN"
        Btn_Simpan.UseVisualStyleBackColor = False
        ' 
        ' Txt_CariNama
        ' 
        Txt_CariNama.Font = New Font("Calibri", 13.0F, FontStyle.Bold)
        Txt_CariNama.Location = New Point(727, 190)
        Txt_CariNama.Name = "Txt_CariNama"
        Txt_CariNama.Size = New Size(283, 29)
        Txt_CariNama.TabIndex = 19
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(20, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1308, 21)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(20, 690)
        Panel2.TabIndex = 0
        ' 
        ' FormPelanggan
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 690)
        Controls.Add(Panel1)
        Font = New Font("Calibri", 12.0F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormPelanggan"
        Text = "FormPelanggan"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_NmPelanggan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_HpPealnggan As TextBox
    Friend WithEvents Btn_Simpan As Button
    Friend WithEvents Btn_Hapus As Button
    Friend WithEvents Btn_Ubah As Button
    Friend WithEvents Txt_CariNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Cari As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Kolom_ID As ColumnHeader
    Friend WithEvents Kolom_Nama As ColumnHeader
    Friend WithEvents Kolom_nomor As ColumnHeader
End Class
