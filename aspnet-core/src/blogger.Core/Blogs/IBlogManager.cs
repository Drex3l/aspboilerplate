using System;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace blogger.Blogs
{
    public interface IBlogManager : IDomainService
    {
         Task<Blog> GetAsync(Guid id);
         Task CreateAsync(Blog @blog);
    }
}