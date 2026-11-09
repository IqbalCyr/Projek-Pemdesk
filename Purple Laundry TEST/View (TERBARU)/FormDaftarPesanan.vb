Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

' =====================================================================
'  FormDaftarPesanan.vb  (code-behind)
'
'  NAMA CONTROL YANG DIASUMSIKAN (ubah di Properties > (Name) bila beda):
'    txtIDTransaksi : TextBox   di bawah label "ID Transaksi"
'    cmbStatus      : ComboBox  di sebelah label "Status"
'    btnUbah        : Button    "UBAH"
'    txtCari        : TextBox   di sebelah label "Cari"
'    btnCari        : Button    ikon kaca pembesar
'    lvPesanan      : ListView  (daftar pesanan)
'
'  PAKET YANG DIPERLUKAN:
'    NuGet > MySql.Data  (Project > Manage NuGet Packages)
' =====================================================================
Public Class FormDaftarPesanan

    ' Sesuaikan user/password dengan XAMPP/MariaDB kamu
    Private ReadOnly connStr As String =
        "server=localhost;port=3306;user id=root;password=;database=laundry;"

    Private ReadOnly budayaID As New CultureInfo("id-ID")

    ' ------------------------------------------------------------------
    '  LOAD FORM
    ' ------------------------------------------------------------------
    Private Sub FormDaftarPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        SetupStatus()
        LoadData()
    End Sub

    ' ------------------------------------------------------------------
    '  SETUP KONTROL
    ' ------------------------------------------------------------------
    Private Sub SetupListView()
        With lvPesanan
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .MultiSelect = False
            .HideSelection = False
            .Columns.Clear()
            .Columns.Add("ID", 50, HorizontalAlignment.Left)
            .Columns.Add("Pelanggan", 140, HorizontalAlignment.Left)
            .Columns.Add("Kasir", 80, HorizontalAlignment.Left)
            .Columns.Add("Layanan", 90, HorizontalAlignment.Left)
            .Columns.Add("Berat", 60, HorizontalAlignment.Right)
            .Columns.Add("Total", 85, HorizontalAlignment.Right)
            .Columns.Add("Tgl Masuk", 125, HorizontalAlignment.Left)
            .Columns.Add("Tgl Selesai", 125, HorizontalAlignment.Left)
            .Columns.Add("Status", 70, HorizontalAlignment.Left)
            .Columns.Add("Tgl Ambil", 125, HorizontalAlignment.Left)
        End With

        txtIDTransaksi.ReadOnly = True   ' ID diisi otomatis dari baris yang dipilih
    End Sub

    Private Sub SetupStatus()
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange(New Object() {"Proses", "Selesai", "Batal"})
        cmbStatus.SelectedIndex = -1
    End Sub

    ' ------------------------------------------------------------------
    '  TAMPILKAN DATA KE LISTVIEW (dengan filter pencarian opsional)
    ' ------------------------------------------------------------------
    Private Sub LoadData(Optional keyword As String = "")
        Dim sql As String =
            "SELECT t.id_transaksi, p.nama AS pelanggan, k.nama AS kasir, " &
            "       l.tipe_layanan, t.berat, t.total_harga, " &
            "       t.tanggal_transaksi, t.estimasi_selesai, t.status, t.tanggal_keluar " &
            "FROM transaksi t " &
            "JOIN pelanggan p ON t.id_pelanggan = p.id_pelanggan " &
            "JOIN kasir k     ON t.id_kasir     = k.id_kasir " &
            "JOIN layanan l   ON t.id_layanan   = l.id_layanan "

        Dim pakaiFilter As Boolean = Not String.IsNullOrWhiteSpace(keyword)
        If pakaiFilter Then
            sql &= "WHERE CAST(t.id_transaksi AS CHAR) LIKE @kw " &
                   "   OR p.nama LIKE @kw " &
                   "   OR k.nama LIKE @kw " &
                   "   OR l.tipe_layanan LIKE @kw " &
                   "   OR t.status LIKE @kw "
        End If
        sql &= "ORDER BY t.id_transaksi DESC"

        Try
            lvPesanan.BeginUpdate()
            lvPesanan.Items.Clear()

            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    If pakaiFilter Then
                        cmd.Parameters.AddWithValue("@kw", "%" & keyword.Trim() & "%")
                    End If

                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        While rd.Read()
                            Dim item As New ListViewItem(rd("id_transaksi").ToString())
                            item.SubItems.Add(rd("pelanggan").ToString())
                            item.SubItems.Add(rd("kasir").ToString())
                            item.SubItems.Add(rd("tipe_layanan").ToString())
                            item.SubItems.Add(rd("berat").ToString() & " kg")
                            item.SubItems.Add("Rp " & Convert.ToInt32(rd("total_harga")).ToString("N0", budayaID))
                            item.SubItems.Add(Convert.ToDateTime(rd("tanggal_transaksi")).ToString("dd/MM/yyyy HH:mm"))
                            item.SubItems.Add(Convert.ToDateTime(rd("estimasi_selesai")).ToString("dd/MM/yyyy"))
                            item.SubItems.Add(rd("status").ToString())

                            If IsDBNull(rd("tanggal_keluar")) Then
                                item.SubItems.Add("-")
                            Else
                                item.SubItems.Add(Convert.ToDateTime(rd("tanggal_keluar")).ToString("dd/MM/yyyy HH:mm"))
                            End If

                            ' Pewarnaan status agar mudah dibaca
                            Select Case rd("status").ToString()
                                Case "Selesai" : item.ForeColor = Color.SeaGreen
                                Case "Batal" : item.ForeColor = Color.Firebrick
                                Case Else : item.ForeColor = Color.Black
                            End Select

                            lvPesanan.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            lvPesanan.EndUpdate()
        End Try
    End Sub

    ' ------------------------------------------------------------------
    '  PILIH BARIS -> ISI ID TRANSAKSI & STATUS
    ' ------------------------------------------------------------------
    Private Sub lvPesanan_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lvPesanan.SelectedIndexChanged

        If lvPesanan.SelectedItems.Count = 0 Then Return

        Dim item As ListViewItem = lvPesanan.SelectedItems(0)
        txtIDTransaksi.Text = item.SubItems(0).Text
        cmbStatus.SelectedItem = item.SubItems(8).Text   ' kolom "Status"
    End Sub

    ' ------------------------------------------------------------------
    '  TOMBOL UBAH -> UPDATE STATUS
    ' ------------------------------------------------------------------
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrWhiteSpace(txtIDTransaksi.Text) Then
            MessageBox.Show("Pilih transaksi dari daftar terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Pilih status baru terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi = MessageBox.Show(
            $"Ubah status transaksi #{txtIDTransaksi.Text} menjadi ""{cmbStatus.Text}""?",
            "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi <> DialogResult.Yes Then Return

        ' Jika Selesai -> tanggal_keluar diisi waktu sekarang (tidak ditimpa bila sudah ada)
        ' Jika Proses / Batal -> tanggal_keluar dikosongkan (NULL)
        Dim sql As String =
            "UPDATE transaksi " &
            "SET status = @status, " &
            "    tanggal_keluar = IF(@status = 'Selesai', COALESCE(tanggal_keluar, NOW()), NULL) " &
            "WHERE id_transaksi = @id"

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDTransaksi.Text))

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Status berhasil diubah.", "Sukses",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Transaksi tidak ditemukan.", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

            LoadData(txtCari.Text)
            ResetInput()

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah status: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------------------------------------------------------
    '  PENCARIAN
    ' ------------------------------------------------------------------
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadData(txtCari.Text)
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        LoadData(txtCari.Text)   ' pencarian langsung saat mengetik
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadData(txtCari.Text)
        End If
    End Sub

    ' ------------------------------------------------------------------
    '  BANTUAN
    ' ------------------------------------------------------------------
    Private Sub ResetInput()
        txtIDTransaksi.Clear()
        cmbStatus.SelectedIndex = -1
    End Sub

End Class