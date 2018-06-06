using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using Microsoft.AspNetCore.Mvc;

using web.Models;
using Api3.Models;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client = new HttpClient();
        void ShowItem(Item item)
        {
            Console.WriteLine($"Name: {item.ItemName}\nAddress: " +
                $"{item.ItemAddress}\nPhone: {item.ItemPhone}");
        }
        async Task<List<Item>> GetItemAsync(string path)
        {
            List<Item> item = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                item = await response.Content.ReadAsAsync<List<Item>>();
            }
            return item;
        }
        public async Task<IActionResult> Index()
        {
            client.BaseAddress = new Uri("http://localhost:4000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            ItemViewModel itemViewModel = new ItemViewModel();
            List<Item> item = null;
            try
            {
                item = await GetItemAsync("api3/api3/items");
                itemViewModel.items = item;
                //ShowItem(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(itemViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
