using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Ears : CheckSenses
    {
        public override void Notification()
        {
            Console.WriteLine("\tPendengaran    : OK");
        }
    }
}
