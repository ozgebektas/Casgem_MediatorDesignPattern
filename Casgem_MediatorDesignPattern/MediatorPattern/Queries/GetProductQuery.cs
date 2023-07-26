using Casgem_MediatorDesignPattern.MediatorPattern.Results;
using MediatR;
using System.Collections.Generic;

namespace Casgem_MediatorDesignPattern.MediatorPattern.Queries
{
    public class GetProductQuery:IRequest<List<GetProductQueryResult>>
    {
    }
}
