<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stok
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Label14 = New Label()
        Panel1 = New Panel()
        Label15 = New Label()
        DataGridView1 = New DataGridView()
        pnlStokTersedia = New Panel()
        StokTersedia_text = New Label()
        Label5 = New Label()
        pnlStokSedikit = New Panel()
        StokSedikit_text = New Label()
        Label2 = New Label()
        pnlStokHabis = New Panel()
        StokHabis_text = New Label()
        Label4 = New Label()
        colomnId = New DataGridViewTextBoxColumn()
        colomnNama = New DataGridViewTextBoxColumn()
        colomnQty = New DataGridViewTextBoxColumn()
        colomnSatuan = New DataGridViewTextBoxColumn()
        Panel5.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlStokTersedia.SuspendLayout()
        pnlStokSedikit.SuspendLayout()
        pnlStokHabis.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(48, 783)
        Panel3.TabIndex = 7
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(48, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1280, 15)
        Panel4.TabIndex = 8
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(pnlStokHabis)
        Panel5.Controls.Add(pnlStokSedikit)
        Panel5.Controls.Add(pnlStokTersedia)
        Panel5.Controls.Add(Label14)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(48, 15)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1280, 187)
        Panel5.TabIndex = 10
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(0, 3)
        Label14.Name = "Label14"
        Label14.Size = New Size(65, 33)
        Label14.TabIndex = 8
        Label14.Text = "Stok"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(48, 202)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1280, 581)
        Panel1.TabIndex = 11
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Calibri", 18F)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(0, 32)
        Label15.Name = "Label15"
        Label15.Size = New Size(149, 29)
        Label15.TabIndex = 12
        Label15.Text = "Daftar Barang"
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colomnId, colomnNama, colomnQty, colomnSatuan})
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(0, 102)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1278, 477)
        DataGridView1.TabIndex = 0
        ' 
        ' pnlStokTersedia
        ' 
        pnlStokTersedia.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        pnlStokTersedia.Controls.Add(StokTersedia_text)
        pnlStokTersedia.Controls.Add(Label5)
        pnlStokTersedia.Location = New Point(134, 49)
        pnlStokTersedia.Name = "pnlStokTersedia"
        pnlStokTersedia.Size = New Size(265, 123)
        pnlStokTersedia.TabIndex = 9
        ' 
        ' StokTersedia_text
        ' 
        StokTersedia_text.AutoSize = True
        StokTersedia_text.Font = New Font("Calibri", 40F, FontStyle.Bold)
        StokTersedia_text.ForeColor = Color.White
        StokTersedia_text.Location = New Point(14, 42)
        StokTersedia_text.Name = "StokTersedia_text"
        StokTersedia_text.Size = New Size(55, 66)
        StokTersedia_text.TabIndex = 1
        StokTersedia_text.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(14, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(186, 33)
        Label5.TabIndex = 0
        Label5.Text = "STOK TERSEDIA"
        ' 
        ' pnlStokSedikit
        ' 
        pnlStokSedikit.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        pnlStokSedikit.Controls.Add(StokSedikit_text)
        pnlStokSedikit.Controls.Add(Label2)
        pnlStokSedikit.Location = New Point(534, 49)
        pnlStokSedikit.Name = "pnlStokSedikit"
        pnlStokSedikit.Size = New Size(265, 123)
        pnlStokSedikit.TabIndex = 10
        ' 
        ' StokSedikit_text
        ' 
        StokSedikit_text.AutoSize = True
        StokSedikit_text.Font = New Font("Calibri", 40F, FontStyle.Bold)
        StokSedikit_text.ForeColor = Color.White
        StokSedikit_text.Location = New Point(14, 42)
        StokSedikit_text.Name = "StokSedikit_text"
        StokSedikit_text.Size = New Size(55, 66)
        StokSedikit_text.TabIndex = 1
        StokSedikit_text.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(14, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 33)
        Label2.TabIndex = 0
        Label2.Text = "STOK SEDIKIT"
        ' 
        ' pnlStokHabis
        ' 
        pnlStokHabis.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        pnlStokHabis.Controls.Add(StokHabis_text)
        pnlStokHabis.Controls.Add(Label4)
        pnlStokHabis.Location = New Point(934, 49)
        pnlStokHabis.Name = "pnlStokHabis"
        pnlStokHabis.Size = New Size(265, 123)
        pnlStokHabis.TabIndex = 11
        ' 
        ' StokHabis_text
        ' 
        StokHabis_text.AutoSize = True
        StokHabis_text.Font = New Font("Calibri", 40F, FontStyle.Bold)
        StokHabis_text.ForeColor = Color.White
        StokHabis_text.Location = New Point(14, 42)
        StokHabis_text.Name = "StokHabis_text"
        StokHabis_text.Size = New Size(55, 66)
        StokHabis_text.TabIndex = 1
        StokHabis_text.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(14, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 33)
        Label4.TabIndex = 0
        Label4.Text = "STOK HABIS"
        ' 
        ' colomnId
        ' 
        colomnId.HeaderText = "ID Stok"
        colomnId.Name = "colomnId"
        colomnId.Width = 250
        ' 
        ' colomnNama
        ' 
        colomnNama.HeaderText = "Nama Barang"
        colomnNama.Name = "colomnNama"
        colomnNama.Width = 500
        ' 
        ' colomnQty
        ' 
        colomnQty.HeaderText = "Qty"
        colomnQty.Name = "colomnQty"
        colomnQty.Width = 250
        ' 
        ' colomnSatuan
        ' 
        colomnSatuan.HeaderText = "Harga Satuan"
        colomnSatuan.Name = "colomnSatuan"
        colomnSatuan.Width = 273
        ' 
        ' Stok
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 783)
        Controls.Add(Panel1)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Stok"
        Text = "Stok"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlStokTersedia.ResumeLayout(False)
        pnlStokTersedia.PerformLayout()
        pnlStokSedikit.ResumeLayout(False)
        pnlStokSedikit.PerformLayout()
        pnlStokHabis.ResumeLayout(False)
        pnlStokHabis.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnlStokHabis As Panel
    Friend WithEvents StokHabis_text As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlStokSedikit As Panel
    Friend WithEvents StokSedikit_text As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlStokTersedia As Panel
    Friend WithEvents StokTersedia_text As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents colomnId As DataGridViewTextBoxColumn
    Friend WithEvents colomnNama As DataGridViewTextBoxColumn
    Friend WithEvents colomnQty As DataGridViewTextBoxColumn
    Friend WithEvents colomnSatuan As DataGridViewTextBoxColumn
End Class
