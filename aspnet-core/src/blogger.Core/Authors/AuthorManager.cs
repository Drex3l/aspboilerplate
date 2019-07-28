using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Events.Bus;
namespace blogger.Authors
{
    public class AuthorManager : IAuthorManager
    {
        private readonly IRepository<Author, long> _authorRepository;
        public IEventBus EventBus { get; set; }
        public AuthorManager (IRepository<Author, long> authorRepository) {
            this._authorRepository = authorRepository;
            this.EventBus = NullEventBus.Instance;
        }
        public async Task<Author> GetAsync (long id) {
            var @author = await _authorRepository.FirstOrDefaultAsync (id);
            if (@author == null) {
                throw new UserFriendlyException ("Could not find author, maybe it's deleted!");
            }
            return @author;
        }

        public async Task CreateAsync (Author @author) {
            await _authorRepository.InsertAsync (@author);
        }

        public async Task UpdateAsync (Author @author) {
             var @record = await _authorRepository
                .GetAll ()
                .Where (e => e.Id == @author.Id)
                .FirstOrDefaultAsync ();
            if (@record == null)
            {
                throw new UserFriendlyException("Could not find the author, maybe it's deleted!");
            }
            await _authorRepository.UpdateAsync (@author);
        }
    }
}