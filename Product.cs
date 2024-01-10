using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment4
{
    public class Product
    {
        public int PId { get; set; }
        public string? PName { get; set; }
        public double Pprice { get; set; }
        public string? PBrand { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime ExpDate { get; set; }

    }
}
