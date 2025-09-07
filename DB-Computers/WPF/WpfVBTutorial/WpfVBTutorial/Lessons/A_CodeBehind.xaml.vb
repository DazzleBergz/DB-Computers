Public Class A_CodeBehind

    Private running As Boolean = False
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' tbHello.Text = "Hello World 2"

        ' Now to continue to this form after run fix the application:
        ' 1. Change StartUpURI="form" in App.xaml or
        ' 2. Override StartUp, create StartUp method and instatiate the form then show
    End Sub

    Private Sub btnRun_Click(sender As Object, e As RoutedEventArgs)
        ' This is just an example getting the button in sender parameter
        ' but you can still use btnRun Name
        Dim btn = CType(sender, Button) ' Ctype will tell the compiler to treat this object as a Button
        btn.Content = "Run"
        If running Then
            tbHello.Text = "Nigga Stop running"
            btn.Content = "Run"
        Else
            tbHello.Text = "Nigga is Running"
            btn.Content = "Stop"
        End If
        running = Not running
    End Sub
End Class
