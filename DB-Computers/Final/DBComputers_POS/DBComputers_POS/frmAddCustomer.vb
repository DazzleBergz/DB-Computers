Imports System.Data.OleDb

Public Class frmAddCustomer

    Dim conn As OleDb.OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader

    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        getCustNumber()
    End Sub

    Private Sub clear()
        txtCustName.Text = ""
        txtCustNum.Text = ""
        txtEmail.Text = ""
        txtMob.Text = ""
    End Sub

    Private Sub getCustNumber()

        Dim newCustNumber As String
        Dim x As Integer = 0
        Dim randomizer As Random = New Random

        newCustNumber = "DB-" & Date.Today.Year.ToString & randomizer.Next(1000, 9999) & "-CN"

        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT [Customer Number] From CustomerDetails"
        reader = cmd.ExecuteReader
        While reader.Read
            If reader.GetString(0) = newCustNumber Then
                conn.Close()
                getCustNumber()
            Else
                txtCustNum.Text = newCustNumber
            End If
        End While
        conn.Close()
    End Sub

    Private Sub btnAddCusto_Click(sender As Object, e As EventArgs) Handles btnAddCusto.Click

        If txtCustName.Text = "" Or txtMob.Text = "" Or txtEmail.Text = "" Then

            MessageBox.Show("Complete details requirements", "Complete Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If IsNumeric(txtMob.Text) Then
                If txtMob.Text.Length = 11 Then

                    conn.Open()
                    cmd = New OleDbCommand
                    cmd.Connection = conn

                    cmd.CommandText = "Insert Into CustomerDetails Values('" & txtCustNum.Text & "', 
                                                                        '" & txtCustName.Text & "',
                                                                        '" & txtMob.Text & "',
                                                                        '" & txtEmail.Text & "')"

                    cmd.ExecuteNonQuery()
                    conn.Close()
                    clear()
                    getCustNumber()
                    MessageBox.Show("Customer Add Successfully", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Phone Number should be 11 digits", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Phone Number should be numeric", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmCustomer.Show()
        Me.Close()
    End Sub
    Private Sub frmAddCustomer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmCustomer.Show()
    End Sub

End Class