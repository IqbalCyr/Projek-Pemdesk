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
        Panel2 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        ComboBox2 = New ComboBox()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.Controls.Add(Panel2)
        Panel1.Font = New Font("Calibri", 12.0F, FontStyle.Bold)
        Panel1.Location = New Point(87, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1091, 688)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(NumericUpDown1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1091, 688)
        Panel2.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(211, 477)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 39)
        Button3.TabIndex = 15
        Button3.Text = "SIMPAN"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(32, 477)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 39)
        Button2.TabIndex = 14
        Button2.Text = "BERSIH"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 13.0F)
        Label8.Location = New Point(154, 432)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 22)
        Label8.TabIndex = 13
        Label8.Text = "Label8"
        Label8.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label7.Location = New Point(32, 429)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 24)
        Label7.TabIndex = 12
        Label7.Text = "Total Harga:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(32, 358)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 39)
        Button1.TabIndex = 11
        Button1.Text = "HITUNG"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Calibri", 13.0F, FontStyle.Bold)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(154, 310)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 29)
        ComboBox2.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label6.Location = New Point(32, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 24)
        Label6.TabIndex = 9
        Label6.Text = "Layanan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Calibri", 13.0F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(154, 266)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 29)
        ComboBox1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label5.Location = New Point(32, 266)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 24)
        Label5.TabIndex = 7
        Label5.Text = "Tipe Cucian"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label4.Location = New Point(211, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 24)
        Label4.TabIndex = 6
        Label4.Text = "Kg"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Calibri", 13.0F)
        NumericUpDown1.Location = New Point(154, 220)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(51, 29)
        NumericUpDown1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label3.Location = New Point(32, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 24)
        Label3.TabIndex = 4
        Label3.Text = "Berat Cucian"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Calibri", 13.0F, FontStyle.Bold)
        TextBox2.Location = New Point(32, 119)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(207, 29)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label2.Location = New Point(32, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 24)
        Label2.TabIndex = 2
        Label2.Text = "No HP Pelanggan"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Calibri", 13.0F, FontStyle.Bold)
        TextBox1.Location = New Point(32, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(352, 29)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(201), CByte(106), CByte(232))
        Label1.Location = New Point(32, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 24)
        Label1.TabIndex = 0
        Label1.Text = "Nama Pelanggan"
        ' 
        ' FormPesanan
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1344, 729)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormPesanan"
        Text = "FormPesanan"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
