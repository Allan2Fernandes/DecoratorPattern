using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class BottomBread : Decorator
    {
        BaseBread b;
        public double bottomBreadCost = 0.5;
        public string bottomBreadDescription = "Bottom bread";
        public BottomBread(BaseBread b)
        {
            this.b = b;
        }

        public override double Cost()
        {
            return b.Cost() + bottomBreadCost;
        }

        public override string Description()
        {
            return bottomBreadDescription + " and " + b.Description();
        }
    }
}
