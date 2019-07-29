using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Abp.AutoMapper;
using Abp.Authorization;
using Abp.Runtime.Session;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;

using blogger.Blogs.Dtos;
namespace blogger.Blogs {
    [AbpAuthorize]
    public class BlogAppService: bloggerAppServiceBase , IBlogAppService
    {
        private readonly IBlogManager _blogManager;
        private readonly IRepository < Blog, Guid > _blogRepository;
        public BlogAppService(
            IBlogManager blogManager,
            IRepository < Blog, Guid > blogRepository) {
            _blogManager = blogManager;
            _blogRepository = blogRepository;
        }
        public async Task < ListResultDto < BlogListDto >> GetListAsync() {
            var blogs = await _blogRepository
                .GetAll()
                .OrderByDescending(e => e.CreationTime)
                .Take(64)
                .ToListAsync();

            return new ListResultDto < BlogListDto > (blogs.MapTo < List < BlogListDto >> ());
        }
        public async Task CreateAsync(CreateBlogInput input)
        {
            var @blog = Blog.Create(AbpSession.GetTenantId(), input.Title, input.Content, input.AuthorId, input.CategoryId, input.Image);
            await _blogManager.CreateAsync(@blog);
        }
    }
}