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
       
        [HttpGet("showAllListProducts")]
        public List<Product> ShowAllListProducts()
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
        [HttpGet ("searchProduct")]
        
        public Product SearchProduct(string name)
        {
            return productsServices.SearchProduct(name);
        }

        [HttpPost("modifyProduct")]
        public Product ModifyProduct(ModelsProducts infoProduct) { 
        
            return productsServices.ModifyProduct(infoProduct);
        }

        [HttpPost("removeProduct")]

        public bool DeleteProduct(string name)
        {
            return productsServices.RemoveProduct(name);
        }




    }
}
