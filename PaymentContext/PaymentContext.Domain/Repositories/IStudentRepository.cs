using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudentRepositoty
    {
        bool DocummentExists(string document);
        bool EmailExists(string email);
        void CreateSubscription(Student student);
    }
}