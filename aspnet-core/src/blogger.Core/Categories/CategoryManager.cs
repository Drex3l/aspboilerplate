using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Events.Bus;
using Abp.UI;

namespace blogger.Categories
{
    public class CategoryManager : ICategoryManager
    {
        public IEventBus EventBus { get; set; }
        private readonly IRepository<Category,int> _categoryRepository;
        public CategoryManager(
            IRepository<Category,int> blogCategoryRepository
        )
        {
            this._categoryRepository = blogCategoryRepository;
            this.EventBus = NullEventBus.Instance;
        }

        public async Task<Category> GetAsync(int id)
        {
            var @categories = await _categoryRepository.FirstOrDefaultAsync(id);
            if (@categories == null)
            {
                throw new UserFriendlyException("Could not found the category, maybe it's deleted!");
            }

            return @categories;
        }

        public async Task CreateAsync(Category @category)
        {
            await _categoryRepository.InsertAsync(@category);
        }
        public async Task DeleteAsync(Category @category)
        {
             await _categoryRepository.DeleteAsync(@category);
        }
    }
}