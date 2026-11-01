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
        For Each row As DataRow In ds.Tables("tabelPelanggan").Rows
            coll.Add(row("nama").ToString())
        Next

        Txt_NmPelanggan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txt_Berat.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Tipe.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Layanan.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txt_Total.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Hitung.Click
        If Txt_Berat.Text = "" Or Combo_Tipe.SelectedIndex = -1 Or Combo_Layanan.SelectedIndex = -1 Then
            MsgBox("Mohon isi berat cucian, tipe cucian, dan layanan terlebih dahulu!", vbExclamation, "Peringatan")
            Return
        End If

        ' Berat tipe data float, tapi dihitung sebagai integer (pembulatan/konversi ke int)
        Dim beratFloat As Single = Val(Txt_Berat.Text)
            Dim beratInt As Integer = CInt(Math.Floor(beratFloat)) ' atau CInt(beratFloat) sesuai kebutuhan

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

            ' Rumus Total Harga sesuai ketentuan
            If beratInt <= 5 Then
                totalHarga = hargaTipe + biayaLayanan
            Else
                totalHarga = hargaTipe + ((beratInt - 5) * 5000) + biayaLayanan
            End If

        Txt_Total.Text = totalHarga.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        If idPelangganSelected = 0 Or Txt_Total.Text = "" Or Combo_Tipe.SelectedIndex = -1 Or Combo_Layanan.SelectedIndex = -1 Then
            MsgBox("Data pesanan belum lengkap atau hitung total harga terlebih dahulu!", vbExclamation, "Peringatan")
            Return
        End If
        ' Format tanggal masuk dan tanggal selesai
        Dim tglMasuk As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim hariSelesai As Integer = If(Combo_Layanan.SelectedItem.ToString() = "Express", 1, 3)
            Dim tglSelesai As String = DateTime.Now.AddDays(hariSelesai).ToString("yyyy-MM-dd")

            ' Menggunakan MySqlDataAdapter dengan string perintah INSERT langsung sesuai gaya dosen
            da = New MySqlDataAdapter("INSERT INTO pesanan (id_pelanggan, id_kasir, berat, tipe_cucian, layanan, total_harga, tanggal_masuk, tanggal_selesai, Status) VALUES ('" & CInt(idPelangganSelected) & "', '" & CInt(KasirAktif.Id_Kasir) & "', '" & CType(Val(Txt_Berat.Text), Single) & "', '" & CStr(Combo_Tipe.SelectedItem.ToString()) & "', '" & CType(Combo_Layanan.SelectedItem.ToString(), String) & "', '" & CInt(Txt_Total.Text) & "', '" & tglMasuk & "', '" & tglSelesai & "', 'Proses')", conn)

            Dim dsInsert As New DataSet
            da.Fill(dsInsert, "pesanan")

            MsgBox("Pesanan berhasil disimpan")
        ClearForm()

    End Sub

    Sub ClearForm()
        Txt_NmPelanggan.Text = ""
        Txt_NoHp.Text = ""
        Txt_Berat.Text = ""
        Combo_Tipe.SelectedIndex = -1
        Combo_Layanan.SelectedIndex = -1
        Txt_Total.Text = ""
        idPelangganSelected = 0
        Txt_NmPelanggan.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Kembali.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
