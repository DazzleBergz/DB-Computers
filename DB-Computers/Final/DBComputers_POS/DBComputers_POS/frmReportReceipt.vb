
Public Class frmReportReceipt

    Private Sub frmReportReceipt_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmCustomer.Enabled = True
        frmCustomer.Close()
    End Sub

    Private Sub frmReportReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class