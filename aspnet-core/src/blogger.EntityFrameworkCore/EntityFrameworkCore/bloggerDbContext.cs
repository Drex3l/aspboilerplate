using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using blogger.Authorization.Roles;
using blogger.Authorization.Users;
using blogger.MultiTenancy;

namespace blogger.EntityFrameworkCore
{
    public class bloggerDbContext : AbpZeroDbContext<Tenant, Role, User, bloggerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public bloggerDbContext(DbContextOptions<bloggerDbContext> options)
            : base(options)
        {
        }
    }
}
