Imports System.Data.OleDb
Public Class frmRemoveProd
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As DataTable
    Dim da As OleDbDataAdapter


    Private Sub cboHardware_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHardware.SelectedIndexChanged
        If cboHardware.SelectedIndex = 0 Then
            conn.Open()
            hardwareDataGridView()
            conn.Close()
        ElseIf cboHardware.SelectedIndex = 1 Then
            conn.Open()
            hardwareDataGridView()
            conn.Close()
        ElseIf cboHardware.SelectedIndex = 2 Then
            conn.Open()
            hardwareDataGridView()
            conn.Close()
        ElseIf cboHardware.SelectedIndex = 3 Then
            conn.Open()
            hardwareDataGridView()
            conn.Close()
        ElseIf cboHardware.SelectedIndex = 4 Then
            conn.Open()
            hardwareDataGridView()
            conn.Close()
        ElseIf cboHardware.SelectedIndex = 5 Then
            conn.Open()
            hardwareDataGridView()
            conn.Close()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmTransaction.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmRemoveProd_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTransaction.Enabled = True
    End Sub

    Private Sub frmRemoveProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\db_ProductList.mdb")
    End Sub

    Private Sub hardwareDataGridView()

        cmd = New OleDbCommand
        cmd.Connection = conn

        If cboHardware.SelectedIndex = 0 Then
            cmd.CommandText = "Select * From tblProcessor"
        ElseIf cboHardware.SelectedIndex = 1 Then
            cmd.CommandText = "Select * From tblMotherboard"
        ElseIf cboHardware.SelectedIndex = 2 Then
            cmd.CommandText = "Select * From tblGPU"
        ElseIf cboHardware.SelectedIndex = 3 Then
            cmd.CommandText = "Select * From tblRam"
        ElseIf cboHardware.SelectedIndex = 4 Then
            cmd.CommandText = "Select * From tblStorage"
        ElseIf cboHardware.SelectedIndex = 5 Then
            cmd.CommandText = "Select * From tblPSU"
        Else
            MessageBox.Show("No Data in this Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboHardware.Focus()
        End If

        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        dgwProductList.DataSource = dt.DefaultView

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgwProductList.Rows.Count = 0 Then
            MessageBox.Show("No Product to Remove", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dgwProductList.CurrentRow.Selected = False Then
            MessageBox.Show("Select Product to Remove from list", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If cboHardware.SelectedIndex = 5 Then
                conn.Open()
                cmd = New OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Delete From tblPSU Where ID = " & "'" & dgwProductList.CurrentRow.Cells("ID").Value.ToString & "'"
                cmd.ExecuteNonQuery()
                hardwareDataGridView()
                conn.Close()
                MessageBox.Show("Product succesfully removed", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboHardware.SelectedIndex = 0 Then
                conn.Open()
                cmd = New OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Delete From tblProcessor Where Product ID = " & "'" & dgwProductList.CurrentRow.Cells("ID").Value.ToString & "'"
                cmd.ExecuteNonQuery()
                hardwareDataGridView()
                conn.Close()
                MessageBox.Show("Product succesfully removed", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboHardware.SelectedIndex = 1 Then
                conn.Open()
                cmd = New OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Delete From tblMotherboard Where ID = " & "'" & dgwProductList.CurrentRow.Cells("ID").Value.ToString & "'"
                cmd.ExecuteNonQuery()
                hardwareDataGridView()
                conn.Close()
                MessageBox.Show("Product succesfully removed", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboHardware.SelectedIndex = 2 Then
                conn.Open()
                cmd = New OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Delete From tblGPU Where ID = " & "'" & dgwProductList.CurrentRow.Cells("ID").Value.ToString & "'"
                cmd.ExecuteNonQuery()
                hardwareDataGridView()
                conn.Close()
                MessageBox.Show("Product succesfully removed", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboHardware.SelectedIndex = 3 Then
                conn.Open()
                cmd = New OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Delete From tblRam Where ID = " & "'" & dgwProductList.CurrentRow.Cells("ID").Value.ToString & "'"
                cmd.ExecuteNonQuery()
                hardwareDataGridView()
                conn.Close()
                MessageBox.Show("Product succesfully removed", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cboHardware.SelectedIndex = 4 Then
                conn.Open()
                cmd = New OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Delete From tblStorage Where ID = " & "'" & dgwProductList.CurrentRow.Cells("ID").Value.ToString & "'"
                cmd.ExecuteNonQuery()
                hardwareDataGridView()
                conn.Close()
                MessageBox.Show("Product succesfully removed", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class