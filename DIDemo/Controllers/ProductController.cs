using DIDemo.Models;
using DIDemo.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    public class ProductController : Controller
    {
        private IProductService service;
        public ProductController(IProductService service)
        {
            this.service = service;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View(service.GetAllProducts());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = service.GetProductById(id);
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                int result = service.AddProduct(product);
                if(result == 1)
                return RedirectToAction(nameof(Index));
                else 
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = service.GetProductById(id);
            return View(product);
           // return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            try
            {
                int result = service.UpdateProduct(product);
                if(result == 1)
                return RedirectToAction(nameof(Index));
                else 
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = service.GetProductById(id);
            return View(product);
            //return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName(nameof(Delete))]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result=service.DeleteProduct(id);
                if(result == 1)
                return RedirectToAction(nameof(Index));
                else 
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
