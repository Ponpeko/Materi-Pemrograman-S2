using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Program
        // Nama : Akhmad Rizki RAmadhani
        // Nim : 22.11.5094
    {
        static void Main(string[] args)
        {
            Dosen dosen1 = new Dosen(1, " ");

            dosen1.setDosen();
            dosen1.setMatakuliah();

            Console.WriteLine("\nNama: {0}", dosen1.Nama);
            Console.WriteLine("NIK : {0}", dosen1.Nik);
            Console.WriteLine("Matakuliah: {0}", dosen1.Matakuliah);

            Console.ReadKey();
        }
    }
}
