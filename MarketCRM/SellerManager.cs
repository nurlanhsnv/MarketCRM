using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM
{
    public class SellerManager : BaseProductManager
    {
       public override void Add(Product product)
        {
            throw new NotImplementedException("Seller can't use this");
        }

        public override void Delete(string proName, int numOfProduct)
        {
            throw new NotImplementedException("Seller can't use this");
        }

        public override void Update(int proID, string newName, double newPrice, int newCategoryId, int newProCount)
        {
            throw new NotImplementedException("Seller can't use this");
        }

        public override void GetAllProduct()
        {
            throw new NotImplementedException("Seller can't use this");
        }

        public override void GetProductById(int proID)
        {
            throw new NotImplementedException("Seller  can't use this");
        }

        public override void GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException("Seller can't use this");
        }

        public override void ReAddSoldProducts(string soldProductName, int numOfProducts)
        {
            throw new NotImplementedException("Seller can't use this");
        } 
    }
}
