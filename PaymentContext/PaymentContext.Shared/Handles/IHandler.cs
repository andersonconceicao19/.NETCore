using PaymentContext.Shared.Commands;

namespace PaymentContext.Shared.Handles
{
    public interface IHandler<T> where T : ICommands
    {
        ICommandResult Handle(T command);
    }
}