Imports System.Data.OleDb

Public Class frmManageCategory

    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader
    Dim dt As DataTable
    Dim da As OleDb.OleDbDataAdapter

    Private Sub frmAddCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")
        getCategories()

    End Sub

    Private Sub getCategories()
        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT Category FROM Categories"
        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        dgwCategories.DataSource = dt.DefaultView
        conn.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        conn.Open()
        If txtCatName.Text = "" Then
            MessageBox.Show("Input name category", "Category Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmd = New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT Category FROM Categories WHERE Category = '" & UCase(txtCatName.Text) & "'"
            reader = cmd.ExecuteReader()

            If reader.Read = True Then
                MessageBox.Show("Product category already taken...", "Product Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCatName.Text = ""
                conn.Close()
            Else
                reader.Close()
                cmd.CommandText = "INSERT INTO Categories VALUES('" & UCase(txtCatName.Text) & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Product category successfully added", "Product Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
                getCategories()
            End If
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmTransaction.Enabled = True
        frmTransaction.Activate()
        Me.Close()
    End Sub

    Private Sub frmAddCategory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTransaction.Enabled = True
        frmTransaction.Activate()
    End Sub
End Class