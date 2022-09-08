using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecoratorPattern
{
    class Sugar : Decorator
    {
        private double SugarCost = 0.2;
        private string SugarDescription = "Sugar";
        private BaseCondiment Base;

        public Sugar(BaseCondiment Base)
        {
            this.Base = Base;
        }
        public override double Cost()
        {
            return SugarCost + Base.Cost();
        }

        public override string Description()
        {
            return SugarDescription + ", " + Base.Description();
        }
    }
}
