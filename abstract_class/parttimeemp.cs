using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    class parttimeemp : Baseclass
    {
        public int hourly { get; set; }
        public int totalhour { get; set; }

        public override int getmonthlysalary()
        {
            return hourly * totalhour;
        }
    }
}
