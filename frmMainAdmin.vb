Public Class frmAdmin
    Private Sub btnCloseAdmin_Click(sender As Object, e As EventArgs) Handles btnCloseAdmin.Click
        Me.Hide()
        frmLogin.Show()
        frmLogin.txtPassword.Text = ""
        frmLogin.txtUsername.Text = ""
    End Sub
End Class