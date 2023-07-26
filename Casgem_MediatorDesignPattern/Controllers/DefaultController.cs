using Casgem_MediatorDesignPattern.MediatorPattern.Commands;
using Casgem_MediatorDesignPattern.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Casgem_MediatorDesignPattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values =await _mediator.Send(new GetProductQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var value=await _mediator.Send(new GetProductUpdateByIDQuery(id));
            return View(value);
        }
        [HttpPost]
        //public async Task<IActionResult> UpdateProduct()
        //{
        //    return View();
        //}
    }
}
