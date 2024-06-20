Public Class mainMenu

    Private Sub DataProdiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataProdiToolStripMenuItem1.Click
        'FrmDataProdi.Show()
        'Me.Hide()
        switchPanel(FrmDataProdi)
    End Sub

    Private Sub DataMahasiswaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataMahasiswaToolStripMenuItem1.Click
        'FrmDataMahasiswa.Show()
        'Me.Hide()
        switchPanel(FrmDataMahasiswa)
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Dim Pesan As String
        Pesan = MsgBox("Anda Yakin Mau Keluar ?", vbQuestion + vbYesNo, "QUESTION")
        If Pesan = vbYes Then
            Me.Hide()
            FrmDataMahasiswa.Close()
            FrmDataProdi.Close()
            FormLogin.Show()
        End If
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub
End Class