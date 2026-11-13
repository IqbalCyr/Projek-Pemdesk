Public Class customer

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Btn_Cari_Click(sender As Object, e As EventArgs) Handles Btn_Cari.Click

    End Sub

    Private Sub btnTambah_Paint(sender As Object, e As PaintEventArgs) Handles btnTambah.Paint
        Dim path As New Drawing2D.GraphicsPath
        Dim radius = 25
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btnTambah.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btnTambah.Width - radius, btnTambah.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btnTambah.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        btnTambah.Region = New Region(path)
    End Sub
End Class