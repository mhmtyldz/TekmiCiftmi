using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekmiCiftmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            string[] TekCift = { "ÇİFT", "TEK" };

            Console.Write("Sayı giriniz!");
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(sayi + " Sayısı " + TekCift[sayi % 2] + " Bir Sayıdır!");







          //  Switchte sonucta bi if yapısı sayılır ama gene de 2. Yöntem olarak yazmak istedim.
            // ***************************************************************************************************************
            //Console.Write("Sayı giriniz!");
            //sayi = int.Parse(Console.ReadLine());


            //switch (sayi%2)
            //{
            //    case 0:
            //        Console.WriteLine(sayi + " Çift Bir Sayıdır!");
            //        break;
            //    case 1:
            //        Console.WriteLine(sayi + " Tek Bir Sayıdır!");
            //        break;
            //}

            // ***************************************************************************************************************

        }
    }
}
