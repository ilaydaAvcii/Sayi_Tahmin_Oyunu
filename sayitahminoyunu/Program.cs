// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int hedefSayi = random.Next(1, 101);  // 1 ile 100 arasında rastgele sayı
        int tahmin = 0;
        int tahminSayisi = 0;

        Console.WriteLine("1 ile 100 arasında bir sayı tuttum! Tahmin etmeye çalış.");

        while (tahmin != hedefSayi)
        {
            Console.Write("Tahmininizi girin: ");
            tahmin = int.Parse(Console.ReadLine());  
            tahminSayisi++;

            if (tahmin < hedefSayi)
            {
                Console.WriteLine("Tahmininiz küçük. Daha büyük bir sayı deneyin.");
            }
            else if (tahmin > hedefSayi)
            {
                Console.WriteLine("Tahmininiz büyük. Daha küçük bir sayı deneyin.");
            }
        }
        Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz. {tahminSayisi} tahminde bulundunuz.");
    }
}
