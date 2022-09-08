using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecoratorPattern
{
    class Milk : Decorator
    {
        private double MilkCost = 0.15;
        private string MilkDescription = "Milk";
        private BaseCondiment Base;

        public Milk(BaseCondiment Base)
        {
            this.Base = Base;
        }
        public override double Cost()
        {
            return MilkCost + Base.Cost();
        }

        public override string Description()
        {
            return MilkDescription + ", " + Base.Description();
        }
    }
}
