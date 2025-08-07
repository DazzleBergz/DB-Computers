Public Class Form1
    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click

        frmUserLogin.Show()
        Me.Hide()

    End Sub

    Private Sub DBCOMPUTERPARTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBCOMPUTERPARTSToolStripMenuItem.Click

        frmAbout.Show()
        Me.Enabled = False

    End Sub

    Private Sub WHEREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WHEREToolStripMenuItem.Click

        MessageBox.Show("Located at :" & vbNewLine & "Biglang Awa St., Brgy. 100, Caloocan City" & vbNewLine & vbNewLine & "Telephone No:" & vbNewLine & "(02)784521", "CONTACT US")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
