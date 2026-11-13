<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Panel1 = New Panel()
        btnKeluar = New Button()
        btnLaporan = New Button()
        btnPengeluaran = New Button()
        btnTransaksi = New Button()
        btnCustomer = New Button()
        btnDashboard = New Button()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Panel6 = New Panel()
        timerAnimasi = New Timer(components)
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(13), CByte(115), CByte(119))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnKeluar)
        Panel1.Controls.Add(btnLaporan)
        Panel1.Controls.Add(btnPengeluaran)
        Panel1.Controls.Add(btnTransaksi)
        Panel1.Controls.Add(btnCustomer)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(274, 1055)
        Panel1.TabIndex = 0
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Dock = DockStyle.Bottom
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = Color.White
        btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), Image)
        btnKeluar.Location = New Point(27, 956)
        btnKeluar.Margin = New Padding(3, 4, 3, 4)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Padding = New Padding(23, 0, 0, 0)
        btnKeluar.Size = New Size(216, 99)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "  Keluar"
        btnKeluar.TextAlign = ContentAlignment.MiddleLeft
        btnKeluar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' btnLaporan
        ' 
        btnLaporan.Dock = DockStyle.Top
        btnLaporan.FlatAppearance.BorderSize = 0
        btnLaporan.FlatStyle = FlatStyle.Flat
        btnLaporan.Font = New Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLaporan.ForeColor = Color.White
        btnLaporan.Image = CType(resources.GetObject("btnLaporan.Image"), Image)
        btnLaporan.Location = New Point(27, 529)
        btnLaporan.Margin = New Padding(3, 4, 3, 4)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Padding = New Padding(23, 0, 0, 0)
        btnLaporan.Size = New Size(216, 87)
        btnLaporan.TabIndex = 5
        btnLaporan.Text = " Pengeluaran"
        btnLaporan.TextAlign = ContentAlignment.MiddleLeft
        btnLaporan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLaporan.UseVisualStyleBackColor = True
        ' 
        ' btnPengeluaran
        ' 
        btnPengeluaran.Dock = DockStyle.Top
        btnPengeluaran.FlatAppearance.BorderSize = 0
        btnPengeluaran.FlatStyle = FlatStyle.Flat
        btnPengeluaran.Font = New Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPengeluaran.ForeColor = Color.White
        btnPengeluaran.Image = CType(resources.GetObject("btnPengeluaran.Image"), Image)
        btnPengeluaran.Location = New Point(27, 442)
        btnPengeluaran.Margin = New Padding(3, 4, 3, 4)
        btnPengeluaran.Name = "btnPengeluaran"
        btnPengeluaran.Padding = New Padding(23, 0, 0, 0)
        btnPengeluaran.Size = New Size(216, 87)
        btnPengeluaran.TabIndex = 4
        btnPengeluaran.Text = "  Laporan"
        btnPengeluaran.TextAlign = ContentAlignment.MiddleLeft
        btnPengeluaran.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPengeluaran.UseVisualStyleBackColor = True
        ' 
        ' btnTransaksi
        ' 
        btnTransaksi.Dock = DockStyle.Top
        btnTransaksi.FlatAppearance.BorderSize = 0
        btnTransaksi.FlatStyle = FlatStyle.Flat
        btnTransaksi.Font = New Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTransaksi.ForeColor = Color.White
        btnTransaksi.Image = CType(resources.GetObject("btnTransaksi.Image"), Image)
        btnTransaksi.Location = New Point(27, 355)
        btnTransaksi.Margin = New Padding(3, 4, 3, 4)
        btnTransaksi.Name = "btnTransaksi"
        btnTransaksi.Padding = New Padding(23, 0, 0, 0)
        btnTransaksi.Size = New Size(216, 87)
        btnTransaksi.TabIndex = 3
        btnTransaksi.Text = "  Transaksi"
        btnTransaksi.TextAlign = ContentAlignment.MiddleLeft
        btnTransaksi.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTransaksi.UseVisualStyleBackColor = True
        ' 
        ' btnCustomer
        ' 
        btnCustomer.Dock = DockStyle.Top
        btnCustomer.FlatAppearance.BorderSize = 0
        btnCustomer.FlatStyle = FlatStyle.Flat
        btnCustomer.Font = New Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCustomer.ForeColor = Color.White
        btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), Image)
        btnCustomer.Location = New Point(27, 268)
        btnCustomer.Margin = New Padding(3, 4, 3, 4)
        btnCustomer.Name = "btnCustomer"
        btnCustomer.Padding = New Padding(23, 0, 0, 0)
        btnCustomer.Size = New Size(216, 87)
        btnCustomer.TabIndex = 2
        btnCustomer.Text = "  Pelanggan"
        btnCustomer.TextAlign = ContentAlignment.MiddleLeft
        btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCustomer.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.Location = New Point(27, 181)
        btnDashboard.Margin = New Padding(3, 4, 3, 4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(23, 0, 0, 0)
        btnDashboard.Size = New Size(216, 87)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "  Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(243, 181)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(31, 874)
        Panel4.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 181)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(27, 874)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(274, 181)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(121, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 18)
        Label2.TabIndex = 2
        Label2.Text = "ROLE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(121, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 18)
        Label1.TabIndex = 1
        Label1.Text = "PURPLE LAUNDRY"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 35)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(13), CByte(115), CByte(119))
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(PictureBox2)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(274, 0)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1536, 52)
        Panel5.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Bottom
        Label4.Font = New Font("Calibri", 15F)
        Label4.ForeColor = Color.White
        Label4.ImageAlign = ContentAlignment.MiddleLeft
        Label4.Location = New Point(0, 14)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(11, 0, 0, 7)
        Label4.Size = New Size(165, 38)
        Label4.TabIndex = 4
        Label4.Text = "DD/MM/YYYY"
        Label4.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Right
        Label3.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.ImageAlign = ContentAlignment.MiddleRight
        Label3.Location = New Point(1394, 0)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(0, 3, 0, 0)
        Label3.Size = New Size(110, 44)
        Label3.TabIndex = 0
        Label3.Text = "AKUN "
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1504, 0)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Padding = New Padding(0, 3, 0, 0)
        PictureBox2.Size = New Size(32, 52)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(274, 52)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1536, 1003)
        Panel6.TabIndex = 3
        ' 
        ' timerAnimasi
        ' 
        timerAnimasi.Interval = 10
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(27, 616)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(23, 0, 0, 0)
        Button1.Size = New Size(216, 87)
        Button1.TabIndex = 7
        Button1.Text = " Pengeluaran"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        ClientSize = New Size(1810, 1055)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnPengeluaran As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents timerAnimasi As Timer
    Friend WithEvents Button1 As Button
End Class
