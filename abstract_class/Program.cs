using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            fulltimeepm fte = new fulltimeepm()
            {
                id = 100,
                fname="ganesh",
                lname="paiya",
                annualsalary=1000
            };
            parttimeemp pte = new parttimeemp()

            {
                id = 100,
                fname = "maha",
                lname = "paiya",
                hourly = 1000,
                totalhour = 12,

            };
            Console.WriteLine(fte.id);
            Console.WriteLine(fte.Fullname());
            Console.WriteLine(fte.getmonthlysalary());
            Console.WriteLine(
                "---------------------------------");
            Console.WriteLine(pte.id);
            Console.WriteLine(pte.Fullname());
            Console.WriteLine(pte.getmonthlysalary());
            Console.WriteLine(
                "---------------------------------");
            Console.ReadLine();

        }
    }
}
