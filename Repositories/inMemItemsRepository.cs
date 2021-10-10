using System;
using System.Collections.Generic;
using System.Linq;
using implementation.Entities;
namespace implementation.Repositories
{
    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Price = 9, Name = "Potion", CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Price = 10, Name = "Iron Sword", CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Price = 11, Name = "Bronce Sheild", CreatedDate = DateTimeOffset.UtcNow }

        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(items => items.Id == id).SingleOrDefault();
        }
    }
}