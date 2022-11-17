using Highest_and_Lowest;
namespace Kata
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(HighsetAndLowest.HighAndLow("1 2 3 4 5"));
            Console.WriteLine(HighsetAndLowest.HighAndLow("1 2 -3 4 5"));
            Console.WriteLine(HighsetAndLowest.HighAndLow("1 9 3 4 -5"));
        }
    }
}