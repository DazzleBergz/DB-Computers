Public Class F_ListView

    Public Sub New()

        InitializeComponent()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As RoutedEventArgs)
        lvEntries.Items.Add(txtEntries.Text)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As RoutedEventArgs)

        'Deleting 1 item
        'If lvEntries.SelectedIndex <> -1 Then
        '    lvEntries.Items.RemoveAt(lvEntries.SelectedIndex)
        'End If

        'Deleting Mulitple
        If lvEntries.SelectedItems.Count > 0 Then
            For i As Integer = lvEntries.SelectedItems.Count - 1 To 0 Step -1
                lvEntries.Items.Remove(lvEntries.SelectedItems(i))
            Next
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs)
        lvEntries.Items.Clear()
    End Sub
End Class
