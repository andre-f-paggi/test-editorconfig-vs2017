using System;

namespace AppConsoles
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            var i = 0;

            if (1 == i)
                Console.WriteLine("Oh no!");

        }
    }

    internal class NamingConventionTest
    {
        private readonly string _field;

        private NamingConventionTest(string field, string property)
        {
            this._field = field;
            this.Property = property;
        }

        public string Property { get; }
    }
}