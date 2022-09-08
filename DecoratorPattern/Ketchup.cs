using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Ketchup : Decorator
    {
        private BaseBread b;
        private double ketchupCost = 0.5;
        private string description = "Ketchup";

        public Ketchup(BaseBread b)
        {
            this.b = b;
        }

        public override double Cost()
        {
            return ketchupCost + b.Cost();
        }

        public override string Description()
        {
            return b.Description() + " and " + description;
        }
    }
}
