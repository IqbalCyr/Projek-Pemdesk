Module PesananController
    Public listpesanan
    Public Function loadpesanan()
        Dim listpesanan = cekpesanandb()
        Return listpesanan
    End Function

End Module
