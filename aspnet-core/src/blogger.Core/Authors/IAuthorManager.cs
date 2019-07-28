using System.Threading.Tasks;
using Abp.Domain.Services;
namespace blogger.Authors
{
    public interface IAuthorManager  : IDomainService
    {
         Task<Author> GetAsync(long id);
         Task CreateAsync(Author @author);
         Task UpdateAsync(Author @author);
    }
}