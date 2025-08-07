Imports System.Data.OleDb

Public Class frmUpdateEmployee

    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cmd As OleDbCommand

    Dim sex, marital, position As String

    Private Sub frmUpdateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        txtEmployeeNo.Text = frmUserReports.lblEmployeeNum.Text
        txtUName.Text = frmUserReports.lblUname.Text
        txtName.Text = frmUserReports.lblName.Text
        txtAddress.Text = frmUserReports.lblAddress.Text
        txtNumber.Text = frmUserReports.lblMob.Text
        txtEmail.Text = frmUserReports.lblEmail.Text

        If frmHome.positions = "Co-Admin" Then
            gbPosition.Visible = False
        End If

        rdoPosition()
        getImage()
    End Sub

    Private Sub getImage()

        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM Users WHERE [Employee Number] = '" & txtEmployeeNo.Text & "'"
        dt = New DataTable
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)

        Dim picbyte() As Byte = dt.Rows(0).Item("picture")
        Dim pic As New System.IO.MemoryStream(picbyte)
        picBoxEmployee.Image = Image.FromStream(pic)
        conn.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If frmHome.positions = "Co-Admin" Then
            position = "Staff"
        End If
        If IsNumeric(txtNumber.Text) Then
            If txtNumber.Text.Length = 11 Then

                Dim ms As New System.IO.MemoryStream
                Dim bm As Bitmap = New Bitmap(picBoxEmployee.Image)
                bm.Save(ms, picBoxEmployee.Image.RawFormat)

                Dim arrPic() As Byte = ms.GetBuffer()

                getStatus()

                conn.Open()

                cmd = New OleDbCommand
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE Users SET uname = '" & UCase(txtUName.Text) & "',
                                                  positions ='" & position & "',
                                                  address = '" & txtAddress.Text & "',
                                                  phoneNumber = '" & txtNumber.Text & "',
                                                  Sex ='" & sex & "',
                                                  maritalStatus ='" & marital & "',
                                                  email = '" & txtEmail.Text & "',
                                                  name = '" & txtName.Text & "',
                                                  Picture =@picture Where [Employee Number] = '" & txtEmployeeNo.Text & "'"

                cmd.Parameters.AddWithValue("@picture", arrPic)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Update Successful", "Update To Database", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conn.Close()

                frmUserReports.Update()

                Me.Close()
            Else
                MessageBox.Show("Phone Number should be 11 digits", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Phone Number should be numeric", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If frmUserReports.lblPosition.Text = "Co-Admin" Then
            rdoAdmin.Checked = True
            position = "Co-Admin"
            rdoSex()
        ElseIf frmUserReports.lblPosition.Text = "Staff" Then
            rdoStaff.Checked = True
            position = "Staff"
            rdoSex()
        End If
    End Sub

    Private Sub rdoSex()
        If frmUserReports.lblSex.Text = "Female" Then
            rdoFemale.Checked = True
            sex = "Female"
            rdoMarital()
        ElseIf frmUserReports.lblSex.Text = "Male" Then
            rdoMale.Checked = True
            sex = "Male"
            rdoMarital()
        End If

    End Sub

    Private Sub rdoMarital()
        If frmUserReports.lblMarital.Text = "Single" Then
            rdoSingle.Checked = True
            marital = "Single"
        ElseIf frmUserReports.lblMarital.Text = "Married" Then
            rdoMarried.Checked = True
            marital = "Married"
        End If
    End Sub

    Private Sub getStatus()

        If rdoAdmin.Checked = True Then
            position = "Co-Admin"
        ElseIf rdoStaff.Checked = True Then
            position = "Staff"
        End If

        If rdoFemale.Checked = True Then
            sex = "Female"
        ElseIf rdoMale.Checked = True Then
            sex = "Male"
        End If

        If rdoSingle.Checked = True Then
            marital = "Single"
        ElseIf rdoMarried.Checked = True Then
            marital = "Married"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmUserReports.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmUpdateEmployee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmUserReports.Enabled = True
    End Sub

End Class