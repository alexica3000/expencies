using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.ConsoleApp
{
    class Program
    {
        public delegate void customDelegate(int integer);

        static void Main(string[] args)
        {
            // <access _modifier> delegate return_type delegate_name(parameters);

            customDelegate cDelegate;

            cDelegate = Print;
            cDelegate(1);
            cDelegate(10);
            cDelegate(100);
            cDelegate.Invoke(1000);

            cDelegate += Print3D;
            cDelegate(2);

            Func<int, double> func = new Func<int, double>(CalculateSQR);
            func += CalculateSQR2;
            Console.WriteLine($"Print result from Func<int, double> {func(5)}");

            Func<int, string, string> delegateFuncMultyParams = new Func<int, string, string>(CalculateAndPrint);
            string result = delegateFuncMultyParams(10, "EUR");
            Console.WriteLine(result);

            Action<List<string>> act = new Action<List<string>>(actionEncodeList);

            List<string> actualList = new List<string> { "A", "B", "C" };

            act(actualList);

            Predicate<List<string>> predicateValidation = new Predicate<List<string>>(validateListIsNullOrEmpty);
            Console.WriteLine(predicateValidation(actualList));

            actualList = new List<string>();
            Console.WriteLine(predicateValidation(actualList));

            actualList = null;
            Console.WriteLine(predicateValidation(actualList));

            Console.ReadKey();
        }

        public static void Print(int integer)
        {
            Console.WriteLine($"Print integer from delegate {integer}");
        }

        public static void Print3D(int integer)
        {
            Console.WriteLine($"Print3D integer from another delegate {integer}");
        }

        public static double CalculateSQR(int integer)
        {
            return integer * integer;
        }

        public static double CalculateSQR2(int integer)
        {
            return integer / integer;
        }


        public static string CalculateAndPrint(int integer, string str)
        {
            Console.WriteLine($"CalculateAndPrint from FuncMultyParam {integer}-{str}");
            return $"{integer}-{str}";
        }

        public static void actionEncodeList(List<string> strings)
        {
            foreach(string s in strings)
            {
                Console.WriteLine($"#{s}#");
            }
        }

        public static bool validateListIsNullOrEmpty(List<string> strings)
        {
            return strings == null || strings.Count == 0;
        }
    }

}
