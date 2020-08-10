using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerManager.Models;
using CustomerManager.Repositories;
using CustomerManager.Mappers;

namespace CustomerManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerRepository _customerRepository;
        public HomeController(CustomerRepository customerRepository){
            _customerRepository = customerRepository;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public  async Task<IActionResult> Customers()
        {
            var viewModel = new ViewModel();
            var resp = await _customerRepository.GetAll();
            var customer = resp.Select(CustomersMapper.Map);
            viewModel.ieCustomerModels = customer;
            
            
            return View(viewModel);
        }
        public async Task<IActionResult> GetCustomer(string id){
            var response = await _customerRepository.Get(Int32.Parse(id));
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerModel model){
            try
            {
                if (ModelState.IsValid)
                {
                    model.CreateDate = DateTime.Now;
                   var response = await _customerRepository.Add(CustomersMapper.Map(model));

                   return Redirect("/home");
                }
                return Redirect("/home");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> EditCustomer(CustomerModel Customer)
        {
            var resp = await _customerRepository.Update(CustomersMapper.Map(Customer));
            return Ok(resp);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCustomer(string id){
            await _customerRepository.DeleteAsync(Int32.Parse(id));
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}