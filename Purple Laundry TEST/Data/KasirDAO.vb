Imports MySql.Data.MySqlClient
Module KasirDAO
    Function cekloginkasir(nama As String, password As String)
        Dim conn As MySqlConnection = getconn()
        If conn IsNot Nothing Then
            Try
                Dim querry As String = "SELECT id_kasir, nama,Password FROM kasir where nama = @nama and password = @pass;"
                Dim kasir As Kasir = Nothing

                Using cmd As New MySqlCommand(querry, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@pass", password)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                    End Using
                End Using
            Catch ex As Exception

            End Try
        End If
    End Function
End Module
