Imports System.Data.Odbc

Public Class FrmDataProdi

    Dim _kode, _nm_prodi As String

    Private Sub FrmDataProdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_prodi()
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM tb_prodi WHERE kd_prodi like '%" & tbCari.Text & "%' OR nm_prodi like '%" & tbCari.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridProdi.DataSource = DS.Tables(0)
            closeConn()
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
            closeConn()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With formInputProdi
            .formNormal()
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridProdi_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridProdi.SelectionChanged
        Dim i As Integer = DataGridProdi.CurrentRow.Index
        _kode = Convert.ToString(DataGridProdi.Item(0, i).Value)
        _nm_prodi = Convert.ToString(DataGridProdi.Item(1, i).Value)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With formInputProdi
            .tbKode.Text = _kode
            .tbNm_prodi.Text = _nm_prodi
            .btnSimpan.Text = "&UBAH"
            .formAktif()
            .btnSimpan.Enabled = True
            .btnTambah.Enabled = False
            .btnSimpan.BackColor = Color.AliceBlue
            .btnBatal.BackColor = Color.AliceBlue
            .btnHapus.BackColor = Color.AliceBlue
            .tbKode.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        'mainMenu.Show()
    End Sub

    Private Sub DataGridProdi_DoubleClick(sender As Object, e As EventArgs) Handles DataGridProdi.DoubleClick
        With formInputProdi
            .tbKode.Text = _kode
            .tbNm_prodi.Text = _nm_prodi
            .btnSimpan.Text = "&UBAH"
            .formAktif()
            .btnSimpan.Enabled = True
            .btnTambah.Enabled = False
            .btnSimpan.BackColor = Color.AliceBlue
            .btnBatal.BackColor = Color.AliceBlue
            .btnHapus.BackColor = Color.AliceBlue
            .tbKode.Enabled = False
            .ShowDialog()
        End With
    End Sub
End Class