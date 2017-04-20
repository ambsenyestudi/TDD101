using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment101.Source
{
    public static class NumberRepository
    {
        private static List<string> _units = new List<string>
        {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six",
            "Seven", "Eight", "Nine" 
        };
        public static List<string> Units { get { return _units; } }

        private static List<string> _tenUnits = new List<string>
        {
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Sixteen",
            "Seventeen", "Eighteen", "Nineteen"
        };
        public static List<string> TenUnits { get { return _tenUnits; } }

        private static List<string> _tens = new List<string>
        {
            "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy",
            "Eighty", "Ninety"
        };
        public static List<string> Tens { get { return _tens; } }


    }
}
