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
        Panel2 = New Panel()
        pnlDashboard = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        pnlPelanggan.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlProses.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnlDiambil.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        pnlDashboard.SuspendLayout()
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
        pnlPelanggan.Location = New Point(54, 155)
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
        pnlProses.Location = New Point(454, 155)
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
        pnlDiambil.Location = New Point(854, 155)
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
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(48, 744)
        Panel1.TabIndex = 13
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
        pnlDashboard.BorderStyle = BorderStyle.FixedSingle
        pnlDashboard.Controls.Add(Label2)
        pnlDashboard.Controls.Add(Label1)
        pnlDashboard.Location = New Point(54, 397)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(1095, 347)
        pnlDashboard.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Right
        Label2.Font = New Font("Calibri", 17F)
        Label2.Location = New Point(937, 0)
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
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 744)
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
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
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
End Class
