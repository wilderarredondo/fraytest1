using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using Microsoft.AspNetCore.Mvc;

using Api3.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace webpage.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client = new HttpClient();

        public HomeController()
        {
        }

        public string GetJsonFromBody()
        {
            string result = "";
            try
            {
                if (!this.Request.ContentLength.HasValue)
                {
                    return null;
                }
                int len = (int)(this.Request.ContentLength ?? 0);
                byte[] buff = new byte[len];
                this.Request.Body.Read(buff, 0, len);
                result = System.Text.Encoding.Default.GetString(buff);
            }
            catch (Exception ex)
            {
                Console.WriteLine("=================>>>>" + ex);
                return null;
            }
            return result;
        }

        [HttpPost]
        [Route("customercreate")]
        public async Task<IActionResult> CustomerCreate()
        {
            if (!this.Request.ContentLength.HasValue)
            {
                return null;
            }

            string data = GetJsonFromBody();
            HttpContent content = new StringContent(data);
            client.BaseAddress = new Uri("http://localhost:4000/");
            HttpResponseMessage response = await client.PostAsync("api3/api3/customercreate", content);
            if (response.IsSuccessStatusCode)
            {
                return Ok();
            }
            return Ok(new {
                Data="",
                ContentType= "application/json"
            });
        }

        void ShowItem(Customer item)
        {
            Console.WriteLine($"Name: {item.CustomerName}\nAddress: " +
                $"{item.CustomerAddress}\nPhone: {item.CustomerPhone}");
        }

        async Task<List<Customer>> GetItemAsync(string path)
        {
            List<Customer> item = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                item = await response.Content.ReadAsAsync<List<Customer>>();
            }
            return item;
        }

        async Task<HttpResponseMessage> GetItemsAsync(string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            return null;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("customerList")]
        public async Task<IActionResult> CustomerList()
        {
            client.BaseAddress = new Uri("http://localhost:4000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            List<Customer> items = null;
            try
            {
                items = await GetItemAsync("api3/api3/customerList");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var serializeQueryParams = JsonConvert.SerializeObject(items);

            JProperty propMessage = new JProperty("Result", serializeQueryParams);
            JObject data = new JObject(propMessage);

            return Ok(new {
                Data=serializeQueryParams,
                ContentType= "application/json"
            });
        }
    }
}
