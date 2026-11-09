Imports MySql.Data.MySqlClient

Public Class FormPelanggan
    Dim conn As MySqlConnection = getconn()
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim idPelangganDipilih As Integer = 0

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturListView()
        TampilkanDataPelanggan()
    End Sub

    Private Sub FormPelanggan_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Panel1 IsNot Nothing Then
            Panel1.Left = (Me.Width - Panel1.Width) / 2
        End If
    End Sub

    ' 1. Pengaturan Kolom ListView
    Sub AturListView()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.GridLines = True

        If ListView1.Columns.Count = 0 Then
            ListView1.Columns.Add("ID", 50, HorizontalAlignment.Left)
            ListView1.Columns.Add("Nama Pelanggan", 220, HorizontalAlignment.Left)
            ListView1.Columns.Add("Nomor HP", 160, HorizontalAlignment.Left)
        End If
    End Sub

    ' 2. Tampilkan Data ke ListView Menggunakan DataSet & DataAdapter (Disconnected)
    Sub TampilkanDataPelanggan(Optional keyword As String = "")
        ListView1.Items.Clear()

        If ds.Tables("tabelPelanggan") IsNot Nothing Then
            ds.Tables("tabelPelanggan").Clear()
        End If

        Dim query As String = "SELECT * FROM pelanggan"
        If keyword <> "" Then
            query &= " WHERE nama LIKE '%" & keyword.Replace("'", "''") & "%'"
        End If

        da = New MySqlDataAdapter(query, conn)
        da.Fill(ds, "tabelPelanggan")

        For Each row As DataRow In ds.Tables("tabelPelanggan").Rows
            Dim arr(2) As String
            arr(0) = row("id_pelanggan").ToString()
            arr(1) = row("nama").ToString()
            arr(2) = row("no_hp").ToString()

            Dim item As New ListViewItem(arr)
            ListView1.Items.Add(item)
        Next

        ClearForm()
    End Sub

    ' 3. Tombol Simpan / Tambah Data (Disconnected Style)
    Private Sub Btn_Simpan_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        If Txt_NmPelanggan.Text = "" Or Txt_HpPealnggan.Text = "" Then
            MsgBox("Nama dan Nomor HP tidak boleh kosong!", vbExclamation, "Peringatan")
            Return
        End If

        Try
            Dim query As String = "INSERT INTO pelanggan (nama, no_hp) VALUES ('" &
                                  Txt_NmPelanggan.Text.Replace("'", "''") & "', '" &
                                  Txt_HpPealnggan.Text.Replace("'", "''") & "')"

            da = New MySqlDataAdapter(query, conn)
            Dim dsInsert As New DataSet
            da.Fill(dsInsert, "pelanggan")

            MsgBox("Data pelanggan berhasil ditambahkan!", vbInformation, "Sukses")
            TampilkanDataPelanggan()
        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    ' 4. Tombol Ubah / Update Data (Disconnected Style)
    Private Sub Btn_Ubah_Click(sender As Object, e As EventArgs) Handles Btn_Ubah.Click
        If idPelangganDipilih = 0 Then
            MsgBox("Pilih data pelanggan dari ListView terlebih dahulu yang ingin diubah!", vbExclamation, "Peringatan")
            Return
        End If

        If Txt_NmPelanggan.Text = "" Or Txt_HpPealnggan.Text = "" Then
            MsgBox("Nama dan Nomor HP tidak boleh kosong!", vbExclamation, "Peringatan")
            Return
        End If

        Try
            Dim query As String = "UPDATE pelanggan SET nama = '" & Txt_NmPelanggan.Text.Replace("'", "''") &
                                  "', no_hp = '" & Txt_HpPealnggan.Text.Replace("'", "''") &
                                  "' WHERE id_pelanggan = " & idPelangganDipilih

            da = New MySqlDataAdapter(query, conn)
            Dim dsUpdate As New DataSet
            da.Fill(dsUpdate, "pelanggan")

            MsgBox("Data pelanggan berhasil diperbarui!", vbInformation, "Sukses")
            TampilkanDataPelanggan()
        Catch ex As Exception
            MsgBox("Gagal mengubah data: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    ' 5. Tombol Hapus Data (Disconnected Style)
    Private Sub Btn_Hapus_Click(sender As Object, e As EventArgs) Handles Btn_Hapus.Click
        If idPelangganDipilih = 0 Then
            MsgBox("Pilih data pelanggan dari ListView terlebih dahulu yang ingin dihapus!", vbExclamation, "Peringatan")
            Return
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus pelanggan ini?", vbYesNo + vbQuestion, "Konfirmasi Hapus") = vbYes Then
            Try
                Dim query As String = "DELETE FROM pelanggan WHERE id_pelanggan = " & idPelangganDipilih

                da = New MySqlDataAdapter(query, conn)
                Dim dsDelete As New DataSet
                da.Fill(dsDelete, "pelanggan")

                MsgBox("Data pelanggan berhasil dihapus!", vbInformation, "Sukses")
                TampilkanDataPelanggan()
            Catch ex As Exception
                ' Menangkap pesan error jika pelanggan masih terikat dengan tabel transaksi (foreign key)
                If ex.Message.Contains("foreign key constraint fails") Then
                    MsgBox("Pelanggan tidak dapat dihapus karena masih memiliki riwayat transaksi aktif!", vbCritical, "Gagal Hapus")
                Else
                    MsgBox("Gagal menghapus data: " & ex.Message, vbCritical, "Error")
                End If
            End Try
        End If
    End Sub

    ' 6. Tombol Cari Data
    Private Sub Btn_Cari_Click(sender As Object, e As EventArgs) Handles Btn_Cari.Click
        TampilkanDataPelanggan(Txt_CariNama.Text.Trim())
    End Sub

    ' 7. Event Saat Baris di ListView Diklik (Auto-Fill ke TextBox)
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedRow As ListViewItem = ListView1.SelectedItems(0)
            idPelangganDipilih = Convert.ToInt32(selectedRow.SubItems(0).Text)
            Txt_NmPelanggan.Text = selectedRow.SubItems(1).Text
            Txt_HpPealnggan.Text = selectedRow.SubItems(2).Text
        End If
    End Sub

    ' Fungsi Reset Form
    Sub ClearForm()
        idPelangganDipilih = 0
        Txt_NmPelanggan.Text = ""
        Txt_HpPealnggan.Text = ""
        Txt_NmPelanggan.Focus()
    End Sub

    ' Event handler kosong pendukung kontrol lainnya
    Private Sub FormPelanggan_Resize_1(sender As Object, e As EventArgs) Handles Me.Resize
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Txt_NmPelanggan_TextChanged(sender As Object, e As EventArgs) Handles Txt_NmPelanggan.TextChanged
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub
    Private Sub Txt_HpPealnggan_TextChanged(sender As Object, e As EventArgs) Handles Txt_HpPealnggan.TextChanged
    End Sub
    Private Sub Txt_CariNama_TextChanged(sender As Object, e As EventArgs) Handles Txt_CariNama.TextChanged
        If Txt_CariNama.Text.Trim() = "" Then
            TampilkanDataPelanggan()
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub
    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint
    End Sub
    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
    End Sub
End Class