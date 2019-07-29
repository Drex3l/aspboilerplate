using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace blogger.Authors.Dtos
{
    [AutoMapFrom(typeof(Author))]
    public class DtoAuthorInput : EntityDto<long>
    {
        [Required]
        [StringLength(Author.MaxNameLength)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(Author.MaxNameLength)]
        public string LastName { get; set; }
        
        [StringLength(Author.MaxEmailLength)]
        public string Email { get; set; }
    }
}