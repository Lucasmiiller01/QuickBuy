using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Contracts;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {

        }

    }
}