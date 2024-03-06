using coneccionBd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coneccionBd.Services
{
    internal class ProductsServices
    {
        public ReciplastkContext dbReciplastk = new ReciplastkContext();

        public void ShowAll()
        {
            var productsList = dbReciplastk.Products.ToList();

            Console.WriteLine(" PRODUCTOS RECIPLASTIK");
            Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine($" NAME              | DESCRIPTION                                        |  CODE        |  BUY PRICE        |  SELL PRICE        |  MARGIN        |");
            //Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var product in productsList)
            {
                Console.WriteLine("infor de product: " + product);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                Console.WriteLine($" Name:          {product.Name}");
                Console.WriteLine($" Description:   {product.Description}");
                Console.WriteLine($" Code:          {product.Code}");
                Console.WriteLine($" Buy Price:     {product.Buyprice}");
                Console.WriteLine($" Sell Price:    {product.Sellprice}");
                Console.WriteLine($" Margin:        {product.Margin}");
                Console.WriteLine($" Is subtype:    {product.Issubtype}");
                Console.WriteLine($" Creation Day:  {product.Creationdate}");
                Console.WriteLine($" Up Date:       {product.Updatedate}");
                Console.WriteLine($" Is Active:     {product.Isactive}");
                //Console.WriteLine($"{product.Name}   {product.Description}           product.Code}  {product.Buyprice}  {product.Sellprice}  {product.Margin}");                            
                //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
        }

        public void  ShowName( string name)
        {
            // Filter by name:
            var dbProductsRows = dbReciplastk.Products.Where(p => p.Name == name).ToList();
            Console.WriteLine();

            //Show all the information. 

            foreach (var item in dbProductsRows) 
            { 
                Console.WriteLine(item);
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

        }



        private void PrintAllProducts ()
        {

            

        }
    }

}
