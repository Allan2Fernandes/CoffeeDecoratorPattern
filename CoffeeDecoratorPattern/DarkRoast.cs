using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecoratorPattern
{
    class DarkRoast : BaseCondiment
    {
        private double DarkRoastCost = 1.1;
        private string DarkRoastDescription = "Dark roast";
        public override double Cost()
        {
            return DarkRoastCost;
        }

        public override string Description()
        {
            return DarkRoastDescription;
        }
    }
}
