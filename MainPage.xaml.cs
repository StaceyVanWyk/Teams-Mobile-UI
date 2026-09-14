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
                Image = "sarah.jpg",

                Messages = new List<ChatMessage>
                {
                    new ChatMessage
                    {
                        Text = "Hi! Did you get the document I sent?",
                        IsMine = false
                    },
                    new ChatMessage
                    {
                        Text = "Yes, I received it. Thank you!",
                        IsMine = true
                    },
                    new ChatMessage
                    {
                        Text = "Great! Let me know if you have any questions.",
                        IsMine = false
                    },
                    new ChatMessage
                    {
                        Text = "Will do 👍",
                        IsMine = true
                    }
                }
            },

            new Chat
            {
                Name = "John",
                Message = "I'll sent the document",
                Time = "08:00",
                Image = "john.jpg",

                Messages = new List<ChatMessage>
                {
                    new ChatMessage
                    {
                        Text = "Morning, I'll send the document shortly.",
                        IsMine = false
                    },
                    new ChatMessage
                    {
                        Text = "Okay, thanks John.",
                        IsMine = true
                    },
                    new ChatMessage
                    {
                        Text = "It should be in your inbox now.",
                        IsMine = false
                    },
                    new ChatMessage
                    {
                        Text = "Got it, thank you!",
                        IsMine = true
                    }
                }
            },

            new Chat
            {
                Name = "Lisa",
                Message = "Thanks!",
                Time = "Yesterday",
                Image = "lisa.jpg",

                Messages = new List<ChatMessage>
                {
                    new ChatMessage
                    {
                        Text = "Are we still meeting tomorrow?",
                        IsMine = false
                    },
                    new ChatMessage
                    {
                        Text = "Yes, the meeting is still on.",
                        IsMine = true
                    },
                    new ChatMessage
                    {
                        Text = "Perfect, thanks!",
                        IsMine = false
                    }
                }
            },

            new Chat
            {
                Name = "Michael",
                Message = "See you tomorrow.",
                Time = "Yesterday",
                Image = "michael.jpg",

                Messages = new List<ChatMessage>
                {
                    new ChatMessage
                    {
                        Text = "Don't forget about the presentation tomorrow.",
                        IsMine = false
                    },
                    new ChatMessage
                    {
                        Text = "I won't forget. Everything is ready.",
                        IsMine = true
                    },
                    new ChatMessage
                    {
                        Text = "Awesome. See you tomorrow!",
                        IsMine = false
                    },
                    new ChatMessage
                    {
                        Text = "See you tomorrow 👋",
                        IsMine = true
                    }
                }
            }
        };

        private async void OnChatTapped(object sender, EventArgs e)
        {
            if (sender is Grid grid && grid.BindingContext is Chat chat)
            {
                await Shell.Current.GoToAsync(
                    nameof(ChatPage),
                    new Dictionary<string, object>
                    {
                        { "Chat", chat }
                    });
            }
        }

        private async void OnTeamsTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TeamsPage));
        }
    }
}