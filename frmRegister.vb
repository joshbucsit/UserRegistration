Imports System.Data.OleDb
Imports System.Windows
Imports FontAwesome.Sharp

Public Class frmRegister
    Private Sub btnRegisterClose_Click(sender As Object, e As EventArgs) Handles btnRegisterClose.Click
        Close()
        frmLogin.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LDRRMA\source\repos\UserRegistration\bin\Database.mdb")
        Using register As New OleDbCommand("Insert INTO tblUser ([username], [password], [fullname], [type]) values (@username, @password, @fullname, @type)", conn)

            register.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = txtAddUsername.Text.Trim
            register.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = txtAddPassword.Text.Trim
            register.Parameters.AddWithValue("@fullname", OleDbType.VarChar).Value = txtAddFullname.Text.Trim
            register.Parameters.AddWithValue("@type", OleDbType.VarChar).Value = cbUsertype.Text.Trim

            conn.Open()
            If register.ExecuteNonQuery Then
                MsgBox("Successfull registration!", MsgBoxStyle.OkOnly, "Information")
            Else
                MsgBox("Registration unsuccessfull!", MsgBoxStyle.OkOnly, "Information")
            End If
        End Using
        conn.Close()
    End Sub
End Class