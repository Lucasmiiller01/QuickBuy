using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
