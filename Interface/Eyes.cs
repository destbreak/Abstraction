using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Eyes : ICheckSenses
    {
        public void Notification()
        {
            Console.WriteLine("\tPenglihatan    : OK");
        }
    }
}
