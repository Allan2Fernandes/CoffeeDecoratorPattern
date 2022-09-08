using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecoratorPattern
{

    class Whip : Decorator
    {
        private double WhipCost = 0.1;
        private string WhipDescription = "Whip";
        private BaseCondiment Base;
        public Whip(BaseCondiment Base)
        {
            this.Base = Base;
        }
        public override double Cost()
        {
            return WhipCost + Base.Cost();
        }

        public override string Description()
        {
            return WhipDescription + ", " + Base.Description();
        }
    }
}
