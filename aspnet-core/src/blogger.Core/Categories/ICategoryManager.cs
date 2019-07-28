using System.Threading.Tasks;
using Abp.Domain.Services;

namespace blogger.Categories {
    public interface ICategoryManager: IDomainService {
        Task < Category > GetAsync(int id);
        Task CreateAsync(Category @category);

        Task DeleteAsync(Category @category);
    }
}