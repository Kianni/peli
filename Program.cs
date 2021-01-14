using System;

namespace Peli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peli alkaa!!!");
            // valitaan luku 1 ja 20 välillä
            Random rnd = new Random();
            int luku  = rnd.Next(1, 21);

            // arvotaan kolme kertaa
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Anna luku:");
                int arvaus = Convert.ToInt32(Console.ReadLine());
                
                // jos arvaus on oikein silmukka päättyy
                if (arvaus == luku)
                {
                    Console.WriteLine("Voitit! Arvasit luvun ihan oikein!");
                    break;
                } else if (arvaus > luku)
                {
                    Console.WriteLine("Luku on pienempi, kuin " + arvaus);
                } else
                {
                    Console.WriteLine("Luku on isompi, kuin " + arvaus);
                }           
                if (i == 2)
                {
                    Console.WriteLine("Hävisit tällä kerta...Luku oli " + luku);
                }
            }          
                      
        }
    }
}
