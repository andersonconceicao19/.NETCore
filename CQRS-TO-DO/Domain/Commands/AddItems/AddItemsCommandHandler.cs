using System;
using System.Threading;
using System.Threading.Tasks;
using CQRS_TO_DO.Entity;
using MediatR;

namespace CQRS_TO_DO.Domain
{
    public class AddItemsCommandHandler
                : IRequestHandler<AddItemsCommand, Unit>
    {
        private readonly ItemsEntity _entity;

        public AddItemsCommandHandler(ItemsEntity entity)
        {
            _entity = entity;
        }

        public Task<Unit> Handle(AddItemsCommand request, CancellationToken cancellationToken)
        {
            _entity.Add(new Items(request.Name, request.Value));
            Console.Write("hi {0} \n");
            return Task.FromResult(Unit.Value);
        }
    }
}
