namespace TeamsMobileUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ChatPage), typeof(ChatPage));
        Routing.RegisterRoute(nameof(CallPage), typeof(CallPage));
        Routing.RegisterRoute(nameof(TeamsPage), typeof(TeamsPage));
        Routing.RegisterRoute(nameof(CalendarPage), typeof(CalendarPage));
        Routing.RegisterRoute(nameof(MorePage), typeof(MorePage));
        Routing.RegisterRoute(nameof(ActivityPage), typeof(ActivityPage));
    }
}