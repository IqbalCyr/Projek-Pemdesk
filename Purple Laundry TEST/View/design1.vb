Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class design1
    Inherits Form

    Private WithEvents pnlContainer As Panel

    Private chartTransaksi As Chart

    Public Sub New()
        Me.Text = "Statistik Total Transaksi"
        Me.ClientSize = New Size(968, 557)
        Me.BackColor = Color.FromArgb(244, 247, 250)

        Me.StartPosition = FormStartPosition.CenterScreen

        InisialisasiKomponen()
        MuatDataDummy()
    End Sub

    Private Sub InisialisasiKomponen()
        ' 1. Panel Kartu Putih mengisi seluruh area Form (dikurangi Padding 16px)
        pnlContainer = New Panel() With {
            .Dock = DockStyle.Fill,
            .BackColor = Color.White,
            .Padding = New Padding(20)
        }
        Me.Controls.Add(pnlContainer)

        ' 2. Label Judul tetap di kiri atas


        ' 4. Chart otomatis melebar & memanjang mengikuti pnlContainer (Anchor ke 4 sisi)
        chartTransaksi = New Chart() With {
            .Location = New Point(15, 60),
            .Size = New Size(pnlContainer.ClientSize.Width - 30, pnlContainer.ClientSize.Height - 75),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right,
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
    Private Sub pnlContainer_Resize(sender As Object, e As EventArgs) Handles pnlContainer.Resize
        pnlContainer.Invalidate()
    End Sub

End Class