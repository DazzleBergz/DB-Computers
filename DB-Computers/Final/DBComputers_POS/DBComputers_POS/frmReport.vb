
Imports System.Data.OleDb

Public Class frmReport

    Dim reportConn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dt As DataTable

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reportConn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        Dim report As New rptTransactions
        dt = New DataTable
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Transactions", reportConn)
        da.Fill(dt)
        report.SetDataSource(dt)
        report.SetParameterValue("Sales", "Daily Sales")
        Me.CrystalReportViewer1.ReportSource = report

        dtpTo.Text = Today
        dtpFrom.Text = Today

        getYear()
    End Sub

    Private Sub getYear()

        Dim currentYear As Integer
        Dim leastYear As Integer

        currentYear = Date.Today.Year

        leastYear = currentYear - 2005

        For index = 0 To leastYear
            cboYear.Items.Add(currentYear - (leastYear - index))
            cboYears.Items.Add(currentYear - (leastYear - index))
        Next

    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click

        Dim totalDays As Integer

        totalDays = DateDiff("d", dtpTo.Text, dtpFrom.Text)

        If totalDays > 0 Then
            MessageBox.Show("TO DATE SHOULD BE GREATER THAN FROM DATE", "Daily Sales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim report As New rptTransactions
            cmd = New OleDbCommand
            cmd.Connection = reportConn
            cmd.CommandText = "SELECT * FROM Transactions Where Transaction_Date BETWEEN @From AND @To"

            cmd.Parameters.AddWithValue("@From", SqlDbType.DateTime).Value = dtpFrom.Text
            cmd.Parameters.AddWithValue("@To", SqlDbType.DateTime).Value = dtpTo.Text

            dt = New DataTable
            da = New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            report.SetDataSource(dt)
            report.SetParameterValue("Sales", "Daily Sales")
            Me.CrystalReportViewer1.ReportSource = report
            Me.Show()
        End If
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click

        If cboMonth.SelectedIndex = -1 Then
            MessageBox.Show("Select Month", "Select Month", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cboYear.SelectedIndex = -1 Then
            MessageBox.Show("Select YEAR", "Select YEAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim month As Integer = cboMonth.SelectedIndex + 1

            Dim days As String = System.DateTime.DaysInMonth(cboYear.SelectedItem, month)

            Dim toDate As String = "01/" & month & "/" & cboYear.SelectedItem.ToString
            Dim fromDate As String = days & "/" & month & "/" & cboYear.SelectedItem.ToString

            Dim report As New rptTransactions
            cmd = New OleDbCommand
            cmd.Connection = reportConn
            cmd.CommandText = "SELECT * FROM Transactions Where Transaction_Date BETWEEN @To AND @From "

            cmd.Parameters.AddWithValue("@To", SqlDbType.DateTime).Value = toDate
            cmd.Parameters.AddWithValue("@From", SqlDbType.DateTime).Value = fromDate

            dt = New DataTable
            da = New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            report.SetDataSource(dt)
            report.SetParameterValue("Sales", "Monthly Sales")
            Me.CrystalReportViewer1.ReportSource = report
            Me.Show()
        End If

    End Sub

    Private Sub btnYearly_Click(sender As Object, e As EventArgs) Handles btnYearly.Click

        If cboYears.SelectedIndex = -1 Then
            MessageBox.Show("Select YEAR in ComboBox", "Select Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim toDate As String = "01/01/" & cboYears.SelectedItem.ToString
            Dim fromDate As String = "31/12/" & cboYears.SelectedItem.ToString

            Dim report As New rptTransactions
            cmd = New OleDbCommand
            cmd.Connection = reportConn
            cmd.CommandText = "SELECT * FROM Transactions Where Transaction_Date BETWEEN @To AND @From "

            cmd.Parameters.AddWithValue("@To", SqlDbType.DateTime).Value = toDate
            cmd.Parameters.AddWithValue("@From", SqlDbType.DateTime).Value = fromDate

            dt = New DataTable
            da = New OleDb.OleDbDataAdapter(cmd)
            da.Fill(dt)
            report.SetDataSource(dt)
            report.SetParameterValue("Sales", "Yearly Sales")
            Me.CrystalReportViewer1.ReportSource = report
            Me.Show()
        End If

    End Sub

    Private Sub frmReport_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmHome.Enabled = True
    End Sub
End Class