﻿using Blog.Web.Models.Category;
using Blog.Web.Models.Tag;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Models.Post
{
    public class PostCreateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
<<<<<<< HEAD
        //public string UrlSlug { get; set; }
        //public bool Published { get; set; } = false;
        //public DateTime PostedOn { get; set; }
        //public DateTime? Modified { get; set; }
        public int CategoryId { get; set; }
        public List<int> Tags { get; set; }
=======
        public string UrlSlug { get; set; }
        public bool Published { get; set; } = false;
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }

        public IEnumerable<int> Tags { get; set; }
>>>>>>> f2cc3b9844136ac9472b369d02627d56b768b255
    }
}
