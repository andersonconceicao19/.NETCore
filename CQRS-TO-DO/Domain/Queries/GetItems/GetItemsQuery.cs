using System.Collections.Generic;
using MediatR;

namespace CQRS_TO_DO.Domain.Queries
{
    public class GetItemsQuery : IRequest<GetItemsQueryViewModel[]>
    {

    }
}