Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel4_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlChart.Paint

    End Sub

    Private Sub Panel4_Paint_2(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub


    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class