using System;
using System.ComponentModel.DataAnnotations;

namespace blogger.Categories.Dtos
{
    public class CreateCategoryInput
    {
        [Required]
        [StringLength(Category.MaxTitleLength)]
        public string Title { get; set; }
    }
}