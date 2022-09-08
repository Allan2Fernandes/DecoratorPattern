using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class BurgerBun : BaseBread
    {
        
        private double bunCost = 1.5;
        private string description = "Burger bun";

   
        public override double Cost()
        {
            return bunCost;
        }

        public override string Description()
        {
           return description;
        }
    }
}
