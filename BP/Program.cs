using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    class Program
    {
         static void Main(string[] args)
        {
            //try to...
            CheckPrimeNumber();
            int[] a = { 55, 4, 99, 2, 5, 1, 9 };
            int[] b = GetShortingArrayASC(a);
            Console.WriteLine("ORDER BY ASC");
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            b = GetShortingArrayDESC(a);
            Console.WriteLine("ORDER BY DESC");
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total is: " + AddingFromArray(a));

            Console.WriteLine("Which one you want to convert? if celcious then press C else F");
            string ch = Console.ReadLine();
            double tem;
            if (ch == "C")
            {
                Console.WriteLine("Enter farenhite tempe...");
                tem = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter celcious tempe...");
                tem = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Converted temp: " + ConvertTempereture(tem, ch));
            Console.WriteLine("Enter a mark for converting between 20 to 100");
            string s = CalculateGrade(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("Converted Grade: " + s);

            Console.WriteLine("Emter 3 arms");
            double ba = Convert.ToDouble(Console.ReadLine());
            double bb = Convert.ToDouble(Console.ReadLine());
            double bc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of Tringle: " + AreaOfTriangle(ba, bb, bc));

            Console.WriteLine("Enter a Year");
            Console.WriteLine(IsLeapYear(Convert.ToDouble(Console.ReadLine())));

            Console.ReadKey();
        }

        public static int[] GetShortingArrayASC(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public static int[] GetShortingArrayDESC(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public static float AddingFromArray(int[] array)
        {
            float total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return total;
        }
        public static double ConvertTempereture(double tem, string ch)
        {
            if (ch == "C")
            {
                return (tem - 32) * 5 / 9;
            }
            else
            {
                return (1.8 * tem) + 32;
            }
        }

        public static string CalculateGrade(int subjectWiseNumber)
        {
            string g = string.Empty;
            int c = subjectWiseNumber / 10;
            switch (c)
            {
                case 8:
                case 9:
                case 10:
                    g = "A+";
                    break;
                case 7:
                    g = "A";
                    break;
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                    g = "F";
                    break;
            }
            return g;
        }

        public static double AreaOfTriangle(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(Convert.ToDouble(s * (s - a) * (s - b) * (s - c)));
        }
        public static string IsLeapYear(double y)
        {
            if ((y % 400 == 0 || y % 100 != 0) && (y % 4 == 0))
            {
                return y + " is a Leap year";
            }
            else
            {
                return y + " is not a Leap year";
            }
        }

        public static void CheckPrimeNumber()
        {
            int n, i, c = 0;
            Console.WriteLine("Enter any number n:");
            n=Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                }
            }

            if (c == 2)
            {
                Console.WriteLine("n is a Prime number");
            }
            else
            {
                Console.WriteLine("n is not a Prime number");
            }
        }
    }
}
