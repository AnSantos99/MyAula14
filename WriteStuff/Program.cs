using System;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string>text = new Stack<string>();
            string input;

            do
            {
                input = Console.ReadLine();
                text.Push(input);
                

            }
            while (input != "");
            text.Pop();
            File.WriteAllLines("Ana.txt", text);









        }
    }
}
