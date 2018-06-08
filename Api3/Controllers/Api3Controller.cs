using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Api3.Models;
using Api3;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net;
using System;
using Newtonsoft.Json;

namespace Api3.Controllers
{
    [Route("api3/[controller]")]
    [ApiController]
    public class Api3Controller : ControllerBase
    {
        private readonly ApiContext _context;

        public Api3Controller(ApiContext context)
        {
            _context = context;
        }

        public string GetJsonFromBody()
        {
            try
            {
                if (!this.Request.ContentLength.HasValue)
                {
                    return null;
                }
                int len = (int)(this.Request.ContentLength ?? 0);
                byte[] buff = new byte[len];
                this.Request.Body.Read(buff, 0, len);
                string result = System.Text.Encoding.Default.GetString(buff);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                return null;
            }
        }

        [HttpPost]
        [Route("customercreate")]
        public ActionResult<HttpResponseMessage> CustomerCreate()
        {
            string data = GetJsonFromBody();
            Customer customer = JsonConvert.DeserializeObject<Customer>(data);
            if (data == null)
                return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = "POST body is null" };

            try
            {
                Customer lastCustomer = _context.Customer.LastOrDefault();
                if(lastCustomer != null)
                {
                    customer.CustomerId = lastCustomer.CustomerId + 1;
                }
                else
                {
                    customer.CustomerId = 1;
                }
                _context.Customer.Add(customer);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.InternalServerError, ReasonPhrase = $"Customer could not be created: {ex.InnerException}" };
            }
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK, ReasonPhrase = "Saved" };
        }

        [HttpGet]
        [Route("customerlist")]
        public ActionResult<List<Customer>>  GetCustomers()
        {
            List<Customer> customer = _context.Customer.ToList();
            return customer;
        }

        [HttpGet]
        [Route("customer/{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            Customer customer = _context.Customer.Where(x => x.CustomerId == id).FirstOrDefault();
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        [HttpPost]
        [Route("customerupdate")]
        public HttpResponseMessage CustomerUpdate([FromBody] JObject data)
        {
            if (data == null)
                return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = "POST body is null" };

            try
            {
                int customerId = data.GetValue("CustomerId").Value<int>();
                Customer customerUpdate = _context.Customer.Where(x => x.CustomerId == customerId).FirstOrDefault();
                if (customerUpdate != null)
                {
                    customerUpdate.CustomerName = data.GetValue("CustomerName").Value<string>();
                    customerUpdate.CustomerPhone = data.GetValue("CustomerPhone").Value<string>();
                    customerUpdate.CustomerAddress = data.GetValue("CustomerAddress").Value<string>();
                    customerUpdate.CustomerEmail = data.GetValue("CustomerEmail").Value<string>();
                    _context.Customer.Update(customerUpdate);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.InternalServerError, ReasonPhrase = $"Customer could not be updated: {ex.InnerException}" };
            }
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK, ReasonPhrase = "Updated" };
        }

        [HttpPost]
        [Route("customerdelete")]
        public HttpResponseMessage SetCustomerDeleteById([FromBody] JObject data)
        {
            try
            {
                int id = data.GetValue("CustomerId").Value<int>();
                Customer customer = _context.Customer.Where(x => x.CustomerId == id).FirstOrDefault();
                if (customer != null)
                {
                    _context.Customer.Remove(customer);
                    _context.SaveChanges();
                }
                else
                {
                    return new HttpResponseMessage { StatusCode = HttpStatusCode.OK, ReasonPhrase = "Notfound"};
                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.InternalServerError, ReasonPhrase = $"Customer could not be removed: {ex.InnerException}" };
            }
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK, ReasonPhrase = "Removed"};
        }
    }
}