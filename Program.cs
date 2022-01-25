using System;
using System.Collections.Generic;

namespace template_csharp_class_of_your_choice
{
    class Program
    {
        static List<Festival> Festivals = new List<Festival>();
        static void Main(string[] args)
        {
            for(int j = 0; j < 3; j++)
            {
                Festivals.Add(CreateFestival());
            }

            Print();
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
