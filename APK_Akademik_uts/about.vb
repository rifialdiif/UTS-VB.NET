Public Class about
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendKeys.Send("{ENTER}")
        Me.Hide()
        mainMenu.Show()
    End Sub
End Class