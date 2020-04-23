using System;

namespace AppStartBlazor.Domain
{
    public class Comments
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public string AuthorIP { get; set; }
        public DateTime DateTime { get; set; }
        public string CommentText { get; set; }
        public CommentStatus CommentStatus { get; set; }

    }
}