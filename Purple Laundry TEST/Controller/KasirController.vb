Module KasirController
    Public Function loggin(nama As String, Password As String)
        Dim namaBersih = nama.Trim()
        Dim passwordBersih = Password.Trim()

        Dim KasirAktif As Kasir = cekloginkasir(namaBersih, passwordBersih)
        Return kasirAktif
    End Function
End Module
