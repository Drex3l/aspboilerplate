using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

using blogger.Blogs;
namespace blogger.Categories.Dtos
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDetailOutput
    {
        public string Title { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}