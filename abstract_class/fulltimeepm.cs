﻿using abstract_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public class fulltimeepm : Baseclass
    {
        public int annualsalary { get; set; }

        public override int getmonthlysalary()
        {
            return annualsalary / 12;
        }
    }
}
