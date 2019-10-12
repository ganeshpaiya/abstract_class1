using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
  public abstract class  Baseclass
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }

        public string Fullname()
        {
            return this.fname + "" + lname;
        }

        public abstract int getmonthlysalary();

    }
}
