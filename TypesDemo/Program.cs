using System;

namespace TypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string exp = "";
            foreach (string arg in args)
            {
                try
                {
                    int i = Convert.ToInt32(arg);
                    sum += i;
                    if (exp == "")
                    {
                        exp += arg;
                    }
                    else
                    {
                        exp += " + " + arg;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("One or more argument is not in integer format");
                    return;
                }
            }
            if (exp == "")
            {
                Console.WriteLine("No arguments");
            }
            else
            {
                Console.WriteLine(exp + " = " + sum.ToString());
            }
        }
    }
}
