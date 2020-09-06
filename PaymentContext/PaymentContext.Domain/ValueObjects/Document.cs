using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
 public class Document : ValueObject
 {
    public Document(string number, EDocumentsType type)
    {
        Number = number;
        Type = type;
        
        AddNotifications(new Contract().Requires().IsTrue(Validate(), "Document.Number", "Documento Invalido"));
    }
    public string Number { get; private set; }
    public EDocumentsType Type { get; private set; }

    private bool Validate()
    {
        if(Type == EDocumentsType.CNPJ && Number.Length == 14)
            return true;
        if(Type == EDocumentsType.CNPJ && Number.Length == 14)
            return true; 

        return false;           
    }
 }   
}