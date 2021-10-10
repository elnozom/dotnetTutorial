using System;
using System.Collections.Generic;
using implementation.Entities;

namespace implementation.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}