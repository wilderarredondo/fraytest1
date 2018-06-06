using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Api3.Models;

namespace Api3.Controllers
{
    [Route("api3/[controller]")]
    [ApiController]
    public class Api3Controller : ControllerBase
    {
        List<Item> _itemList;
        public Api3Controller()
        {
            FillAllListsValues();
        }

        [HttpGet]
        [Route("items")]
        public ActionResult <List<Item>> GetAll()
        {
            return _itemList.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetById(string id)
        {
            Item item = _itemList.Where(x => x.ItemId == id).FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        public void FillAllListsValues()
        {
            _itemList = new List<Item>();

            Item Item1 = new Item
            {
                ItemId = "1",
                ItemName = "Angelo M. Ullman",
                ItemPhone = "123456789",
                ItemAddress = "Angelo Address",
                ItemEmail = "Angelo@mail.com"
            };

            Item Item2 = new Item
            {
                ItemId = "2",
                ItemName = "Maudie V. Hall",
                ItemPhone = "234567891",
                ItemAddress = "Maudie Address",
                ItemEmail = "Maudie@mail.com"
            };

            Item Item3 = new Item
            {
                ItemId = "3",
                ItemName = "David M. Brooks",
                ItemPhone = "345678912",
                ItemAddress = "David Address",
                ItemEmail = "David@mail.com"
            };

            Item Item4 = new Item
            {
                ItemId = "4",
                ItemName = "Marcelle S. Padilla",
                ItemPhone = "456789123",
                ItemAddress = "Marcelle Address",
                ItemEmail = "Marcelle@mail.com"
            };

            Item Item5 = new Item
            {
                ItemId = "5",
                ItemName = "Evelyn S. Bradley",
                ItemPhone = "567891234",
                ItemAddress = "Evelyn Address",
                ItemEmail = "Evelyn@mail.com"
            };

            Item Item6 = new Item
            {
                ItemId = "6",
                ItemName = "James C. Turner",
                ItemPhone = "678912345",
                ItemAddress = "James Address",
                ItemEmail = "James@mail.com"
            };

            Item Item7 = new Item
            {
                ItemId = "7",
                ItemName = "Heriberto E. Witte",
                ItemPhone = "789123456",
                ItemAddress = "Heriberto Address",
                ItemEmail = "Heriberto@mail.com"
            };

            Item Item8 = new Item
            {
                ItemId = "8",
                ItemName = "Carol J. Bender",
                ItemPhone = "891234567",
                ItemAddress = "Carol Address",
                ItemEmail = "Carol@mail.com"
            };

            Item Item9 = new Item
            {
                ItemId = "9",
                ItemName = "Michelle M. Borror",
                ItemPhone = "132457689",
                ItemAddress = "Michelle Address",
                ItemEmail = "Michelle@mail.com"
            };

            Item Item10 = new Item
            {
                ItemId = "10",
                ItemName = "Donald P. Tewksbury",
                ItemPhone = "324576891",
                ItemAddress = "Donald Address",
                ItemEmail = "Donald@mail.com"
            };

            Item Item11 = new Item
            {
                ItemId = "11",
                ItemName = "Kenneth P. Moler",
                ItemPhone = "245768913",
                ItemAddress = "Kenneth Address",
                ItemEmail = "Kenneth@mail.com"
            };

            Item Item12 = new Item
            {
                ItemId = "12",
                ItemName = "David I. Morris",
                ItemPhone = "457689132",
                ItemAddress = "David2 Address",
                ItemEmail = "David2@mail.com"
            };

            Item Item13 = new Item
            {
                ItemId = "13",
                ItemName = "David A. Ireland",
                ItemPhone = "576891324",
                ItemAddress = "David1 Address",
                ItemEmail = "David1@mail.com"
            };

            Item Item14 = new Item
            {
                ItemId = "14",
                ItemName = "Curtis J. Horace",
                ItemPhone = "768913245",
                ItemAddress = "Curtis Address",
                ItemEmail = "Curtis@mail.com"
            };

            Item Item15 = new Item
            {
                ItemId = "15",
                ItemName = "Lashaun J. Morgan",
                ItemPhone = "689132457",
                ItemAddress = "Lashaun Address",
                ItemEmail = "Lashaun@mail.com"
            };

            Item Item16 = new Item
            {
                ItemId = "16",
                ItemName = "Joe W. Hanlon",
                ItemPhone = "891324576",
                ItemAddress = "Joe Address",
                ItemEmail = "Joe@mail.com"
            };

            Item Item17 = new Item
            {
                ItemId = "17",
                ItemName = "Alma J. Olson",
                ItemPhone = "913245768",
                ItemAddress = "Alma Address",
                ItemEmail = "Alma@mail.com"
            };

            Item Item18 = new Item
            {
                ItemId = "18",
                ItemName = "Brian T. Hayes",
                ItemPhone = "132337689",
                ItemAddress = "Brian Address",
                ItemEmail = "Brian@mail.com"
            };

            Item Item19 = new Item
            {
                ItemId = "19",
                ItemName = "Deborah G. Kavanaugh",
                ItemPhone = "324576891",
                ItemAddress = "Deborah Address",
                ItemEmail = "Deborah@mail.com"
            };

            Item Item20 = new Item
            {
                ItemId = "20",
                ItemName = "James S. Gargano",
                ItemPhone = "245768913",
                ItemAddress = "James1 Address",
                ItemEmail = "James1@mail.com"
            };

            _itemList.Add(Item1);
            _itemList.Add(Item2);
            _itemList.Add(Item3);
            _itemList.Add(Item4);
            _itemList.Add(Item5);
            _itemList.Add(Item6);
            _itemList.Add(Item7);
            _itemList.Add(Item8);
            _itemList.Add(Item9);
            _itemList.Add(Item10);
            _itemList.Add(Item11);
            _itemList.Add(Item12);
            _itemList.Add(Item13);
            _itemList.Add(Item14);
            _itemList.Add(Item15);
            _itemList.Add(Item16);
            _itemList.Add(Item17);
            _itemList.Add(Item18);
            _itemList.Add(Item19);
            _itemList.Add(Item20);
        }
    }
}