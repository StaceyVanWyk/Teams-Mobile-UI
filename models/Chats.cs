namespace TeamsMobileUI.Models
{
    public class Chat
    {
        public string Name { get; set; }

        public string Message { get; set; }

        public string Time { get; set; }

        public string Image { get; set; }

        public List<ChatMessage> Messages { get; set; } = new();
    }

    public class ChatMessage
    {
        public string Text { get; set; }

        public bool IsMine { get; set; }
    }
}