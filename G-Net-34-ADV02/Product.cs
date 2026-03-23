using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV02
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public override string ToString()
        {
            return $"{Name} -${Price} (Stock:{Stock})";
        }
    }
}
