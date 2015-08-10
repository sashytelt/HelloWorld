using System;

namespace SandrosHelloWorld.Animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void FindHuman(Human human)
        {
            Console.WriteLine("{1}: Im looking for {0}", human.Name, _name);
        }



        public override void Speak()
        {
            Console.Out.WriteLine("Woof");
        }
    }
}