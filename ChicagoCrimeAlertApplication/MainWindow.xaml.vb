Class MainWindow
    Private Sub Home_Click(sender As Object, e As RoutedEventArgs)
        Home.Visibility = System.Windows.Visibility.Visible
        Stats.Visibility = System.Windows.Visibility.Hidden
        About.Visibility = System.Windows.Visibility.Hidden
        News.Visibility = System.Windows.Visibility.Hidden
        Alerts.Visibility = System.Windows.Visibility.Hidden
    End Sub

    Private Sub StatsBtn_Click(sender As Object, e As RoutedEventArgs) Handles StatsBtn.Click
        Home.Visibility = System.Windows.Visibility.Hidden
        Stats.Visibility = System.Windows.Visibility.Visible
        About.Visibility = System.Windows.Visibility.Hidden
        News.Visibility = System.Windows.Visibility.Hidden
        Alerts.Visibility = System.Windows.Visibility.Hidden
    End Sub

    Private Sub CrimeNewsBtn_Click(sender As Object, e As RoutedEventArgs)
        Home.Visibility = System.Windows.Visibility.Hidden
        Stats.Visibility = System.Windows.Visibility.Hidden
        About.Visibility = System.Windows.Visibility.Hidden
        News.Visibility = System.Windows.Visibility.Visible
        Alerts.Visibility = System.Windows.Visibility.Hidden
    End Sub

    Private Sub AlertBtn_Click(sender As Object, e As RoutedEventArgs) Handles AlertBtn.Click
        Home.Visibility = System.Windows.Visibility.Hidden
        Stats.Visibility = System.Windows.Visibility.Hidden
        About.Visibility = System.Windows.Visibility.Hidden
        News.Visibility = System.Windows.Visibility.Hidden
        Alerts.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub AboutBtn_Click(sender As Object, e As RoutedEventArgs) Handles AboutBtn.Click
        Home.Visibility = System.Windows.Visibility.Hidden
        Stats.Visibility = System.Windows.Visibility.Hidden
        About.Visibility = System.Windows.Visibility.Visible
        News.Visibility = System.Windows.Visibility.Hidden
        Alerts.Visibility = System.Windows.Visibility.Hidden
    End Sub
End Class
