Imports MVVMTutorial.ViewModel

Class MainWindow
    Public Sub New()
        InitializeComponent()
        Dim vm As MainWindowViewModel = New MainWindowViewModel()
        DataContext = vm
    End Sub
End Class
