Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button5.Text = KasirAktif.Nama
    End Sub

    Private Sub FormMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If KasirAktif IsNot Nothing Then
            Button5.Text = KasirAktif.Nama
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Public Sub BukaFormPelanggan()
        With FormPelanggan
            .TopLevel = False
            Panel4.Controls.Add(FormPelanggan)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BukaFormPelanggan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With FormPesanan
            .TopLevel = False
            Panel4.Controls.Add(FormPesanan)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With FormDaftarPesanan
            .TopLevel = False
            Panel4.Controls.Add(FormDaftarPesanan)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Apakah Anda yakin ingin LogOut?", vbYesNo + vbQuestion, "Konfirmasi LogOut") = vbYes Then
            Dim loginForm As New formlogin()
            loginForm.Show()
            Me.Hide()
            KasirAktif = Nothing
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub


End Class