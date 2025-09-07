Namespace Views
    Public Class ModalWindow
        Public Sub New()
            InitializeComponent()
        End Sub

        Private _success As Boolean = False
        Private _input As String
        Public Property Success As Boolean
            Get
                Return _success
            End Get
            Set(value As Boolean)
                _success = value
            End Set
        End Property

        Public Property Input As String
            Get
                Return _input
            End Get
            Set(value As String)
                _input = value
            End Set
        End Property

        Private Sub btnOK_Click(sender As Object, e As RoutedEventArgs)
            Success = True
            Input = txtInput.Text
            Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As RoutedEventArgs)
            Close()
        End Sub

        Private Sub txtInput_TextChanged(sender As Object, e As TextChangedEventArgs)
            If Not String.IsNullOrEmpty(txtInput.Text) Then
                btnOK.IsEnabled = True
            Else
                btnOK.IsEnabled = False
            End If
        End Sub
    End Class
End Namespace


