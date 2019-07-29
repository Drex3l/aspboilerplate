using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
namespace blogger.Authors.Dtos
{
    [AutoMapFrom(typeof(Author))]
    public class AuthorListDto : EntityDto<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsDeactivated { get; set; }
        public int BlogCount { get; set;}
    }
}