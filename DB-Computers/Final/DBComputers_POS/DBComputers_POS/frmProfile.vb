Imports System.Data.OleDb

Public Class frmProfile

    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Dim sex, marital As String

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")

        txtEmployeeNo.Text = frmHome.lblEmployeeNum.Text

        getDetails()
        rdoSex()
        getImage()

    End Sub

    Private Sub getDetails()
        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM Users WHERE [Employee Number] = '" & frmHome.lblEmployeeNum.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read

            txtUName.Text = rd.GetString(1)
            txtName.Text = rd.GetString(10)
            txtAddress.Text = rd.GetString(4)
            txtNumber.Text = rd.GetString(5)
            txtEmail.Text = rd.GetString(9)
            sex = rd.GetString(6)
            marital = rd.GetString(7)

        End While
        conn.Close()
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

    Private Sub rdoSex()
        If sex = "Female" Then
            rdoFemale.Checked = True
            rdoMarital()
        ElseIf sex = "Male" Then
            rdoMale.Checked = True
            rdoMarital()
        End If

    End Sub

    Private Sub rdoMarital()
        If marital = "Single" Then
            rdoSingle.Checked = True
        ElseIf marital = "Married" Then
            rdoMarried.Checked = True
        End If
    End Sub

    Private Sub frmProfile_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmHome.Show()
    End Sub

    Private Sub btnChooseimg_Click(sender As Object, e As EventArgs) Handles btnChooseimg.Click
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.JFIF)|*.BMP;*.JPG;*.GIF;*.PNG;*.JFIF"

        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picBoxEmployee.Image = Image.FromFile(dialog.FileName)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtNumber.Text.Length = 11 Then
            If IsNumeric(txtNumber.Text) Then

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

            Else
                MessageBox.Show("Phone Number should be numeric", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Phone Number should be 11 digits", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub getStatus()

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

    Private Sub btnUpdatePass_Click(sender As Object, e As EventArgs) Handles btnUpdatePass.Click
        Me.Enabled = False
        frmChangePassword.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmHome.Show()
        Me.Close()
    End Sub
End Class