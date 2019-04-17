﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string w, rawTimeWorked;
            int i;
            double ttl, t;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            Console.Write("Enter what you did:");
            w = Console.ReadLine();
            Console.Write("How long did you do it for:");
            rawTimeWorked = Console.ReadLine();

            while (double.TryParse(rawTimeWorked, out t) == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given.");
                Console.Write("How long did you do it for:");
                rawTimeWorked = Console.ReadLine();
            }

            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more item (y/n): ");

            string answer = Console.ReadLine();
            bool cont = false;

            if (answer.ToLower() == "yes")
                cont = true;

            while (cont == true)
            {
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
                while (double.TryParse(rawTimeWorked, out t) == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid number given.");
                    Console.Write("How long did you do it for:");
                    rawTimeWorked = Console.ReadLine();
                }

                ent.HoursWorked = t;
                ent.WorkDone = t;
                ents.Add(ent);
                Console.Write("Do you want to enter more item (y/n): ");
                answer = Console.ReadLine();
                cont = false;

                if (answer.ToLower() == "yes")
                {
                    cont = true;
                }

            }

            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.ToLower().Contains("acme"))
                {
                    ttl += ents[i].HoursWorked;
                }

            }
            Console.WriteLine("Simulating sending mail to acme:");
            Console.WriteLine("Your bill is &" + ttl * 150 + "for the hours worked.");

            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.ToLower().Contains("abc"))
                {
                    ttl += ents[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating sending mail to abc:");
            Console.WriteLine("Your bill is &" + ttl * 150 + "for the hours worked.");

            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }

            if (ttl > 40)
            {
                Console.WriteLine("You will get paid $" + (((ttl - 40) * 15) + (40 * 10)) + "for the hours work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + (ttl * 10) + "for your time.");
            }

            Console.WriteLine();
            Console.Write("Press any key to exit...............");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public double HoursWorked;
        public string WorkDone;
    }
}
