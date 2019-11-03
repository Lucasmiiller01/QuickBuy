namespace QuickBuy.Domain.Entities
{
    class ItemOrder : Entity
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }

        public override void Validate()
        {
            ClearMessagesValidation();

            if (Amount < 1)
            {
                AddMessage("A quatidade precisa ser mais que 0.");
            }

        }
    }
}
