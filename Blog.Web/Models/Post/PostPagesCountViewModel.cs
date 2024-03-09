namespace Blog.Web.Models.Post
{
    public class PostPagesCountViewModel
    {
        public ICollection<PostItemViewModel> Posts { get; set; } = null!;
        public int PagesCount { get; set; }
    }
}
