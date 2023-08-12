using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebAppService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    public class ProductsController : ControllerBase
    {

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Products")]
        public List<Products> Products()//Async method
        {
            Products pd = new Products();
            List<Products> lstPd = new List<Products>();
            pd.ProductCode = "001";
            pd.ProductName = "Printer";
            pd.ProductType = "Hardware";
            pd.UnitPrice = 100;
            pd.WarrentyPeriod = "5 Year";
            lstPd.Add(pd);

            Products pds = new Products();
            pds.ProductCode = "002";
            pds.ProductName = "CRM Soft";
            pds.ProductType = "Software";
            pds.UnitPrice = 1000;
            pds.WarrentyPeriod = "10 Year";
            lstPd.Add(pds);
            _logger.LogInformation("Returned the all the Product list");
            return lstPd;
        }

        [HttpGet]
        [Route("ProductsID")]
        public List<Products> ProductsID(string prodID)
        {
            Products pd = new Products();
            List<Products> lstPd = new List<Products>();
            pd.ProductCode = "001";
            pd.ProductName = "Printer";
            pd.ProductType = "Hardware";
            pd.UnitPrice = 100;
            pd.WarrentyPeriod = "5 Year";
            lstPd.Add(pd);

            Products pds = new Products();
            pds.ProductCode = "002";
            pds.ProductName = "CRM Soft";
            pds.ProductType = "Software";
            pds.UnitPrice = 1000;
            pds.WarrentyPeriod = "10 Year";
            lstPd.Add(pds);
            var lstPd1 = lstPd.Where(s => s.ProductCode == prodID).ToList();
            _logger.LogInformation("Returned the Product ID details");
            return lstPd1.ToList<Products>();
        }
    }
}
