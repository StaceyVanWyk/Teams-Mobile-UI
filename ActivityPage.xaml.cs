namespace TeamsMobileUI;

public partial class ActivityPage : ContentPage
{
    public ActivityPage()
    {
        InitializeComponent();
    }

    private async void OnActivityTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ActivityPage));
    }

    private async void OnChatTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void OnTeamsTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TeamsPage));
    }

    private async void OnCalendarTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CalendarPage));
    }

    private async void OnMoreTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MorePage));
    }
}