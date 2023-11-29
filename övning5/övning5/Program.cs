using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        // detta är en statisk metod med en int som ett returvärde
        // metoden tar en parameter i form av ett random objekt av
        // randomklassen

        static int RullaTärning(Random slumpObjekt)
        {
            int slag = slumpObjekt.Next(1, 7);
            return slag;
            /*lägger in next i metoden som slumpar fram tal mellan 1-7,
             eftersom 7 är högsta siffran kommer den inte att slumpas 
            utan bara tal mellan 1-6 precis som på en tärning.
            sedan returneras de rullade värdena i "slag". */

            // här ska du skapa kod som slumpar fram ett tal
            // mellan 1 och 6, så att metoden "rullar" en 6 sidig
            // tärning när vi kallar på den

            // metoden ska sedan returnera det rullade värdet
        }

        static void Main()
        {
            Random slump = new Random(); // Skapar en instans av klassen Random för vårt slumptal
            List<int> tärningar = new List<int>(); // listan för att spara våra rullade tärningar

            Console.WriteLine("\n\tVälkommen till tärningsgeneratorn!");

            bool kör = true;
            while (kör)
            {
                Console.WriteLine("\n\t[1] Rulla tärning\n" +
                    "\t[2] Kolla vad du rullade\n" +
                    "\t[3] Avsluta");
                Console.Write("\tVälj: ");
                int val;
                int.TryParse(Console.ReadLine(), out val);

                switch (val)
                {
                    case 1:
                        Console.Write("\n\tHur många tärningar vill du rulla: ");
                        bool inmatning = int.TryParse(Console.ReadLine(), out int antal);

                        if (inmatning)
                        {
                            for (int i = 0; i < antal; i++)
                            {
                                // här kallar vi på metoden RullaTärning
                                // och sparar det returnerade värdet i 
                                // listan tärningar
                                tärningar.Add(RullaTärning(slump));
                            }
                        }
                        break;
                    case 2:
                        int sum = 0; // Skapar en int som ska innehålla medelvärdet av alla tärningsrullningar.
                        foreach (int slag in tärningar)
                        {
                            sum += tärningar.Count / slag;
                        }
                        /*jag gjorde den här foreach loopen och försökte tolka de tips du gav mig för jag hittar
                         verkligen inte något när jag försöker kolla msdn, det ända jag hittar när jag googlar är
                        personer som gjort samma uppgift och jag kan ju inte kopiera deras kod så klart. och
                        jag vet ju inte hur de kommit fram till sin kod heller så jag har inte direkt kollat den
                        koden särskilt nogrannt. koden jag la in fungerar inte riktigt heller men jag tänkte
                        att jag lägger in det jag kommit fram till. något händer i alla fall med uträkningen.*/
                        if (tärningar.Count <= 0)
                        {
                            Console.WriteLine("\n\tDet finns inga sparade tärningsrull! ");
                        }
                        else
                        {
                            Console.WriteLine("\n\tRullade tärningar: ");
                            foreach (int tärning in tärningar)
                            {
                                Console.WriteLine("\t" + tärning);
                            }
                            Console.WriteLine("\n\tMedelvärdet på alla tärningsrull: " + sum); // Här ska medelvärdet skrivas ut
                        }

                        break;
                    case 3:
                        Console.WriteLine("\n\tTack för att du rullade tärning!");
                        Thread.Sleep(1000);
                        kör = false;
                        break;
                    default:
                        Console.WriteLine("\n\tVälj 1-3 från menyn.");
                        break;
                }
            }
        }
    }
}
