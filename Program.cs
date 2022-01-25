using System;
using System.Collections.Generic;

namespace template_csharp_class_of_your_choice
{
    class Program
    {
        static List<Festival> Festivals = new List<Festival>();
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1. Add a Festival");
                Console.WriteLine("2. View All Festivals");
                Console.WriteLine("3. Add Amenities");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Festivals.Add(CreateFestival());
                        break;
                    case 2:
                        Print();
                        break;
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Print()
        {
            int i = 1;
            foreach (Festival fest in Festivals)
            {
                Console.WriteLine(i + ". " + fest.Name);
                i++;
            }
        }

        static Festival CreateFestival()
        {
            Console.WriteLine("What's the name of your festival?");
            string name = Console.ReadLine();
            Console.WriteLine("What year did you go?");
            string year = Console.ReadLine();
            Console.WriteLine("Where does the location take place?");
            string location = Console.ReadLine();
            Console.WriteLine("Is there camping? (y/n)");
            string isCamping = Console.ReadLine();
            bool camping = false;
            if (isCamping == "y" || isCamping == "yes")
            {
                camping = true;
            }

            return new Festival() { Name = name, Year = year, IsCamping = camping, Location = location };

            //Festival myFestival = new Festival() { Name = name, Year = year, IsCamping = camping, Location = location };

            //return myFestival;
        }
    }
}
