Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class design1
    Inherits Form

    Private WithEvents pnlContainer As Panel
    Private lblJudul As Label
    Private lblSubJudul As Label
    Private chartTransaksi As Chart

    Public Sub New()
        ' Pengaturan ukuran dan tampilan dasar Form (936 x 460)
        Me.Text = "Statistik Total Transaksi"
        Me.ClientSize = New Size(936, 460)
        Me.BackColor = Color.FromArgb(244, 247, 250) ' Latar belakang abu-abu muda dashboard
        Me.StartPosition = FormStartPosition.CenterScreen

        InisialisasiKomponen()
        MuatDataDummy() ' Ganti fungsi ini dengan query database Anda
    End Sub

    Private Sub InisialisasiKomponen()
        ' 1. Panel Kartu Putih (Container) disesuaikan dengan Form 936x460
        pnlContainer = New Panel() With {
            .Size = New Size(896, 420),
            .Location = New Point(20, 20),
            .BackColor = Color.White,
            .Padding = New Padding(20)
        }
        Me.Controls.Add(pnlContainer)

        ' 2. Label Judul ("Statistik Total Transaksi")
        lblJudul = New Label() With {
            .Text = "Statistik Total Transaksi",
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.FromArgb(50, 60, 70),
            .AutoSize = True,
            .Location = New Point(24, 20)
        }
        pnlContainer.Controls.Add(lblJudul)

        ' 3. Label Subjudul ("7 Hari Terakhir") rata kanan mengikuti lebar panel
        lblSubJudul = New Label() With {
            .Text = "7 Hari Terakhir",
            .Font = New Font("Segoe UI", 9, FontStyle.Regular),
            .ForeColor = Color.Gray,
            .AutoSize = True,
            .Location = New Point(780, 24)
        }
        pnlContainer.Controls.Add(lblSubJudul)

        ' 4. Kontrol Chart mengisi ruang dalam panel kartu
        chartTransaksi = New Chart() With {
            .Location = New Point(15, 60),
            .Size = New Size(866, 345),
            .BackColor = Color.White
        }

        ' Konfigurasi ChartArea
        Dim area As New ChartArea("MainArea")
        area.BackColor = Color.White

        ' Pengaturan Sumbu X (Hari)
        area.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 240, 240)
        area.AxisX.LineColor = Color.FromArgb(220, 220, 220)
        area.AxisX.LabelStyle.ForeColor = Color.Gray
        area.AxisX.LabelStyle.Font = New Font("Segoe UI", 8.5F)
        area.AxisX.MajorTickMark.Enabled = False
        area.AxisX.Interval = 1

        ' Pengaturan Sumbu Y (Nilai 0.0 - 4.5 kelipatan 0.5)
        area.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240)
        area.AxisY.LineColor = Color.FromArgb(220, 220, 220)
        area.AxisY.LabelStyle.ForeColor = Color.Gray
        area.AxisY.LabelStyle.Font = New Font("Segoe UI", 8.0F)
        area.AxisY.LabelStyle.Format = "0.0"
        area.AxisY.Minimum = 0.0
        area.AxisY.Maximum = 4.5
        area.AxisY.Interval = 0.5
        area.AxisY.MajorTickMark.LineColor = Color.FromArgb(220, 220, 220)

        chartTransaksi.ChartAreas.Add(area)

        ' Konfigurasi Legend di bagian bawah
        Dim legend As New Legend("MainLegend") With {
            .Docking = Docking.Bottom,
            .Alignment = StringAlignment.Center,
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 9.0F)
        }
        chartTransaksi.Legends.Add(legend)

        ' Konfigurasi Series (Batang Grafik)
        Dim series As New Series("Total Transaksi") With {
            .ChartType = SeriesChartType.Column,
            .Color = Color.FromArgb(118, 179, 195), ' Warna biru tosca lembut
            .BorderWidth = 0,
            .IsValueShownAsLabel = False,
            .IsXValueIndexed = True
        }
        series("PointWidth") = "0.82"

        chartTransaksi.Series.Add(series)
        pnlContainer.Controls.Add(chartTransaksi)
    End Sub

    ' Contoh pengisian data sesuai tampilan screenshot
    Private Sub MuatDataDummy()
        Dim s As Series = chartTransaksi.Series("Total Transaksi")
        s.Points.Clear()

        s.Points.AddXY("Wednesday", 1.0)
        s.Points.AddXY("Friday", 1.0)
        s.Points.AddXY("Saturday", 4.0)
    End Sub

    ' Efek sudut membulat (Rounded Corner) pada panel putih
    Private Sub pnlContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlContainer.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim radius As Integer = 15
        Dim rect As New Rectangle(0, 0, pnlContainer.Width - 1, pnlContainer.Height - 1)
        Dim path As New GraphicsPath()

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        pnlContainer.Region = New Region(path)
    End Sub

End Class