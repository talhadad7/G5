using System;

namespace G5
{
    public class Announcement
    {
        public string MessageID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string Audience { get; set; }

        // שינוי כאן: במקום string WriterID → Member Writer
        public Member Writer { get; set; }

        public Announcement(string messageID, string title, string content, DateTime publishDate, string audience, Member writer)
        {
            MessageID = messageID;
            Title = title;
            Content = content;
            PublishDate = publishDate;
            Audience = audience;
            Writer = writer;
        }

        public override string ToString()
        {
            return $"[{PublishDate:dd/MM/yyyy}] {Title} by {Writer.firstName} {Writer.lastName} - {Content}";
        }
    }
}
