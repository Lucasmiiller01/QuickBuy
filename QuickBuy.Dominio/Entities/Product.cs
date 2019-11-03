namespace QuickBuy.Domain.Entities
{
    class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
