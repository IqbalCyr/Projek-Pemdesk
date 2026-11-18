Imports MySql.Data.MySqlClient
Module UsersDAO
    Function cekloginkasir(nama As String, password As String)
        Dim conn As MySqlConnection = getconn()
        Dim kasirAktif As Kasir = Nothing
        conn.Open()
        If conn IsNot Nothing Then
            Try
                Dim querry As String = "SELECT id_User, username,nama_lengkap,no_hp,Password,alamat,role FROM users where username = @nama;"

                Using cmd As New MySqlCommand(querry, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            Dim passdb = reader("password").ToString()
                            If String.Equals(password, passdb, StringComparison.OrdinalIgnoreCase) Then

                                kasirAktif = New Kasir(
                                    Convert.ToInt32(reader("id_User")),
                                    reader("username").ToString(),
                                    reader("password").ToString(),
                                    reader("role").ToString(),
                                    reader("nama_lengkap").ToString(),
                                    reader("no_hp").ToString(),
                                    reader("alamat").ToString()
                                    )
                            Else
                                MsgBox("Kata sandi salah!!!")
                            End If
                        Else
                            MsgBox("Nama Akun tersebut tidak terdaftar!!!")

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
