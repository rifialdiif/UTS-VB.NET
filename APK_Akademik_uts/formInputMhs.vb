'
'
'
'         Made by Fadli Nurhidayat with ❤️
'
'
'
Imports System.Data.Odbc

Public Class formInputMhs
    Sub formAktif()
        'membuat Clas Prosedur Meng Aktifkan Object
        tbNIM.Enabled = False
        tbNama.Enabled = True
        cbAgama.Enabled = True
        tbTmp_lahir.Enabled = True
        dtpTgl_lahir.Enabled = True
        tbAlamat.Enabled = True
        cbJurusan.Enabled = True
        cbKelamin.Enabled = True
        cbStatus.Enabled = True
    End Sub

    Sub formNonAktif()
        'membuat Clas Prosedur Men Non-Aktifkan Object
        tbNIM.Enabled = False
        tbNama.Enabled = False
        cbAgama.Enabled = False
        tbTmp_lahir.Enabled = False
        dtpTgl_lahir.Enabled = False
        tbAlamat.Enabled = False
        cbJurusan.Enabled = False
        cbKelamin.Enabled = False
        cbStatus.Enabled = False
    End Sub

    Sub formKosong()
        'Membuat Sub Prosedure untuk Mengosongkan Object
        tbNIM.Clear()
        tbNama.Clear()
        'cbKelamin.Items.Clear() ' Mengosongkan ComboBox Jenis Kelamin
        cbKelamin.SelectedIndex = -1
        'cbAgama.Items.Clear() ' Mengosongkan ComboBox Agama
        cbAgama.SelectedIndex = -1
        tbTmp_lahir.Clear()
        tbAlamat.Clear()
        'cbJurusan.Items.Clear() ' Mengosongkan ComboBox Jurusan
        cbJurusan.DataSource = Nothing
        'cbStatus.Items.Clear() ' Mengosongkan ComboBox Status
        cbStatus.SelectedIndex = -1
    End Sub

    Sub formNormal()
        formNonAktif()
        btnHapus.Enabled = False
        btnHapus.Text = "&HAPUS"
        btnSimpan.Text = "&SIMPAN"
        btnSimpan.Enabled = False
        btnTambah.Enabled = True
        btnBatal.Text = "&KELUAR"
    End Sub

    Sub Agama()
        'membuat Sub untuk menampilkan Item Agama kedalam objek combobox
        cbAgama.Items.Add("ISLAM")
        cbAgama.Items.Add("KRISTEN KATOLIK")
        cbAgama.Items.Add("KRISTEN PROTESTAN")
        cbAgama.Items.Add("HINDU")
        cbAgama.Items.Add("BUDHA")
        cbAgama.Items.Add("KONGHUCU")
    End Sub

    Sub StatusMahasiswa()
        'membuat Sub untuk menampilkan Item StatusMahasiswa kedalam objek combobox
        cbStatus.Items.Add("AKTIF")
        cbStatus.Items.Add("NON AKTIF")
        cbStatus.Items.Add("CUTI AKADEMIK")
        cbStatus.Items.Add("DROP OUT")
    End Sub

    Sub JenisKelamin()
        cbKelamin.Items.Add("LAKI-LAKI")
        cbKelamin.Items.Add("PEREMPUAN")
    End Sub

    Sub JurusanAkademik()
        Try
            DA = New OdbcDataAdapter("SELECT * FROM tb_prodi", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_prodi")
            cbJurusan.DataSource = DS.Tables("tb_prodi")
            cbJurusan.DisplayMember = "nm_prodi"
            cbJurusan.ValueMember = "kd_prodi"
            cbJurusan.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Sub clearCB()
        cbAgama.Items.Clear()
        cbKelamin.Items.Clear()
        cbStatus.Items.Clear()
    End Sub
    Sub buatNIMMhs()
        Try
            Call openConn()
            CMD =
                New OdbcCommand("SELECT * FROM tb_mahasiswa WHERE nim IN (SELECT MAX(nim) FROM tb_mahasiswa) ORDER BY nim Desc", Conn)
            'DA = New OleDbDataAdapter("SELECT * FROM mhs WHERE nim_mhs IN (SELECT MAX(nim_mhs)' FROM mhs) ORDER BY nim_mhs DESC'", dbConn)
            'Buatkan Variabel
            Dim Hasil As String
            Dim formatY As String = Date.Now.Year.ToString()
            Dim maxNIM As Object = CMD.ExecuteScalar

            'fungsi if 2018+04+006
            If maxNIM = 0 Then
                Hasil = formatY + "04" + "001"
                tbNIM.Text = Hasil
            Else
                Dim lastNumber As Integer = Integer.Parse(maxNIM.ToString().Substring(7))
                If lastNumber >= "999" Then
                    Hasil = formatY + "04" + "001"
                Else
                    Dim nextNumber As Integer = lastNumber + 1
                    Hasil = formatY + "04" + nextNumber.ToString("000")
                End If
            End If
            tbNIM.Text = Hasil
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Call closeConn()
        End Try

    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        'ini menggunakan event Click pada button tambah
        Call buatNIMMhs()
        Call formAktif()

        Call Agama()
        Call StatusMahasiswa()
        Call JenisKelamin()
        Call JurusanAkademik()

        tbNama.Focus()
        btnTambah.Enabled = False
        btnSimpan.Enabled = True
        btnSimpan.Text = "&SIMPAN"
        btnSimpan.BackColor = Color.AliceBlue
        btnBatal.Text = "&BATAL"
        btnHapus.Enabled = False
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If btnBatal.Text = "&BATAL" Then
            Call clearCB()
            Call formKosong()
            'Me.Close()
            Me.Dispose()
        ElseIf btnBatal.Text = "&KELUAR" Then
            Call clearCB()
            Call formKosong()
            Me.Dispose()
        Else
            Call formNormal()
            Call formKosong()
            btnTambah.Enabled = True
            btnTambah.BackColor = Color.AliceBlue
            'btnSimpan.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            If tbNama.Text = "" Then
                MsgBox("Data nama harus diisi!", vbInformation, "Informasi")
                tbNama.Focus()
            ElseIf cbKelamin.Text = "" Then
                MsgBox("Data jenis kelamin harus diisi!", vbInformation, "Informasi")
                cbKelamin.Focus()
            ElseIf cbAgama.Text = "" Then
                MsgBox("Data agama harus diisi!", vbInformation, "Informasi")
                cbAgama.Focus()
            ElseIf tbAlamat.Text = "" Then
                MsgBox("Data alamat harus diisi!", vbInformation, "Informasi")
                tbAlamat.Focus()
            ElseIf cbJurusan.Text = "" Then
                MsgBox("Data jurusan harus diisi!", vbInformation, "Informasi")
                cbJurusan.Focus()
            ElseIf cbStatus.Text = "" Then
                MsgBox("Data status harus diisi!", vbInformation, "Informasi")
                cbStatus.Focus()
            Else
                'perintah Untuk menyimpan data dari form vb ke tabel mahasiswa
                If btnSimpan.Text = "&SIMPAN" Then
                    Try
                        Call openConn()
                        'SQLInsert = "INSERT INTO mhs (nim_mhs,nama_mhs,jk_mhs,agama,alamat_mhs,kd_prodi,status_mhs) VALUES ('" _
                        '    & tbNIM.Text & "','" _
                        '    & tbNama.Text & "','" _
                        '    & cbKelamin.SelectedItem & "','" _
                        '    & cbAgama.SelectedItem & "','" _
                        '    & tbAlamat.Text & "','" _
                        '    & cbJurusan.SelectedValue & "','" _
                        '    & cbStatus.SelectedItem & "');"
                        SQLInsert = "INSERT INTO tb_mahasiswa VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
                        CMD = New OdbcCommand(SQLInsert, Conn)
                        With CMD
                            .Parameters.AddWithValue("@nim", tbNIM.Text)
                            .Parameters.AddWithValue("@nama", tbNama.Text)
                            .Parameters.AddWithValue("@jk", cbKelamin.SelectedItem)
                            .Parameters.AddWithValue("@agama", cbAgama.SelectedItem)
                            .Parameters.AddWithValue("@tempat_lahir", tbTmp_lahir.Text)
                            .Parameters.AddWithValue("@tgl_lahir", dtpTgl_lahir.Text)
                            .Parameters.AddWithValue("@alamat", tbAlamat.Text)
                            .Parameters.AddWithValue("@kd_prodi", cbJurusan.SelectedValue)
                            .Parameters.AddWithValue("@status", cbStatus.SelectedItem)
                            .ExecuteNonQuery()
                        End With

                        MsgBox("Data Saved")
                        Call formKosong()
                        Call formNormal()
                        Call clearCB()
                        Call load_data()
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
                            SQLUpdate = "UPDATE tb_mahasiswa set nama= ?, jk= ?, agama= ?, tempat_lahir= ?, tgl_lahir=?, alamat= ?, kd_prodi= ?,status= ? WHERE nim like '" & tbNIM.Text & "'"
                            CMD = New OdbcCommand(SQLUpdate, Conn)
                            With CMD
                                '.Parameters.AddWithValue("@nim_mhs", tbNIM.Text)
                                .Parameters.AddWithValue("@nama", tbNama.Text)
                                .Parameters.AddWithValue("@jk", cbKelamin.SelectedItem)
                                .Parameters.AddWithValue("@agama", cbAgama.SelectedItem)
                                .Parameters.AddWithValue("@tempat_lahir", tbTmp_lahir.Text)
                                .Parameters.AddWithValue("@tgl_lahir", dtpTgl_lahir.Text)
                                .Parameters.AddWithValue("@alamat", tbAlamat.Text)
                                .Parameters.AddWithValue("@kd_prodi", cbJurusan.SelectedValue)
                                .Parameters.AddWithValue("@status", cbStatus.SelectedItem)
                                .ExecuteNonQuery()
                            End With

                            'CMD.ExecuteNonQuery()
                            MsgBox("Data Updated")
                            Call formNormal()
                            Call formKosong()
                            Call clearCB()
                            Call load_data()
                            'Call clearCB()
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
                SQLDelete = "DELETE FROM tb_mahasiswa WHERE nim ='" & tbNIM.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)
                CMD.ExecuteNonQuery()
                Call formKosong()
                Call clearCB()
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
            Call buatNIMMhs()
            Call clearCB()
            btnTambah.Enabled = True
            btnTambah.BackColor = Color.AliceBlue
            btnSimpan.Text = "&SIMPAN"
            btnHapus.Enabled = False
            btnHapus.BackColor = Color.Red
            tbNama.Focus()
        End If
    End Sub

    Private Sub formInputMhs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call formNonAktif()
        'JenisKelamin()
        'Call Agama()
        'Call formNormal()
        'Call JurusanAkademik()
        'Call StatusMahasiswa()
    End Sub

    Private Sub cbJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJurusan.SelectedIndexChanged
        Try
            ' Get the selected item from the ComboBox
            Dim selectedProdi As String = cbJurusan.Text

            ' Use a parameterized query to avoid SQL injection
            Dim query As String = "SELECT * FROM tb_prodi WHERE nm_prodi = ?"
            Dim command As OdbcCommand = New OdbcCommand(query, Conn)
            command.Parameters.AddWithValue("nm_prodi", selectedProdi)

            DA = New OdbcDataAdapter(command)
            DS = New DataSet
            DA.Fill(DS, "tb_prodi")

            ' Check if there is at least one row returned
            If DS.Tables("tb_prodi").Rows.Count > 0 Then
                ' Display the desired column value in the label
                lbProdi.Text = DS.Tables("tb_prodi").Rows(0)("kd_prodi").ToString()
            Else
                ' Handle the case where no rows are returned
                lbProdi.Text = "No data found"
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class