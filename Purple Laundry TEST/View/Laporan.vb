Public Class Laporan
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click

    End Sub
    Private Sub btnEkspor_Paint(sender As Object, e As PaintEventArgs) Handles btnEkspor.Paint
        Dim path As New Drawing2D.GraphicsPath
        Dim radius = 25
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btnEkspor.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btnEkspor.Width - radius, btnEkspor.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btnEkspor.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        btnEkspor.Region = New Region(path)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class