using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppDbRecipastk.DataAccess;
using WebAppDbRecipastk.NewFolder4;
using WebAppDbRecipastk.services;

namespace WebAppDbRecipastk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dbReciplastkController : ControllerBase
    {
                       
        public ProductsServices productsServices = new ProductsServices();

       
        [HttpGet("showAllInfo")]
        public List<Product> ShowAllInfo()
        {

            return productsServices.ShowAllListProducts();

        }
        [HttpGet("ShowProductsForName")]

        public List<Product> ShowProductsForName(string name)
        {

            return productsServices.ShowProductForName(name);
        }
        [HttpGet("ShowProductsFirstName")]

        public Product ShowProductsFirstName(string name)
        {

            return productsServices.ShowProductsFirstName(name);
        }

        [HttpGet("verifyProduct")]

        public bool VeryfyProduct(string name)
        {
            return productsServices.VerifyProduct(name);
        }


        [HttpPost("createNewProduct")]
        public bool CreateNewProduct(ModelsProducts infoProduct)
        {
            
            return productsServices.CreateNewProduct(infoProduct);
        }
        
        [HttpPost("ModifyAllProduct")]

        public Product ModifyAllProduct(string name, string description, string code, int buyPrice, int sellPrice, int margin)
        {
            return productsServices.ModifyAllProduct2(name, description, code, buyPrice, sellPrice, margin);
        }

        [HttpPost("ModifyAllProduct2")]
        public Product ModifyllProduct2(ModelsProducts infoProduct) { 
        
            return productsServices.ModifyAllProduct(infoProduct);
        }

        [HttpPost("RemoveProduct")]

        public bool DeleteProduct(string name)
        {
            return productsServices.RemoveProduct(name);
        }




    }
}
