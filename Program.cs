using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4399
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama     : Nadhira Aurell P");
            Console.WriteLine("NIM      : 21.11.4399");
            Console.WriteLine("Kelas    : 21-IF-08");


            Console.WriteLine("\n");


            Karyawan karyawan1 = new Karyawan(1122, "Mauraa", 5000000);
            Karyawan karyawan2 = new Karyawan(2345, "Naura", 4000000);
            Karyawan karyawan3 = new Karyawan(1790, "Paijo", -100000);


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.WriteLine("\n\nAnda telah mendapat kenaikan gaji nih!!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);


            Console.ReadKey();
        }
    }
}