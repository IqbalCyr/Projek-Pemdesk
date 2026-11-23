Public Class Transaksi
    Private _daftarTransaksiAsli As New List(Of transaksimdl)()
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        LoadDataTransaksi()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    End Sub

    Private Sub btnTambah_Paint(sender As Object, e As PaintEventArgs) Handles btnTambah.Paint
        Dim path As New Drawing2D.GraphicsPath
        Dim radius = 25
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btnTambah.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btnTambah.Width - radius, btnTambah.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btnTambah.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        btnTambah.Region = New Region(path)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub







    'procedure
    Private Sub SetupDataGridView()
        DataGridView1.AutoGenerateColumns = False

        ' Sesuaikan index (0 s/d 6) dengan urutan kolom di gambar:
        ' 0: Transaksi | 1: Tanggal | 2: Nama Pelanggan | 3: Total Harga | 4: Pembayaran | 5: Status | 6: Aksi
        DataGridView1.Columns(0).DataPropertyName = "No_Nota"
        DataGridView1.Columns(1).DataPropertyName = "Tanggal_trx"
        DataGridView1.Columns(2).DataPropertyName = "Cust"
        DataGridView1.Columns(3).DataPropertyName = "Total_Harga"
        DataGridView1.Columns(4).DataPropertyName = "Status_pembayaran"
        DataGridView1.Columns(5).DataPropertyName = "Status"

        ' Format tampilan tanggal dan mata uang (opsional tapi disarankan)
        DataGridView1.Columns(1).DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"

        ' Atur teks tombol pada kolom Aksi (index 6)
        Dim btnCol As DataGridViewButtonColumn = TryCast(DataGridView1.Columns(6), DataGridViewButtonColumn)
        If btnCol IsNot Nothing Then
            btnCol.Text = "Ubah Status"
            btnCol.UseColumnTextForButtonValue = True
        End If
    End Sub

    ' 2. Ambil data dari TransaksiDAO dan tampilkan ke DataGridView1
    Private Sub LoadDataTransaksi()
        Try
            _daftarTransaksiAsli = TransaksiDAO.getAlltransaksi()
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = _daftarTransaksiAsli
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 3. Logika Pencarian (Bisa dipanggil lewat klik btn_Cari atau saat mengetik di txtCari)
    Private Sub CariData()
        Dim keyword As String = txtCari.Text.Trim().ToLower()

        If String.IsNullOrEmpty(keyword) Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = _daftarTransaksiAsli
        Else
            ' Filter berdasarkan Nama Pelanggan (atau No_Nota jika diperlukan)
            Dim hasilFilter = _daftarTransaksiAsli.Where(Function(t) _
                (t.Cust IsNot Nothing AndAlso t.Cust.ToLower().Contains(keyword)) OrElse
                (t.No_Nota IsNot Nothing AndAlso t.No_Nota.ToLower().Contains(keyword))
            ).ToList()

            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = hasilFilter
        End If
    End Sub

    ' Event saat tombol cari diklik
    Private Sub btn_Cari_Click(sender As Object, e As EventArgs) Handles Btn_Cari.Click
        CariData()
    End Sub

    ' Event real-time saat mengetik di txtCari (opsional, hapus jika hanya ingin via tombol)
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        CariData()
    End Sub

    ' 4. Event saat tombol di kolom "Aksi" (index 6) diklik
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Abaikan jika header diklik atau bukan kolom Aksi (index 6)
        If e.RowIndex < 0 OrElse e.ColumnIndex <> 6 Then Exit Sub

        ' Ambil objek transaksimdl dari baris yang diklik
        Dim trxTerpilih As transaksimdl = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, transaksimdl)

        ' --- CONTOH AKSI: Ubah status transaksi ---
        ' Silakan sesuaikan dengan alur aplikasi kamu (misal buka Form Edit atau langsung update)
        MessageBox.Show($"Transaksi dipilih: {trxTerpilih.No_Nota} ({trxTerpilih.Cust})", "Info")

        ' Jika data diubah langsung pada objek trxTerpilih lalu disimpan ke DAO:
        ' TransaksiDAO.updateTransaksi(trxTerpilih)
        ' DataGridView1.InvalidateRow(e.RowIndex)
    End Sub
End Class