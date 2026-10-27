Imports MySql.Data.MySqlClient
Module Koneksi
    Dim conn As New MySqlConnection
    Dim constring As String = "server=localhost;user=root;password=;database=laundry;port=3306"
    Public Function getconn() As MySqlConnection
        Try

            conn = New MySqlConnection(constring)
        Catch ex As Exception
            MsgBox($"koneksi gagal: {ex.Message},harap periksa ulang file konfigurasi")
            Return Nothing
        End Try
        Return conn
    End Function
End Module
