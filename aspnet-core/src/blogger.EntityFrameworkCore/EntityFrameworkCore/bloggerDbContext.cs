using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using blogger.Authorization.Roles;
using blogger.Authorization.Users;
using blogger.MultiTenancy;
using blogger.Blogs;
using blogger.Authors;
using blogger.Categories;

namespace blogger.EntityFrameworkCore
{
    public class bloggerDbContext : AbpZeroDbContext<Tenant, Role, User, bloggerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        
        public bloggerDbContext(DbContextOptions<bloggerDbContext> options)
            : base(options)
        {
        }
    }
}
