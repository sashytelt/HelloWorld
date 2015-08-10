using System;

namespace SandrosHelloWorld
{
    public class Human
    {
        public readonly string Name;
        private int _age;

        private int _liquidDrinked;


        public Human(string name, int age)
        {
            Name = name;
            _age = age;

            _liquidDrinked = 0;
        }

        public void Drink(Bottle bottleToDrinkFrom, int amount)
        {
            Console.Out.WriteLine("I'm {0}, and im about to drink {1}", Name, bottleToDrinkFrom.DrinkName);

            if (bottleToDrinkFrom.Drink(amount))
            {
                _liquidDrinked += amount;
            }
        }
    }
}