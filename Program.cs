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
                Console.Clear();
                Console.WriteLine("1. Add a Festival");
                Console.WriteLine("2. View All Festivals");
                Console.WriteLine("3. Add Amenities");
                Console.WriteLine("4. Quit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Festivals.Add(CreateFestival());
                        break;
                    case 2:
                        Console.Clear();
                        Print(true);
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        break;
                    case 3:
                        int index = SelectFestival();
                        Console.WriteLine("Enter all amenities separated by commas: ");

                        string[] amenities = Console.ReadLine().Split(',');

                        Festivals[index - 1].Amenities = new List<String>(amenities);

                        break;
                    case 4:
                        isRunning = false;
                        break;
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static int SelectFestival()
        {
            Console.Clear();
            Console.WriteLine("Choose a festival from the list below: ");
            Print(false);

            return Convert.ToInt32(Console.ReadLine());
        }

        static void Print(bool withDetail)
        {
            int i = 1;
            foreach (Festival fest in Festivals)
            {
                Console.WriteLine(i + ". " + fest.Name);
                if (withDetail)
                {
                    Console.WriteLine("List of Amenities");
                    foreach(string amenity in fest.Amenities)
                    {
                        Console.WriteLine(amenity);
                    }
                }
                i++;
            }
        }

        static Festival CreateFestival()
        {
            Console.Clear();
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
