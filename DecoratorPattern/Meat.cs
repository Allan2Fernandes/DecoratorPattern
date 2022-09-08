using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Meat : Decorator
    {
        private BaseBread b;
        private double meatCost = 3;
        private string meatDescription = "Meat";

        public Meat(BaseBread b)
        {
            this.b = b;
        }

        public override double Cost()
        {
            return meatCost + b.Cost();
        }

        public override string Description()
        {
            return meatDescription + " and " + b.Description();
        }

    }
}
