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
            bool success =int.TryParse(input,out _number);
            return success;
        }
    }
}
