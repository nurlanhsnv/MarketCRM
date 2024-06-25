using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM
{
    internal interface IProductServise
    {
        void Add(Product product);
        void AddCategory(Category category);
        void Delete(string proName, int numOfProduct);
        void Update(int proİD, string newName, double newPrice, int newCategoryId, int newProCount);
        void Sell(string proName, int numOfProduct);
        void GetAllProduct();
        void GetProductById(int proID);
        void GetProductByCategory(string categoryName);
        void ReAddSoldProducts(string soldProductName, int numOfProducts);
    }
}
