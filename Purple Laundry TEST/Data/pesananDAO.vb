Imports MySql.Data.MySqlClient

Module pesananDAO
    Public Function cekpesanandb()
        Dim dtData = Nothing
        Dim query As String = "SELECT p.id_pesanan, pel.nama AS nama_pelanggan, k.nama AS nama_kasir, p.berat, p.tipe_cucian, p.layanan, p.total_harga, p.tanggal_masuk, p.tanggal_selesai, p.Status FROM pesanan p JOIN pelanggan pel ON p.id_pelanggan = pel.id_pelanggan JOIN kasir k ON p.id_kasir = k.id_kasir"
        Try
            dtData = New DataTable()
            Using conn As MySqlConnection = getconn()
                Using cmd As New MySqlCommand(query, conn)
                    ' MySqlDataAdapter otomatis membuka dan menutup koneksi saat fungsi Fill dijalankan
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dtData)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengambil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Mengembalikan tabel yang sudah berisi data
        Return dtData
    End Function
End Module
