
Public Class UserControl1
    Public Property Title As String
        Get
            Return txtTitle.Text
        End Get
        Set(value As String)
            txtTitle.Text = value
        End Set
    End Property

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Button in UserControl clicked!")
    End Sub
End Class


