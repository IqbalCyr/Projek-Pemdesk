<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuatPesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Txt_NoHp = New TextBox()
        Txt_Berat = New TextBox()
        Combo_Tipe = New ComboBox()
        Combo_Layanan = New ComboBox()
        Txt_Total = New TextBox()
        Btn_Hitung = New Button()
        Btn_Simpan = New Button()
        Btn_Kembali = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Txt_NmPelanggan = New TextBox()
        SuspendLayout()
        ' 
        ' Txt_NoHp
        ' 
        Txt_NoHp.Font = New Font("Segoe UI", 10F)
        Txt_NoHp.Location = New Point(12, 94)
        Txt_NoHp.Name = "Txt_NoHp"
        Txt_NoHp.Size = New Size(228, 25)
        Txt_NoHp.TabIndex = 1
        ' 
        ' Txt_Berat
        ' 
        Txt_Berat.Font = New Font("Segoe UI", 10F)
        Txt_Berat.Location = New Point(104, 154)
        Txt_Berat.Name = "Txt_Berat"
        Txt_Berat.Size = New Size(46, 25)
        Txt_Berat.TabIndex = 2
        ' 
        ' Combo_Tipe
        ' 
        Combo_Tipe.Font = New Font("Segoe UI", 10F)
        Combo_Tipe.FormattingEnabled = True
        Combo_Tipe.Items.AddRange(New Object() {"Cuci Lipat", "Cuci Setrika"})
        Combo_Tipe.Location = New Point(119, 185)
        Combo_Tipe.Name = "Combo_Tipe"
        Combo_Tipe.Size = New Size(150, 25)
        Combo_Tipe.TabIndex = 3
        ' 
        ' Combo_Layanan
        ' 
        Combo_Layanan.Font = New Font("Segoe UI", 10F)
        Combo_Layanan.FormattingEnabled = True
        Combo_Layanan.Items.AddRange(New Object() {"Reguler", "Express"})
        Combo_Layanan.Location = New Point(119, 216)
        Combo_Layanan.Name = "Combo_Layanan"
        Combo_Layanan.Size = New Size(150, 25)
        Combo_Layanan.TabIndex = 4
        ' 
        ' Txt_Total
        ' 
        Txt_Total.Font = New Font("Segoe UI", 10F)
        Txt_Total.Location = New Point(119, 298)
        Txt_Total.Name = "Txt_Total"
        Txt_Total.Size = New Size(150, 25)
        Txt_Total.TabIndex = 5
        ' 
        ' Btn_Hitung
        ' 
        Btn_Hitung.Font = New Font("Segoe UI", 10F)
        Btn_Hitung.Location = New Point(12, 255)
        Btn_Hitung.Name = "Btn_Hitung"
        Btn_Hitung.Size = New Size(79, 33)
        Btn_Hitung.TabIndex = 6
        Btn_Hitung.Text = "HITUNG"
        Btn_Hitung.UseVisualStyleBackColor = True
        ' 
        ' Btn_Simpan
        ' 
        Btn_Simpan.Font = New Font("Segoe UI", 15F)
        Btn_Simpan.Location = New Point(346, 277)
        Btn_Simpan.Name = "Btn_Simpan"
        Btn_Simpan.Size = New Size(140, 62)
        Btn_Simpan.TabIndex = 7
        Btn_Simpan.Text = "SIMPAN"
        Btn_Simpan.UseVisualStyleBackColor = True
        ' 
        ' Btn_Kembali
        ' 
        Btn_Kembali.Font = New Font("Segoe UI", 10F)
        Btn_Kembali.Location = New Point(2, 394)
        Btn_Kembali.Name = "Btn_Kembali"
        Btn_Kembali.Size = New Size(89, 30)
        Btn_Kembali.TabIndex = 8
        Btn_Kembali.Text = "Kembali"
        Btn_Kembali.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(12, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 9
        Label1.Text = "Nama Pelanggan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(12, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 20)
        Label2.TabIndex = 10
        Label2.Text = "No HP Pelanggan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(12, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 11
        Label3.Text = "Berat Cucian"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(156, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 20)
        Label4.TabIndex = 12
        Label4.Text = "Kg"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(12, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 20)
        Label5.TabIndex = 13
        Label5.Text = "Tipe Cucian"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(12, 216)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 14
        Label6.Text = "Layanan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F)
        Label7.Location = New Point(12, 301)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 20)
        Label7.TabIndex = 15
        Label7.Text = "Total Harga"
        ' 
        ' Txt_NmPelanggan
        ' 
        Txt_NmPelanggan.Font = New Font("Segoe UI", 10F)
        Txt_NmPelanggan.Location = New Point(12, 37)
        Txt_NmPelanggan.Name = "Txt_NmPelanggan"
        Txt_NmPelanggan.Size = New Size(325, 25)
        Txt_NmPelanggan.TabIndex = 16
        ' 
        ' FormBuatPesanan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(611, 429)
        Controls.Add(Txt_NmPelanggan)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Btn_Kembali)
        Controls.Add(Btn_Simpan)
        Controls.Add(Btn_Hitung)
        Controls.Add(Txt_Total)
        Controls.Add(Combo_Layanan)
        Controls.Add(Combo_Tipe)
        Controls.Add(Txt_Berat)
        Controls.Add(Txt_NoHp)
        Name = "FormBuatPesanan"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Txt_NoHp As TextBox
    Friend WithEvents Txt_Berat As TextBox
    Friend WithEvents Combo_Tipe As ComboBox
    Friend WithEvents Combo_Layanan As ComboBox
    Friend WithEvents Txt_Total As TextBox
    Friend WithEvents Btn_Hitung As Button
    Friend WithEvents Btn_Simpan As Button
    Friend WithEvents Btn_Kembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_NmPelanggan As TextBox

End Class
