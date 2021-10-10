using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using implementation.Repositories;
using implementation.Entities;
using implementation.Dtos;
using System.Linq;
namespace implementation.Controllers
{
    // GET /items
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase 
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository){
            this.repository = repository;
        }


        // GET /items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select( item => item.AsDto());
            return items;
        }


        // GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id).AsDto();
            return item == null ? NotFound() : item;
        }
    }
}
