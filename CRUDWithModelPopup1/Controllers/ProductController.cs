using CRUDWithModelPopup1.DAL;
using CRUDWithModelPopup1.Models.DBEntites;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWithModelPopup1.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyDbContext _dbContext;

        public ProductController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetProducts()
        {
            var products = _dbContext.Products;
            return Json(products);
        }

        public JsonResult Insert(Product productModel)
        {
            if(ModelState == null || ModelState.IsValid)
            {
                _dbContext.Products.Add(productModel);
                _dbContext.SaveChanges();
                return Json("Product Saved Successfully");
            }
            return Json("Invalid data");

        }
    }
}
