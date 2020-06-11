using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Eyes : CheckSenses
    {
        public override void Notification()
        {
            Console.WriteLine("\tPenglihatan    : OK");
        }
    }
}
