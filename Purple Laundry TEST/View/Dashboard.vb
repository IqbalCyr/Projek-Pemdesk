Public Class Dashboard
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub pnlPelanggan_Paint(sender As Object, e As PaintEventArgs) Handles pnlPelanggan.Paint
        Dim path As New Drawing2D.GraphicsPath
        Dim radius = 25
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(pnlPelanggan.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(pnlPelanggan.Width - radius, pnlPelanggan.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, pnlPelanggan.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        pnlPelanggan.Region = New Region(path)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub pnlProses_Paint(sender As Object, e As PaintEventArgs) Handles pnlProses.Paint
        Dim path As New Drawing2D.GraphicsPath
        Dim radius = 25
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(pnlProses.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(pnlProses.Width - radius, pnlProses.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, pnlProses.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        pnlProses.Region = New Region(path)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub pnlDiambil_Paint(sender As Object, e As PaintEventArgs) Handles pnlDiambil.Paint
        Dim path As New Drawing2D.GraphicsPath
        Dim radius = 25
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(pnlDiambil.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(pnlDiambil.Width - radius, pnlDiambil.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, pnlDiambil.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        pnlDiambil.Region = New Region(path)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pnlDashboard_Paint(sender As Object, e As PaintEventArgs) Handles pnlDashboard.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class