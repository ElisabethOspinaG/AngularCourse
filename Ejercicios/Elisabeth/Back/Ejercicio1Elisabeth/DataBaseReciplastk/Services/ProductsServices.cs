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

            foreach (var product in AllProductsForName)
            {
                
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
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");

        }


        public void CreateNewProduct()
        {
            // Create the model that will contain all the information.
            var newProduct = new Product();
            Console.WriteLine("Digite en nombre del nuevo producto. ");
            newProduct.Name = Console.ReadLine();
            Console.WriteLine("Digite en nombre del nuevo producto. ");
            newProduct.Description = Console.ReadLine();

            // add to the table
            dbReciplastk.Products.Add(newProduct);
            // save the changes to the database
            dbReciplastk.SaveChanges(); // Every time you change the database, you should save the changes !!!

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
                            Console.WriteLine("Escriba el nuevo nombre del producto: ");
                            var newName = Console.ReadLine();
                            existNameProduct.Name = newName;

                            // save the changes to the database
                            dbReciplastk.SaveChanges();

                            Console.WriteLine();
                            Console.WriteLine($" Nuevo nombre:          {existNameProduct.Name}");
                            Console.WriteLine();
                            break;
                        case "2":

                            // Find the model that will modify.
                            Console.WriteLine("Escriba el nuevo nombre del producto: ");
                            var newDescription = Console.ReadLine();
                            existNameProduct.Description = newDescription;
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

        public void DeleteProduct(string name)
        {
            // Find the model that will delete.
            var existNameProduct = dbReciplastk.Products.Where(p => p.Name == name).FirstOrDefault();
            if (existNameProduct != null)
            {
                dbReciplastk.Products.Remove(existNameProduct);
                // save the changes to the database ??
                dbReciplastk.SaveChanges(); //
            }
            else
            {
                Console.WriteLine("Este producto no existe");
            }
           

           

        }




    }
}
