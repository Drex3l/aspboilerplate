using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Abp.Domain.Entities;

using blogger.Blogs;
namespace blogger.Categories
{
    [Table("AppCategory")]
    public class Category  : Entity<int>
    {
        public const int MaxTitleLength = 128;

        [Required]
        [StringLength(MaxTitleLength)]
        // [Index(IsUnique = true)]
        public virtual string Title { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<Blog> Blogs { get; set; }

        /// <summary>
        /// We don't make constructor public and forcing to create events using <see cref="Create"/> method.
        /// But constructor can not be private since it's used by EntityFramework.
        /// Thats why we did it protected.
        /// </summary>
        public Category()
        {
            
        }
        public static Category Create(string title)
        {
            var @category = new Category
            {
                Title = title
            };
            @category.Blogs = new Collection<Blog>();
            return @category;
        }
    }
}