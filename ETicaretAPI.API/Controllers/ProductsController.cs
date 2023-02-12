using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        readonly private IOrderReadRepository _orderReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;

        readonly private ICustomerReadRepository _customerReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            Order order = await _orderReadRepository.GetByIdAsync("2567F7A8-80C1-4D3A-F908-08DB0CEE3014");
            order.Address = "İstanbul/Üsküdar";
            await _orderWriteRepository.SaveAsync();

        }
    }
}
