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
            Hero myhero = new Hero(); // object hero
            Hero myKaja = new Kaja(); // object kaja
            Hero myYin = new Yin();   // object yin

            myhero.speak();
            myKaja.speak();
            myYin.speak();
        }
    }
}
