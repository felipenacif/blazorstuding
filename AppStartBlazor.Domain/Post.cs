using System;
using System.Collections.Generic;
using System.Text;

namespace AppStartBlazor.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public User CreatorUser { get; set; }
        public DateTime LastUpdateData { get; set; }
        public User LastUpdateUser { get; set; }
        public PostStatus PublishStatus { get; set; }
        public IEnumerable<Comments> Comments { get; set; }

    }
}
