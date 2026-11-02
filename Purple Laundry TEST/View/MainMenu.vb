Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuAkun.Text = KasirAktif.Nama
        Dim listpesanan = Nothing
        listpesanan = loadpesanan()
        If listpesanan Is Nothing Then
            ListView1.Hide()
            Button1.Hide()
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            ComboBox1.Hide()
            TextBox1.Hide()
            TextBox2.Hide()
        Else
            Judul.Hide()
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MenuAkun_Click(sender As Object, e As EventArgs) Handles MenuAkun.Click

    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click

    End Sub

    Private Sub PELANGGAN_Click(sender As Object, e As EventArgs) Handles PELANGGAN.Click

    End Sub

    Private Sub TambahPelanggan_Click(sender As Object, e As EventArgs) Handles TambahPelanggan.Click

    End Sub

    Private Sub EditPelanggan_Click(sender As Object, e As EventArgs) Handles EditPelanggan.Click

    End Sub

    Private Sub HapusPelanggan_Click(sender As Object, e As EventArgs) Handles HapusPelanggan.Click

    End Sub

    Private Sub DAFTARPESANAN_Click(sender As Object, e As EventArgs) Handles DAFTARPESANAN.Click

    End Sub

    Private Sub Judul_Click(sender As Object, e As EventArgs) Handles Judul.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Pesanan.Click
        Me.Hide()
        FormBuatPesanan.Show()
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


End Class