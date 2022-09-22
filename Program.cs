using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Bob da Glob");
            names.Add("Sledman Stan");
            names.Add("John Doraymi");
            names.Add("Inspecta D.");
            names.Add("Ghostbro Joe");

            names.ForEach(name => Console.Write(name + ", "));

            string somethingAmazing = "Woahwowaza";

            List<string> stuff = new List<string> { "abda", "karaba", "malasada", somethingAmazing };

            int x = 5;
            int y = 7;
            int result = Adder(x, y);

            Console.Write($"\nYour grade is {result}/100 \n Oh my... brilliant!");
        }

        static int Adder(int a, int b)
        {
            return a + b;
        }
    }
}
