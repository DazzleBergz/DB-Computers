Imports System.Data.OleDb

Public Class frmSetPassword

    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim cmd As OleDbCommand

    Dim bytImage() As Byte

    Dim uName, named, email, address, mob, sex, marital, position, employeeNumber As String

    Private Sub frmSetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If frmHome.positions = "Co-Admin" Then
            position = "Staff"
        End If

        If UCase(txtPassword.Text) = "" Or UCase(txtConfirmPass.Text) = "" Then
            MessageBox.Show("Complete details on textbox", "Complete Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Not UCase(txtPassword.Text) = UCase(txtConfirmPass.Text) Then
                MessageBox.Show("Confirmation passwrod is not correct.... Password not match in confirmation", "Confirm Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    Dim ms As New System.IO.MemoryStream
                    Dim bmpImage As New Bitmap(frmAddEmployee.picBoxEmployee.Image)
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    bytImage = ms.ToArray()
                    ms.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                uName = frmAddEmployee.txtUName.Text
                address = frmAddEmployee.txtAddress.Text
                mob = frmAddEmployee.txtNumber.Text
                employeeNumber = frmAddEmployee.txtEmployeeNo.Text
                named = frmAddEmployee.txtName.Text
                email = frmAddEmployee.txtxEmail.Text
                rdoPosition()

                conn.Open()
                cmd = New OleDbCommand
                cmd.Connection = conn

                cmd.CommandText = "Insert Into Users([Employee Number], uname, pass, positions, address, phoneNumber, Sex, maritalStatus, picture, email, name) 
                                        VALUES(@ID, @uname, @pass, @positions, @address, @phoneNumber, @Sex, @maritalStatus, @picture, @email, @name)"
                cmd.Parameters.AddWithValue("@ID", employeeNumber)
                cmd.Parameters.AddWithValue("@uname", UCase(uName))
                cmd.Parameters.AddWithValue("@pass", UCase(txtPassword.Text))
                cmd.Parameters.AddWithValue("@positions", position)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@phoneNumber", mob)
                cmd.Parameters.AddWithValue("@Sex", sex)
                cmd.Parameters.AddWithValue("@maritalStatus", marital)
                cmd.Parameters.AddWithValue("@picture", bytImage)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@name", named)

                cmd.ExecuteNonQuery()
                conn.Close()
                frmAddEmployee.Close()
                Me.Close()
                MessageBox.Show("Account Add Successfuly", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub rdoPosition()
        If frmAddEmployee.rdoFemale.Checked Then
            sex = frmAddEmployee.rdoFemale.Text
            rdoSex()
        ElseIf frmAddEmployee.rdoMale.Checked Then
            sex = frmAddEmployee.rdoMale.Text
            rdoSex()
        End If
    End Sub

    Private Sub rdoSex()
        If frmAddEmployee.rdoAdmin.Checked Then
            position = frmAddEmployee.rdoAdmin.Text
            rdoMarital()
        ElseIf frmAddEmployee.rdoStaff.Checked Then
            position = frmAddEmployee.rdoStaff.Text
            rdoMarital()
        End If
    End Sub

    Private Sub rdoMarital()
        If frmAddEmployee.rdoSingle.Checked Then
            marital = frmAddEmployee.rdoSingle.Text
        ElseIf frmAddEmployee.rdoMarried.Checked Then
            marital = frmAddEmployee.rdoMarried.Text
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmAddEmployee.Enabled = True
        Me.Close()
    End Sub

End Class