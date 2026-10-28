Module KasirModel
    Public Class Kasir
        'atribut dari obj kasir
        Private _id_kasir As Integer
        Private _nama As String
        Private _password As String

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
        Public Sub New(id As Integer, nama As String, pass As String)
            Me._id_kasir = id
            Me._nama = nama
            Me._password = pass
        End Sub
    End Class
End Module
