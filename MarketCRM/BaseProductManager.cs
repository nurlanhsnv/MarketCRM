using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM
{
    public abstract class BaseProductManager : IProductServise 
    {
       public static  List<Product> productsList= new List<Product>();
       public static  List<Product> soldProducts = new List<Product>();
       public static  List<Category> categoryList = new List<Category>();
        public virtual void Add(Product product)
        {
            productsList.Add(product);
             
        }

        public virtual void AddCategory(Category category)
        {
            categoryList.Add(category);
        }
        public virtual void Delete(string proName, int numOfProduct)
        { 
          
                foreach (Product product in productsList)
                {
                if (product.ProductName == proName)
                {
                    if (product.ProductCount == numOfProduct) { productsList.Remove(product); Console.WriteLine("Mehsul silindi"); }
                    else if (product.ProductCount < numOfProduct)
                    {
                        Console.WriteLine("Bu qeder mehsul yoxdur");
                    }
                    else { product.ProductCount -= numOfProduct; }
                }
                 
            }

            
        }
        public virtual void Sell(string proName, int numOfProduct)
        {
             foreach(Product product in productsList) 
             {
                    if (product.ProductName == proName)
                    {
                    if (product.ProductCount == numOfProduct) { 
                        productsList.Remove(product); soldProducts.Add(product);
                        Console.WriteLine("Mehsul hamisi satildi");
                    }
                    else if(product.ProductCount < numOfProduct)
                    {
                        Console.WriteLine("Bu qeder mehsul yoxdur");
                    }
                    else { product.ProductCount -= numOfProduct; }
                    }
                

            }
        }

        public virtual void Update(int proID, string newName, double newPrice, int newCategoryId, int newProCount)
        {
            foreach (Product product in productsList)
            {
                if (product.ProductID == proID) { 

                    product.ProductName = newName;
                product.Price = newPrice;
                product.CategoryIDProduct = newCategoryId;
                product.ProductCount = newProCount;
            }
            }
        }
        public virtual void GetAllProduct()
        {
           
         foreach(Product product1 in productsList)
            {
                foreach (Category category in categoryList) {
                    if(category.CategoryId== product1.CategoryIDProduct) {
                       Console.WriteLine($"Product ID: {product1.ProductID}, " +
                        $"  Product name: {product1.ProductName}" +
                        $"  Product's category id and its name: {product1.CategoryIDProduct} {category.CategoryName}" +
                        $"  Price: {product1.Price}" +
                        $" Product's Count: {product1.ProductCount}");}
                    
                }
            } 
        }

        public virtual void GetProductByCategory(string  categoryName)
        {
           
            foreach (Category categoryy in categoryList)
            { 
                    if(categoryy.CategoryName == categoryName) 
                    { 
                       foreach (Product product in productsList) 
                       {
                         if (categoryy.CategoryId == product.CategoryIDProduct)
                         {
                           Console.WriteLine($"Category name: {categoryy.CategoryName}" +
                            $"  Product name: {product.ProductName}" +
                            $"  Product Price: {product.Price}" +
                            $"  Product's Count: {product.ProductCount}");
                         } 
                       }
                    }
                    
               
            }
        }

        public virtual void GetProductById(int proID)
        {
            foreach(Product product in productsList)
            {
                if(product.ProductID == proID)
                {
                    Console.WriteLine($"  Product name: {product.ProductName}" +
                            $"  Product Price: {product.Price}" +
                            $"  Product's Count: {product.ProductCount}");
                }
            }
        }

        public virtual void ReAddSoldProducts(string soldProductName, int numOfProducts)
        {
            Product foundProduct = null;

            foreach (Product product in soldProducts)
            {
                if (product.ProductName == soldProductName)
                {
                    foundProduct = product;
                    break;
                }
            }

            if (foundProduct != null)
            {
                foundProduct.ProductCount += numOfProducts;
                productsList.Add(foundProduct);
                soldProducts.Remove(foundProduct);
            }
        }

     
    }
}
