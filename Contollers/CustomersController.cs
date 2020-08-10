using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerManager.Repositories;
using CustomerManager.Mappers;
using CustomerManager.Models;

namespace CustomerManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerRepository _customerRepository;
        private readonly ContactRepository _contactRepository;
        public CustomersController(CustomerRepository customerRepository, ContactRepository contactRepository){
            _customerRepository = customerRepository;
            _contactRepository = contactRepository;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var viewModel = new ViewModel();
            var resp = (await _customerRepository.GetAll()).Select(CustomersMapper.Map);

            foreach (var item in resp)
            {
                item.Contacts =(await _contactRepository.getForId(item.Id)).Select(ContactsMapper.Map).ToList();
            }

            return Ok(resp);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}