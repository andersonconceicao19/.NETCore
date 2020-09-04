using System;

namespace PaymentContext.Domain.Entities
{
   public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionConde,
                            DateTime paidDate, 
                            DateTime expireDate, 
                            decimal total, string address, string document, string payer, string email,
                            decimal totalPaid ) 
                            : base(paidDate, expireDate, total, address, document, payer, email, totalPaid)
        {
            TransactionConde = transactionConde;
        }

        public string  TransactionConde { get; private set; }
    }

}