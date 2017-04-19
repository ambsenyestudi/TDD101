using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment101.Source
{
    public class InputReader
    {
        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
        }
        public bool TryReadNumber()
        {
            string input = Console.ReadLine();
            bool success = ValidateNumber(input);
            return success;
        }
        //Testable unit
        public bool ValidateNumber(string sNumber)
        {
            bool success = int.TryParse(sNumber, out _number);
            //should be possitive
            success = success && (Number >= 0);
            return success;
        }
    }
}
