using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Mouth : CheckSenses
    {
        public override void Notification()
        {
            Console.WriteLine("\tBerbicara      : OK");
        }
    }
}
