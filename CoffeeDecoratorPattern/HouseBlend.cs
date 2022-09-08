using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecoratorPattern
{
    class HouseBlend : BaseCondiment
    {
        private double HouseBlendCost = 1.2;
        private string HouseBlendDescription = "HouseBlend";
        public override double Cost()
        {
            return HouseBlendCost;
        }

        public override string Description()
        {
            return HouseBlendDescription;
        }
    }
}
