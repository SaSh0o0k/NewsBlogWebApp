using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Data.Entities
{
    [Table("tblTags")]
    public class TagEntity : BaseEntity<int>
    {
        [Key]
        public int Id { get; set; }

<<<<<<< HEAD
        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string UrlSlug { get; set; }

        [StringLength(5000)]
=======
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string UrlSlug { get; set; }

        [StringLength(200)]
>>>>>>> f2cc3b9844136ac9472b369d02627d56b768b255
        public string Description { get; set; }

        public virtual ICollection<PostTagEntity> PostTags { get; set; }
    }
}
