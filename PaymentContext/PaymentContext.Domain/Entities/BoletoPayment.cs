using System;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, 
                            string boletoNumber,
                            DateTime paidDate, 
                            DateTime expireDate, 
                            decimal total, string address, string document, string payer, string email,
                            decimal totalPaid ) 
                            : base(paidDate, expireDate, total, address, document, payer, email, totalPaid)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }

}