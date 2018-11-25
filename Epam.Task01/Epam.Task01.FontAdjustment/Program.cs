using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.FontAdjustment
{
    class Program
    {
        [Flags]
        enum FontState : byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
        }
        static void Main(string[] args)
        {
            FontState fontType = 0;
            string input;
            int font;
            
            do
            {
                Console.WriteLine("Font parameters: {0}",fontType.ToString());
                Console.WriteLine("Input:\n"+
                                  "     1: bold\n" +
                                  "     2: italic\n" +
                                  "     3: underline");
                //Console.WriteLine("     exit: for exit");
                input = Console.ReadLine();
                
                if ((int.TryParse(input, out font)) && (font > 0) && (font < 4))
                {
                    switch (font)
                    {
                        case 1: fontType ^= FontState.Bold; break;
                        case 2: fontType ^= FontState.Italic; break;
                        case 3: fontType ^= FontState.Underline; break;
                    }
                }
                else
                {
                    if (input.Equals("exit"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input");
                    }
                }
            } while (!(input.Equals("exit")));
        }
    }
}
