Imports System.Drawing.Drawing2D

Public Class Menu
    ' Simpan referensi tombol yang sedang aktif
    Private activeButton As Button = Nothing

    ' Warna teks/ikon aktif (biru tua) dan non-aktif (putih)
    Private activeColor As Color = Color.FromArgb(0, 96, 130)
    Private inactiveColor As Color = Color.White

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Dashboard
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel6.Controls.Add(Dashboard)
            .BringToFront()
            .Show()
        End With

        SetActiveButton(btnDashboard)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        SetActiveButton(btnDashboard)
        BukaFormChild(Dashboard)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        SetActiveButton(btnCustomer)
        BukaFormChild(customer)
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        SetActiveButton(btnTransaksi)
        ' BukaFormChild(Transaksi)
    End Sub

    Private Sub btnPengeluaran_Click(sender As Object, e As EventArgs) Handles btnPengeluaran.Click
        SetActiveButton(btnPengeluaran)
        ' BukaFormChild(Pengeluaran)
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        SetActiveButton(btnLaporan)
        ' BukaFormChild(Laporan)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BukaFormChild(childForm As Form)
        Panel6.Controls.Clear()
        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel6.Controls.Add(childForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' --- FUNGSI MENGATUR TOMBOL AKTIF ---
    Private Sub SetActiveButton(targetButton As Button)
        Dim allButtons() As Button = {btnDashboard, btnCustomer, btnTransaksi, btnPengeluaran, btnLaporan}

        ' 1. Reset semua tombol menjadi transparan
        For Each btn As Button In allButtons
            btn.BackColor = Color.Transparent
            btn.ForeColor = inactiveColor
            btn.Region = Nothing
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 255, 255, 255)
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent
            If btn.Image IsNot Nothing Then
                btn.Image = RecolorImage(btn.Image, inactiveColor)
            End If
            btn.Invalidate() ' Hapus gambar kapsul putih dari tombol lama
        Next

        ' 2. Tandai tombol aktif (tetap BackColor = Transparent, kapsul putih digambar lewat Paint)
        activeButton = targetButton
        activeButton.BackColor = Color.Transparent
        activeButton.ForeColor = activeColor
        activeButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        activeButton.FlatAppearance.MouseDownBackColor = Color.Transparent

        If activeButton.Image IsNot Nothing Then
            activeButton.Image = RecolorImage(activeButton.Image, activeColor)
        End If

        activeButton.Invalidate() ' Picu event Paint untuk menggambar kapsul halus
    End Sub

    ' --- MENGGAMBAR KAPSUL PUTIH HALUS (ANTI-ALIASING) PADA TOMBOL AKTIF ---
    Private Sub MenuButton_Paint(sender As Object, e As PaintEventArgs) Handles btnDashboard.Paint, btnCustomer.Paint, btnTransaksi.Paint, btnPengeluaran.Paint, btnLaporan.Paint

        Dim btn = DirectCast(sender, Button)

        ' Hanya gambar kapsul putih jika tombol ini yang sedang aktif
        If btn Is activeButton Then
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

            ' Sedikit dikurangi 1px pada tinggi agar lengkungan atas/bawah tidak terpotong batas kontrol
            Dim bounds As New RectangleF(0, 0.5F, btn.Width, btn.Height - 1.0F)
            Dim radius = bounds.Height / 2.0F
            Dim diameter = radius * 2.0F

            Using path As New GraphicsPath
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90)
                path.AddLine(bounds.X + radius, bounds.Y, bounds.Right, bounds.Y)
                path.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Bottom)
                path.AddLine(bounds.Right, bounds.Bottom, bounds.X + radius, bounds.Bottom)
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90)
                path.CloseFigure()

                ' Gambar background putih mulus
                Using brush As New SolidBrush(Color.White)
                    e.Graphics.FillPath(brush, path)
                End Using
            End Using

            ' Gambar ulang ikon & teks di atas kapsul putih agar tidak tertutup
            Dim iconLeft = btn.Padding.Left + 15
            If btn.Image IsNot Nothing Then
                Dim iconY = (btn.Height - btn.Image.Height) \ 2
                e.Graphics.DrawImage(btn.Image, iconLeft, iconY, btn.Image.Width, btn.Image.Height)
                iconLeft += btn.Image.Width + 10
            End If

            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font,
                New Rectangle(iconLeft, 0, btn.Width - iconLeft, btn.Height),
                btn.ForeColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
        End If
    End Sub

    ' Fungsi mengubah warna ikon PNG secara otomatis
    Private Function RecolorImage(img As Image, newColor As Color) As Bitmap
        Dim bmp As New Bitmap(img.Width, img.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim colorMatrix As New Imaging.ColorMatrix(New Single()() {
                New Single() {0, 0, 0, 0, 0},
                New Single() {0, 0, 0, 0, 0},
                New Single() {0, 0, 0, 0, 0},
                New Single() {0, 0, 0, 1, 0},
                New Single() {newColor.R / 255.0F, newColor.G / 255.0F, newColor.B / 255.0F, 0, 1}
            })
            Dim attributes As New Imaging.ImageAttributes()
            attributes.SetColorMatrix(colorMatrix)
            g.DrawImage(img, New Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes)
        End Using
        Return bmp
    End Function
End Class