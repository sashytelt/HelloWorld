using System;

namespace SandrosHelloWorld.Animals
{
    public abstract class Animal 
    {
        protected readonly string _name;

        protected Animal(string name = "bevardis")
        {
            _name = name;
        }

        public virtual void Sleep()
        {
            Console.Out.WriteLine("{0}: Im sleeping", _name);
        }

        public abstract void Speak();
    }
}