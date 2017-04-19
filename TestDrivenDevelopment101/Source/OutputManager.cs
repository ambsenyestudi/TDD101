using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment101.Source
{
    public class OutputManager
    {
        private string _greeting = "Hello this is an additons calcualtor";
        private string _question = "Please insert number and press enter";
        private string _errorMessage = "This is not valid input please insert a number and press enter";
        public void Greet()
        {
            Console.WriteLine(_greeting);
        }
        public void Ask()
        {
            Console.WriteLine(_question);
        }
        public void WarnInvalidInput()
        {
            Console.WriteLine(_errorMessage);
        }
        public void Answer(AdditonCalculator calculator)
        {
            string answer = string.Format(
                "The resulting number of the adding {0} and {1} is {2}", 
                calculator.FirstNumber, calculator.SecondNumber, calculator.PerformAddition());
            Console.WriteLine(answer);
        }
        
            
    }
}
