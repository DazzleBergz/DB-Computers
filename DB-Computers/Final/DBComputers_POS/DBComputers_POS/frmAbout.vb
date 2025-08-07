Public Class frmAbout
    Private Sub frmAbout_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Form1.Enabled = True

    End Sub

    Private Sub btnGBack_Click(sender As Object, e As EventArgs) Handles btnGBack.Click

        Form1.Enabled = True
        Me.Close()

    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class