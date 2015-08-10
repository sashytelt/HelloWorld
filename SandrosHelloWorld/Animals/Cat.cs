using System;

namespace SandrosHelloWorld.Animals
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public void BeLazy()
        {
            Console.WriteLine("{0}: Im lazy", _name);
        }

        public override void Speak()
        {
            Console.Out.WriteLine("Miau");
        }

        public override void Sleep()
        {
            Console.WriteLine("{0}: Fuck sleep", _name);
        }
    }
}