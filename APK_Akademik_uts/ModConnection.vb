'
'
'
'         Made by Fadli Nurhidayat with ❤️
'
'
'
Imports System.Data.Odbc
Module ModConnection
    Public Conn As OdbcConnection
    Public DR As OdbcDataReader
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public CMD As OdbcCommand
    Public connStr As String
    Public SQLInsert As String
    Public SQLUpdate As String
    Public SQLDelete As String

    Public Sub openConn()
        connStr = "Dsn=MySQL ANSI - dbAkademik;uid=root"
        Conn = New OdbcConnection(connStr)

        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Public Sub closeConn()
        If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub

    Public Sub load_data()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM viewMahasiswa ORDER BY nim ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "viewMahasiswa")
            FrmDataMahasiswa.DataGridMahasiswa.DataSource = DS.Tables("viewMahasiswa")
            FrmDataMahasiswa.DataGridMahasiswa.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Sub

    Public Sub load_prodi()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM tb_prodi ORDER BY kd_prodi ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "tb_prodi")
            FrmDataProdi.DataGridProdi.DataSource = DS.Tables("tb_prodi")
            FrmDataProdi.DataGridProdi.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Sub
End Module
