using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.Models
{
    public interface IItemService
    {
        List<Item> GetAllItems();

        Item GetItem(string Id);

        void DeleteItem(string Id);

        string CreateItem(Item NewItem);

        void EditItem(string Id, Item EditedItem);
    }
}
