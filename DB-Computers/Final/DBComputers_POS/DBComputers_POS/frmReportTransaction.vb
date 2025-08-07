Public Class frmReportTransaction

    Private Sub frmReportTransaction_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTransaction.Enabled = True
    End Sub
End Class