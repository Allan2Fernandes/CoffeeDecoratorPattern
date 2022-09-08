using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecoratorPattern
{
    public abstract class BaseCondiment
    {
        public abstract double Cost();
        public abstract string Description();
    }
}
