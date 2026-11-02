Imports MySql.Data.MySqlClient
Public Class TambahPelanggan

    Private ReadOnly connStr As String =
    "Server=127.0.0.1;Port=3306;Database=laundry;Uid=root;Pwd=;"
    Private Sub TambahPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.MaxLength = 100
        txtNohp.MaxLength = 15
    End Sub

    Private Sub txtNohp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNohp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnTmbh_Click(sender As Object, e As EventArgs) Handles btnTmbh.Click
        Dim nama As String = txtNama.Text.Trim()
        Dim hp As String = txtNohp.Text.Trim()

        ' Validasi
        If nama = "" Then
            MessageBox.Show("Nama lengkap wajib diisi.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If hp.Length < 10 Then
            MessageBox.Show("No HP minimal 10 digit.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNohp.Focus()
            Return
        End If

        ' Simpan ke database
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim sql As String = "INSERT INTO pelanggan (nama, no_hp) VALUES (@nama, @hp)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data pelanggan berhasil ditambahkan.", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Kosongkan input agar bisa menambah pelanggan berikutnya
            txtNama.Clear()
            txtNohp.Clear()
            txtNama.Focus()

        Catch ex As MySqlException
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class