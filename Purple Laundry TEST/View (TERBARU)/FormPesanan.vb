Imports MySql.Data.MySqlClient

Public Class FormPesanan
    Dim conn As MySqlConnection = getconn()
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter

    Dim idPelangganSelected As Integer = 0
    Dim totalHargaVal As Integer = 0

    Sub LoadAutoCompletePelanggan()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT * FROM pelanggan", conn)
        da.Fill(ds, "tabelPelanggan")
        Dim coll As New AutoCompleteStringCollection()
        For Each row As DataRow In ds.Tables("tabelPelanggan").Rows
            coll.Add(row("nama").ToString())
        Next

        Txt_NmPelanggan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Txt_NmPelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource
        Txt_NmPelanggan.AutoCompleteCustomSource = coll
    End Sub

    Sub LoadComboBoxLayanan()
        ' Mengisi Combo Tipe/Layanan dari tabel 'layanan'
        If ds.Tables("layanan") IsNot Nothing Then ds.Tables("layanan").Clear()
        da = New MySqlDataAdapter("SELECT * FROM layanan", conn)
        da.Fill(ds, "layanan")

        Combo_Tipe.Items.Clear()
        For Each row As DataRow In ds.Tables("layanan").Rows
            Combo_Tipe.Items.Add(row("tipe_cucian").ToString())
        Next

        ' Pastikan Combo Layanan (Express / Reguler) juga terisi jika belum diatur di designer
        If Combo_Layanan.Items.Count = 0 Then
            Combo_Layanan.Items.Add("Reguler")
            Combo_Layanan.Items.Add("Express")
        End If
    End Sub

    Sub ClearForm()
        Txt_NmPelanggan.Text = ""
        Txt_HpPealnggan.Text = ""
        Nmr_Berat.Value = 0
        Combo_Tipe.SelectedIndex = -1
        Combo_Layanan.SelectedIndex = -1
        totalHargaVal = 0
        Lbl_TotalHarga.Text = ""
        Lbl_TotalHarga.Visible = False

        ' Reset tanggal ke hari ini
        DT_TanggalMasuk.Value = DateTime.Now
        DT_TanggalSelesai.Value = DateTime.Now

        Txt_NmPelanggan.Focus()
    End Sub

    Private Sub FormPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAutoCompletePelanggan()
        LoadComboBoxLayanan()

        ' Sembunyikan label total harga saat form pertama kali dimuat
        Lbl_TotalHarga.Visible = False

        ' Set Tanggal Masuk otomatis ke hari ini dan non-aktifkan (read-only)
        DT_TanggalMasuk.Value = DateTime.Now
        DT_TanggalMasuk.Enabled = False

        ' Non-aktifkan Tanggal Selesai karena dihitung otomatis oleh sistem
        DT_TanggalSelesai.Enabled = False
    End Sub

    Private Sub FormPesanan_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Private Sub Txt_NmPelanggan_TextChanged(sender As Object, e As EventArgs) Handles Txt_NmPelanggan.TextChanged
        Dim foundRows() As DataRow
        foundRows = ds.Tables("tabelPelanggan").Select("nama = '" & Txt_NmPelanggan.Text.Replace("'", "''") & "'")

        If foundRows.Length > 0 Then
            Txt_HpPealnggan.Text = foundRows(0)("no_hp").ToString()
            idPelangganSelected = Convert.ToInt32(foundRows(0)("id_pelanggan"))
        Else
            Txt_HpPealnggan.Text = ""
            idPelangganSelected = 0
        End If
    End Sub

    ' Logika Otomatis Tanggal Selesai Berdasarkan Pilihan Layanan
    Private Sub Combo_Layanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Layanan.SelectedIndexChanged
        If Combo_Layanan.SelectedItem IsNot Nothing Then
            Dim pilihanLayanan As String = Combo_Layanan.SelectedItem.ToString()

            If pilihanLayanan = "Express" Then
                ' Express = 1 hari dari tanggal masuk
                DT_TanggalSelesai.Value = DT_TanggalMasuk.Value.AddDays(1)
            Else
                ' Reguler = 3 hari dari tanggal masuk
                DT_TanggalSelesai.Value = DT_TanggalMasuk.Value.AddDays(3)
            End If
        End If
    End Sub

    Private Sub Btn_Hitung_Click(sender As Object, e As EventArgs) Handles Btn_Hitung.Click
        ' Validasi input sebelum dihitung
        If Nmr_Berat.Value = 0 Or Combo_Tipe.SelectedIndex = -1 Or Combo_Layanan.SelectedIndex = -1 Then
            MsgBox("Mohon isi berat cucian, tipe cucian, dan layanan terlebih dahulu!", vbExclamation, "Peringatan")
            Return
        End If

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

        ' Hitung total harga berdasarkan berat (misal > 5kg ada penambahan tarif)
        Dim beratInt As Integer = CInt(Nmr_Berat.Value)
        If beratInt <= 5 Then
            totalHargaVal = hargaTipe + biayaLayanan
        Else
            totalHargaVal = hargaTipe + ((beratInt - 5) * 5000) + biayaLayanan
        End If

        ' Tampilkan ke Label Total Harga dan ubah Visible menjadi True
        Lbl_TotalHarga.Text = "Rp " & totalHargaVal.ToString("#,##0")
        Lbl_TotalHarga.Visible = True
    End Sub

    Private Sub Btn_Simpan_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        If idPelangganSelected = 0 Or totalHargaVal = 0 Or Combo_Tipe.SelectedIndex = -1 Or Combo_Layanan.SelectedIndex = -1 Then
            MsgBox("Data belum lengkap atau silakan klik tombol Hitung terlebih dahulu!", vbExclamation, "Peringatan")
            Return
        End If

        If KasirAktif Is Nothing Then
            MsgBox("Sesi kasir tidak valid. Silakan login ulang.", vbCritical, "Error")
            Return
        End If

        ' Mengambil nilai tanggal langsung dari komponen DateTimePicker yang sudah diatur otomatis
        Dim tglTransaksi As String = DT_TanggalMasuk.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim estimasiSelesai As String = DT_TanggalSelesai.Value.ToString("yyyy-MM-dd")

        ' Ambil id_layanan dari tabel layanan (sesuaikan relasi ID jika diperlukan)
        Dim idLayananSelected As Integer = 1

        Try
            Dim query As String = "INSERT INTO transaksi (id_pelanggan, id_kasir, id_layanan, berat, total_harga, tanggal_transaksi, estimasi_selesai, status) " &
                                  "VALUES (" & idPelangganSelected & ", " &
                                  KasirAktif.Id_Kasir & ", " &
                                  idLayananSelected & ", " &
                                  CInt(Nmr_Berat.Value) & ", " &
                                  totalHargaVal & ", '" &
                                  tglTransaksi & "', '" &
                                  estimasiSelesai & "', 'Proses')"

            da = New MySqlDataAdapter(query, conn)
            Dim dsInsert As New DataSet
            da.Fill(dsInsert, "transaksi")

            MsgBox("Transaksi berhasil disimpan!", vbInformation, "Sukses")
            ClearForm()

        Catch ex As Exception
            MsgBox("Gagal menyimpan transaksi: " & ex.Message, vbCritical, "Error Database")
        End Try
    End Sub

    Private Sub Btn_Bersih_Click(sender As Object, e As EventArgs) Handles Btn_Bersih.Click
        ClearForm()
    End Sub

    ' Event handler kosong pendukung kontrol lainnya
    Private Sub FormPesanan_Resize_1(sender As Object, e As EventArgs) Handles Me.Resize
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txt_HpPealnggan.TextChanged
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles Nmr_Berat.ValueChanged
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Tipe.SelectedIndexChanged
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DT_TanggalMasuk.ValueChanged
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DT_TanggalSelesai.ValueChanged
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Mengambil induk form (FormMenu) dan memanggil fungsi pembuka FormPelanggan di Panel4
        Dim menuUtama As FormMenu = TryCast(Me.ParentForm, FormMenu)
        If menuUtama IsNot Nothing Then
            menuUtama.BukaFormPelanggan()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class