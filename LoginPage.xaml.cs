namespace TeamsMobileUI;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnSignInClicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EmailEntry.Text) ||
            string.IsNullOrWhiteSpace(PasswordEntry.Text))
        {
            await DisplayAlert(
                "Sign in",
                "Please enter your email and password.",
                "OK");

            return;
        }

        await Shell.Current.GoToAsync("//MainPage");
    }
}