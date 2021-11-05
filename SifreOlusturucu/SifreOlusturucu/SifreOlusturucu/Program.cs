using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreOlusturucu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[+] Kaç haneli şifre oluşturulsun?: ");
            int sifreHaneSayisi = Convert.ToInt32(Console.ReadLine());

            string[] randomChar = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P",
                                    "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z",
                                    "X", "C", "V", "B", "N", "M", "q", "w", "e", "r",
                                    "t", "y", "u", "i", "o", "p", "a", "s", "d", "f",
                                    "g", "h", "j", "k", "l", "z", "x", "c", "v", "b",
                                    "n", "m", "!", "?", "*", "0", "1", "2", "3", "4",
                                    "5", "6", "7", "8", "9" };
            Random randomSayiUret = new Random();

            if (sifreHaneSayisi > 20)
            {
                Console.WriteLine("[+] 20 haneden fazla şifre üretilemiyor.");
            }
            else if (sifreHaneSayisi <= 20)
            {
                string sifre = "";
                for (int i = 1; i <= sifreHaneSayisi; i++)
                {
                    sifre += "" + randomChar[randomSayiUret.Next(0, 66)];
                }
                Console.WriteLine("[+] " + sifreHaneSayisi + " haneli oluşturulan şifre: " + sifre);
            }
        }
    }
}
