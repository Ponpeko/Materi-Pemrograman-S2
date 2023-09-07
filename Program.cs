using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat object baru
            Weapon sword = new Weapon();

            // mengubah data dari Type (property) dan akan masuk ke type (member class)
            sword.Type = "Nichirin";  // berhasil

            // menampilkan output
            sword.display();
        }
    }
}
