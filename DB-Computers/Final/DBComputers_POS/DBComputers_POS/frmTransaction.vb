Imports System.Data.OleDb

Public Class frmTransaction

    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader
    Dim report As New rptTransactions

    Public hardware As String

    Private Sub frmTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        If frmHome.positions = "Staff" Then
            gbxProdControl.Visible = False
        Else
            gbxProdControl.Visible = True
        End If

        btnPayment.Enabled = False
        btnRemove.Enabled = False
        btnClearAll.Enabled = False
        cboPrice.Enabled = False
        txtSearch.Enabled = False

        btnPlus.Enabled = False
        btnMinus.Enabled = False

        lblEmployeeNum.Text = frmHome.employee
        lblEmpName.Text = frmHome.employeeName
        lblDay.Text = Today.DayOfWeek.ToString
        lblMonth.Text = Today.ToString("MMMM/dd/yyyy")

        getCategories()
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        cboPrice.SelectedItem = "None"
        txtSearch.Text = ""

        If cboCategory.SelectedIndex = -1 Then
            cboPrice.Enabled = False
            txtSearch.Enabled = False
        End If

        hardwareDataGridView()
    End Sub

    Private Sub hardwareDataGridView()
        hardware = cboCategory.SelectedItem

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "Select [Product ID], [Product Name], Manufacturer, [Product Description], Price From Product WHERE Category = '" & hardware & "'"

        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        dgwProductList.DataSource = dt.DefaultView

        cboPrice.Enabled = True
        txtSearch.Enabled = True
    End Sub

    Private Sub removeProduct()
        conn.Close()
        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn

        cmd.CommandText = "Delete From Product Where [Product ID] = '" & dgwProductList.CurrentRow.Cells("Product ID").Value.ToString & "'"
        cmd.ExecuteNonQuery()

        hardwareDataGridView()

        MessageBox.Show("Product succesfully removed", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub getCategories()
        conn.Close()
        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "Select Category From Categories"
        reader = cmd.ExecuteReader()

        While reader.Read
            cboCategory.Items.Add(reader.GetString(0))
        End While

        cboCategory.SelectedIndex = -1
    End Sub

    Private Sub cboPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPrice.SelectedIndexChanged
        conn.Close()
        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn

        If cboPrice.SelectedItem = "None" Then

            hardwareDataGridView()

        Else
            txtSearch.Text = ""

            If cboPrice.SelectedIndex = 1 Then
                cmd.CommandText = "Select * From Product WHERE Category = '" & cboCategory.SelectedItem & "' AND Price BETWEEN 1000 AND 10000"
            ElseIf cboPrice.SelectedIndex = 2 Then
                cmd.CommandText = "Select * From Product WHERE Category = '" & cboCategory.SelectedItem & "' AND Price BETWEEN 10000 AND 30000"
            ElseIf cboPrice.SelectedIndex = 3 Then
                cmd.CommandText = "Select * From Product WHERE Category = '" & cboCategory.SelectedItem & "' AND Price BETWEEN 30000 AND 60000"
            ElseIf cboPrice.SelectedIndex = 4 Then
                cmd.CommandText = "Select * From Product WHERE Category = '" & cboCategory.SelectedItem & "' AND Price BETWEEN 50000 AND 70000"
            ElseIf cboPrice.SelectedIndex = 5 Then
                cmd.CommandText = "Select * From Product WHERE Category = '" & cboCategory.SelectedItem & "' AND Price BETWEEN 70000 AND 100000"
            End If
        End If

        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        dgwProductList.DataSource = dt.DefaultView

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If txtSearch.Text = "" Then

            hardwareDataGridView()

        Else
            cboPrice.SelectedItem = "None"
            conn.Close()
            conn.Open()
            cmd = New OleDbCommand
            cmd.Connection = conn

            cmd.CommandText = "SELECT [Product ID], [Product Name], Manufacturer, [Product Description], Price From Product WHERE Category = '" & cboCategory.SelectedItem & "' AND [Product Name] Like '%" & txtSearch.Text & "%'"

            dt = New DataTable
            da = New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            dgwProductList.DataSource = dt.DefaultView
        End If

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        Dim subTotal As Integer
        Dim apperance As Boolean

        If Not lstOrder.Items.Count = 0 Then
            For index = 0 To lstOrder.Items.Count - 1

                If dgwProductList.CurrentRow.Cells("Product Name").Value.ToString = lstOrder.Items(index).SubItems(0).Text Then
                    lstOrder.Items(index).SubItems(1).Text = CInt(lstOrder.Items(index).SubItems(1).Text) + 1

                    apperance = True

                    lstOrder.Items(index).SubItems(3).Text = CInt(lstOrder.Items(index).SubItems(2).Text) * CInt(lstOrder.Items(index).SubItems(1).Text)
                    getTotal()
                End If
            Next

        End If

        If apperance = False Then
            If Not dgwProductList.Rows.Count = 0 Then

                subTotal = dgwProductList.CurrentRow.Cells("Price").Value * 1

                lstOrder.Items.Add(New ListViewItem({dgwProductList.CurrentRow.Cells("Product Name").Value.ToString,
                                    1,
                                    dgwProductList.CurrentRow.Cells("Price").Value.ToString,
                                    subTotal}))

                btnPayment.Enabled = True
                btnRemove.Enabled = True
                btnClearAll.Enabled = True

                getTotal()
            End If
        End If


    End Sub

    Private Sub lstOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrder.SelectedIndexChanged
        lblQuantity.Text = CInt(lstOrder.FocusedItem.SubItems(1).Text)
        btnPlus.Enabled = True

        If lblQuantity.Text = 1 Then
            btnMinus.Enabled = False
        Else
            btnMinus.Enabled = True
        End If
    End Sub
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If lstOrder.Items.Count = 0 Then
            btnPlus.Enabled = False
            btnMinus.Enabled = False
        Else
            btnPlus.Enabled = True
            If lblQuantity.Text = 0 Then
                btnMinus.Enabled = False
            Else
                btnMinus.Enabled = True
            End If

            lstOrder.FocusedItem.SubItems(1).Text = CInt(lstOrder.FocusedItem.SubItems(1).Text) + 1
            lblQuantity.Text = CInt(lstOrder.FocusedItem.SubItems(1).Text)
            lstOrder.FocusedItem.SubItems(3).Text = CInt(lstOrder.FocusedItem.SubItems(2).Text) * CInt(lstOrder.FocusedItem.SubItems(1).Text)
            getTotal()
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click

        If lstOrder.Items.Count = 0 Then
            btnPlus.Enabled = False
            btnMinus.Enabled = False
        Else
            btnPlus.Enabled = True
            If lblQuantity.Text = 2 Then
                btnMinus.Enabled = False
            Else
                btnMinus.Enabled = True
            End If

            lstOrder.FocusedItem.SubItems(1).Text = CInt(lstOrder.FocusedItem.SubItems(1).Text) - 1
            lblQuantity.Text = CInt(lstOrder.FocusedItem.SubItems(1).Text)
            lstOrder.FocusedItem.SubItems(3).Text = CInt(lstOrder.FocusedItem.SubItems(2).Text) * CInt(lstOrder.FocusedItem.SubItems(1).Text)
            getTotal()
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lstOrder.SelectedItems.Count > 0 Then
            lstOrder.Items.Remove(lstOrder.SelectedItems(0))
            getTotal()
            btnPlus.Enabled = False
            btnMinus.Enabled = False
            lblQuantity.Text = "0"
        End If

        If lblSubTotal.Text = "0" Then
            btnPayment.Enabled = False
            btnRemove.Enabled = False
            btnClearAll.Enabled = False
            btnPlus.Enabled = False
            btnMinus.Enabled = False
            lblQuantity.Text = "0"
        Else
            btnPayment.Enabled = True
        End If



    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        lstOrder.Items.Clear()
        btnPayment.Enabled = False
        btnClearAll.Enabled = False
        btnRemove.Enabled = False
        cboPrice.Enabled = False
        txtSearch.Enabled = False
        btnPlus.Enabled = False
        btnMinus.Enabled = False
        lblQuantity.Text = "0"
        getTotal()
    End Sub

    Private Sub getTotal()

        Dim subTotal As Integer
        Dim itemTotal As Integer

        For index = 0 To lstOrder.Items.Count - 1
            subTotal = CInt(subTotal + lstOrder.Items(index).SubItems(3).Text)
            itemTotal = CInt(itemTotal + lstOrder.Items(index).SubItems(1).Text)
        Next

        lblSubTotal.Text = subTotal
        lblItem.Text = itemTotal

    End Sub

    Private Sub btnAddProd_Click(sender As Object, e As EventArgs) Handles btnAddProd.Click
        frmAddProd.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnRemoveProd_Click(sender As Object, e As EventArgs) Handles btnRemoveProd.Click


        If dgwProductList.Rows.Count = 0 Then
            MessageBox.Show("No Product to Remove", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dgwProductList.CurrentRow.Selected = False Then
            MessageBox.Show("Select Product to Remove from list", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            removeProduct()
        End If
    End Sub

    Private Sub btnUpdateProd_Click(sender As Object, e As EventArgs) Handles btnUpdateProd.Click
        If dgwProductList.Rows.Count = 0 Then
            MessageBox.Show("No Product to Edit", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dgwProductList.CurrentRow.Selected = False Then
            MessageBox.Show("Select Product to Update from list", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            frmUpdateProd.Show()
            Me.Enabled = False
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        report = New rptTransactions

        Dim todayDate As String
        todayDate = Date.Today

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM Transactions WHERE Transaction_Date = @dates"

        cmd.Parameters.AddWithValue("@dates", SqlDbType.DateTime).Value = todayDate
        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        report.SetDataSource(dt)
        report.SetParameterValue("Sales", "Today Sales")
        frmReportTransaction.CrystalReportViewer1.ReportSource = report
        Me.Enabled = False
        frmReportTransaction.Show()
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        Me.Enabled = False
        frmManageCategory.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmCustomer.Show()
        Me.Enabled = False
    End Sub

    Private Sub frmTransaction_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        frmHome.Show()
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        frmHome.Close()
        frmUserLogin.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub frmTransaction_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cboCategory.Items.Clear()
        If dgwProductList.Rows.Count > 0 Then
            dgwProductList.DataSource = dt.NewRow
        End If
        getCategories()
    End Sub

End Class