using GenericRepo.GenericRepository;
using GenericRepo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GenericRepo.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepository _repository;
        public CustomerController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _repository.SelectAllAsync<Customer>();
            return View(model);
        }
        public async Task<IActionResult> AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddCustomer(Customer customer)
        {
            await _repository.CreateAsync<Customer>(customer);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCustomer(int id)
        {
            var model = await _repository.SelectByIdAsync<Customer>(id);
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> UpdateCustomer(Customer customer)
        {
            await _repository.UpdateAsync<Customer>(customer);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCustomer(int id)
        {

            var model = await _repository.SelectByIdAsync<Customer>(id);
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteCustomer(Customer customer)
        {
            await _repository.DeleteAsync<Customer>(customer);

            return RedirectToAction("Index");
        }

    }
}
