using System;

namespace del2ProgProv2MalteNordlof
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodMedAllCode();

            static void MetodMedAllCode()  // lägger allt i en metod av nån annledning
            {
                Random randomGenerator = new Random();
                int random1 = randomGenerator.Next(1, 100); // jätte fult sätt att göra 5 slumptal som jag sen kan lägga in i min array 
                int random2 = randomGenerator.Next(1, 100);
                int random3 = randomGenerator.Next(1, 100);
                int random4 = randomGenerator.Next(1, 100);
                int random5 = randomGenerator.Next(1, 100);

                string[] saker = new string[] { "Bomber", "swords", "godis", "HP laptops", "pizza" };
                int[] sakerVikt = new int[] { random1, random2, random3, random4, random5 };

                Console.WriteLine("Welcome to my shop (press anykey exept power off to continue)"); //första som skrivs ut och hälsar spelaren
                Console.ReadKey(); // ser till att spelet stannar en stund tills spelar trycker något
                Console.Clear();
                Console.WriteLine("Here is what I offer");

                for (int i = 0; i < saker.Length; i++) // skriver utt alla saker och deras vikt
                {
                    Console.WriteLine(saker[i] + " their wight is: " + sakerVikt[i]);
                }

                int carry = -5;
                bool inputRecived  = false;
                
                while (!inputRecived)
                {
                    Console.WriteLine("How much can you carry (write whole nummber between 1-100");
                    string input = Console.ReadLine();
                    inputRecived = Int32.TryParse(input, out carry);    
                }


                for (int i = 0; i < saker.Length; i++)
                {
                    if (carry >= sakerVikt[i]) // kollar ifall man kan bära saken för varje grej
                    {
                        Console.WriteLine("you could carry some " + saker[i]);
                    }
                    else
                    {
                        Console.WriteLine("bruh you can't even carry " + saker[i]);
                    }
                }
                Console.WriteLine("Goodbye (press anykey exept power off to close window)");
                Console.ReadKey();
            }
        }
    }
}
