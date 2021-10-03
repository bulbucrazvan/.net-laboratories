using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager("Hello", "There", new DateTime(1, 1, 1), new DateTime(2000, 1, 10));
            Console.WriteLine(manager.Salutation());
            Console.WriteLine(manager.IsActive());
            Employee architect = new Architect("Hello", "World", new DateTime(1, 1, 1), new DateTime(2021, 12, 30));
            Console.WriteLine(architect.Salutation());
            Console.WriteLine(architect.IsActive());
            foreach (string word in "This is a sentence.".GetWords())
            {
                Console.WriteLine(word);
            }
        }
    }
}
