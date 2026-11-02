Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        MenuAkun.Text = KasirAktif.Nama
        listpesanan = loadpesanan()

        If listpesanan Is Nothing Then
            ListView1.Hide()
            Button1.Hide()
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            ComboBox1.Hide()
            TextBox1.Hide()
            TextBox2.Hide()
        Else
            Judul.Hide()
            ' Panggil sub untuk menampilkan data awal ke ListView
            TampilkanDataKeListView(listpesanan)
        End If
    End Sub

    ' --- SUB TERPISAH UNTUK MENAMPILKAN DATA KE LISTVIEW ---
    Private Sub TampilkanDataKeListView(ByVal dt As DataTable)
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ' Bersihkan kolom dan item lama
        ListView1.Columns.Clear()
        ListView1.Items.Clear()

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' 1. Buat Header Kolom secara dinamis
            For Each col As DataColumn In dt.Columns
                Dim namaKolom As String = col.ColumnName.Replace("_", " ")
                ListView1.Columns.Add(namaKolom, 120)
            Next

            ' 2. Masukkan Baris Data ke ListView
            For Each row As DataRow In dt.Rows
                Dim lvi As New ListViewItem(row(0).ToString())

                For i As Integer = 1 To dt.Columns.Count - 1
                    If dt.Columns(i).DataType Is GetType(DateTime) AndAlso Not IsDBNull(row(i)) Then
                        lvi.SubItems.Add(Convert.ToDateTime(row(i)).ToString("yyyy-MM-dd"))
                    Else
                        lvi.SubItems.Add(row(i).ToString())
                    End If
                Next
                ListView1.Items.Add(lvi)
            Next
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Pesanan.Click
        Me.Hide()
        FormBuatPesanan.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Jika kedua input kosong, kembalikan tampilan ke semua data dan hentikan proses
        If String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MsgBox("Mohon isi ID pesanan atau nama pembeli terlebih dahulu", MsgBoxStyle.Information, "Peringatan")
            TampilkanDataKeListView(listpesanan) ' Reset ListView ke data penuh
            Exit Sub ' Hentikan eksekusi agar tidak memproses filter kosong
        End If

        If listpesanan Is Nothing OrElse listpesanan.Rows.Count = 0 Then Exit Sub

        ' 2. Filter menggunakan DataView
        Dim dv As New DataView(listpesanan)
        Dim kriteriaFilter As New List(Of String)

        ' Filter berdasarkan ID Pesanan (ID_Nota)
        Dim idPesanan As String = TextBox1.Text.Trim()
        If idPesanan <> "" Then
            kriteriaFilter.Add("Convert(ID_Nota, 'System.String') LIKE '%" & idPesanan & "%'")
        End If

        ' Filter berdasarkan Nama Pelanggan atau Kasir
        Dim namaCari As String = TextBox2.Text.Trim()
        If namaCari <> "" Then
            kriteriaFilter.Add("(Nama_Pelanggan LIKE '%" & namaCari & "%' OR Nama_Kasir LIKE '%" & namaCari & "%')")
        End If

        ' 3. Gabungkan kriteria filter
        Dim filterString As String = String.Join(" AND ", kriteriaFilter)
        dv.RowFilter = filterString

        ' 4. Tampilkan hasil pencarian ke ListView
        TampilkanDataKeListView(dv.ToTable())
    End Sub

End Class