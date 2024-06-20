'
'
'
'         Made by Fadli Nurhidayat with ❤️
'
'
'

Imports System.Data.Odbc
Public Class FrmDataMahasiswa

    Dim _nim, _nama, _jk, _agama, _tmp_lahir, _tgl_lahir, _alamat, _prodi, _status As String

    Private Sub FrmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Menampilkan data mahasiswa dari TbMahasiswa
        Try
            cbProdi.Items.Add("")
            cbProdi.Items.Add("Teknologi Listrik (D3)")
            cbProdi.Items.Add("Mekatronika (D3)")
            cbProdi.Items.Add("Teknologi Mesin (D3)")
            cbProdi.Items.Add("Teknologi Rekayasa Perangkat Lunak (D4)")
            Call load_data()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call openConn()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With formInputMhs
            .JurusanAkademik()
            .formNormal()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        'mainMenu.Show()
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM viewMahasiswa WHERE nim like '%" & tbCari.Text & "%' OR nama like '%" & tbCari.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridMahasiswa.DataSource = DS.Tables(0)
            closeConn()
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
            closeConn()
        End Try

    End Sub

    Private Sub DataGridMahasiswa_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridMahasiswa.SelectionChanged
        Dim i As Integer = DataGridMahasiswa.CurrentRow.Index
        _nim = Convert.ToString(DataGridMahasiswa.Item(0, i).Value)
        _nama = Convert.ToString(DataGridMahasiswa.Item(1, i).Value)
        _jk = DataGridMahasiswa.Item(2, i).Value.ToString
        '_jk = Convert.ToString(DataGridMahasiswa.SelectedCells(2).Value)
        _agama = Convert.ToString(DataGridMahasiswa.Item(3, i).Value)
        _tmp_lahir = Convert.ToString(DataGridMahasiswa.Item(4, i).Value)
        _tgl_lahir = Convert.ToString(DataGridMahasiswa.Item(5, i).Value)
        _alamat = Convert.ToString(DataGridMahasiswa.Item(6, i).Value)
        _prodi = DataGridMahasiswa.Item(7, i).Value
        _status = Convert.ToString(DataGridMahasiswa.Item(8, i).Value)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With formInputMhs
            .clearCB()
            .JenisKelamin()
            .Agama()
            .StatusMahasiswa()
            .JurusanAkademik()
            .tbNIM.Text = _nim
            .tbNama.Text = _nama
            .cbKelamin.Text = _jk
            .cbAgama.Text = _agama
            .tbTmp_lahir.Text = _tmp_lahir
            .dtpTgl_lahir.Text = _tgl_lahir
            .tbAlamat.Text = _alamat
            .cbJurusan.Text = _prodi
            .cbStatus.Text = _status
            .btnSimpan.Text = "&UBAH"
            .formAktif()
            .btnSimpan.Enabled = True
            .btnTambah.Enabled = False
            .btnSimpan.BackColor = Color.AliceBlue
            .btnBatal.BackColor = Color.AliceBlue
            .btnHapus.BackColor = Color.AliceBlue
            .tbNIM.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub cbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdi.SelectedIndexChanged
        Try
            If cbProdi.SelectedIndex > 0 Then
                Call openConn()

                DA = New OdbcDataAdapter("SELECT * FROM viewMahasiswa WHERE nm_prodi = '" & cbProdi.Text & "'", Conn)

                DS = New DataSet
                DA.Fill(DS)
                DataGridMahasiswa.DataSource = DS.Tables(0)

                Call closeConn()
            Else
                load_data()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Sub

    Private Sub DataGridMahasiswa_DoubleClick(sender As Object, e As EventArgs) Handles DataGridMahasiswa.DoubleClick
        With formInputMhs
            .clearCB()
            .JenisKelamin()
            .Agama()
            .StatusMahasiswa()
            .JurusanAkademik()
            .tbNIM.Text = _nim
            .tbNama.Text = _nama
            .cbKelamin.Text = _jk
            .cbAgama.Text = _agama
            .tbTmp_lahir.Text = _tmp_lahir
            .dtpTgl_lahir.Text = _tgl_lahir
            .tbAlamat.Text = _alamat
            .cbJurusan.Text = _prodi
            .cbStatus.Text = _status
            .btnSimpan.Text = "&UBAH"
            .formAktif()
            .btnSimpan.Enabled = True
            .btnTambah.Enabled = False
            .btnSimpan.BackColor = Color.AliceBlue
            .btnBatal.BackColor = Color.AliceBlue
            .btnHapus.BackColor = Color.AliceBlue
            .tbNIM.Enabled = False
            .ShowDialog()
        End With
    End Sub
End Class