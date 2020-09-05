using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName,
                            string cardNumber, string lastTransactionNumber, DateTime paidDate, 
                            DateTime expireDate, 
                            decimal total, Address address, Document document, string payer, Email email,
                            decimal totalPaid ) 
                            : base(paidDate, expireDate, total, address, document, payer, email, totalPaid)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }

}