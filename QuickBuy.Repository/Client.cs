using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Repositories
{
    public class Client
    {
        public Client ()
        {
            var userRepository = new UserRepository();
            var user = new User();

            userRepository.Add(user);

        }

    }
}
