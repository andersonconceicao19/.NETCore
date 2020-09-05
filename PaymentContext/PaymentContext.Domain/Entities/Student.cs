using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entity;

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
    }

     public Name Name { get; private set; } 
     public Document Document { get; private set; }
     public Email Email { get; private set; }
     public Address Address { get; private set; }
     public IReadOnlyCollection<Subscription> Subscription { get  { return _subscriptions.ToArray(); } }
    }
}