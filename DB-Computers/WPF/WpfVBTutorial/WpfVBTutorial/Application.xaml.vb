Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

    'Overrude Start up
    Public Sub A_CodeBehind_StartUp(sender As Object, e As StartupEventArgs) Handles Me.Startup
        ' Create the form then show
        Dim form = New O_StyleTemplates()
        form.Show()
    End Sub
End Class
