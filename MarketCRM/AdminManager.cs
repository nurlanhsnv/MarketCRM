using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM
{
    public class AdminManager : BaseProductManager
    {

        public override void Sell(string proName, int numOfProduct)
        {
            throw new NotImplementedException("Admin can't use this");
        }

        public override void ReAddSoldProducts(string soldProductName, int numOfProducts)
        {
            throw new NotImplementedException("Admin can't use this");
        }


    }
}
