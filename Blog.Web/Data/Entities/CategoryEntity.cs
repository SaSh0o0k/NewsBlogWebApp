using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Data.Entities
{
    [Table("tblCategories")]
    public class CategoryEntity : BaseEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string UrlSlug { get; set; }

        [StringLength(5000)]
        public string Description { get; set; }

        public virtual ICollection<PostEntity> Posts { get; set; }
    }
}
