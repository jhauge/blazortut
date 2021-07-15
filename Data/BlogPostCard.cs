using System;

namespace BlazorTut.Data
{
    public class BlogPostCard
    {
        public BlogPostCard()
        {
        }

        public BlogPostCard(BlogPost post)
        {
            this.Title = post.Title;
            this.Date = post.Date;
            this.BodyText = post.BodyText.Length > 100 ? post.BodyText.Substring(0, 100) : post.BodyText;
        }

        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string BodyText { get; set; }


    }
}
