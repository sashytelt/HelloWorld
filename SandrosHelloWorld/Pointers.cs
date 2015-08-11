using System.Collections.Generic;

namespace SandrosHelloWorld
{
    public class Pointers
    {
        public void StaticVars(int i, float f, string s)
        {
            i = 10;
            f = (float) 20.0;
            s = "buu";
        }

        public void PointerVars(ref List<string> strings, Bottle bottle)
        {
            strings = new List<string>();
            strings.Add("Paksa");
            strings.Add("Rolandas");

            bottle.Drink(100);
        }
    }
}