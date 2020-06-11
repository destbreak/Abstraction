using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Player1 : CheckPlayer
    {
        public override void Notification()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\t\tDATA PEMAIN");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\tNama     : Kirigaya Kazuto");
            Console.WriteLine("\tNickname : Kirito");
            Console.WriteLine("\tGender   : Laki-laki");
            Console.WriteLine("\tLevel    : 54");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
