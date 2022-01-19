using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eu
{
    class Unioallamai
    {
        public Unioallamai(string sor)
        {
            string[] sorelemek = sor.Split(';');
            this.Orszag = sorelemek[0];
            this.Datum = Convert.ToDateTime(sorelemek[1]);

        }

        public string Orszag { get; set; }
        public DateTime Datum { get; set; }
    }
}
    
