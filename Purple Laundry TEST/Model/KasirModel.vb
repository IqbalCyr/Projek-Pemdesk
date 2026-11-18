Module KasirModel
    Public Class Kasir
        'atribut dari obj kasir
        Private _id_kasir As Integer
        Private _nama As String
        Private _password As String
        Private _role As String
        Private _namalengkap As String
        Private _nohp As String
        Private _alamat As String

        Public Property Nohp As String
            Get
                Return _nohp
            End Get
            Set(value As String)
                _nohp = value
            End Set
        End Property

        Public Property Alamat As String
            Get
                Return _alamat
            End Get
            Set(value As String)
                _alamat = value
            End Set
        End Property
        Public Property Id_Kasir As Integer
            'setter dan getter dari atribut id_kasir 
            Get
                Return _id_kasir
            End Get
            Set(value As Integer)
                _id_kasir = value
            End Set
        End Property

        Public Property Nama As String
            'setter dan getter dari atribut nama
            Get
                Return _nama
            End Get
            Set(value As String)
                _nama = value
            End Set
        End Property
        Public Property Password As String
            Get
                Return _password
            End Get
            Set(value As String)
                _password = value
            End Set
        End Property
        Public Property Namalengkap As String
            Get
                Return _namalengkap
            End Get
            Set(value As String)
                _namalengkap = value
            End Set
        End Property
        Public Property Role As String
            Get
                Return _role
            End Get
            Set(value As String)
                _role = value
            End Set
        End Property
        Public Sub New(id As Integer, nama As String, pass As String, role As String, namalengkap As String, nohp As String, alamat As String)
            Me._id_kasir = id
            Me._nama = nama
            Me._password = pass
            Me._role = role
            Me._namalengkap = namalengkap
            Me._nohp = nohp
            Me._alamat = alamat
        End Sub
    End Class
End Module
