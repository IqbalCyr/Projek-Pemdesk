Imports MySql.Data.MySqlClient

Module transaksimodel
    Public Class transaksimdl

        Private _id_transaksi As Integer
        Private _no_nota As String
        Private _cust As String
        Private _layanan As String
        Private _user As String
        Private _qty As Decimal
        Private _harga_satuan As Decimal
        Private _is_expres As Boolean
        Private _diskon As Decimal
        Private _total_harga As Decimal
        Private _tanggal_trx As DateTime
        Private _tanggal_estimasi_selesai As Date
        Private _tanggal_selesai As Date
        Private _tanggal_diambil As Date
        Private _status As String
        Private _status_pembayaran As String
        Private _catatan As String

        Public Property Id_transaksi As Integer
            Get
                Return _id_transaksi
            End Get
            Set(value As Integer)
                _id_transaksi = value
            End Set
        End Property

        Public Property Cust As String
            Get
                Return _cust
            End Get
            Set(value As String)
                _cust = value
            End Set
        End Property

        Public Property Layanan As String
            Get
                Return _layanan
            End Get
            Set(value As String)
                _layanan = value
            End Set
        End Property
        Public Property User As String
            Get
                Return _user
            End Get
            Set(value As String)
                _user = value
            End Set
        End Property

        Public Property Qty As Decimal
            Get
                Return _qty
            End Get
            Set(value As Decimal)
                _qty = value
            End Set
        End Property

        Public Property Harga_satuan As Decimal
            Get
                Return _harga_satuan
            End Get
            Set(value As Decimal)
                _harga_satuan = value
            End Set
        End Property
        Public Property Is_expres As Boolean
            Get
                Return _is_expres
            End Get
            Set(value As Boolean)
                _is_expres = value
            End Set
        End Property
        Public Property Diskon As Decimal
            Get
                Return _diskon
            End Get
            Set(value As Decimal)
                _diskon = value
            End Set
        End Property
        Public Property Total_Harga As Decimal
            Get
                Return _total_harga
            End Get
            Set(value As Decimal)
                _total_harga = value
            End Set
        End Property
        Public Property Tanggal_trx As DateTime
            Get
                Return _tanggal_trx
            End Get
            Set(value As DateTime)
                _tanggal_trx = value
            End Set
        End Property

        Public Property Tanggal_estimasi_selesai As Date
            Get
                Return _tanggal_estimasi_selesai
            End Get
            Set(value As Date)
                _tanggal_estimasi_selesai = value
            End Set
        End Property

        Public Property Tanggal_selesai As Date
            Get
                Return _tanggal_selesai
            End Get
            Set(value As Date)
                _tanggal_selesai = value
            End Set
        End Property

        Public Property Tanggal_diambil As Date
            Get
                Return _tanggal_diambil
            End Get
            Set(value As Date)
                _tanggal_diambil = value
            End Set
        End Property

        Public Property Status As String
            Get
                Return _status
            End Get
            Set(value As String)
                _status = value
            End Set
        End Property

        Public Property Status_pembayaran As String
            Get
                Return _status_pembayaran
            End Get
            Set(value As String)
                _status_pembayaran = value
            End Set
        End Property

        Public Property Catatan As String
            Get
                Return _catatan
            End Get
            Set(value As String)
                _catatan = value
            End Set
        End Property
        Public Property No_Nota As String
            Get
                Return _no_nota
            End Get
            Set(value As String)
                _no_nota = value
            End Set
        End Property

        Public Sub New()
            ' Konstruktor kosong
        End Sub

        Public Sub New(idTransaksi As Integer,
               noNota As String,
               cust As String,
               layanan As String,
               user As String,
               qty As Decimal,
               hargaSatuan As Decimal,
               isExpres As Boolean,
               diskon As Decimal,
               totalHarga As Decimal,
               tanggalTrx As DateTime,
               tanggalEstimasiSelesai As DateTime,
               status As String,
               statusPembayaran As String)

            Me.Id_transaksi = idTransaksi
            Me.No_Nota = noNota
            Me.Cust = cust
            Me.Layanan = layanan
            Me.User = user
            Me.Qty = qty
            Me.Harga_satuan = hargaSatuan
            Me.Is_expres = isExpres
            Me.Diskon = diskon
            Me.Total_Harga = totalHarga
            Me.Tanggal_trx = tanggalTrx
            Me.Tanggal_estimasi_selesai = tanggalEstimasiSelesai
            Me.Status = status
            Me.Status_pembayaran = statusPembayaran
        End Sub
    End Class
End Module
