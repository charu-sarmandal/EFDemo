using Microsoft.AspNetCore.Mvc;
using EfDemo.Models;
using System.CodeDom;

namespace EfDemo.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly DairyDbContext _dairyContext;

        public ProductController(DairyDbContext dairyContext)
        {
            _dairyContext = dairyContext;
        }
       

        // GET: api/products
        [HttpGet]
        public  IEnumerable<ProductModel> GetProducts()
        {
            return  _dairyContext.Products.ToList();
        }
    }
}
