using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " aplikasi calculator";
            Console.Write("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            
            Console.WriteLine("hasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
            Console.WriteLine("hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("hasil Perkalian {0} * {1} = {2}" , a, b, perkalian(a, b));
            Console.WriteLine("hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\n Tekan sembarang key untuk keluar");
            Console.ReadKey();  
        
         }

        static int penambahan(int a, int b) 
        {
            return a + b;
        }

        static int pengurangan(int a, int b) 
        {
            return a - b;
        }

        static int perkalian(int a, int b) 
        {
            return a * b;
        }

        static int pembagian(int a, int b) 
        {
            return a / b;
        }
    }
}
