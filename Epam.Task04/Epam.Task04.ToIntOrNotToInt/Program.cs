using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04.ToIntOrNotToInt
{
    public static class Program
    {
        public const char Comma = ',';
        public const char Exp = 'E';
        public const char Explow = 'e';
        public const char Plus = '+';
        public const char Minus = '-';
        public const char Zero = '0';

        public static bool IsPositiveInt(this string param)
        {
            string temp;
            int e_index = -1;

            temp = param.Trim();

            if (!char.IsDigit(temp[0]))
            {
                if (!(temp[0] == Plus))
                {
                    return false;
                }
            }

            if (!(temp.IndexOf(Plus, 1) == temp.LastIndexOf(Plus)))
            {
                if (!(temp[0] == Plus))
                {
                    return false;
                }
            }

            if (!(temp.IndexOf(Minus) == temp.LastIndexOf(Minus)))
            {
                return false;
            }

            if (!(temp.IndexOf(Comma) == temp.LastIndexOf(Comma)))
            {
                return false;
            }

            if (!(temp.IndexOf(Exp) == temp.LastIndexOf(Exp)))
            {
                return false;
            }

            if (!(temp.IndexOf(Explow) == temp.LastIndexOf(Explow)))
            {
                return false;
            }

            if (!(temp.IndexOf(Exp) == -1) && !(temp.IndexOf(Explow) == -1))
            {
                return false;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (!(char.IsDigit(temp[i]) || temp[i] == Comma || temp[i] == Exp || temp[i] == Explow || temp[i] == Plus || temp[i] == Minus))
                {
                    return false;
                }
            }

            if (temp[0] == Plus)
            {
                temp = temp.Remove(0, 1);
            }

            if (temp.IndexOf(Exp) == -1)
            {
                e_index = temp.IndexOf(Explow);
            }
            else
            {
                e_index = temp.IndexOf(Exp);
            }

            if (e_index == temp.Length - 1)
            {
                return false;
            }

            if (!(temp.IndexOf(Comma) == -1) && !(e_index == -1))
            {
                if (temp.IndexOf(Comma) >= e_index - 1)
                {
                    return false;
                }
            }

            if (temp.IndexOf(Comma) == temp.Length - 1)
            {
                return false;
            }

            if (!(temp.IndexOf(Minus, 1) == -1))
            {
                if (!(temp.IndexOf(Minus, 1) == e_index + 1))
                {
                    return false;
                }
            }

            if (temp[0] == Zero)
            {
                return false;
            }

            if (!(temp.IndexOf(Minus) == -1) && !(temp.IndexOf(Plus) == -1))
            {
                return false;
            }

            if (e_index == -1 && !(temp.IndexOf(Plus) == -1))
            {
                return false;
            }

            if (e_index == -1 && !(temp.IndexOf(Minus) == -1))
            {
                return false;
            }

            if (!(e_index == -1))
            {
                if (!(temp.IndexOf(Comma) == -1))
                {
                    if (temp.IndexOf(Comma) >= e_index - 1)
                    {
                        return false;
                    }
                }
            }

            if (!char.IsDigit(temp[0]))
            {
                return false;
            }
            else
            {
                if (temp.IndexOf(Comma) == -1)
                {
                    if (e_index == -1)
                    {
                        return true;
                    }
                    else
                    {
                        if (!(temp.IndexOf(Minus) == -1))
                        {
                            int pow_digit = 0;
                            int pow = 0;
                            int zero_count = 0;

                            for (int i = temp.IndexOf(Minus) + 1; i < temp.Length; i++)
                            {
                                pow_digit = temp[i] - Zero;
                                pow += pow_digit * (int)Math.Pow(10, temp.Length - i - 1);
                            }

                            int j = e_index - 1;

                            while (j >= 1)
                            {
                                if (!(temp[j] == Zero))
                                {
                                    break;
                                }

                                zero_count++;
                                j--;
                            }

                            if (pow > zero_count)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    int zero_count = 0;

                    if (e_index == -1)
                    {
                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i] == Zero)
                            {
                                zero_count++;
                            }
                        }

                        if (zero_count == temp.Length - temp.IndexOf(Comma) - 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!(temp.IndexOf(Minus) == -1))
                        {
                            int pow_digit = 0;
                            int pow = 0;

                            for (int i = e_index - 1; i > temp.IndexOf(Comma); i--)
                            {
                                if (temp[i] == Zero)
                                {
                                    zero_count++;
                                }
                            }

                            for (int j = temp.IndexOf(Minus) + 1; j < temp.Length; j++)
                            {
                                pow_digit = temp[j] - Zero;
                                pow += pow_digit * (int)Math.Pow(10, temp.Length - j - 1);
                            }

                            if (!(zero_count == e_index - temp.IndexOf(Comma) + 1))
                            {
                                return false;
                            }
                            else
                            {
                                for (int i = temp.IndexOf(Comma) - 1; i > 1; i--)
                                {
                                    if (temp[i] == Zero)
                                    {
                                        zero_count++;
                                    }
                                }

                                if (pow > zero_count)
                                {
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            int pow_digit = 0;
                            int pow = 0;

                            for (int i = e_index - 1; i > temp.IndexOf(Comma); i--)
                            {
                                if (temp[i] == Zero)
                                {
                                    zero_count++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            int numbers_after_comma = 0;

                            for (int i = e_index - 1 - zero_count; i > temp.IndexOf(Comma); i--)
                            {
                                numbers_after_comma++;
                            }

                            int upper_pow = e_index + 1;

                            if (!(temp.IndexOf(Plus) == -1))
                            {
                                upper_pow = temp.IndexOf(Plus) + 1;
                            }

                            for (int j = upper_pow; j < temp.Length; j++)
                            {
                                pow_digit = temp[j] - Zero;
                                pow += pow_digit * (int)Math.Pow(10, temp.Length - j - 1);
                            }

                            if (pow > numbers_after_comma)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] arr = new string[] { "+100000000000e-11", "1234", " 01", "2,2E1", "10e-1", "+1,0e-1", "1,0e", "1,e1" };

            foreach (var item in arr)
            {
                Console.WriteLine($"{item} {item.IsPositiveInt()}");
            }
        }
    }
}
