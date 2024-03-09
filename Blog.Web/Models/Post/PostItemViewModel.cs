using Blog.Web.Models.Category;
using Blog.Web.Models.Tag;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> f2cc3b9844136ac9472b369d02627d56b768b255

namespace Blog.Web.Models.Post
{
    public class PostItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }
<<<<<<< HEAD
	    public int CategoryId { get; set; }
=======
>>>>>>> f2cc3b9844136ac9472b369d02627d56b768b255
        public CategoryItemViewModel Category { get; set; }
        public ICollection<TagItemViewModel> Tags { get; set; }
    }
}
