using System;
using System.ComponentModel.DataAnnotations;

namespace blogger.Blogs.Dtos
{
    public class CreateBlogInput
    {
        [Required]
        [StringLength(Blog.MaxTitleLength)]
        public string Title { get; set; }
        
        [Required]
        [StringLength(Blog.MaxContentLength)]
        public string Content { get; set; }

        public string Image { get; set; }
        public long AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}