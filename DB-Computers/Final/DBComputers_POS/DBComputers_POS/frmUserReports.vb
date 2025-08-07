Imports System.Data.OleDb
Public Class frmUserReports

    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Dim bytImage() As Byte
    Private Sub frmUserReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        employeeDataGridView()

        lblEmployee.Text = frmHome.employee
        lblEmpName.Text = frmHome.employeeName
        lblDay.Text = Today.DayOfWeek.ToString
        lblMonth.Text = Today.ToString("MMMM/dd/yyyy")

    End Sub

    Private Sub getImage()
        conn.Close
        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM Users WHERE [Employee Number] = '" & lblEmployeeNum.Text & "'"
        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim picbyte() As Byte = dt.Rows(0).Item("picture")
            Dim pic As New System.IO.MemoryStream(picbyte)
            picBoxEmployee.Image = Image.FromStream(pic)
        End If
        conn.Close()
    End Sub

    Private Sub employeeDataGridView()

        Dim staff, coAdmin As String

        staff = "Staff"
        coAdmin = "Co-Admin"

        dgwEmployees.Rows.Clear()

        conn.Close()
        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn

        If frmHome.positions = "Admin" Then
            cmd.CommandText = "SELECT * FROM Users WHERE positions = '" & staff & "' OR positions = '" & coAdmin & "'"
        Else
            cmd.CommandText = "SELECT * FROM Users WHERE positions = '" & staff & "'"
        End If

        dgwEmployees.Rows.Clear()

        rd = cmd.ExecuteReader
        While rd.Read

            dgwEmployees.Rows.Add(rd.Item("Employee Number"),
                                  rd.Item("uname"),
                                  rd.Item("name"),
                                  rd.Item("phoneNumber"),
                                  rd.Item("positions"),
                                  rd.Item("email"),
                                  rd.Item("address"),
                                  rd.Item("sex"),
                                  rd.Item("maritalStatus"))
        End While
        getImage()
    End Sub

    Private Sub dgwEmployees_SelectionChanged(sender As Object, e As EventArgs) Handles dgwEmployees.SelectionChanged
        lblEmployeeNum.Text = dgwEmployees.CurrentRow.Cells(0).Value.ToString
        lblUname.Text = dgwEmployees.CurrentRow.Cells(1).Value.ToString
        lblName.Text = dgwEmployees.CurrentRow.Cells(2).Value.ToString
        lblMob.Text = dgwEmployees.CurrentRow.Cells(3).Value.ToString
        lblPosition.Text = dgwEmployees.CurrentRow.Cells(4).Value.ToString
        lblEmail.Text = dgwEmployees.CurrentRow.Cells(5).Value.ToString
        lblAddress.Text = dgwEmployees.CurrentRow.Cells(6).Value.ToString
        lblSex.Text = dgwEmployees.CurrentRow.Cells(7).Value.ToString
        lblMarital.Text = dgwEmployees.CurrentRow.Cells(8).Value.ToString

        If conn.State = ConnectionState.Closed Then
            getImage()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        dgwEmployees.Rows.Clear()
        conn.Close()
        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM Users WHERE [Employee Number] Like '%" & txtSearch.Text &
            "%' OR uname Like '%" & txtSearch.Text &
            "%' OR positions Like '%" & txtSearch.Text &
            "%' OR address Like '%" & txtSearch.Text &
            "%' OR phoneNumber Like '%" & txtSearch.Text &
            "%' OR Sex Like '%" & txtSearch.Text &
            "%' OR maritalStatus Like '%" & txtSearch.Text &
            "%' OR email Like '%" & txtSearch.Text & "%' "

        rd = cmd.ExecuteReader

        While rd.Read
            dgwEmployees.Rows.Add(rd.Item("Employee Number"),
                                  rd.Item("uname"),
                                  rd.Item("name"),
                                  rd.Item("phoneNumber"),
                                  rd.Item("positions"),
                                  rd.Item("email"),
                                  rd.Item("address"),
                                  rd.Item("Sex"),
                                  rd.Item("maritalStatus"))
        End While
        getImage()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgwEmployees.Rows.Clear()
        employeeDataGridView()
        getImage()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.Enabled = False
        frmAddEmployee.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Me.Enabled = False
        frmUpdateEmployee.Show()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        conn.Close()
        conn.Open()
        Dim result As DialogResult

        result = MessageBox.Show("Do you want to remove this account?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result <> result.No Then
            cmd = New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM Users WHERE [Employee Number] ='" & lblEmployeeNum.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Remove", "An Account has been remove successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information)
            employeeDataGridView()
        End If
    End Sub

    Private Sub frmUserReports_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        frmHome.Show()
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub
End Class