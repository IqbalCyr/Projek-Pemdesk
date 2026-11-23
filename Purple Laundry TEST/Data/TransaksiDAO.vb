Imports MySql.Data.MySqlClient

Module TransaksiDAO

    Public Function getAlltransaksi() As List(Of transaksimdl)

        Dim daftarTransaksi As New List(Of transaksimdl)()
        ' Gunakan JOIN agar id_cust, id_layanan, dan id_user langsung tampil namanya
        Dim query As String = "SELECT t.id_transaksi, t.no_nota, c.nama AS nama_cust, " &
                              "l.nama_layanan, u.nama_lengkap AS nama_user, t.qty, t.harga_satuan, " &
                              "t.is_express, t.diskon, t.total_harga, t.tanggal_trx, " &
                              "t.tanggal_estimasi_selesai, t.status, t.status_pembayaran " &
                              "FROM transaksi t " &
                              "LEFT JOIN customers c ON t.id_cust = c.id_cust " &
                              "LEFT JOIN layanan l ON t.id_layanan = l.id_layanan " &
                              "LEFT JOIN users u ON t.id_user = u.id_user " &
                              "ORDER BY t.id_transaksi DESC"

        Dim conn = getconn()
        conn.Open()
        Using cmd As New MySqlCommand(query, conn)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim trx As New transaksimdl With {
                            .Id_transaksi = Convert.ToInt32(reader("id_transaksi")),
                            .No_Nota = reader("no_nota").ToString(),
                            .Cust = reader("nama_cust").ToString(),
                            .Layanan = reader("nama_layanan").ToString(),
                            .User = reader("nama_user").ToString(),
                            .Qty = Convert.ToDecimal(reader("qty")),
                            .Harga_satuan = Convert.ToDecimal(reader("harga_satuan")),
                            .Is_expres = Convert.ToBoolean(reader("is_express")),
                            .Diskon = Convert.ToDecimal(reader("diskon")),
                            .Total_Harga = Convert.ToDecimal(reader("total_harga")),
                            .Tanggal_trx = Convert.ToDateTime(reader("tanggal_trx")),
                            .Tanggal_estimasi_selesai = Convert.ToDateTime(reader("tanggal_estimasi_selesai")),
                            .Status = reader("status").ToString(),
                            .Status_pembayaran = reader("status_pembayaran").ToString()
                        }
                    daftarTransaksi.Add(trx)
                End While
            End Using
        End Using
        conn.Close()
        Return daftarTransaksi
    End Function
End Module
