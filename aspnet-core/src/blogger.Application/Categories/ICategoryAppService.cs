using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using blogger.Categories.Dtos;

namespace blogger.Categories {
    public interface ICategoryAppService: IApplicationService {
        Task < ListResultDto < CategoryListDto >> GetListAsync();
        Task CreateAsync(CreateCategoryInput input);
        Task DeleteAsync(EntityDto < int > input);
    }
}