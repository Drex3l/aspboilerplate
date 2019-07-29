using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace blogger.Blogs.Dtos
{
    [AutoMapFrom(typeof(Blog))]
    public class BlogListDto : FullAuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public long AuthorID { get; set; }
        public string Image { get; set; }
    }
}