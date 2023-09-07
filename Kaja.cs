using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    // child dari Hero
    class Kaja : Hero
    {
        // override method speak dari Parent
        public override void speak()
        {
            Console.WriteLine("Aku adalah kekuatan dan wujud asli cahaya");
        }
    }
}
