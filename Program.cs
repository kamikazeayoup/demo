using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using Baseline.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {

        static void Main(string[] args)
        {
            string s = "Race A Car";

            string newstr = Regex.Replace(s , "[^a-zA-Z0-9]" , "").ToLower();
            Console.WriteLine(newstr);
            char[] newch = newstr.ToLower().ToCharArray() ;
            Array.Reverse(newch);
            string cmp = new string(newch);

            Console.WriteLine(newstr);
            Console.WriteLine(cmp);
            

        }
        public static bool IsPow(int n)
        {
            for (int i = 0; i < 31; i++)
            {
                Int64 number = Convert.ToInt64(Math.Pow(2, i));
                if (number == n)
                    return true;
            }
            return false;
        }
    }
}
