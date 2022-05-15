using System.Text.Json;
using System.Globalization;
using System.Collections.Generic;

namespace Spotiflix
{
    internal class Tools
    {
        //Get's string input & makes sure it's not empty or null
        internal string GetStringInput()
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
        internal int GetIntInput()
        {
            int input;
            string? stringinput;
            do
            {
                //ValueTuple can store 2 inputs from GetCursorPosition
                ValueTuple<int, int> f = Console.GetCursorPosition();
                stringinput = Console.ReadLine();
                if (string.IsNullOrEmpty(stringinput) || !Int32.TryParse(stringinput, out input))
                {
                    //used to tell you it's the wrong input &
                    //delete that specific feedback after you have acknowledge it. 

                    ValueTuple<int, int> d = Console.GetCursorPosition();
                    Console.Write("Invalid Input");
                    Console.ReadKey();
                    //Delet "Invalid Input" message
                    Console.SetCursorPosition(d.Item1, d.Item2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    //The delete's the invalid input
                    Console.SetCursorPosition(f.Item1, f.Item2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    //Returns to the end of the question
                    Console.SetCursorPosition(f.Item1, f.Item2);


                }
            } while (!Int32.TryParse(stringinput, out input));
            return input;
        }
        internal DateTime GetDate()
        {
            string? input;
            DateTime date;

            do
            {
                //ValueTuple can store 2 inputs from GetCursorPosition
                ValueTuple<int, int> f = Console.GetCursorPosition();
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || !DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    //used to tell you it's the wrong input &
                    //delete that specific feedback after you have acknowledge it. 

                    ValueTuple<int, int> d = Console.GetCursorPosition();
                    Console.Write("Invalid Input");
                    Console.ReadKey();
                    Console.SetCursorPosition(d.Item1, d.Item2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(f.Item1, f.Item2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(f.Item1, f.Item2);
                }

            } while (string.IsNullOrEmpty(input) || !DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date));

            return date;
        }
        //**********Not In use. Didn't Work*********************

        //internal TimeSpan GetTime()
        //{
        //    string? input;
        //    TimeSpan time;

        //    do
        //    {
        //        //ValueTuple can store 2 inputs from GetCursorPosition
        //        ValueTuple<int, int> f = Console.GetCursorPosition();
        //        input = Console.ReadLine();
        //        if (string.IsNullOrEmpty(input) || !TimeSpan.TryParseExact(input, "ss", CultureInfo.InvariantCulture, TimeSpanStyles.None, out time))
        //        {
        //            //used to tell you it's the wrong input &
        //            //delete that specific feedback after you have acknowledge it. 

        //            ValueTuple<int, int> d = Console.GetCursorPosition();
        //            Console.Write("Invalid Input");
        //            Console.ReadKey();
        //            Console.SetCursorPosition(d.Item1, d.Item2);
        //            Console.Write(new string(' ', Console.WindowWidth));
        //            Console.SetCursorPosition(f.Item1, f.Item2);
        //            Console.Write(new string(' ', Console.WindowWidth));
        //            Console.SetCursorPosition(f.Item1, f.Item2);
        //        }

        //    } while (string.IsNullOrEmpty(input) || !TimeSpan.TryParseExact(input, "ss", CultureInfo.InvariantCulture, TimeSpanStyles.None, out time));

        //    return time;
        //}

        //Enter SearchWord
        internal string SearchWord()
        {
            SearchGraphics search = new();
            search.SearchWord();
            return GetStringInput();
        }
    }
}
