using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Hesap Makinesi --------------");
            int x = 5;
            Calculator calculator = new Calculator();
            while (x == 5)
            {
                Console.WriteLine("Toplama İşlemi (1)" +
                "Çıkarma Işlemi (2)" +
                "Çarpma Işlemi (3)" +
                "Bölme Işlemi (4)" +
                "Faktoriyel Alma (5)");
                Console.WriteLine("Sayi Giriniz :");
                int select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                {
                    Console.Write("1. Sayiyi Giriniz");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayiyi Giriniz");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    calculator.Topla(number1, number2);
                }
                else if (select == 2)
                {
                    Console.Write("1. Sayiyi Giriniz");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayiyi Giriniz");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    calculator.Cikar(number1, number2);
                }
                else if (select == 3)
                {
                    Console.Write("1. Sayiyi Giriniz");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayiyi Giriniz");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    calculator.Carpma(number1, number2);
                }
                else if (select == 4)
                {
                    Console.Write("1. Sayiyi Giriniz");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayiyi Giriniz");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    calculator.Bolme(number1, number2);
                }
                else if (select == 5)
                {
                    Console.Write("Faktoriyelini Almak Istediginiz Sayiyi Giriniz : ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    calculator.Faktoriyel(number1);
                }

            }
            
            

        }
    }
}
