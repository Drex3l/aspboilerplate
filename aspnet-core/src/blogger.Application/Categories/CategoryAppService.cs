using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

using Abp.UI;

using blogger.Categories.Dtos;

namespace blogger.Categories
{
    [AbpAuthorize]
    public class CategoryAppService  : bloggerAppServiceBase, ICategoryAppService
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IRepository<Category, int> _categoryRepository;

        public CategoryAppService(
            ICategoryManager categoryManager,
            IRepository<Category, int> categoryRepository)
        {
            _categoryManager = categoryManager;
            _categoryRepository = categoryRepository;
        }

        public async Task<ListResultDto<CategoryListDto>> GetListAsync()
        {
            var categories = await _categoryRepository
            .GetAll()
            .Take(64)
            .ToListAsync();
            return new ListResultDto<CategoryListDto>(categories.MapTo<List<CategoryListDto>>());
        }
        public async Task CreateAsync(CreateCategoryInput input)
        {
            var @category = Category.Create(input.Title);
            await _categoryManager.CreateAsync(@category);
        }
        public async Task DeleteAsync(EntityDto<int> input)
        {
            var cat = await _categoryRepository.FirstOrDefaultAsync(input.Id);
            if(cat == null){
                throw new UserFriendlyException("Category Not Found");
            }else
            {
                    await _categoryManager.DeleteAsync(cat);
            }
        
        }
    }
}