
Namespace Base

    Public Class RelayCommand
        Implements ICommand
        Private _execute As Action(Of Object)
        Private _canExecute As Func(Of Object, Boolean)

        Public Custom Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
            AddHandler(value As EventHandler)
                AddHandler CommandManager.RequerySuggested, value
            End AddHandler
            RemoveHandler(value As EventHandler)
                RemoveHandler CommandManager.RequerySuggested, value
            End RemoveHandler
            RaiseEvent(sender As Object, e As EventArgs)
                CommandManager.InvalidateRequerySuggested()
            End RaiseEvent
        End Event

        Public Sub New(execute As Action(Of Object), Optional canExecute As Func(Of Object, Boolean) = Nothing)
            _execute = execute
            _canExecute = canExecute
        End Sub

        Public Sub Execute(parameter As Object) Implements ICommand.Execute
            _execute(parameter)
        End Sub

        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            If _canExecute Is Nothing Then
                Return True
            End If
            Return _canExecute(parameter)
        End Function
    End Class
End Namespace


