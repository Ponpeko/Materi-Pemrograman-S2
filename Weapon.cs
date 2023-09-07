using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    public class Weapon
    {
        // field dengan member class private tidak dapat di akses dari luar
        private string type;

        // properti untuk mengakses data dari member class
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        // display untuk tes
        public void display()
        {
            Console.WriteLine("Sword type: {0}", type);
        }
    }
}
