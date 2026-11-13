<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label14 = New Label()
        Panel3 = New Panel()
        btnTambah = New Button()
        Panel4 = New Panel()
        Btn_Cari = New Button()
        Label15 = New Label()
        txtCari = New TextBox()
        DataGridView1 = New DataGridView()
        colomnNama = New DataGridViewTextBoxColumn()
        colomnNoHp = New DataGridViewTextBoxColumn()
        colomnAksi = New DataGridViewButtonColumn()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(48, 783)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(48, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1280, 15)
        Panel2.TabIndex = 1
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(0, 3)
        Label14.Name = "Label14"
        Label14.Size = New Size(188, 33)
        Label14.TabIndex = 6
        Label14.Text = "Data Pelanggan"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnTambah)
        Panel3.Controls.Add(Label14)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(48, 15)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1280, 187)
        Panel3.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Calibri", 18F)
        btnTambah.ForeColor = Color.White
        btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), Image)
        btnTambah.Location = New Point(12, 100)
        btnTambah.Margin = New Padding(0)
        btnTambah.Name = "btnTambah"
        btnTambah.Padding = New Padding(10, 0, 0, 0)
        btnTambah.Size = New Size(260, 67)
        btnTambah.TabIndex = 7
        btnTambah.Text = "Tambah Pelanggan"
        btnTambah.TextAlign = ContentAlignment.MiddleLeft
        btnTambah.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Btn_Cari)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(txtCari)
        Panel4.Controls.Add(DataGridView1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(48, 202)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1280, 581)
        Panel4.TabIndex = 8
        ' 
        ' Btn_Cari
        ' 
        Btn_Cari.BackColor = Color.White
        Btn_Cari.FlatStyle = FlatStyle.Flat
        Btn_Cari.ForeColor = Color.Black
        Btn_Cari.Image = CType(resources.GetObject("Btn_Cari.Image"), Image)
        Btn_Cari.Location = New Point(514, 33)
        Btn_Cari.Name = "Btn_Cari"
        Btn_Cari.Size = New Size(33, 32)
        Btn_Cari.TabIndex = 22
        Btn_Cari.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Calibri", 18F)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(0, 32)
        Label15.Name = "Label15"
        Label15.Size = New Size(113, 29)
        Label15.TabIndex = 12
        Label15.Text = "Cari nama"
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Calibri", 15F)
        txtCari.Location = New Point(107, 33)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(440, 32)
        txtCari.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        DataGridViewCellStyle1.Font = New Font("Calibri", 13F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(51), CByte(217), CByte(178))
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colomnNama, colomnNoHp, colomnAksi})
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(0, 102)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1278, 477)
        DataGridView1.TabIndex = 0
        ' 
        ' colomnNama
        ' 
        colomnNama.HeaderText = "Nama Pealnggan"
        colomnNama.Name = "colomnNama"
        colomnNama.Width = 500
        ' 
        ' colomnNoHp
        ' 
        colomnNoHp.HeaderText = "Nomor HP"
        colomnNoHp.Name = "colomnNoHp"
        colomnNoHp.Width = 350
        ' 
        ' colomnAksi
        ' 
        colomnAksi.HeaderText = "Aksi"
        colomnAksi.Name = "colomnAksi"
        colomnAksi.Text = "EDIT"
        colomnAksi.Width = 384
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' customer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 783)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "customer"
        Text = "customer"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label15 As Label
    Friend WithEvents Btn_Cari As Button
    Friend WithEvents colomnNama As DataGridViewTextBoxColumn
    Friend WithEvents colomnNoHp As DataGridViewTextBoxColumn
    Friend WithEvents colomnAksi As DataGridViewButtonColumn
End Class
