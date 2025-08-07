Imports System.Data.OleDb

Public Class frmUpdateProd

    Dim cmd As OleDbCommand
    Dim conn As OleDbConnection
    Dim dt As DataTable
    Dim da As OleDbDataAdapter

    Private Sub frmUpdateProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")
        getProduct()
    End Sub

    Private Sub getProduct()

        txtProductID.Text = frmTransaction.dgwProductList.CurrentRow.Cells("Product ID").Value.ToString
        txtProdName.Text = frmTransaction.dgwProductList.CurrentRow.Cells("Product Name").Value.ToString
        txtProdManufacturer.Text = frmTransaction.dgwProductList.CurrentRow.Cells("Manufacturer").Value.ToString
        txtCategory.Text = frmTransaction.hardware
        rctDescription.Text = frmTransaction.dgwProductList.CurrentRow.Cells("Product Description").Value.ToString
        txtPrice.Text = frmTransaction.dgwProductList.CurrentRow.Cells("Price").Value.ToString

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If IsNumeric(txtPrice.Text) Then

            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Product SET [Price]='" & txtPrice.Text & "'WHERE [Product ID]='" & txtProductID.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Price Succesfully Updated", "Price Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()

            returnForm()

        Else
            MessageBox.Show("Price should be numeric", "Product Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles Button1.Click
        returnForm()
    End Sub

    Private Sub frmUpdateProd_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTransaction.Enabled = True
        frmTransaction.Activate()
    End Sub

    Private Sub returnForm()
        Me.Close()
        frmTransaction.Activate()
        frmTransaction.Enabled = True
    End Sub
End Class