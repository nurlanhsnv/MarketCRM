using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM
{
    public class HeadCashierManager :BaseProductManager
    {
        public override void Sell(string proName, int numOfProduct)
        {
            throw new NotImplementedException("HeadCashier can't use this ");
        }
    }
}
