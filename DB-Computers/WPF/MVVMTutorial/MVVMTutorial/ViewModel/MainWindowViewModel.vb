Imports System.Collections.ObjectModel
Imports MVVMTutorial.Base
Imports MVVMTutorial.Model

Namespace ViewModel
    Public Class MainWindowViewModel
        Inherits ViewModelBase

        Private ReadOnly _addCommand As RelayCommand = New RelayCommand(Sub(o) AddItem())
        Private ReadOnly _deleteCommand As RelayCommand = New RelayCommand(Sub(o) DeleteItem(), Function(o) SelectedItem IsNot Nothing)
        Private ReadOnly _saveCommand As RelayCommand = New RelayCommand(Sub(o) SaveItem(), Function(o) canSave())
        Private _items As ObservableCollection(Of Item)
        Private _selectedItem As Item

        Public Sub New()
            Items = New ObservableCollection(Of Item)()
        End Sub

        Public ReadOnly Property AddCommand As RelayCommand
            Get
                Return _addCommand
            End Get
        End Property

        Public ReadOnly Property DeleteCommand As RelayCommand
            Get
                Return _deleteCommand
            End Get
        End Property

        Public ReadOnly Property SaveCommand As RelayCommand
            Get
                Return _saveCommand
            End Get
        End Property

        Public Property SelectedItem As Item
            Get
                Return _selectedItem
            End Get
            Set(value As Item)
                _selectedItem = value
                OnPropertyChange()
            End Set
        End Property

        Public Property Items As ObservableCollection(Of Item)
            Get
                Return _items
            End Get
            Set(value As ObservableCollection(Of Item))
                _items = value
            End Set
        End Property

        Public Sub AddItem()
            Items.Add(
            New Item With {
            .Name = "NEW ITEM",
            .SerialNumber = "XXXXX",
            .Quantity = 0
            })
        End Sub

        Public Sub DeleteItem()
            Items.Remove(SelectedItem)
        End Sub

        Private Sub SaveItem()
            'Database is on?
        End Sub

        Private Function canSave() As Boolean
            Return True
        End Function
    End Class
End Namespace


