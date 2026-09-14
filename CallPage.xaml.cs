using Plugin.Maui.Audio;

namespace TeamsMobileUI;

public partial class CallPage : ContentPage
{
    private int _seconds;
    private IDispatcherTimer? _timer;

    private readonly IAudioManager _audioManager;
    private IAudioPlayer? _callSound;

    public CallPage()
    {
        InitializeComponent();

        _audioManager = AudioManager.Current;

        _timer = Dispatcher.CreateTimer();
        _timer.Interval = TimeSpan.FromSeconds(1);
        _timer.Tick += OnTimerTick;
        _timer.Start();

        _ = PlayCallSound();
    }

    private async Task PlayCallSound()
    {
        try
        {
            var stream = await FileSystem.OpenAppPackageFileAsync(
                "teams_like_call_ringtone.wav");

            _callSound = _audioManager.CreatePlayer(stream);

            _callSound.Play();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(
                $"Audio error: {ex.Message}");
        }
    }

    private void OnTimerTick(object? sender, EventArgs e)
    {
        _seconds++;

        TimeSpan time = TimeSpan.FromSeconds(_seconds);

        CallTimerLabel.Text = time.ToString(@"mm\:ss");

        if (_seconds == 1)
        {
            CallStatusLabel.Text = "Connected";
        }
    }

    private void OnMuteClicked(object? sender, EventArgs e)
    {
        MuteLabel.Text = MuteLabel.Text == "Mute"
            ? "Unmute"
            : "Mute";
    }

    private void OnCameraClicked(object? sender, EventArgs e)
    {
        CameraLabel.Text = CameraLabel.Text == "Camera"
            ? "Camera off"
            : "Camera";
    }

    private void OnSpeakerClicked(object? sender, EventArgs e)
    {
        SpeakerLabel.Text = SpeakerLabel.Text == "Speaker"
            ? "Speaker off"
            : "Speaker";
    }

    private async void OnEndCallClicked(object? sender, EventArgs e)
    {
        _timer?.Stop();

        _callSound?.Stop();
        _callSound?.Dispose();

        await Shell.Current.GoToAsync("..");
    }
}