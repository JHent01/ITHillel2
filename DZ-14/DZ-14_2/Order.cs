using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_2
{
    internal class Order
    {
         
        public int order; 
       public string costomerName;
       public int totalAmount;
        public Order(int order,string name) 
        {
            this.order = order;
            this.costomerName = name;
            this.totalAmount ++;
            
        }
    }
}
