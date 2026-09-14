using TeamsMobileUI.Models;

namespace TeamsMobileUI;

[QueryProperty(nameof(Chat), "Chat")]
public partial class ChatPage : ContentPage
{
    private Chat _chat;

    public ChatPage()
    {
        InitializeComponent();
    }

    public Chat Chat
    {
        get => _chat;
        set
        {
            _chat = value;
            BindingContext = this;
        }
    }
        private async void OnCallClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CallPage));
    }
}
