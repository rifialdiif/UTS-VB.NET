Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class FormLogin
    Private Property attempts As Integer
    Public Property userRole As String

    Private Sub checkLogin()
        Try
            Call openConn()
            'CMD = New OdbcCommand("SELECT * FROM users WHERE username = '" + tbUser.Text + "' AND password = '" + tbPass.Text + "'", Conn)
            CMD = New OdbcCommand("SELECT * FROM tb_user WHERE nama = ? AND pass = ?", Conn)

            'Assign parameters
            With CMD
                .Parameters.AddWithValue("@username", tbUser.Text)
                .Parameters.AddWithValue("@password", tbPass.Text)
            End With

            'Execute command
            Dim dr As OdbcDataReader = CMD.ExecuteReader()

            'Check if record exists
            If dr.HasRows Then
                dr.Read()
                'Reset attempts
                attempts = 0
                userRole = dr("role")
                Select Case userRole
                    Case "Admin"
                        MessageBox.Show("Welcome Admin!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        mainMenu.ShowDialog()

                    Case "User"
                        MessageBox.Show("Welcome " + tbUser.Text + "!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()

                        With mainMenu
                            .MasterToolStripMenuItem.Text = "Data"
                            .ShowDialog()
                        End With

                End Select
            Else
                'Increment attempts
                attempts += 1

                'Check attempts limit
                If attempts >= 3 Then
                    'Disable login button
                    btnLogin.Enabled = False

                    'Display message
                    MessageBox.Show("Too many failed attempts. Please try again later.")
                    tbPass.Clear()
                    tbUser.Clear()
                Else
                    'Error message
                    MessageBox.Show("Incorrect username or password. Attempt " & attempts & " of 3.")
                    tbUser.Clear()
                    tbPass.Clear()
                End If
            End If
            closeConn()
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        End Try

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If tbUser.Text = "" Then
                MsgBox("Nama User tidak boleh kosong", MsgBoxStyle.Exclamation, "Kosong!")
                tbUser.Focus()
            ElseIf tbPass.Text = "" Then
                MsgBox("Nama Password tidak boleh kosong", MsgBoxStyle.Exclamation, "Kosong!")
                tbPass.Focus()
            Else
                Call checkLogin()
            End If
        Catch ex As Exception
            MsgBox("err:" + ex.Message)
        End Try
        tbUser.Clear()
        tbPass.Clear()


    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim Pesan As String
        Pesan = MsgBox("Anda Yakin Mau Keluar ?", vbQuestion + vbYesNo, "QUESTION")
        If Pesan = vbYes Then
            Me.Close()
            Application.Exit()
        Else
            tbPass.Focus()
        End If

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.BackColor = Color.AliceBlue
        btnBatal.BackColor = Color.Red
    End Sub
End Class