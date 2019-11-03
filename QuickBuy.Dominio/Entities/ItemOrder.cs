namespace QuickBuy.Domain.Entities
{
    public class ItemOrder : Entity
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }

        public override void Validate()
        {
            ClearMessagesValidation();

            if (Amount == 0)
            {
                AddMessage("Quantidade não informada.");
            }

            if (ProductId == 0)
            {
                AddMessage("Sem referência de produto.");
            }

        }
    }
}
