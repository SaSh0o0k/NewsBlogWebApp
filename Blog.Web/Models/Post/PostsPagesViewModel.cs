namespace Blog.Web.Models.Post
{
    public class PostsPagesViewModel
    {
        public int Count { get; set; }
        public int PageNumber { get; set; }

        public string? TagUrlSlug { get; set; }
        public string? CategoryUrlSlug { get; set; }
    }
}
