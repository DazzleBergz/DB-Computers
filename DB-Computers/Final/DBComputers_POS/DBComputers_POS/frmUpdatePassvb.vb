Imports System.Data.OleDb

Public Class frmUpdatePassvb
    Dim conn As OleDb.OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Dim currentPass As String
    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT pass FROM Users WHERE [Employee Number] = '" & frmProfile.txtEmployeeNo.Text & "'"

        rd = cmd.ExecuteReader
        While rd.Read
            currentPass = rd.Item("pass")
        End While

        conn.Close()

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If UCase(txtConfirmPass.Text) = "" Or UCase(txtCurrentPass.Text) = "" Or UCase(txtPassword.Text) = "" Then
            MessageBox.Show("Put all requirements", "Complete Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Not UCase(txtCurrentPass.Text) = currentPass Then
                MessageBox.Show("Wrong Password...", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not UCase(txtConfirmPass.Text) = UCase(txtPassword.Text) Then
                    MessageBox.Show("Wrong Confirmation", "Wrong Confirmation Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    conn.Open()

                    cmd = New OleDbCommand
                    cmd.Connection = conn
                    cmd.CommandText = "UPDATE Users SET pass = '" & UCase(txtPassword.Text) & "' WHERE ID = '" & frmHome.employee & "'"
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Update Successful", "Update To Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmHome.Enabled = True
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtCurrentPass.UseSystemPasswordChar = False
        Else
            txtCurrentPass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub frmUpdatePassvb_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmHome.Enabled = True
    End Sub
End Class