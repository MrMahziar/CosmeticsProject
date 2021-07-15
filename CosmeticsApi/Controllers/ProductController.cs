using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductInputDto productInputDto)
        {
            await productService.Insert(productInputDto);
            return Ok();

        }
        [HttpGet("{id}")]
        public async Task <IActionResult> Get(int id)
        {
           var product= await productService.Get(id);
            return Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var product = await productService.GetAll();
            return Ok(product);
        }
        [HttpPut]

        public async Task<IActionResult> Update(ProductInputDto productInputDto)
        {
            await productService.Update(productInputDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete( int id)
        {
            await productService.Delete(id);
            return Ok();
        }

    }
}