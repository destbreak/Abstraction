using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Nose : ICheckSenses
    {
        public void Notification()
        {
            Console.WriteLine("\tPernafasan     : OK");
        }
    }
}
