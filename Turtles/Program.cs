using System;

namespace Turtles
{
    public static class Program
    {
        public static void Main()
        {
            int counter = 1;
            while (counter <= 1000)
                Console.WriteLine($"I like turtles");
            counter++;
            // TODO: Prints "I like turtles." 1000 times.

            Console.ReadLine();
        }
    }
}
