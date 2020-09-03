using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public DateTime CreatAt { get; set; }
        public DateTime LastUpDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool Activate { get; set; }
        public List<Payment> Payments { get; set; }
    }
}