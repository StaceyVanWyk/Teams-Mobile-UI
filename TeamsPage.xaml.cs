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
}