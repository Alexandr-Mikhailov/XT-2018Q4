using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.MyString
{
    public class MyString
    {
        public MyString(string text)
        {
            this.Mystring = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                this.Mystring[i] = (char)text[i];
            }
        }

        public char[] Mystring { get; set; }

        public static char[] MyConcat(MyString text1, MyString text2)
        {
            int len = text1.MyLength() + text2.MyLength();
            char[] concat = new char[len];

            for (int i = 0; i < text1.MyLength(); i++)
            {
                concat[i] = text1.Mystring[i];
            }

            len = text1.MyLength();

            for (int i = 0; i < text2.MyLength(); i++)
            {
                concat[i + len] = text2.Mystring[i];
            }

            return concat;
        }

        public static int CompareMyString(MyString text1, MyString text2)
        {
            if (text1.MyLength() > text2.MyLength())
            {
                return 1;
            }
            else
            {
                if (text1.MyLength() < text2.MyLength())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static int FindMyString(MyString text1, MyString text2)
        {
            if (text1.MyLength() < text2.MyLength())
            {
                return -1;
            }

            int len = text1.MyLength() - text2.MyLength();
            int j = 0;

            for (int i = 0; i < text2.MyLength(); i++)
            {
                while (!(text2.Mystring[i] == text1.Mystring[i + j]) && (j < len))
                {
                    j++;
                }

                if (!(text2.Mystring[i] == text1.Mystring[i + j]))
                {
                    return -1;
                }
            }

            return j;
        }

        public static string MyToString(MyString text)
        {
            string result = string.Empty;

            for (int i = 0; i < text.MyLength(); i++)
            {
                result += text.Mystring[i];
            }

            return result;
        }

        public int MyLength()
        {
            return this.Mystring.Length;
        }
    }
}
