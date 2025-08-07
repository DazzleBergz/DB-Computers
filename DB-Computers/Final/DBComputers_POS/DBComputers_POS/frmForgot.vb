Imports System.Data.OleDb
Imports System.Net.Mail
Public Class frmForgot
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader
    Dim vCode As String

    Private Function RNG(ByVal Codelength As Integer) As String
        Dim randomValue As New Random()
        Dim letter As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim returnValue As String = Nothing
        For i As Integer = 1 To Codelength
            returnValue += letter(randomValue.Next(0, letter.Length))
        Next
        Return returnValue
    End Function

    Private Sub User()
        conn.Open()
        cmd = New OleDbCommand("Select * from Users where [Email] = @Email", conn)
        cmd.Parameters.AddWithValue("Email", txtEmail.Text)
        reader = cmd.ExecuteReader
        If reader.Read Then
            txtUsername.Text = reader("uname").ToString
            txtUsername.Enabled = False
            conn.Close()
        End If


    End Sub

    Private Sub btnSendCode_Click(sender As Object, e As EventArgs) Handles btnSendCode.Click
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")
        Try
            If txtEmail.Text = "" Then
                MessageBox.Show("Enter Your Email Address", "Account Recovery", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using cmd As New OleDbCommand("SELECT COUNT(*) From Users WHERE Email = @Email", conn)
                cmd.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = txtEmail.Text.Trim
                conn.Open()
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    vCode = RNG(6)
                    Dim smtpServer As New SmtpClient("smtp.gmail.com")
                    Dim mail As New MailMessage
                    mail.From = New MailAddress("dbcomputers.bsit@gmail.com")
                    mail.To.Add(txtEmail.Text)
                    mail.Subject = "Account Recovery - DB Computers Parts POS"
                    mail.Body = "<p>Good day,you recently requested to reset your password to be reset for your account in our DB Computer Parts POS System" &
                                "Copy and Paste the code below for you to reset your password</p>" &
                                "<p>Here's your code:<h1><b> " & vCode & "</b></h1>" &
                                "<p>____________________________________________________________________________________________________________" &
                                "<h3>Just a reminder:</h3>" &
                                "<p> Never share your password to anyone</p>" &
                                "<p> Use password that is hard to guess.Be sure to include uppercase and lowercase characters</p>" &
                                "<p>____________________________________________________________________________________________________________" &
                                "<P>If you did not request a password reset, kindly ignore this email or send us a reply.</p>" &
                                "<Thank You!<br>" &
                                "DB Computer Parts POS System Team</p>"

                    mail.IsBodyHtml = True
                    smtpServer.Port = 587
                    smtpServer.Credentials = New System.Net.NetworkCredential("dbcomputers.bsit@gmail.com", "iegxzhjmusfcpkmj")
                    smtpServer.EnableSsl = True
                    smtpServer.Send(mail)
                    MessageBox.Show("Verification Code has been sent to your email", "Verification Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Email does not exist in the database", "Email do not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    conn.Close()
                    Return
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("No Internet Connection", "Connect to Internet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        conn.Close()

    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        User()

        If txtCode.Text = "" Then
            MessageBox.Show("Please Enter Your Vefication Code!", "Verification Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            If txtCode.Text = vCode Then
                MessageBox.Show("Code Succesfully Verified", "Valid Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Panel1.Visible = False
            Else
                MessageBox.Show("Wrong Verification Code, try again.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If txtNewPass.Text = "" Or txtConfirmPass.Text = "" Then
            MessageBox.Show("Please Enter your new Password!", "Input Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtNewPass.Text = txtConfirmPass.Text Then
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE Users SET [pass]='" & txtNewPass.Text & "'WHERE [Email]='" & txtEmail.Text & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Password Succesfully Changed", "Account Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                Me.Close()
                frmUserLogin.Show()
            Else
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
    End Sub

    Private Sub frmForgot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\DB_Computers.mdb")
    End Sub

    Private Sub frmForgot_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmUserLogin.Enabled = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmUserLogin.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmUserLogin.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtNewPass.UseSystemPasswordChar = False
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            txtNewPass.UseSystemPasswordChar = True
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class