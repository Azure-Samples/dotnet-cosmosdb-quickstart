using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todo.Models;
using Microsoft.Extensions.Options;

namespace todo.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: Item
        public ActionResult Index()
        {
            return View(_itemService.GetAllItems());
        }

        // GET: Item/Details/5
        public ActionResult Details(string id)
        {
            Item item = _itemService.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return View(item);
            }
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item NewItem)
        {
            try
            {
                _itemService.CreateItem(NewItem);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(string id)
        {
            Item item = _itemService.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return View(item);
            }
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Item EditedItem)
        {
            try
            {
                _itemService.EditItem(id, EditedItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(string id)
        {
            Item item = _itemService.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return View(item);
            }
        }

        // POST: Item/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                _itemService.DeleteItem(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}