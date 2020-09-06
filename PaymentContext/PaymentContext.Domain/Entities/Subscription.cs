using System;
using System.Collections.Generic;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : Entity
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
        public IReadOnlyCollection<Payment> Payments { get; private set; }

        public void AddPayment(Payment payment)
        {
            AddNotifications(new Contract().Requires()
                .IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription.Payments", "A data deve ser no valor futuro!."));
            _payments.Add(payment);
        }        
        public void Activated()
        {
            LastUpDate = DateTime.Now;
        }
        public void Inactivate()
        {
            LastUpDate = DateTime.Now;
        }
    }
}