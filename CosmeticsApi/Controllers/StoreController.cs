using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService storeService;

        public StoreController(IStoreService storeService)
        {
            this.storeService = storeService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(StoreInputDto storeInputDto)
        {
            await storeService.Insert(storeInputDto);
            return Ok();

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var store = await storeService.Get(id);
            return Ok(store);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var store = await storeService.GetAll();
            return Ok(store);
        }
        [HttpPut]

        public async Task<IActionResult> Update(StoreInputDto storeInputDto)
        {
            await storeService.Update(storeInputDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await storeService.Delete(id);
            return Ok();
        }
    }
}