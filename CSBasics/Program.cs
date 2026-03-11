using System.Net.NetworkInformation;

namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double pi = 3.14;
            //Console.WriteLine(pi);
            //bool isLearningCS = true;
            //Console.WriteLine(isLearningCS);
            //string favouriteFilm = "The Martian";
            //Console.WriteLine("My favourite film is " + favouriteFilm);
            //favouriteFilm = "High School Musical";
            //Console.WriteLine("My favourite film is " + favouriteFilm);

            string firstName = "Jodie";

            printGreeting(firstName);

        }
        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }
}
