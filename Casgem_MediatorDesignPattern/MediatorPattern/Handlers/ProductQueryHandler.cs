using Casgem_MediatorDesignPattern.DAL;
using Casgem_MediatorDesignPattern.MediatorPattern.Queries;
using Casgem_MediatorDesignPattern.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_MediatorDesignPattern.MediatorPattern.Handlers
{
    public class ProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly Context _context;

        public ProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetProductQueryResult
            {
                ProductID=x.ProductID,
                Brand = x.Brand,
                Category = x.Category,
                Stock = x.Stock,
                Name = x.Name,
                Price = x.Price,
            }).AsNoTracking().ToListAsync();
        }
    }
}
