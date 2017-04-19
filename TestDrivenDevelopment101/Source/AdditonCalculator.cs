using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment101.Source
{
    public class AdditonCalculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int PerformAddition()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
