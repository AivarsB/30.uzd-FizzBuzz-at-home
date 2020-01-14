using System;

namespace _30.uzd_FizzBuzz_at_home
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 22; i++)

            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
// Izmantojot for ciklu izdrukāt uz ekrāna skaitļu virkni. Ciklam ir jāatkārtojas 21 reizi. 
// Gadījumā, ja tekošā cikla vērtība dalās ar trīs bez atlikuma tad uz jāizdrukā vārds Fizz, 
// ja cikla vērtība bez atlikuma dalās ar 5, tad jāizdrukā Buzz. Ja cikla vērtība bez atlikuma dalās ar 3 un 5, tad jāizdrukā vārds FizzBuzz. 
// Visos pārējos gadījumos ir jāizdrukā cikla vērtība. Rezultātam jāizskatās šādi: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz utt.