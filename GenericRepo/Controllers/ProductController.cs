using GenericRepo.GenericRepository;
using GenericRepo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GenericRepo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository _repository;
        public ProductController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _repository.SelectAllAsync<Product>();
            return View(model);
        }
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct(Product product)
        {
             await _repository.CreateAsync<Product>(product);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateProduct(int id)
        {
            var model = await _repository.SelectByIdAsync<Product>(id);
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> UpdateProduct(Product product)
        {
            await _repository.UpdateAsync<Product>(product);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {

            var model = await _repository.SelectByIdAsync<Product>(id);
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteProduct(Product product)
        {
            await _repository.DeleteAsync<Product>(product);

            return RedirectToAction("Index");
        }


    }
}
