using System;

namespace CoffeeDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCondiment MyCondiment = new Decaf();
            MyCondiment = new Milk(MyCondiment);
            MyCondiment = new Milk(MyCondiment); //Add extra milk
            MyCondiment = new Sugar(MyCondiment);
            MyCondiment = new Whip(MyCondiment);

            Console.WriteLine("Total Price is {0}£", Math.Ceiling(MyCondiment.Cost()));
            Console.WriteLine("List of Condiments is: {0}", MyCondiment.Description());
        }
    }
}
