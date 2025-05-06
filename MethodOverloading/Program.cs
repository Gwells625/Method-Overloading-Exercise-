using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            var sum = numOne + numTwo;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)

        {
            
            Console.WriteLine(Add(2,3,true));
            Add(5, 6);
            Add(4.5m, 6.5m);
            Add(6, 8, true);



        }
    }
}
