using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz");
            int diziuzunulugu = Convert.ToInt32(Console.ReadLine());

            int[] sayidizisi = new int[diziuzunulugu];
            for (int i = 0; i < sayidizisi.Length; i++)
            {
                Console.WriteLine("Lütfen"+(i+1)+". sayıyı giriniz: ");
                sayidizisi[i] = Convert.ToInt32(Console.ReadLine());
            }
            int toplam=0;
            for (int j = 0; j < sayidizisi.Length; j++)
            {
                toplam += sayidizisi[j];
            }
            int ortalama = toplam / diziuzunulugu;
            Console.WriteLine(ortalama);
            Console.ReadLine();
        }
    }
}
