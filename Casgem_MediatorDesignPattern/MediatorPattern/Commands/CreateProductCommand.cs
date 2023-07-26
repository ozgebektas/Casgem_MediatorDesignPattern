using MediatR;

namespace Casgem_MediatorDesignPattern.MediatorPattern.Commands
{
    public class CreateProductCommand:IRequest
    {
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
