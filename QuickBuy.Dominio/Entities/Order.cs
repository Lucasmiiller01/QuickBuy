using System;
using System.Collections.Generic;
using QuickBuy.Domain.ObjectValue;

namespace QuickBuy.Domain.Entities
{
    class Order
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

    }
}
