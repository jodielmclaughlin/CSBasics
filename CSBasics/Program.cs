using System.Net.NetworkInformation;

namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(isStringLonger("Hi there",8));
            Console.WriteLine(isStringLonger("Hello", 17));
            Console.WriteLine(isStringLonger("My name is Jodie", 6));
            Console.WriteLine(isStringLonger("Whats for lunch?", 22));
            Console.WriteLine(isStringLonger("Nice, love that", 2));


            int additionResult = Sum(10, 5);

            Console.WriteLine(additionResult);
        }
        private static bool isStringLonger(string word, int number)
        {
            
            return word.Length > number;
         
        }

        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
