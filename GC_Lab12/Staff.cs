using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab12
{
    class Staff : Person
    {
        public string School { set; get; }
        public double Pay { set; get; }

        public Staff(string name, string address, string school, double pay) : base (name, address)
        {
            Pay = pay;
            School = school;
        }

        public override string ToString()
        {
            base.ToString();
            //Console.WriteLine($"Pay: {Pay}");
            //Console.WriteLine($"School: {School}");
            return "STAFF MEMBER ERROR";
        }

        


    }


}
