using System;
namespace inluppg31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("jag ser att du vill vara i tävling. du måste vara mellan 16 och 19 år. skriv din gamlighet");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder > 19)
            {
                Console.WriteLine("shit din gamling stick härifrån");

            }
            else if (ålder < 16)
            {
                Console.WriteLine("shit din bebis stick härifrån");
            }
            else
            {
                Console.WriteLine("nice du är normal stick hit på tisdag och kötta på i tävlingen");
            }
        }

    }

}
