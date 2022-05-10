using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotiflix
{
    internal class Tools
    {
        //Get's string input & makes sure it's not empty or null
        internal string GetInput()
        {
            string? input;
            do
            {
                //ValueTuple can store 2 inputs from GetCursorPosition
                ValueTuple<int, int> f = Console.GetCursorPosition();
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    //used to tell you it's the wrong input &
                    //delete that specific feedback after you have acknowledge it. 
                    
                    ValueTuple<int, int> d = Console.GetCursorPosition();
                    Console.Write("Invalid Input");
                    Console.ReadKey();
                    Console.SetCursorPosition(d.Item1, d.Item2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(f.Item1, f.Item2);
                }
            } while (string.IsNullOrEmpty(input));
            return input;
        }
    }
}
