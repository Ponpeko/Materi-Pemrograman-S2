using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat object sword baru
            Sword sword = new Sword();

            // memanggil method slash
            sword.slash();

            // display field dari kedua class
            Console.WriteLine("\nSword type: " + sword.type);
            Console.WriteLine("Sword model: " + sword.model);
        }
    }
}
