Imports System.Data.OleDb
Public Class frmUserLogin

    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cmd As OleDbCommand

    Private Sub frmUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")
    End Sub

    Private Sub frmUserLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        If UCase(txtUName.Text) = Nothing Or UCase(txtPass.Text) = Nothing Then
            MessageBox.Show("Enter Credentials", "Enter all Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            conn.Open()
            cmd = New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE uname='" & UCase(txtUName.Text) & "' AND pass='" & UCase(txtPass.Text) & "'"
            Dim count As Integer = cmd.ExecuteScalar()

            If (count > 0) Then
                MessageBox.Show("Login Successfully", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                Me.Hide()
                frmHome.Show()
            Else
                MessageBox.Show("Account not found check credentials", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUName.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub klblForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles klblForgot.LinkClicked
        Me.Enabled = False
        frmForgot.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class