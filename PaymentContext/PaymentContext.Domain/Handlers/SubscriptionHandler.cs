using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handles;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.Entities;
using System;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler : Notifiable,
                IHandler<CreateBoletoSubscriptionCommand>,
                IHandler<CreatePayPalSubscriptionCommand>
                
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

            // Gerar Objects Values
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Number, Enums.EDocumentsType.CPF);
            var email = new Email(command.Email);
            var address = new Address(command.Street, command.Number, command.Neighborhood, command.City, command.State, command.ZipCode, command.Country);

            // Gerar Entidades
            var student = new Student(name, document, email);
            var subscription = new Subscription(DateTime.Now.AddMonths(1));
            var payment = new BoletoPayment(command.BarCode, 
                command.BoletoNumber, 
                command.PaidDate, 
                command.ExpireDate, 
                command.Total, 
                address, new Document(command.PayerDocument, command.PayerDocumentType), 
                command.Payer, 
                email, 
                command.TotalPaid 
                );

            // Relacionamentos            
            subscription.AddPayment(payment);
            student.AddSubscription(subscription);

            //Aplicar Validações
            AddNotifications(name, document, email, address, student, subscription, payment);

            //Salvar as informações
            _repository.CreateSubscription(student);

            //Enviar email de boas vindas
                //Send email Só criar um serviços

            return new CommandResult(true, "Assinatura concluída.");
        }

        public ICommandResult Handle(CreatePayPalSubscriptionCommand command)
        {
            /*
                Só implementar o mesmo código de cima.
            */
            throw new NotImplementedException();
        }
    }
}
