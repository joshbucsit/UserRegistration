Public Class frmUser
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Close()
        frmLogin.txtPassword.Text = ""
        frmLogin.txtUsername.Text = ""
        frmLogin.Show()
    End Sub
End Class