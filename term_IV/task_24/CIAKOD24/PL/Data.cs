using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIAKOD24
{
    internal class Data
    {
        public static void PrintToConsole(string s)
        {
            Console.WriteLine(s);
        }

        public static string ReadFromConsole()
        {
            string s = Console.ReadLine();
            return s;
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }

    internal class DataWindows
    {
        public static void PrintToForm(string s)
        {
            Console.WriteLine(s);
        }

        public static string ReadFromForm()
        {
            string s = Console.ReadLine();
            return s;
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
