using System;
using System.Collections.Generic;
using System.Linq;
using QuickBuy.Domain.ObjectValue;

namespace QuickBuy.Domain.Entities
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public ICollection<ItemOrder> ItensOrders { get; set; }
        public int FormPaymentId { get; set; }
        public FormPayment FormPayment { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string NumberAddress { get; set; }
        public string FullAdress { get; set; }

        public override void Validate()
        {
            ClearMessagesValidation();

            if(!ItensOrders.Any())
            {
                AddMessage("Pedido não pode ficar sem item de pedido.");
            }

            if (string.IsNullOrEmpty(CEP))
            {
                AddMessage("Cep deve estar preenchido.");
            }
        }
    }
}
