using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
 public class Name : ValueObject
 {
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        
        AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(FirstName, 3,"Name.FirstName" ,"O nome deve conter no minimo 3 caracter")                       
            );
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
 }   
}