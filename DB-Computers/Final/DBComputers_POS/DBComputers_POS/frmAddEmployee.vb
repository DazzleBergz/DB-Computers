
Imports System.Data.OleDb
Public Class frmAddEmployee

    Dim conn As OleDb.OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Dim missed As Integer
    Dim randomizer As New Random()
    Dim employeeNumber As String

    Private Sub frmAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        generateEmployeeNumber()

        If frmHome.positions = "Co-Admin" Then
            gbPosition.Visible = False
            rdoStaff.Checked = True
        End If

    End Sub

    Private Sub generateEmployeeNumber()

        employeeNumber = "DB-" & Date.Today.Year.ToString & randomizer.Next(1000, 9999).ToString

        conn.Open()

        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT [Employee Number] FROM Users Where [Employee Number] = '" & employeeNumber & "'"
        rd = cmd.ExecuteReader

        If rd.Read Then
            conn.Close()
            generateEmployeeNumber()
        Else
            txtEmployeeNo.Text = employeeNumber
        End If
        conn.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        missed = 0
        rdoPosition()

        If missed > 0 Or txtAddress.Text = "" Or txtEmployeeNo.Text = "" Or txtName.Text = "" Or txtUName.Text = "" Then
            MessageBox.Show("Please Complete Details", "Complete Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If IsNumeric(txtNumber.Text) Then
                If txtNumber.Text.Length = 11 Then
                    frmSetPassword.Show()
                Else
                    MessageBox.Show("Phone Number should be 11 digits", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Phone Number should be numeric", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnChooseimg_Click(sender As Object, e As EventArgs) Handles btnChooseimg.Click
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.JFIF)|*.BMP;*.JPG;*.GIF;*.PNG;*.JFIF"

        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picBoxEmployee.Image = Image.FromFile(dialog.FileName)
        End If
    End Sub

    Private Sub rdoPosition()
        If rdoFemale.Checked Or rdoMale.Checked Then
            rdoSex()
        Else
            missed = missed + 1
        End If
    End Sub

    Private Sub rdoSex()
        If rdoAdmin.Checked Or rdoStaff.Checked Then
            rdoMarital()
        Else
            missed = missed + 1
        End If
    End Sub

    Private Sub rdoMarital()
        If rdoSingle.Checked Or rdoMarried.Checked Then

        Else
            missed = missed + 1
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmUserReports.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmAddEmployee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmUserReports.Enabled = True
    End Sub

End Class