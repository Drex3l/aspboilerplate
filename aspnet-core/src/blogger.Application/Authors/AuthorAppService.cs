using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.Runtime.Session;
using Abp.Application.Services.Dto;

using blogger.Authors.Dtos;

namespace blogger.Authors
{
    [AbpAuthorize]
    public class AuthorAppService : bloggerAppServiceBase
    {
        private readonly IAuthorManager _authorManager;
        private readonly IRepository<Author, long> _authorsRepository;
        public AuthorAppService (
            IAuthorManager authorManager,
            IRepository<Author, long> authorsRepository) {
            _authorManager = authorManager;
            _authorsRepository = authorsRepository;
        }
        public async Task<ListResultDto<AuthorListDto>> GetListAsync (GetAuthorListInput input) {
            var authors = await _authorsRepository
                .GetAll ()
                .WhereIf (!input.IncludeInactiveAccounts, e => !e.IsDeactivated)
                .Take (64)
                .ToListAsync ();

            return new ListResultDto<AuthorListDto> (authors.MapTo<List<AuthorListDto>> ());
        }
        public async Task CreateAsync (DtoAuthorInput input) {
            var @author = Author.Create (AbpSession.GetTenantId (), input.FirstName, input.LastName, input.Email);
            await _authorManager.CreateAsync (@author);
        }
        public async Task DeativateAsync (EntityDto<long> input) {
            var @author = await _authorManager.GetAsync (input.Id);
            @author.IsDeactivated = !@author.IsDeactivated;
            await _authorManager.UpdateAsync (@author);
        }
        public async Task<AuthorDetailOutput> GetDetailAsync (EntityDto<long> input) {
            var @author = await _authorsRepository
                .GetAll ()
                .Where (e => e.Id == input.Id)
                .Include (x => x.Blogs)
                .FirstOrDefaultAsync ();

            if (@author == null) {
                throw new UserFriendlyException ("Could not found the author, maybe it's deleted.");
            }
            return @author.MapTo<AuthorDetailOutput> ();
        }

        public async Task UpdateAsync (DtoAuthorInput input) {
            var @record = await _authorsRepository
                .GetAll ()
                .Where (e => e.Id == input.Id)
                .FirstOrDefaultAsync ();

            if (@record == null) {
                throw new UserFriendlyException ("Could not found the author, maybe it's deleted.");
            }
            var @author = Author.Update (input.Id, AbpSession.GetTenantId (), input.FirstName, input.LastName, input.Email);
            await _authorManager.UpdateAsync (@author);
        }
    }
}