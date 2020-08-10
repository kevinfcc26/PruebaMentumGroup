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
    
        [HttpPost]
        public async Task<IActionResult> Post(ContactsModel contact)
        {
            var res = await _contactRepository.Add( ContactsMapper.Map( contact ));
            return Ok( ContactsMapper.Map( res));
        }

    }
}