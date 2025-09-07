Imports WpfVBTutorial.Views

Public Class M_OpeningWindows
    Private Sub btnNormal_Click(sender As Object, e As RoutedEventArgs) Handles btnNormal.Click
        Dim normalWindows As NormalWindow = New NormalWindow
        normalWindows.Show()
    End Sub

    Private Sub btnModal_Click(sender As Object, e As RoutedEventArgs) Handles btnModal.Click
        Dim modalWindow As ModalWindow = New ModalWindow
        Opacity = 0.4
        modalWindow.ShowDialog()
        Opacity = 1
        If modalWindow.Success Then
            txtInput.Text = modalWindow.Input
        End If

    End Sub
End Class
