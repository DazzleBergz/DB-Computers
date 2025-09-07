Public Class L_CustomAppWin
    Private Sub Window_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        DragMove()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As RoutedEventArgs)
        WindowState = WindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As RoutedEventArgs)
        If WindowState <> WindowState.Maximized Then
            WindowState = WindowState.Maximized
        Else
            WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
