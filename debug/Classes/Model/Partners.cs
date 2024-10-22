using System;
using System.Collections.Generic;
using System.Text;

namespace Master_Pol.Classes.Model
{
    public class Partners
    {
        public Int64 id { get; set; }
        public Int64 typePartner { get; set; }
        public string nameCompany { get; set; }
        public string address { get; set; }
        public Int64 inn { get; set; }
        public string fioDirector { get; set; }
        public Int64 telephone { get; set; }
        public string email { get; set; }
        public int rating { get; set; }
    }
}
