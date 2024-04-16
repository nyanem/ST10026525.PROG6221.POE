using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10026525.POE.PART1
{
    internal class ingredientClass
    {
       
            //Declaring Variebles
            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }

        public ingredientClass(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }     
    }
}
