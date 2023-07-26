using Casgem_MediatorDesignPattern.DAL;
using Casgem_MediatorDesignPattern.MediatorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_MediatorDesignPattern.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {

        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                Name = request.Name,
                Stock = request.Stock,
                Brand = "Bilinmiyor",
                Price=0
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
