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

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }


        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() {Id =Guid.NewGuid(), CreatedDate= DateTime.Now , Name="Product1", Price=300,Stock=20,Status=true,IsDeleted=false },
            //    new() {Id =Guid.NewGuid(), CreatedDate= DateTime.Now , Name="Product2", Price=200,Stock=20,Status=true,IsDeleted=false },
            //    new() {Id =Guid.NewGuid(), CreatedDate= DateTime.Now , Name="Product3", Price=500,Stock=20,Status=true,IsDeleted=false },
            //});

            //await _productWriteRepository.SaveAsync();

            Product p = await _productReadRepository.GetByIdAsync("FC358AC6-E31D-4129-A4D9-83080E576AA4",false);
            p.Name = "Product1";
            await _productWriteRepository.SaveAsync();
        }
    }
}
