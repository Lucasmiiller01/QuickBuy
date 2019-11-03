using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using System;

namespace QuickBuy.Web4.Controllers
{
    [Route("api/[Controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_productRepository.GetAll());
                /* return BadRequest("teste") */
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());             
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            try
            {
                _productRepository.Add(product);
                return Created("api/product/", product);
                /* return BadRequest("teste") */
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    } 
}
