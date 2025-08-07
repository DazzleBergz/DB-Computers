Imports System.Data.OleDb
Public Class frmHome

    Dim conn As OleDb.OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader

    Public positions As String
    Public employeeName As String
    Public employee As Object
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT positions FROM Users WHERE uname='" & UCase(frmUserLogin.txtUName.Text) & "' AND pass='" & UCase(frmUserLogin.txtPass.Text) & "'"
        reader = cmd.ExecuteReader

        While reader.Read
            Dim position As String = reader.GetString(0)

            If position = "Staff" Then
                btnUsers.Visible = False

            ElseIf position = "Admin" Then
                btnUsers.Visible = True
                lbPosition.Text = "Admin"
                lbPosition.BackColor = Color.FromArgb(128, 128, 255)
            ElseIf position = "Co-Admin" Then
                btnUsers.Visible = True
                lbPosition.Text = "Co-Admin"
                lbPosition.BackColor = Color.FromArgb(128, 128, 255)
            End If

            positions = position

        End While
        conn.Close()

        lblDay.Text = Today.DayOfWeek.ToString
        lblMonth.Text = Today.ToString("MMMM/dd/yyyy")

        getEmployee()
    End Sub

    Private Sub getEmployee()

        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT [Employee Number], name FROM Users WHERE uname='" & UCase(frmUserLogin.txtUName.Text) & "' AND pass='" & UCase(frmUserLogin.txtPass.Text) & "'"
        reader = cmd.ExecuteReader
        While reader.Read
            employee = reader.GetString(0)
            employeeName = reader.GetString(1)
        End While
        conn.Close()
        lblEmployeeNum.Text = employee
        lblEmpName.Text = employeeName
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        frmProfile.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        frmUserReports.Show()
        Me.Hide()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        frmReport.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmUserLogin.txtUName.Text = ""
        frmUserLogin.txtPass.Text = ""
        Me.Close()
    End Sub

    Private Sub frmHome_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmUserLogin.txtUName.Text = ""
        frmUserLogin.txtPass.Text = ""
        frmUserLogin.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

End Class