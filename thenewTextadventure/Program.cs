using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace thenewTextadventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int timer = 300;
            Console.WriteLine("H");
            Thread.Sleep(timer);
            Console.Clear();
            Console.WriteLine("Ha");
            Thread.Sleep(timer);
            Console.Clear();
            Console.WriteLine("Hal");
            Thread.Sleep(timer);
            Console.Clear();
            Console.WriteLine("Hall");
            Thread.Sleep(timer);
            Console.Clear();
            Console.WriteLine("Hallo");
            Thread.Sleep(timer);
            Console.Clear();
            Console.WriteLine("Hallo?");
            Thread.Sleep(timer);
            timer = 500;
            Console.Clear();
            Console.WriteLine("Hallo?, hört");
            Thread.Sleep(timer);
            Console.Clear();
            Console.WriteLine("Hallo?, hört mich");
            Thread.Sleep(timer);
            Console.Clear();
            sprungmarke:
            Console.WriteLine("Hallo?, hört mich jemand?");
            Thread.Sleep(timer);
            Console.WriteLine("");
            Console.WriteLine("Anworten:");
            Console.WriteLine("Ja oder Nein!");
            int hoeren = Antwort(Console.ReadLine());
            if (hoeren == 1)
            {
                Console.Clear();
                Console.WriteLine("Gut, wer bist du?");

            }
            else if (hoeren == 0)
            {
                Console.Clear();
                Console.WriteLine("HAAAAAAALLLLLLLLOOOO, niemand da? NEEEEIIIIINNNN!");
            }
            else if (hoeren == -1)
            {
                Console.WriteLine("Ich kann dich nicht verstehen");
                goto sprungmarke;
            }
            else
            {
                goto sprungmarke;
            }


            Console.ReadKey();
        }

        static int Antwort(string a)
        {
        if (a == "Ja")
            {
            return 1;
            }
        else if (a == "Nein")
            {
            return 0;
            }
            else 
            {
            return -1;
            }
        }
        
    }
}
