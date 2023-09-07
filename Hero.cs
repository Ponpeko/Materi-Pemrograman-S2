using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    // class abstract
    abstract class Hero
    {
        // method abstract tidak bisa memiliki body
        public abstract void speak();

        // method biasa dengan body
        public void speakdefault()
        {
            Console.WriteLine("This hero is speaking");
        }
    }
}
