using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string crazy = "";
            
            do
            {
                Console.WriteLine("do I prefer dogs, cats, birds or bunnies?");
                string CaseSwitch = Console.ReadLine();


                switch (CaseSwitch)
                {
                    case "birds":
                        Console.WriteLine("I do like birds! Did you know they are closely related to dinosaurs? Crazy right.");
                        crazy = "yeah";
                        break;
                    case "dogs":
                    case "cats":
                    case "bunnies":
                        Console.WriteLine("I mean, they're cool, but my favourite is slightly less mammal");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("psst. hey. I gave you options for a reason.");
                        break;
                }
            } while (crazy != "yeah");
            Console.ReadLine();
            Console.WriteLine("anyway... Peace!");
            Console.ReadKey();




        }
    }
    }

