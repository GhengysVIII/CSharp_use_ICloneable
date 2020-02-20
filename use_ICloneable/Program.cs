using System;

namespace use_ICloneable {
    class Program {

        static void Main(string[] args) {

            Boat b1 = new Boat();
            Vehicle c1 = (b1.Clone() as Vehicle);

            b1.Marque = "Machin";
            c1.Marque = "truc";

            Console.WriteLine("type b1: {0}", b1.GetType());
            Console.WriteLine("type c1: {0}", c1.GetType());
            Console.WriteLine();
            Console.WriteLine(b1.Marque);
            Console.WriteLine(c1.Marque);

        }
    }
}
