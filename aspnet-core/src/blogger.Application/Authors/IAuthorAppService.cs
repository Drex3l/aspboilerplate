using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using blogger.Authors.Dtos;

namespace blogger.Authors
{
    public interface IAuthorAppService : IApplicationService
    {
        Task<ListResultDto<AuthorListDto>> GetListAsync(GetAuthorListInput input);
        Task CreateAsync(DtoAuthorInput input);
        Task UpdateAsync(DtoAuthorInput input);
        Task DeativateAsync(EntityDto<long> input);
        Task<AuthorDetailOutput> GetDetailAsync(EntityDto<long> input);
    }
}