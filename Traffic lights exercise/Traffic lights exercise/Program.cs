using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_lights_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Traffic lights ... " + "\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red Light - STOP!" + "\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow Lights - GET READY!" + "\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green Lights - GO!" + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("And there they all go!");
            

        }
    }
}
