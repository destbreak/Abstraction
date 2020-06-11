using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Touch : ICheckSenses
    {
        public void Notification()
        {
            Console.WriteLine("\tPeraba         : OK");
        }
    }
}
