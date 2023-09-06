using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nilai a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan nilai b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));


            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }


        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        { 
            return a * b; 
        } 

        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
