using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
   public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionConde,
                            DateTime paidDate, 
                            DateTime expireDate, 
                            decimal total, Address address, Document document, string payer, Email email,
                            decimal totalPaid ) 
                            : base(paidDate, expireDate, total, address, document, payer, email, totalPaid)
        {
            TransactionConde = transactionConde;
        }

        public string  TransactionConde { get; private set; }
    }

}