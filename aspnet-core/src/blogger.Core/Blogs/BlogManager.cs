using System;
using System.Threading.Tasks;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Events.Bus;

namespace blogger.Blogs
{
    public class BlogManager : IBlogManager
    {
        public IEventBus EventBus { get; set; }
        private readonly IRepository<Blog, Guid> _blogRepository;
        public BlogManager(IRepository<Blog, Guid> blogRepository)
        {
            this._blogRepository = blogRepository;
            this.EventBus = NullEventBus.Instance;
        }
        public async Task<Blog> GetAsync(Guid id)
        {
            var @blog = await _blogRepository.FirstOrDefaultAsync(id);
            if (@blog == null)
            {
                throw new UserFriendlyException("Could not found the event, maybe it's deleted!");
            }
            return @blog;
        }
        public async Task CreateAsync(Blog @blog)
        {
            await _blogRepository.InsertAsync(@blog);
        }
    }
}