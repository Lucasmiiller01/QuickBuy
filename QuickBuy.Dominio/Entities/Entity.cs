using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _messagesValidation { get; set; }
        private List<string> MessageValidation
        {
            get { return _messagesValidation ?? (_messagesValidation = new List<string>()); }

        }

        public abstract void Validate();
        protected void ClearMessagesValidation()
        {
            MessageValidation.Clear();
        }

        protected void AddMessage( string message)
        {
            MessageValidation.Add(message);
        }


        protected bool isValid
        {
            get { return !MessageValidation.Any(); }
        }
    }
}
