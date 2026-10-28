Imports MySql.Data.MySqlClient
Module KasirDAO
    Function cekloginkasir(nama As String, password As String)
        Dim conn As MySqlConnection = getconn()
        Dim kasirAktif As Kasir = Nothing
        conn.Open()
        If conn IsNot Nothing Then
            Try
                Dim querry As String = "SELECT id_kasir, nama,Password FROM kasir where nama = @nama;"

                Using cmd As New MySqlCommand(querry, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            Dim passdb = reader("password").ToString()
                            If String.Equals(password, passdb, StringComparison.OrdinalIgnoreCase) Then

                                kasirAktif = New Kasir(
                                    Convert.ToInt32(reader("id_kasir")),
                                    reader("nama").ToString(),
                                    reader("password").ToString()
                                    )
                            Else
                                MsgBox("Kata sandi tidak ditemukan!!!")
                            End If
                        Else
                            MsgBox("Nama salah akun tidak ditemukan!!")

                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("gagal mengambil data :" & ex.Message)
            End Try
        End If
        conn.Close()
        Return kasirAktif
    End Function
End Module
