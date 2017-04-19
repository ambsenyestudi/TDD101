using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment101
{
    class Program
    {
        //kids additon caculator
        static void Main(string[] args)
        {
            string greeting = "Hello this is an aditons calcualtor";
            string question = "Please insert number and press enter";
            Console.WriteLine(greeting);
            Console.WriteLine(question);
            var first = Console.ReadLine();
            Console.WriteLine(question);
            var second = Console.ReadLine();
            int result = int.Parse(first) + int.Parse(second);
            string answer = string.Format("The resulting number of the adding {0} and {1} is {2}", first, second, result);
            Console.WriteLine(answer);
            Console.WriteLine("Press any key to exit");
            var any = Console.Read();
        }
    }
}
