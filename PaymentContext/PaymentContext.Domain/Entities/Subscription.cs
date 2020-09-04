using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private List<Payment> _payments;
        public Subscription(DateTime? expireDate)
        {
            CreatAt = DateTime.Now;
            LastUpDate = DateTime.Now;
            ExpireDate = expireDate;
            Activate = true;
            _payments = new List<Payment>();
        }

        public DateTime CreatAt { get; private set; }
        public DateTime LastUpDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Activate { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get; set; }
    }
}