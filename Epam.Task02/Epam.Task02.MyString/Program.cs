using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.MyString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text1 = " sample1 ";
            string text2 = "sample";
            MyString p = new MyString(text1);
            MyString r = new MyString(text2);

            char[] s = MyString.MyConcat(p, r);
            Console.WriteLine(s);

            int i = 2;
            i = MyString.CompareMyString(p, r);
            Console.WriteLine(i);
            Console.WriteLine(p.MyLength());
            Console.WriteLine(MyString.MyToString(p));

            i = MyString.FindMyString(p, r);
            Console.WriteLine(i);
        }
    }
}
