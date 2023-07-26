using Casgem_MediatorDesignPattern.DAL;
using Casgem_MediatorDesignPattern.MediatorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_MediatorDesignPattern.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.ProductID);
            values.Brand=request.Brand;
            values.Name=request.Name;
            values.Price=request.Price;
            values.Category=request.Category;
            values.Stock=request.Stock;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
