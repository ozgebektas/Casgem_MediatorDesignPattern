using Casgem_MediatorDesignPattern.MediatorPattern.Results;
using MediatR;

namespace Casgem_MediatorDesignPattern.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery:IRequest<GetProductUpdateByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int id)
        {
            ID=id;
        }
        public int ID { get; set; }
    }
}
