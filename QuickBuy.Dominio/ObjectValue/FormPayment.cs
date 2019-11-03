using QuickBuy.Domain.Enums;

namespace QuickBuy.Domain.ObjectValue
{
    class FormPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool isBillet
        {
            get { return Id == (int)TypeFormPaymentEnum.Billet; }
        }

        public bool isCreditCard
        {
            get { return Id == (int)TypeFormPaymentEnum.CreditCard; }
        }
        public bool isUndefined
        {
            get { return Id == (int)TypeFormPaymentEnum.Undefined; }
        }
        public bool isDeposit
        {
            get { return Id == (int)TypeFormPaymentEnum.Deposit; }
        }


    }
}
