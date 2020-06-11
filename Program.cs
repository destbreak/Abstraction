using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using Abstraction.AbstractClass; // AbstractClass
using Abstraction.Interface; // Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // CheckSenses senses; // AbstractClass
            // CheckPlayer player; // AbstractClass
            ICheckSenses senses; // Interface
            ICheckPlayer player; // Interface

            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("     SELAMAT DATANG DI SWORD ART ONLINE");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            senses = new Brain();
            senses.Notification();
            senses = new Nose();
            senses.Notification();
            senses = new Eyes();
            senses.Notification();
            senses = new Ears();
            senses.Notification();
            senses = new Mouth();
            senses.Notification();
            senses = new Touch();
            senses.Notification();

            Console.WriteLine();

            player = new Player1();
            player.Notification();

            Console.ReadKey();
        }
    }
}
