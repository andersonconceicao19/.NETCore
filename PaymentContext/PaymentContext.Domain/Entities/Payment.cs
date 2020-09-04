using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, string address, string document, string payer, string email, decimal totalPaid)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            Address = address;
            Document = document;
            Payer = payer;
            Email = email;
            TotalPaid = totalPaid;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public string Address { get; private set; }
        public string Document { get; private set; }
        public string Payer { get; private set; }
        public string Email { get; private set; }
        public decimal TotalPaid { private get; set; }
    }
    
}