
Imports System.Data.OleDb
Public Class frmCustomer
    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader


    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        showCustomerDetails()
        getTransNumber()

        lblSubTotal.Text = frmTransaction.lblSubTotal.Text

        lblEmployeeNum.Text = frmHome.employee
        lblEmpName.Text = frmHome.employeeName
        lblDay.Text = Today.DayOfWeek.ToString
        lblMonth.Text = Today.ToString("MMMM/dd/yyyy")

    End Sub

    Public Sub showCustomerDetails()

        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "Select * From CustomerDetails"

        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        dgwCustomers.DataSource = dt.DefaultView

        conn.Close()
    End Sub

    Private Sub generateReceipt()

        For index = 0 To frmTransaction.lstOrder.Items.Count - 1

            conn.Open()

            cmd = New OleDbCommand
            cmd.Connection = conn

            cmd.CommandText = "Insert Into Receipt Values ('" & frmTransaction.lstOrder.Items(index).SubItems(0).Text & "',
                                                            '" & frmTransaction.lstOrder.Items(index).SubItems(1).Text & "',
                                                            '" & frmTransaction.lstOrder.Items(index).SubItems(2).Text & "',
                                                            '" & frmTransaction.lstOrder.Items(index).SubItems(3).Text & "')"
            cmd.ExecuteNonQuery()

            conn.Close()
        Next
    End Sub

    Private Sub getTransNumber()
        Dim newTransNumber As String
        Dim x As Integer = 0
        Dim randomizer As Random = New Random

        newTransNumber = "DB-" & Date.Today.Year.ToString & randomizer.Next(1000, 9999) & "TR"

        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT Transaction_Number From Transactions"
        reader = cmd.ExecuteReader
        While reader.Read
            If reader.GetString(0) = newTransNumber Then
                conn.Close()
                getTransNumber()
            Else
                txtTransNumber.Text = newTransNumber
                txtDate.Text = Today
            End If
        End While
        conn.Close()
    End Sub

    Private Sub receipt()
        Dim report As New rptReceipt
        dt = New DataTable
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Receipt", conn)
        da.Fill(dt)
        report.SetDataSource(dt)
        report.SetParameterValue("Transaction Number", txtTransNumber.Text)
        report.SetParameterValue("Total Items", frmTransaction.lblItem.Text)
        report.SetParameterValue("Cash", txtCash.Text)
        report.SetParameterValue("Change", lblChange.Text)
        report.SetParameterValue("Total Amount", lblTotAmount.Text)
        report.SetParameterValue("Cashier", frmHome.employeeName)
        frmReportReceipt.CrystalReportViewer1.ReportSource = report
        Me.Enabled = False
        frmReportReceipt.Show()
    End Sub

    Private Sub clearReceipts()
        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn

        cmd.CommandText = "DELETE FROM Receipt"
        cmd.ExecuteNonQuery()

        conn.Close()
    End Sub

    Private Sub frmCustomer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTransaction.Enabled = True
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim totalAmount, subAmount, cash, change As Integer

        subAmount = lblSubTotal.Text

        If txtCash.Text = "" Then
            MessageBox.Show("Put amount on cash", "No Cash", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            If IsNumeric(txtCash.Text) Then

                If lblCustName.Text = "" Or lblCustNum.Text = "" Then
                    MessageBox.Show("Select Customer or Add Customer", "No Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    cash = txtCash.Text

                    If cash >= subAmount Then

                        totalAmount = subAmount
                        change = cash - totalAmount

                        lblChange.Text = Format(change, "###0.00")
                        lblTotAmount.Text = Format(totalAmount, "###0.00")

                        btnPayment.Enabled = True
                    Else
                        MessageBox.Show("Put greater amount", "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                MessageBox.Show("Put numeric data on cash", "Invalid Data - Cash", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn

        cmd.CommandText = "Insert Into Transactions Values ('" & lblCustNum.Text & "',
                                                            '" & lblCustName.Text & "',
                                                            '" & txtDate.Text & "',
                                                            '" & lblTotAmount.Text & "',
                                                            '" & txtTransNumber.Text & "')"

        cmd.ExecuteNonQuery()

        conn.Close()

        generateReceipt()
        receipt()
        clearReceipts()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        lblCustNum.Text = dgwCustomers.CurrentRow.Cells("Customer Number").Value.ToString
        lblCustName.Text = dgwCustomers.CurrentRow.Cells("Customer Name").Value.ToString

    End Sub

    Private Sub searchCustomer()

        dgwCustomers.DataSource = dt.NewRow

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM CustomerDetails WHERE [Customer Number] Like '%" & txtSearch.Text & "%' OR [Customer Name] Like '%" & txtSearch.Text & "%' "
        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        dgwCustomers.DataSource = dt.DefaultView
        conn.Close()

    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        frmAddCustomer.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTime.Text = TimeOfDay

    End Sub

    Private Sub frmCustomer_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgwCustomers.DataSource = dt.NewRow
        showCustomerDetails()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgwCustomers.DataSource = dt.NewRow
        searchCustomer()
    End Sub

End Class