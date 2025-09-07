Imports System.Collections.ObjectModel

Public Class G_Observable


    Private _entries As ObservableCollection(Of String)

    Public Sub New()
        DataContext = Me
        _entries = New ObservableCollection(Of String)
        InitializeComponent()
    End Sub

    Public Property Entries As ObservableCollection(Of String)
        Get
            Return _entries
        End Get
        Set(value As ObservableCollection(Of String))
            _entries = value
        End Set
    End Property

    Private Sub btnAdd_Click(sender As Object, e As RoutedEventArgs)
        Entries.Add(txtEntries.Text)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As RoutedEventArgs)
        Dim selectedItem As String = TryCast(lvEntries.SelectedItem, String)
        Entries.Remove(selectedItem)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs)
        Entries.Clear()
    End Sub
End Class
