Imports System.Data.OleDb

Public Class frmMain
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LDRRMA\source\repos\Registration\Resources\Database.mdb")
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
            sql = "Select * from studentRegistration"
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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub

    Private Sub btnDashboard_MouseHover(sender As Object, e As EventArgs) Handles btnDashboard.MouseHover
        btnDashboard.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub btnStudProfile_MouseHover(sender As Object, e As EventArgs) Handles btnStudProfile.MouseHover
        btnStudProfile.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub btnSetting_MouseHover(sender As Object, e As EventArgs) Handles btnSetting.MouseHover
        btnSetting.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub btnSetting_MouseLeave(sender As Object, e As EventArgs) Handles btnSetting.MouseLeave
        btnSetting.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnStudProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnStudProfile.MouseLeave
        btnStudProfile.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnDashboard_MouseLeave(sender As Object, e As EventArgs) Handles btnDashboard.MouseLeave
        btnDashboard.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnExitMain_Click(sender As Object, e As EventArgs) Handles btnExitMain.Click

    End Sub

    Private Sub btnExitMain_MouseHover(sender As Object, e As EventArgs) Handles btnExitMain.MouseHover
        btnExitMain.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub btnExitMain_MouseLeave(sender As Object, e As EventArgs) Handles btnExitMain.MouseLeave
        btnExitMain.FlatAppearance.BorderSize = 0
    End Sub
End Class