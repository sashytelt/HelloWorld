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
            ////Bottle vodka = new Bottle("Vodka",750);

            //Human sandra = new Human("Sandra", 21);

            ////sandra.Drink(vodka, 40);
            ////sandra.Drink(cocacola, 500);


            Cat cat = new Cat("Micius");
            //Dog dog = new Dog("Rokis");

            List<IMovement> movableBeings = new List<IMovement>();
            movableBeings.Add(cat);

            Point point = new Point {Y = 1, X = 0};

            foreach (IMovement movableBeing in movableBeings)
            {
                movableBeing.Move( new Point { Y = new Random().Next() /* Assume that it is precalculated */ } );
            }
            

            //cat.BeLazy();
            //dog.FindHuman(sandra);

            //cat.Speak();
            //dog.Speak();



            //Animal dogAnimal = dog;
            //Animal catAnimal = cat;


            //dogAnimal.Sleep();
            //catAnimal.Sleep();


            //Bottle cocacola = new Bottle("Coca-Cola", 2000);
            //List<string> namesList = new List<string>();
            //namesList.Add("Sandra");

            Pointers p = new Pointers();


            //p.PointerVars(namesList, cocacola);

            //int i = 1;
            //float f = (float)12.0;
            //string s = "aa";

            //p.StaticVars(i, f, s);



            TightBox<Bottle> tašė = new TightBox<Bottle>();
            tašė.Add(new Bottle("cocacola", 123));


        }
    }
}
