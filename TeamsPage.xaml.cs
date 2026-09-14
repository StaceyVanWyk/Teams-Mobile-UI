using TeamsMobileUI.Models;

namespace TeamsMobileUI;

public partial class TeamsPage : ContentPage
{
    public TeamsPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    public List<Team> Teams { get; set; } = new()
    {
        new Team
        {
            Name = "Development Team",
            Description = "Software development and projects"
        },

        new Team
        {
            Name = "Marketing Team",
            Description = "Marketing and communications"
        },

        new Team
        {
            Name = "College Project",
            Description = "Assignment and coursework"
        },

        new Team
        {
            Name = "Design Team",
            Description = "Design and creative projects"
        }
    };

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