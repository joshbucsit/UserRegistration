Imports System.Data.OleDb

Public Class frmAdmin
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LDRRMA\source\repos\IntegrativeProgramming02\bin\Database.mdb")
    Private Sub btnAdminClose_Click(sender As Object, e As EventArgs) Handles btnAdminClose.Click
        Me.Hide()
        frmLogin.Show()
        frmLogin.txtPassword.Text = ""
        frmLogin.txtUsername.Text = ""
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            conn.Open()
            sql = "Select * from tblUser"
            cmd.Connection = conn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
End Class