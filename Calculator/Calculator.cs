using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int FirstNumber { private get; set; }
        public int SecondNumber { private get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
