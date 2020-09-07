using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handles;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler : Notifiable ,IHandler<CreateBoletoSubscriptionCommand>
    {
        public readonly IStudentRepositoty _repository;

        public SubscriptionHandler(IStudentRepositoty repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            //Fail Fast Validation
            command.Validate();
            if (command.Invalid())
            {
                return new CommandResult(false, "Não foi possivel sua assinatura.");
            }
            // Verificar se o documento existe
            if(_repository.DocummentExists(command.Document))
            {
                return new CommandResult(false, "Documento já incluso!.");
            }
                // Verificar se o Email existe
            if(_repository.EmailExists(command.Email))
            {
                return new CommandResult(false, "Email já incluso!.");
            }

            // Minuto 12















            return new CommandResult(true, "Assinatura concluída.");
        }
    }
}
