using System;
using System.Collections.Generic;
using System.Text;

namespace HesapMakinesi
{
    class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public void Topla(int a , int b)
        {
            int toplam = a + b;
            Console.WriteLine($"Toplam = {toplam}");
        }
        public void Cikar(int a, int b)
        {
            int cikarim = a - b;
            Console.WriteLine($"Toplam = {cikarim}");
        }
        public void Carpma(int a, int b)
        {
            int carpim = a * b;
            Console.WriteLine($"Carpim = {carpim}");
        }
        public void Bolme(int a , int b)
        {
            double bolum = a / b;
            Console.WriteLine($"Bolum = {bolum}");
        }
        public void Faktoriyel(int a)
        {
            int Faktoriyel = 1;
            for (int i = 1; i <= a; i++)
            {
               Faktoriyel = Faktoriyel * i;
            }
            Console.WriteLine($"Faktoriyel = {Faktoriyel}");
        }
       
    }
}
