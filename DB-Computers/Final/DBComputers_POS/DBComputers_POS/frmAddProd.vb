Imports System.Data.OleDb

Public Class frmAddProd

    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader

    Private Sub frmAddProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")
        getCategories()
        getProdNumber()
    End Sub

    Private Sub getCategories()
        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "Select Category From Categories"
        reader = cmd.ExecuteReader()

        While reader.Read
            cboHardware.Items.Add(reader.GetString(0))
        End While

        conn.Close()
    End Sub

    Private Sub getProdNumber()

        Dim newProdNumber As String
        Dim x As Integer = 0
        Dim randomizer As Random = New Random

        newProdNumber = "DB-" & Date.Today.Year.ToString & randomizer.Next(1000, 9999) & "-PD"

        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT [Product ID] From Product"

        reader = cmd.ExecuteReader
        While reader.Read
            If reader.GetString(0) = newProdNumber Then
                conn.Close()
                getProdNumber()
            Else
                txtProductID.Text = newProdNumber
            End If
        End While
        conn.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn

        If txtProductID.Text = "" Or txtProdName.Text = "" Or txtProdManufacturer.Text = "" Then
            MessageBox.Show("Please Fill Out All The Information", "Product Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If IsNumeric(txtPrice.Text) Then
                cmd.CommandText = "Insert into Product VALUES('" & CType(txtProductID.Text, String) & "',
                                                                    '" & CType(cboHardware.SelectedItem, String) & "',
                                                                    '" & CType(txtProdName.Text, String) & "',
                                                                    '" & CType(txtProdManufacturer.Text, String) & "',
                                                                    '" & CType(rctDescription.Text, String) & "',
                                                                    '" & CType(txtPrice.Text, Integer) & "')"

                MessageBox.Show("Product Succesfully Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear()
                cmd.ExecuteNonQuery()
                conn.Close()
                getProdNumber()
            Else
                MessageBox.Show("Price should be numeric", "Product Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        conn.Close()
    End Sub

    Private Sub Clear()
        txtPrice.Text = ""
        txtProdManufacturer.Text = ""
        txtProdName.Text = ""
        rctDescription.Text = ""
    End Sub

    Private Sub frmAddProd_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTransaction.Enabled = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmTransaction.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPrice.Text = ""
        txtProdManufacturer.Text = ""
        txtProdName.Text = ""
        rctDescription.Text = ""
    End Sub
End Class