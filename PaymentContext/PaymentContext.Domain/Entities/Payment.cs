using System;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidDate,
         DateTime expireDate, 
         decimal total, 
         Address address, 
         Document document, 
         string payer, 
         Email email, 
         decimal totalPaid)
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

            AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(0,Total, "Payment.Total", "O total nao pode ser zero")
            .IsGreaterOrEqualsThan(Total, TotalPaid, "Payment.TotalPaid", "O valor pago é menor e blabla!"));
            
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public Address Address { get; private set; }
        public Document Document { get; private set; }
        public string Payer { get; private set; }
        public Email Email { get; private set; }
        public decimal TotalPaid { private get; set; }
    }
    
}