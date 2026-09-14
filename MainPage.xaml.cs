using TeamsMobileUI.Models;

namespace TeamsMobileUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public List<Chat> Chats { get; set; } = new()
        {
            new Chat
            {
                Name = "Stacey",
                Message = "Moring, did the meeting start?",
                Time = "09:15",
                Image = "sarah.jpg"
            },

            new Chat
            {
                Name = "John",
                Message = "I'll sent the document",
                Time = "08:00",
                Image = "john.jpg"
            },

            new Chat
            {
                Name = "Lisa",
                Message = "Thanks!",
                Time = "Yesterday",
                Image = "lisa.jpg"
            },

            new Chat
            {
                Name = "Michael",
                Message = "See you tomorrow.",
                Time = "Yesterday",
                Image = "michael.jpg"
            }
        };
    }
}