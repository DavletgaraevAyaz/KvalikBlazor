namespace KvalikBlazor.Response
{
    public class MessageResponse
    {
        public int SenderId { get; set; }
        public string SenderName { get; set; }
        public string Text { get; set; }
        public DateTime SentAt { get; set; }
    }
}
