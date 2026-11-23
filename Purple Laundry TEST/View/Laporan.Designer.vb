<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        ComboBox1 = New ComboBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel6 = New Panel()
        DataGridView1 = New DataGridView()
        colomnTransaksi = New DataGridViewTextBoxColumn()
        colomnTanggal = New DataGridViewTextBoxColumn()
        colomn = New DataGridViewTextBoxColumn()
        colomnItem = New DataGridViewTextBoxColumn()
        colomnJumlah = New DataGridViewTextBoxColumn()
        colomnSub = New DataGridViewTextBoxColumn()
        colomnTotal = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        Label14 = New Label()
        btnEkspor = New Button()
        Panel5 = New Panel()
        Panel6.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 13F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(20, 43)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.MinimumSize = New Size(10, 0)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(130, 31)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "Status"
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(48, 783)
        Panel3.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(48, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1280, 15)
        Panel4.TabIndex = 7
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(DataGridView1)
        Panel6.Controls.Add(ComboBox1)
        Panel6.Controls.Add(Panel1)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(48, 202)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1280, 581)
        Panel6.TabIndex = 10
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colomnTransaksi, colomnTanggal, colomn, colomnItem, colomnJumlah, colomnSub, colomnTotal})
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(0, 102)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1278, 477)
        DataGridView1.TabIndex = 0
        ' 
        ' colomnTransaksi
        ' 
        colomnTransaksi.HeaderText = "Transaksi"
        colomnTransaksi.Name = "colomnTransaksi"
        colomnTransaksi.Width = 195
        ' 
        ' colomnTanggal
        ' 
        colomnTanggal.HeaderText = "Tanggal"
        colomnTanggal.Name = "colomnTanggal"
        colomnTanggal.Width = 202
        ' 
        ' colomn
        ' 
        colomn.HeaderText = "Status"
        colomn.Name = "colomn"
        colomn.Width = 150
        ' 
        ' colomnItem
        ' 
        colomnItem.FillWeight = 225F
        colomnItem.HeaderText = "Item"
        colomnItem.Name = "colomnItem"
        colomnItem.Width = 225
        ' 
        ' colomnJumlah
        ' 
        colomnJumlah.HeaderText = "Jumlah"
        colomnJumlah.Name = "colomnJumlah"
        colomnJumlah.Width = 153
        ' 
        ' colomnSub
        ' 
        colomnSub.HeaderText = "SubTotal"
        colomnSub.Name = "colomnSub"
        colomnSub.Width = 160
        ' 
        ' colomnTotal
        ' 
        colomnTotal.HeaderText = "Total"
        colomnTotal.Name = "colomnTotal"
        colomnTotal.Width = 190
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DateTimePicker2)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(203, 3)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(612, 86)
        Panel1.TabIndex = 2
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 13F)
        DateTimePicker2.Location = New Point(339, 40)
        DateTimePicker2.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(266, 31)
        DateTimePicker2.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 13F)
        DateTimePicker1.Location = New Point(12, 40)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(265, 31)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label2.Location = New Point(447, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 4
        Label2.Text = "Akhir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label1.Location = New Point(112, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 25)
        Label1.TabIndex = 3
        Label1.Text = "Awal"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(0, 3)
        Label14.Name = "Label14"
        Label14.Size = New Size(104, 33)
        Label14.TabIndex = 8
        Label14.Text = "Laporan"
        ' 
        ' btnEkspor
        ' 
        btnEkspor.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        btnEkspor.FlatAppearance.BorderSize = 0
        btnEkspor.FlatStyle = FlatStyle.Flat
        btnEkspor.Font = New Font("Calibri", 18F)
        btnEkspor.ForeColor = Color.White
        btnEkspor.Image = CType(resources.GetObject("btnEkspor.Image"), Image)
        btnEkspor.Location = New Point(12, 100)
        btnEkspor.Margin = New Padding(0)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Padding = New Padding(10, 0, 0, 0)
        btnEkspor.Size = New Size(197, 67)
        btnEkspor.TabIndex = 9
        btnEkspor.Text = "  Ekspor Data"
        btnEkspor.TextAlign = ContentAlignment.MiddleLeft
        btnEkspor.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEkspor.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(btnEkspor)
        Panel5.Controls.Add(Label14)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(48, 15)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1280, 187)
        Panel5.TabIndex = 9
        ' 
        ' Laporan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1328, 783)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Laporan"
        Text = "Laporan"
        Panel6.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnEkspor As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents colomnTransaksi As DataGridViewTextBoxColumn
    Friend WithEvents colomnTanggal As DataGridViewTextBoxColumn
    Friend WithEvents colomn As DataGridViewTextBoxColumn
    Friend WithEvents colomnItem As DataGridViewTextBoxColumn
    Friend WithEvents colomnJumlah As DataGridViewTextBoxColumn
    Friend WithEvents colomnSub As DataGridViewTextBoxColumn
    Friend WithEvents colomnTotal As DataGridViewTextBoxColumn
End Class
