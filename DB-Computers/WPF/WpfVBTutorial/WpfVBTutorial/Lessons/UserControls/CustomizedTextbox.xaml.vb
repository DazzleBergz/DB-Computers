Namespace UserControls
    Public Class CustomizedTextbox

        Private _placeholder As String

        Public Property Placeholder As String
            Get
                Return _placeholder
            End Get
            Set(value As String)
                _placeholder = value
                ' Do not do this for demonstration only
                tblPlaceHolder.Text = _placeholder
                ' Use OnPropertyChanged() very cool :)
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs)
            txtInput.Clear()
            txtInput.Focus()
        End Sub

        Private Sub txtInput_TextChanged(sender As Object, e As TextChangedEventArgs)
            If String.IsNullOrEmpty(txtInput.Text) Then
                tblPlaceHolder.Visibility = Visibility.Visible
            Else
                tblPlaceHolder.Visibility = Visibility.Hidden
            End If
        End Sub
    End Class
End Namespace


