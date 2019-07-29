using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

using blogger.Blogs;

namespace blogger.Authors.Dtos
{
    [AutoMapFrom(typeof(Author))]
    public class AuthorDetailOutput : EntityDto<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsDeactivated { get;  set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}