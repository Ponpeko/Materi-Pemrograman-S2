using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static List<Pesanan> daftarPesanan = new List<Pesanan>();

        static void Main(string[] args)
        {
            bool loop = true;

            Console.WriteLine("Aplikasi Pemesanan Tiket Pesawat Kertas 365 Hari");

            while (loop)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Pesanan Baru");
                Console.WriteLine("2. Lihat Pesanan");
                Console.WriteLine("3. Exit");

                Console.Write("Pilih menu [1...3]: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        TambahPesanan();
                        break;
                    case "2":
                        LihatDaftarPesanan();                       
                        break;
                    default:
                        return;
                }
            }
        }

        static void TambahPesanan()
        {
            Console.Clear();

            Pesanan pesanan = new Pesanan();

            Console.WriteLine("Silahkan isi data berikut ");

            Console.Write("Nama: ");
            pesanan.NamaPemesan = Console.ReadLine();

            Console.Write("NIK: ");
            pesanan.NIK = Console.ReadLine();

            Console.Write("Nomor telepon: ");
            pesanan.NomorTelepon = Console.ReadLine();

            Console.Write("Nomor kartu vaksin: ");
            pesanan.NomorKartuVaksin = Console.ReadLine();

            Console.Write("Alamat rumah: ");
            pesanan.AlamatRumah = Console.ReadLine();

            daftarPesanan.Add(pesanan);

            Console.WriteLine("Pesanan berhasil ditambahkan!");

            Console.ReadKey();
            Console.Clear();
        }

        static void LihatDaftarPesanan()
        {
            Console.Clear();

            int urutan = 1;
            if (daftarPesanan.Count == 0)
            {
                Console.WriteLine("Belum ada pesanan.");
            }
            else
            {
                Console.WriteLine("\nDaftar Pesanan tiket pesawat:");
                foreach (Pesanan pesanan in daftarPesanan)
                {
                    pesanan.printTicket(urutan);    
                    urutan++;
                }
            }            
            Console.ReadKey();
            Console.Clear();
        }
    }
}