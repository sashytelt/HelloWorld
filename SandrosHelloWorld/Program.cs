using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using SandrosHelloWorld.Animals;

namespace SandrosHelloWorld
{
    class Program
    {


        static void Main(string[] args)
        {

            //Bottle cocacola = new Bottle("Coca-Cola", 2000);
            //Bottle vodka = new Bottle("Vodka",750);

            Human sandra = new Human("Sandra", 21);

            //sandra.Drink(vodka, 40);
            //sandra.Drink(cocacola, 500);

  
            Cat cat = new Cat("Micius");
            Dog dog = new Dog("Rokis");

            cat.BeLazy();
            dog.FindHuman(sandra);

            cat.Speak();
            dog.Speak();
            


            Animal dogAnimal = dog;
            Animal catAnimal = cat;


            dogAnimal.Sleep();
            catAnimal.Sleep();

        }
    }
}
