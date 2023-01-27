Imports System.Runtime.CompilerServices
Imports System.Data.OleDb
Imports System.Net

Public Class frmLogin
    Private Sub btnForgotPass_Click(sender As Object, e As EventArgs) Handles btnForgotPass.Click

    End Sub

    Private Sub btnForgotPass_MouseHover(sender As Object, e As EventArgs) Handles btnForgotPass.MouseHover
        btnForgotPass.BackColor = Color.White
        btnForgotPass.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub btnForgotPass_MouseLeave(sender As Object, e As EventArgs) Handles btnForgotPass.MouseLeave
        btnForgotPass.BackColor = Color.Transparent
        btnForgotPass.ForeColor = Color.White
    End Sub

    Private Sub btnNewUser_MouseLeave(sender As Object, e As EventArgs) Handles btnNewUser.MouseLeave
        btnNewUser.BackColor = Color.Transparent
        btnNewUser.ForeColor = Color.White
    End Sub

    Private Sub btnNewUser_MouseHover(sender As Object, e As EventArgs) Handles btnNewUser.MouseHover
        btnNewUser.BackColor = Color.White
        btnNewUser.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'connect the database and filter the input
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LDRRMA\source\repos\UserRegistration\bin\Database.mdb")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [tblUser] WHERE [username] = '" & txtUsername.Text & "' and [password] = '" & txtPassword.Text & "'", conn)
        'Dim da As New OleDbDataAdapter(cmd)

        If Not conn.State = ConnectionState.Open Then
            conn.Open()
        End If
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim username As String = ""
        Dim usertype As String = ""

        While dr.Read
            username = dr("username").ToString
            usertype = dr("type").ToString
        End While


        If dt.Rows.Count = 1 Then
            If usertype = "Admin" Then
                frmAdmin.Show()
                frmAdmin.lblUser.Text = "Welcome, " & username & "!"
                Me.Hide()
            Else
                frmUser.Show()
                frmUser.lblUserGreet.Text = "Welcome, " & username & "!"
            End If
        Else
                MsgBox("The username and password is Incorrect!", MsgBoxStyle.OkOnly, "Invalid Login")
        End If
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        Me.Hide()
        frmRegister.Show()

    End Sub
End Class

