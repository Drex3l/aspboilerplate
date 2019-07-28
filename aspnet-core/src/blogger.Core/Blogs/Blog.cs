using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

using blogger.Authors;
using blogger.Categories;

namespace blogger.Blogs
{
    [Table("AppBlog")]
    public class Blog : FullAuditedEntity<Guid>, IMustHaveTenant
    {
        public const int MaxTitleLength = 128;
        public const int MaxContentLength = 4096;
        public virtual int TenantId { get; set; }

        [Required]
        [StringLength(MaxTitleLength)]
        public virtual string Title { get; protected set; }

        [Required]
        [StringLength(MaxContentLength)]
        public virtual string Content { get; protected set; }

        public virtual string Image { get; protected set; }
        public virtual Author Author { get; protected set; }
        public virtual long AuthorId { get; protected set; }
        
        
        public virtual int CategoryId { get; protected set; }
        public virtual Category Category { get; protected set; }

        /// <summary>
        /// We don't make constructor public and forcing to create events using <see cref="Create"/> method.
        /// But constructor can not be private since it's used by EntityFramework.
        /// Thats why we did it protected.
        /// </summary>
        protected Blog()
        {
            
        }
        public static Blog Create(int tenantId, string title, string content,  long authorID, int categoryID, string image = null)
        {
            var @blog = new Blog
            {
                Id = Guid.NewGuid(),
                TenantId = tenantId,
                Title = title,
                Content = content,
                CategoryId = categoryID,
                AuthorId = authorID,
                Image = image
            };
            return @blog;
        }
    }
}