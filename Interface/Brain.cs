using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Brain : ICheckSenses
    {
        public void Notification()
        {
            Console.WriteLine("\tKesehatan Otak : Sangat Baik");
        }
    }
}
