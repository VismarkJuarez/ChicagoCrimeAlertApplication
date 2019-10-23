Class MainWindow
    Private Sub Home_Click(sender As Object, e As RoutedEventArgs)
        Home.Visibility = System.Windows.Visibility.Visible
        Stats.Visibility = System.Windows.Visibility.Hidden
    End Sub

    Private Sub StatsBtn_Click(sender As Object, e As RoutedEventArgs) Handles StatsBtn.Click
        Home.Visibility = System.Windows.Visibility.Hidden
        Stats.Visibility = System.Windows.Visibility.Visible
    End Sub
End Class
