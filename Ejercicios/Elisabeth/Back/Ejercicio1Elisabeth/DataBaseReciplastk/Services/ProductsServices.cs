using DataBaseReciplastk.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBaseReciplastk.Services
{
    internal class ProductsServices
    {

        public ReciplastkContext dbReciplastk = new ReciplastkContext();

        public void ShowAllProductsReciPlastk ()
        {
            var allProductsList = dbReciplastk.Products.ToList();

           foreach (var product in allProductsList)
            {
               
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
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
        }

        public void FilterAllProductsForName (string productName)
        {
            // Filter by name:
            var AllProductsForName = dbReciplastk.Products.Where(p => p.Name == productName).ToList();

            Console.WriteLine($"productsForName:  {AllProductsForName}");

            foreach (var product in AllProductsForName)
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

            }
        }

        public void FilterFirstProductsforName(string productName)
        {
            // Filter by first name:
            var FirstProductsForName = dbReciplastk.Products.Where(p => p.Name == productName).FirstOrDefault();

            Console.WriteLine("infor de product: " + FirstProductsForName);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($" Name:          {FirstProductsForName.Name}");
            Console.WriteLine($" Description:   {FirstProductsForName.Description}");
            Console.WriteLine($" Code:          {FirstProductsForName.Code}");
            Console.WriteLine($" Buy Price:     {FirstProductsForName.Buyprice}");
            Console.WriteLine($" Sell Price:    {FirstProductsForName.Sellprice}");
            Console.WriteLine($" Margin:        {FirstProductsForName.Margin}");
            Console.WriteLine($" Is subtype:    {FirstProductsForName.Issubtype}");
            Console.WriteLine($" Creation Day:  {FirstProductsForName.Creationdate}");
            Console.WriteLine($" Up Date:       {FirstProductsForName.Updatedate}");
            Console.WriteLine($" Is Active:     {FirstProductsForName.Isactive}");

        }


        public void CreateNewProduct()
        {


        }

        public void ModifyProduct(string name)
        {
            var existNameProduct = dbReciplastk.Products.Where(p => p.Name == name).FirstOrDefault();

            if (existNameProduct == null)
            {
                Console.WriteLine("Ese producto no se encuentra en la base de datos.");
            } else
            {
                Console.WriteLine();
                Console.WriteLine(" ingrse la opcion a modificar: ");
                Console.WriteLine();
                Console.WriteLine(" 1. nombre del producto.");
                Console.WriteLine(" 2. descripcion del producto.");
                Console.WriteLine(" 3. codigo del producto.");
                Console.WriteLine(" 4. precio de compra.");
                Console.WriteLine(" 5. precio de venta.");
                Console.WriteLine(" 6. Todas las especificaciones.");
                Console.WriteLine(" 0. Salir.");
                var opc = Console.ReadLine();
                var salir = 0;
                do
                {
                    switch (opc)
                    {
                        case "1":

                            // Find the model that will modify.
                            var rowToModify = dbReciplastk.Products.Where(p => p.Name == name).FirstOrDefault();
                            rowToModify.Name = "Modified from code";

                            // save the changes to the database
                            dbReciplastk.SaveChanges();


                            break;
                        default:
                            break;
                    }
                }
                while (salir != 0);
            }
           
               


        }

        public void DeleteProduct()
        {

        }




    }
}
