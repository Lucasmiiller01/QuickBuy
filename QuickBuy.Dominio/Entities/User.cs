using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            ClearMessagesValidation();

            if (string.IsNullOrEmpty(Email))
            {
                AddMessage("Email do usuário precisa ser informado.");
            }

            if (string.IsNullOrEmpty(Name))
            {
                AddMessage("Nome do usuário precisa ser informado.");
            }

        }
    }
}
