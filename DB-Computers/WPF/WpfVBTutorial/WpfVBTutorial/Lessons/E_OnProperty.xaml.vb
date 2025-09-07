Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class E_OnProperty
    Implements INotifyPropertyChanged
    Public Sub New()
        DataContext = Me
        InitializeComponent()

    End Sub

    Private _boundText As String
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property BoundText As String
        Get
            Return _boundText
        End Get
        Set(value As String)
            _boundText = value
            onPropertiesChanged()
        End Set
    End Property


    ' CallerMemberName will pass the root class of the property like "BoundText"
    ' So it can be reusable
    Private Sub onPropertiesChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Private Sub btnSet_Click(sender As Object, e As RoutedEventArgs)
        tbResult.Text = _boundText
    End Sub
End Class
