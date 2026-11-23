Public Class form2
    Dim listtrx As List(Of transaksimdl) = TransaksiDAO.getAlltransaksi()

    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = listtrx
    End Sub
End Class