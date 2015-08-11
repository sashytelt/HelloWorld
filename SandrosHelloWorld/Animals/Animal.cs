using System;
using System.Collections;

namespace SandrosHelloWorld.Animals
{
    public abstract class Animal : IMovement, IEnumerator
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

        public void Move(Point location)
        {
            Console.WriteLine("{0}: Moving to {0}x{1}", location.X, location.Y);
        }

        public Point CurrentLocation
        {
            get
            {
                return null;;
            }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current { get; }
    }
}