<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        pnlPelanggan = New Panel()
        PictureBox3 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        pnlProses = New Panel()
        PictureBox4 = New PictureBox()
        Label8 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        pnlDiambil = New Panel()
        PictureBox5 = New PictureBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        pnlDashboard = New Panel()
        pnlChart = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        Panel7 = New Panel()
        Button3 = New Button()
        Label24 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        Panel6 = New Panel()
        Button2 = New Button()
        Label20 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Panel5 = New Panel()
        Button1 = New Button()
        Label19 = New Label()
        Label17 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        pnlPelanggan.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlProses.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnlDiambil.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        pnlDashboard.SuspendLayout()
        Panel4.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Calibri", 18F)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(213, 44)
        Label16.Name = "Label16"
        Label16.Size = New Size(70, 29)
        Label16.TabIndex = 12
        Label16.Text = "AKUN"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Calibri", 18F)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(42, 44)
        Label15.Name = "Label15"
        Label15.Size = New Size(180, 29)
        Label15.TabIndex = 11
        Label15.Text = "Selamat Datang, "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(42, 11)
        Label14.Name = "Label14"
        Label14.Size = New Size(136, 33)
        Label14.TabIndex = 10
        Label14.Text = "Dashboard"
        ' 
        ' pnlPelanggan
        ' 
        pnlPelanggan.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        pnlPelanggan.Controls.Add(PictureBox3)
        pnlPelanggan.Controls.Add(Label7)
        pnlPelanggan.Controls.Add(Label6)
        pnlPelanggan.Controls.Add(Label5)
        pnlPelanggan.Location = New Point(54, 97)
        pnlPelanggan.Name = "pnlPelanggan"
        pnlPelanggan.Size = New Size(320, 188)
        pnlPelanggan.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(229, 100)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(85, 85)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 10F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(229, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 17)
        Label7.TabIndex = 2
        Label7.Text = "7 Hari Terakhir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 40F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(14, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 66)
        Label6.TabIndex = 1
        Label6.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(14, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 33)
        Label5.TabIndex = 0
        Label5.Text = "PELANGGAN"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 40F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(14, 42)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 66)
        Label9.TabIndex = 1
        Label9.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(14, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(190, 33)
        Label10.TabIndex = 0
        Label10.Text = "DALAM PROSES"
        ' 
        ' pnlProses
        ' 
        pnlProses.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        pnlProses.Controls.Add(PictureBox4)
        pnlProses.Controls.Add(Label8)
        pnlProses.Controls.Add(Label9)
        pnlProses.Controls.Add(Label10)
        pnlProses.Location = New Point(481, 97)
        pnlProses.Name = "pnlProses"
        pnlProses.Size = New Size(320, 188)
        pnlProses.TabIndex = 9
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(229, 100)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(85, 85)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 10F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(229, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 17)
        Label8.TabIndex = 2
        Label8.Text = "7 Hari Terakhir"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 10F)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(229, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 17)
        Label11.TabIndex = 2
        Label11.Text = "7 Hari Terakhir"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Calibri", 40F, FontStyle.Bold)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(14, 42)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 66)
        Label12.TabIndex = 1
        Label12.Text = "0"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(14, 9)
        Label13.Name = "Label13"
        Label13.Size = New Size(112, 33)
        Label13.TabIndex = 0
        Label13.Text = "DIAMBIL"
        ' 
        ' pnlDiambil
        ' 
        pnlDiambil.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        pnlDiambil.Controls.Add(PictureBox5)
        pnlDiambil.Controls.Add(Label11)
        pnlDiambil.Controls.Add(Label12)
        pnlDiambil.Controls.Add(Label13)
        pnlDiambil.Location = New Point(900, 97)
        pnlDiambil.Name = "pnlDiambil"
        pnlDiambil.Size = New Size(320, 188)
        pnlDiambil.TabIndex = 5
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(229, 100)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(85, 85)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(48, 744)
        Panel1.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(48, 744)
        Panel3.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(48, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1264, 15)
        Panel2.TabIndex = 14
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.Controls.Add(pnlChart)
        pnlDashboard.Controls.Add(Label2)
        pnlDashboard.Controls.Add(Label1)
        pnlDashboard.Location = New Point(54, 314)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(847, 418)
        pnlDashboard.TabIndex = 15
        ' 
        ' pnlChart
        ' 
        pnlChart.Location = New Point(14, 61)
        pnlChart.Name = "pnlChart"
        pnlChart.Size = New Size(819, 345)
        pnlChart.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Right
        Label2.Font = New Font("Calibri", 17F)
        Label2.Location = New Point(691, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 5, 10, 0)
        Label2.Size = New Size(156, 33)
        Label2.TabIndex = 1
        Label2.Text = "7 Hari Terakhir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10, 5, 0, 0)
        Label1.Size = New Size(286, 38)
        Label1.TabIndex = 0
        Label1.Text = "Statistik Total Transaksi"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(938, 314)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(281, 418)
        Panel4.TabIndex = 16
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Button3)
        Panel7.Controls.Add(Label24)
        Panel7.Controls.Add(Label26)
        Panel7.Controls.Add(Label27)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 258)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(281, 100)
        Panel7.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Calibri", 12F)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(191, 51)
        Button3.Name = "Button3"
        Button3.Size = New Size(55, 31)
        Button3.TabIndex = 4
        Button3.Text = "Cek"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Calibri", 14F)
        Label24.Location = New Point(191, 19)
        Label24.Name = "Label24"
        Label24.Size = New Size(60, 23)
        Label24.TabIndex = 3
        Label24.Text = "Waktu"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Calibri", 14F)
        Label26.Location = New Point(16, 51)
        Label26.Name = "Label26"
        Label26.Size = New Size(96, 23)
        Label26.TabIndex = 1
        Label26.Text = "Total Harga"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Calibri", 14F)
        Label27.Location = New Point(16, 19)
        Label27.Name = "Label27"
        Label27.Size = New Size(28, 23)
        Label27.TabIndex = 0
        Label27.Text = "ID"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Button2)
        Panel6.Controls.Add(Label20)
        Panel6.Controls.Add(Label22)
        Panel6.Controls.Add(Label23)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 158)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(281, 100)
        Panel6.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Calibri", 12F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(191, 51)
        Button2.Name = "Button2"
        Button2.Size = New Size(55, 31)
        Button2.TabIndex = 4
        Button2.Text = "Cek"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Calibri", 14F)
        Label20.Location = New Point(191, 19)
        Label20.Name = "Label20"
        Label20.Size = New Size(60, 23)
        Label20.TabIndex = 3
        Label20.Text = "Waktu"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Calibri", 14F)
        Label22.Location = New Point(16, 51)
        Label22.Name = "Label22"
        Label22.Size = New Size(96, 23)
        Label22.TabIndex = 1
        Label22.Text = "Total Harga"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Calibri", 14F)
        Label23.Location = New Point(16, 19)
        Label23.Name = "Label23"
        Label23.Size = New Size(28, 23)
        Label23.TabIndex = 0
        Label23.Text = "ID"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Button1)
        Panel5.Controls.Add(Label19)
        Panel5.Controls.Add(Label17)
        Panel5.Controls.Add(Label4)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 58)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(281, 100)
        Panel5.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 12F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(191, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(55, 31)
        Button1.TabIndex = 4
        Button1.Text = "Cek"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Calibri", 14F)
        Label19.Location = New Point(191, 19)
        Label19.Name = "Label19"
        Label19.Size = New Size(60, 23)
        Label19.TabIndex = 3
        Label19.Text = "Waktu"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Calibri", 14F)
        Label17.Location = New Point(16, 51)
        Label17.Name = "Label17"
        Label17.Size = New Size(96, 23)
        Label17.TabIndex = 1
        Label17.Text = "Total Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 14F)
        Label4.Location = New Point(16, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 23)
        Label4.TabIndex = 0
        Label4.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Top
        Label3.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(5, 5, 0, 20)
        Label3.Size = New Size(217, 58)
        Label3.TabIndex = 1
        Label3.Text = "Pesanan Terdekat"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 744)
        Controls.Add(Panel4)
        Controls.Add(pnlDashboard)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(pnlDiambil)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(pnlPelanggan)
        Controls.Add(pnlProses)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        pnlPelanggan.ResumeLayout(False)
        pnlPelanggan.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlProses.ResumeLayout(False)
        pnlProses.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        pnlDiambil.ResumeLayout(False)
        pnlDiambil.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlPelanggan As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlProses As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents pnlDiambil As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlChart As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
End Class
