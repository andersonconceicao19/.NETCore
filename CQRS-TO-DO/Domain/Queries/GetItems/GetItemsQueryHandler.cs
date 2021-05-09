using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRS_TO_DO.Entity;
using MediatR;

namespace CQRS_TO_DO.Domain.Queries
{
    public class GetItemsQueryHandler
        : IRequestHandler<GetItemsQuery, GetItemsQueryViewModel[]>
    {
        private readonly ItemsEntity _items;

        public GetItemsQueryHandler(ItemsEntity items)
        {
            _items = items;
        }

        public Task<GetItemsQueryViewModel[]> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            var r = _items.GetAll().Select(x => new GetItemsQueryViewModel()
            {
                Nome = x.Nome,
                Valor = x.Valor
            }).ToArray();
           return Task.FromResult(r);
        }

    }
}