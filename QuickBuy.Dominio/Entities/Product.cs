﻿namespace QuickBuy.Domain.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public override void Validate()
        {
            ClearMessagesValidation();

            if (string.IsNullOrEmpty(Name))
            {
                AddMessage("Nome de produto precisa ser informado.");
            }

        }
    }
}
