Public Class formlogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmsk.Click
        Dim sesikasir As Kasir = Nothing
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Mohin isi data diri anda terlebih dahulu")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong")

        ElseIf TextBox2.Text = "" Then
            MsgBox("Kata Sandi Tidak Boleh kosong")
        Else
            sesikasir = loggin(TextBox1.Text, TextBox2.Text)

        End If
        If sesiKasir IsNot Nothing Then
            MsgBox($"Selamat Datang kasir : {sesiKasir.Nama}")
            Me.Hide()
            MainMenu.Show()
        End If

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        btnmsk.Enabled = True

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        btnmsk.Enabled = True
    End Sub

    Private Sub formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnmsk.Enabled = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Cbktsndi_CheckedChanged(sender As Object, e As EventArgs) Handles Cbktsndi.CheckedChanged
        If Cbktsndi.Checked Then

            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class