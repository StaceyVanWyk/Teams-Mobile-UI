namespace TeamsMobileUI.Models
{
    public class Chat
    {
        public string Name { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public string Time { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public List<ChatMessage> Messages { get; set; } = new();
    }

    public class ChatMessage
    {
        public string Text { get; set; } = string.Empty;

        public bool IsMine { get; set; }
    }
}