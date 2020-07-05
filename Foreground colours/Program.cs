using System;

namespace Foreground_colours
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(Console.BackgroundColor==ConsoleColor.Black){
                Console.BackgroundColor=ConsoleColor.Red;
                Console.ForegroundColor=ConsoleColor.Black;
                Console.Clear();
            }
        }
    }
}
