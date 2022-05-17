using ClassLibrary1.DataAccess;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyShopDataManager.Controllers
{
    //[Authorize]
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<ProductModel> GetGetProduct()
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            List<ProductModel> productModelList = new List<ProductModel>();
            productModelList =  productDataAccess.GetProduct();


            return productModelList;
        }
    }
}
