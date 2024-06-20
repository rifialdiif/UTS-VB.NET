Imports System.Data.Odbc

Public Class formInputProdi

    Sub formAktif()
        tbKode.Enabled = False
        tbNm_prodi.Enabled = True
    End Sub

    Sub formNonaktif()
        tbKode.Enabled = False
        tbNm_prodi.Enabled = False
    End Sub

    Sub formKosong()
        tbKode.Clear()
        tbNm_prodi.Clear()
    End Sub

    Sub formNormal()
        formNonaktif()
        btnHapus.Enabled = False
        btnSimpan.Text = "&SIMPAN"
        btnSimpan.Enabled = False
        btnTambah.Enabled = True
        btnBatal.Text = "&KELUAR"
    End Sub

    Sub buatKode()
        Try
            Call openConn()
            CMD =
            New OdbcCommand("SELECT * FROM tb_prodi WHERE kd_prodi IN (SELECT MAX(kd_prodi) FROM tb_prodi) ORDER BY kd_prodi Desc", Conn)

            'Buatkan Variabel
            Dim Hasil As String
            Dim maxProdi As Object = CMD.ExecuteScalar

            'fungsi if PR+006
            If maxProdi Is DBNull.Value Then
                Hasil = "PR001"
                tbKode.Text = Hasil
            Else
                Dim lastNumber As Integer = Integer.Parse(maxProdi.ToString().Substring(2))
                If lastNumber >= 999 Then
                    Hasil = "PR001"
                Else
                    Dim nextNumber As Integer = lastNumber + 1
                    Hasil = "PR" + nextNumber.ToString("000")
                End If
            End If
            tbKode.Text = Hasil
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Call closeConn()
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        'ini menggunakan event Click pada button tambah
        Call buatKode()
        Call formAktif()

        tbNm_prodi.Focus()
        btnTambah.Enabled = False
        btnSimpan.Enabled = True
        btnSimpan.Text = "&SIMPAN"
        btnSimpan.BackColor = Color.AliceBlue
        btnBatal.Text = "&BATAL"
        btnHapus.Enabled = False
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If btnBatal.Text = "&BATAL" Then
            Call formKosong()
            'Me.Close()
            Me.Dispose()
        ElseIf btnBatal.Text = "&KELUAR" Then
            Call formKosong()
            Me.Dispose()
        Else
            Call formNormal()
            Call formKosong()
            btnTambah.Enabled = True
            btnTambah.BackColor = Color.AliceBlue
            btnSimpan.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            If tbNm_prodi.Text = "" Then
                MsgBox("Data nama program studi harus diisi!", vbInformation, "Informasi")
                tbNm_prodi.Focus()
            Else
                'perintah Untuk menyimpan data dari form vb ke tabel mahasiswa
                If btnSimpan.Text = "&SIMPAN" Then
                    Try
                        Call openConn()
                        SQLInsert = "INSERT INTO tb_prodi VALUES (?, ?)"
                        CMD = New OdbcCommand(SQLInsert, Conn)
                        With CMD
                            .Parameters.AddWithValue("@nim", tbKode.Text)
                            .Parameters.AddWithValue("@nama", tbNm_prodi.Text)
                            .ExecuteNonQuery()
                        End With

                        MsgBox("Data Saved")
                        Call formKosong()
                        Call formNormal()
                        Call load_prodi()
                    Catch ex As Exception
                        MessageBox.Show("err: " + ex.Message)
                    Finally
                        Call closeConn()
                        Me.Dispose()
                    End Try
                    btnTambah.Enabled = True
                    btnSimpan.Enabled = False
                    btnTambah.Focus()
                    btnTambah.BackColor = Color.AliceBlue

                ElseIf btnSimpan.Text = "&UBAH" Then
                    Try
                        Call openConn()
                        If MsgBox("Are you sure you want to update the data?", vbYesNo + vbQuestion) = vbYes Then
                            SQLUpdate = "UPDATE tb_prodi set nm_prodi= ? WHERE kd_prodi like '" & tbKode.Text & "'"
                            CMD = New OdbcCommand(SQLUpdate, Conn)
                            With CMD
                                .Parameters.AddWithValue("@nama", tbNm_prodi.Text)
                                .ExecuteNonQuery()
                            End With

                            'CMD.ExecuteNonQuery()
                            MsgBox("Data Updated")
                            Call formNormal()
                            Call formKosong()
                            Call load_prodi()
                            btnTambah.Enabled = True
                            btnSimpan.BackColor = DefaultBackColor
                            btnTambah.Focus()
                            btnTambah.BackColor = Color.AliceBlue
                            btnHapus.BackColor = DefaultBackColor
                            btnBatal.BackColor = Color.Red
                            Call closeConn()
                            Me.Dispose()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("err: " + ex.Message)
                    End Try
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Err: " + ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Konfirmasi As String
        Konfirmasi = MsgBox("Anda yakin akan menghapus data ini?", vbYesNo + vbQuestion,
       "Informasi")
        If Konfirmasi = vbYes Then
            Try
                Call openConn()
                SQLDelete = "DELETE FROM tb_prodi WHERE kd_prodi ='" & tbKode.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)
                CMD.ExecuteNonQuery()
                Call formKosong()
                btnTambah.Enabled = True
                btnTambah.BackColor = Color.AliceBlue
                btnSimpan.Enabled = False
                btnHapus.Enabled = False
                btnHapus.BackColor = Color.Red
                MsgBox("Data Deleted.")
                Call load_data()
                Call closeConn()
                Me.Dispose()
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            End Try

        Else
            Call formKosong()
            Call buatKode()
            btnTambah.Enabled = True
            btnTambah.BackColor = Color.AliceBlue
            btnSimpan.Text = "&SIMPAN"
            btnHapus.Enabled = False
            btnHapus.BackColor = Color.Red
            tbNm_prodi.Focus()
        End If
    End Sub
End Class