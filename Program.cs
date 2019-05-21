using System;
using Patterns.Prototype;
using Coding.Exercise;

namespace Patterns_prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[]{"John", "Smith"}, new Adress("London st.", 165));
            var jane = john.DeepCopy();
            jane.Adress.houseNumber = 321;
            jane.Names[0] = "Jane";
            System.Console.WriteLine(john);
            System.Console.WriteLine(jane);

            var line = new Line( new Point(2,3), new Point(6,7));
            System.Console.WriteLine(line);

            var line2 = line.DeepCopy();
            line2.Start.X = 0;
            System.Console.WriteLine(line2);
            
            
        }
    }
}