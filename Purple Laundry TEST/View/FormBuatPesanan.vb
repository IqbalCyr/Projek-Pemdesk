Imports MySql.Data.MySqlClient

Public Class FormBuatPesanan
    Dim conn As MySqlConnection = getconn()
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter

    Dim idPelangganSelected As Integer = 0
    Sub LoadAutoCompletePelanggan()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT * FROM pelanggan", conn)
        da.Fill(ds, "tabelPelanggan")
        Dim coll As New AutoCompleteStringCollection()
        'For Each row As DataRow In ds.Tables("tabelPelanggan").Rows
        'coll.Add(row("nama").ToString())
        For i As Integer = 0 To (ds.Tables("tabelPelanggan").Rows.Count - 1)
            coll.Add(ds.Tables("tabelPelanggan").Rows(i)("nama"))
        Next

        Txt_NmPelanggan.AutoCompleteMode = AutoCompleteMode.Suggest
        Txt_NmPelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource
        Txt_NmPelanggan.AutoCompleteCustomSource = coll
    End Sub

    Sub LoadComboBoxTipeDanLayanan()
        ' Mengisi Tipe Cucian dari tabel tarif_layanan
        If ds.Tables("tarif_layanan") IsNot Nothing Then ds.Tables("tarif_layanan").Clear()
        da = New MySqlDataAdapter("SELECT * FROM tarif_layanan", conn)
        da.Fill(ds, "tarif_layanan")

        Combo_Tipe.Items.Clear()
        For Each row As DataRow In ds.Tables("tarif_layanan").Rows
            Combo_Tipe.Items.Add(row("tipe_cucian").ToString())
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MenuAkun.Text = KasirAktif.Nama
        LoadAutoCompletePelanggan()

    End Sub

    Private Sub Txt_NmPelanggan_TextChanged(sender As Object, e As EventArgs) Handles Txt_NmPelanggan.TextChanged
        Dim foundRows() As DataRow
        foundRows = ds.Tables("tabelPelanggan").Select("nama = '" & Txt_NmPelanggan.Text.Replace("'", "''") & "'")

        If foundRows.Length > 0 Then
            Txt_NoHp.Text = foundRows(0)("no_hp").ToString()
            idPelangganSelected = Convert.ToInt32(foundRows(0)("id_pelanggan"))
        Else
            Txt_NoHp.Text = ""
            idPelangganSelected = 0
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_NoHp.TextChanged

    End Sub

    Private Sub Txt_Berat_ValueChanged(sender As Object, e As EventArgs) Handles Nmr_Berat.ValueChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Tipe.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Layanan.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Hitung.Click
        ' Validasi menggunakan NumericUpDown.Value
        If Nmr_Berat.Value = 0 Or Combo_Tipe.SelectedIndex = -1 Or Combo_Layanan.SelectedIndex = -1 Then
            MsgBox("Mohon isi berat cucian, tipe cucian, dan layanan terlebih dahulu!", vbExclamation, "Peringatan")
            Return
        End If

        ' Mengambil nilai berat langsung sebagai Integer dari NumericUpDown
        Dim hargaTipe As Integer = 0
        If Combo_Tipe.SelectedItem.ToString() = "Cuci Lipat" Then
            hargaTipe = 13000
        ElseIf Combo_Tipe.SelectedItem.ToString() = "Cuci Setrika" Then
            hargaTipe = 17000
        End If

        Dim biayaLayanan As Integer = 0
        If Combo_Layanan.SelectedItem.ToString() = "Express" Then
            biayaLayanan = 4000
        Else
            biayaLayanan = 0
        End If

        Dim totalHarga As Integer = 0
        If Nmr_Berat.Value <= 5 Then
            totalHarga = hargaTipe + biayaLayanan
        Else
            totalHarga = hargaTipe + ((Nmr_Berat.Value - 5) * 5000) + biayaLayanan
        End If

        Lbl_Total.Text = "Rp " & totalHarga.ToString("#,##0")
        Lbl_Total.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        ' Validasi kelengkapan data
        If idPelangganSelected = 0 Or Lbl_Total.Text = "Rp 0" Or Combo_Tipe.SelectedIndex = -1 Or Combo_Layanan.SelectedIndex = -1 Then
            MsgBox("Data pesanan belum lengkap atau hitung total harga terlebih dahulu!", vbExclamation, "Peringatan")
            Return
        End If

        ' Pastikan KasirAktif tidak kosong untuk menghindari NullReferenceException pada ID Kasir
        If KasirAktif Is Nothing Then
            MsgBox("Sesi kasir tidak valid. Silakan login ulang.", vbCritical, "Error")
            Return
        End If

        ' Format tanggal masuk dan tanggal selesai
        Dim tglMasuk As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim hariSelesai As Integer = If(Combo_Layanan.SelectedItem.ToString() = "Express", 1, 3)
        Dim tglSelesai As String = DateTime.Now.AddDays(hariSelesai).ToString("yyyy-MM-dd")

        Try
            ' Perintah INSERT menggunakan Nmr_Berat.Value
            Dim query As String = "INSERT INTO pesanan (id_pelanggan, id_kasir, berat, tipe_cucian, layanan, total_harga, tanggal_masuk, tanggal_selesai, Status) VALUES (" &
                                  idPelangganSelected & ", " &
                                  "1" & ", " & 'KasirAktif.Id_Kasir & ", " &
                                  Nmr_Berat.Value & ", '" &
                                  Combo_Tipe.SelectedItem.ToString() & "', '" &
                                  Combo_Layanan.SelectedItem.ToString() & "', " &
                                  CInt(Lbl_Total.Text.Replace("Rp ", "").Replace(",", "")) & ", '" &
                                  tglMasuk & "', '" &
                                  tglSelesai & "', 'Proses')"

            da = New MySqlDataAdapter(query, conn)
            Dim dsInsert As New DataSet
            da.Fill(dsInsert, "pesanan")

            MsgBox("Pesanan berhasil disimpan", vbInformation, "Sukses")
            ClearForm()

        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menyimpan: " & ex.Message, vbCritical, "Error Database")
        End Try
    End Sub

    Sub ClearForm()
        Txt_NmPelanggan.Text = ""
        Txt_NoHp.Text = ""
        Nmr_Berat.Value = 0
        Combo_Tipe.SelectedIndex = -1
        Combo_Layanan.SelectedIndex = -1
        Lbl_Total.Text = "Rp 0"
        Lbl_Total.Visible = False
        idPelangganSelected = 0
        Txt_NmPelanggan.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Kembali.Click
        ClearForm()
        Me.Hide()
        MainMenu.Show()
    End Sub

    ' Sisa event handler lainnya dibiarkan tetap
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label6.Click, Label5.Click, Label7.Click
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub

    Private Sub MenuAkun_Click(sender As Object, e As EventArgs) Handles MenuAkun.Click
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
    End Sub

    Private Sub PELANGGAN_Click(sender As Object, e As EventArgs) Handles PELANGGAN.Click
    End Sub

    Private Sub TambahPelanggan_Click(sender As Object, e As EventArgs) Handles TambahPelanggan.Click
        Dim tambahPelangganForm As New TambahPelanggan()
        tambahPelangganForm.Show()
        Me.Hide()
    End Sub

    Private Sub EditPelanggan_Click(sender As Object, e As EventArgs) Handles EditPelanggan.Click
    End Sub

    Private Sub HapusPelanggan_Click(sender As Object, e As EventArgs) Handles HapusPelanggan.Click
    End Sub

    Private Sub DAFTARPESANAN_Click(sender As Object, e As EventArgs) Handles DAFTARPESANAN.Click
    End Sub

    Private Sub Lbl_total_Click(sender As Object, e As EventArgs) Handles Lbl_Total.Click

    End Sub
End Class