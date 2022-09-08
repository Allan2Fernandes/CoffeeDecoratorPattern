using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecoratorPattern
{
    class Decaf : BaseCondiment
    {
        private double DecafCost = 1.4;
        private string DecafDescription = "Decaf";
        public override double Cost()
        {
            return DecafCost;
        }

        public override string Description()
        {
            return DecafDescription;
        }
    }
}
