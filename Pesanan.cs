using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Pesanan
    {
        public string NamaPemesan { get; set; }
        public string NIK { get; set; }
        public string NomorTelepon { get; set; }
        public string NomorKartuVaksin { get; set; }
        public string AlamatRumah { get; set; }

        public void printTicket(int urutan)
        {          
            Console.WriteLine("------------------------------");
            Console.WriteLine("Pesanan ke-" + urutan);
            Console.WriteLine("Nama               : " + NamaPemesan);
            Console.WriteLine("NIK                : " + NIK);
            Console.WriteLine("Nomor Telepon      : " + NomorTelepon);
            Console.WriteLine("Nomor Kartu Vaksin : " + NomorKartuVaksin);
            Console.WriteLine("Alamat Rumah       : " + AlamatRumah);
            Console.WriteLine("------------------------------");
        }
    }
}
