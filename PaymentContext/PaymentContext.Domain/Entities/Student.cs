using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
     private List<Subscription> _subscriptions;

    public Student(Name name, Document document, Email email )
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();
        
        AddNotifications(name, document, email);
    }

     public Name Name { get; private set; } 
     public Document Document { get; private set; }
     public Email Email { get; private set; }
     public Address Address { get; private set; }
     public IReadOnlyCollection<Subscription> Subscription { get  { return _subscriptions.ToArray(); } }
    
    public void AddSubscription(Subscription subscription)
    {
        var hasSubscriptionActive = false;
        foreach (var sub in _subscriptions)
        {
            if (sub.Activate)
            {
                hasSubscriptionActive = true;
            }
        }
        if(hasSubscriptionActive)
            AddNotification("Student.Subscription", "Você já tem uma assinatura ativa.");
        //Há como fazer com contratos tambem esta validações.
    }

    }
}