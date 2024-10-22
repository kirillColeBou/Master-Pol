using System;
using System.Collections.Generic;
using System.Text;

namespace Master_Pol.Classes.Model
{
    public class Products
    {
        public Int64 id { get; set; }
        public Int64 typeProduct { get; set; }
        public string articleNumber { get; set; }
        public string name { get; set; }
        public double priceMin { get; set; }
    }
}
