using System;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the time to test your luck habilities.");
            Console.WriteLine("One dice for you and another for your greatest enemy.");
            Console.WriteLine("You win, you can continue pursuing your dream.");
            Console.WriteLine("You lose, well...");
            Console.WriteLine("You die.");

            Random random = new Random();
            int enemy = random.Next(1, 20);
                {
                    Console.WriteLine($"The enemy rolled the number {enemy} on the dark dice.");
                }
            int hero = random.Next(1, 20);
                {
                    Console.WriteLine($"Thou have rolled the numer {hero} on the dusty dice.");
                }
            
                {
                if (enemy == hero)
                {
                    Console.WriteLine("May you gentleman try again?");
                    do
                    {
                        enemy = random.Next(1, 20);
                        {
                            Console.WriteLine($"The enemy rolled the number {enemy} on the bloody dice.");
                        }
                        hero = random.Next(1, 20);
                        {
                            Console.WriteLine($"Thou have rolled the numer {hero} on the helpless dice.");
                        }
                    }
                    while (hero == enemy);
                }
                else if (enemy > hero)
                {
                    Console.WriteLine("Thou have perished.");
                }
                else if (enemy < hero)
                {
                    Console.WriteLine("Thou shall pass.");
                }
                
            }
        }
    }
}
