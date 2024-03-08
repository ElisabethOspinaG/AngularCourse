﻿using Microsoft.EntityFrameworkCore;
using WebAppDbRecipastk.DataAccess;
using WebAppDbRecipastk.NewFolder4;

namespace WebAppDbRecipastk.services
{
    public class ProductsServices
    {

        public ReciplastkContext dbReciplastk = new ReciplastkContext();

        public List<Product> ShowAllListProducts()
        {
            var allProductsList = dbReciplastk.Products.ToList();
            return allProductsList;
           
        }
        public List<Product> ShowProductForName(string name)
        {
            var listProduct = dbReciplastk.Products.Where(p => p.Name == name).ToList(); ;
            if (listProduct != null)
            {

                return listProduct;
            }
            else
            {
                return null;
            }
        }

        public Product ShowProductsFirstName(string name)
        {
            var listProduct = dbReciplastk.Products.Where(p => p.Name == name).FirstOrDefault();
            if (listProduct != null)
            {
                return listProduct;
            }
            else
            {
                return null;
            }
        }
        public bool VerifyProduct(string name)
        {
            var existProduct = dbReciplastk.Products.Where(p => p.Name == name).FirstOrDefault();
            if (existProduct != null)
            {
                return true;
            }
            else
            {
                
                return false;

            }
        }

        public bool CreateNewProduct(ModelsProducts infoProduct)
        {
            var existProduct = dbReciplastk.Products.Where(p => p.Name == infoProduct.Name).FirstOrDefault();
            if(existProduct != null)
            {
                Console.WriteLine("El producto ya existe. ");
                return true;
            }
            else
            {
                var newProduct = new Product();

                newProduct.Name = infoProduct.Name;
                newProduct.Description = infoProduct.Description;
                newProduct.Code = infoProduct.Code;
                newProduct.Buyprice = infoProduct.BuyPrice;
                newProduct.Sellprice = infoProduct.SellPrice;

                dbReciplastk.Products.Add(newProduct);
                dbReciplastk.SaveChanges();
                return false;

            }
            
        }
        public bool CreateNewProduct2(string name, string description, string code, int buyPrice, int sellPrice )
        {
            var product = dbReciplastk.Products.Where(p => p.Name == name).FirstOrDefault();
            if (product == null)
            {
                var newProduct = new Product();
                newProduct.Name = name;
                newProduct.Description = description;
                newProduct.Code = code;
                newProduct.Buyprice = buyPrice;
                newProduct.Sellprice = sellPrice;
                dbReciplastk.Products.Add(newProduct);
                dbReciplastk.SaveChanges();

                return true;
            }
            else
            {
                
                return false;
            }
        }

        public Product ModifyAllProduct(string name, string description, string code, int buyPrice, int sellPrice, int margin)
        {
            var product = dbReciplastk.Products.Where(p => p.Name == name).FirstOrDefault();
            if (product != null)
            {
                product.Name = name;
                product.Description = description;
                product.Code = code;
                product.Buyprice = buyPrice;
                product.Sellprice = sellPrice;
                product.Margin = margin;
                dbReciplastk.SaveChanges();

                var productModify = dbReciplastk.Products.Where(p=>p.Name == product.Name).FirstOrDefault();    
                return productModify;
            }
            else
            {
                return null;
            }
        }

        public Product ModifyAllProduct2(ModelsProducts infoProducts)
        {
            var product = dbReciplastk.Products.Where(p => p.Name == infoProducts.Name).FirstOrDefault();
            if (product != null)
            {
                product.Name = infoProducts.Name;
                product.Description = infoProducts.Description;
                product.Code = infoProducts.Code;
                product.Buyprice = infoProducts.BuyPrice;
                product.Sellprice = infoProducts.SellPrice;
                product.Margin = infoProducts.Margin;
                dbReciplastk.SaveChanges();

                var productModify = dbReciplastk.Products.Where(p => p.Name == product.Name).FirstOrDefault();
                return productModify;
            }
            else
            {
                return null;
            }
        }

        public bool RemoveProduct(string name)
        {
            var productFound = dbReciplastk.Products.Where(p => p.Name == name).FirstOrDefault();   
            if (productFound != null)
            {
                dbReciplastk.Products.Remove(productFound);
                dbReciplastk.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
