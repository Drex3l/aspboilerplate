using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace blogger.Categories.Dtos
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryListDto  : EntityDto<int>
    {
        public string Title { get; set; }
    }
}