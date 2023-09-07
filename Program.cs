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
           Kaja kaja = new Kaja();
            kaja.speak();         // akan ter-override 
            kaja.speakdefault();  // tidak ter-override
        }
    }
}
