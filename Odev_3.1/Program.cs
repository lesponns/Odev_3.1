using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Kullanıcıdan
            1 adet sayı talep edin, kullanıcı 5 in katı bir sayı girmezse program
            kullanıcıdan tekrar tekrar sayı istesin.*/

            int input = 0;
            do
            { 
                Console.Write("Sayı değeri: ");
                input = int.Parse(Console.ReadLine());
            } 
            while (input % 5 != 0);

            Console.WriteLine("Girdiğiniz sayı 5'in katıdır. Sayı: " + input);
            Console.ReadKey();

        }
    }
}
