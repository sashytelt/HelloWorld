using System;

namespace SandrosHelloWorld
{
    public class Bottle
    {

        private int _liquidAmount;
        public readonly string DrinkName;

        public Bottle(string drinkName, int liquidAmount)
        {
            DrinkName = drinkName;
            _liquidAmount = liquidAmount;
        }

        public bool Drink(int amountToDrink)
        {
            if (_liquidAmount < amountToDrink)
            {
                Console.Out.WriteLine("Not enough liquid left");
                return false;
            }
            else
            {
                Console.Out.WriteLine("Drinking {0} amount of liquid: {1}", amountToDrink, DrinkName);

                _liquidAmount = _liquidAmount - amountToDrink;

                Console.Out.WriteLine("Amount of liquid left: " + _liquidAmount);

                return true;
            }
        }
    }
}