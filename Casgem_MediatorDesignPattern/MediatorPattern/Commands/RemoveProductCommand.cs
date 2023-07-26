using MediatR;

namespace Casgem_MediatorDesignPattern.MediatorPattern.Commands
{
    public class RemoveProductCommand:IRequest
    {
        public RemoveProductCommand(int id)
        {
            ID = id;
        }
        public int ID { get; set; }
    }
}
