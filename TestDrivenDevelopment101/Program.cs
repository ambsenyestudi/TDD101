using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrivenDevelopment101.Source;

namespace TestDrivenDevelopment101
{
    class Program
    {
        //kids additon caculator
        static void Main(string[] args)
        {
            //New Requierment: Only positve numbers
            OutputManager outputManager = new OutputManager();
            InputReader inputReader = new InputReader();
            AdditonCalculator calculator = new AdditonCalculator();
            outputManager.Greet();
            outputManager.Ask();
            while (!inputReader.TryReadNumber())
            {
                outputManager.WarnInvalidInput();
            }
            calculator.FirstNumber = inputReader.Number;
            outputManager.Ask();
            while (!inputReader.TryReadNumber())
            {
                outputManager.WarnInvalidInput();
            };
            calculator.SecondNumber = inputReader.Number;
            outputManager.Answer(calculator);
            Console.WriteLine("Press any key to exit");
            var any = Console.Read();

            
        }
    }
}
