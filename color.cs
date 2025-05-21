using System;

namespace ConsoleApp5
{
    internal class Color
    {
        static public void WriteColored(string text, ConsoleColor color, object line)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static public void WriteColored(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
