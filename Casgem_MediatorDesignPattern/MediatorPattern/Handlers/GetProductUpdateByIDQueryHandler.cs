using Casgem_MediatorDesignPattern.DAL;
using Casgem_MediatorDesignPattern.MediatorPattern.Queries;
using Casgem_MediatorDesignPattern.MediatorPattern.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_MediatorDesignPattern.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetProductUpdateByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ID);
            return new GetProductUpdateByIDQueryResult
            {
                Brand = values.Brand,
                Category = values.Category,
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock
            };
        }
    }
}
