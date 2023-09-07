using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Dosen
        // Nama : Akhmad Rizki RAmadhani
        // Nim : 22.11.5094
    {
        public string Matakuliah { get; set; }
        public string Nama { get; set; }
        public int Nik { get; set; }

        public Dosen(int nik, string nama) 
        {
            Nama = nama;
            Nik = nik;           
        }

        public void setDosen()
        {
            Console.Write("Masukkan nama Dosen: ");
            string nama = Convert.ToString(Console.ReadLine());
            Nama = nama;

            Console.Write("Masukkan NIK Dosen: ");
            int nik = Convert.ToInt32(Console.ReadLine());
            Nik = nik;
        }

        public void setMatakuliah()
        {          
            Console.Write("Masukkan nama Matakuliah: ");
            string matakuliah = Convert.ToString(Console.ReadLine());
            Matakuliah = matakuliah;
        }
    }
}
