namespace QuickBuy.Domain.Entities
{
    class ItemOrder
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }
    }
}
