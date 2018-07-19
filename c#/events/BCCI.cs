using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public delegate void changed();
    public class BCCI
    {
        public static event changed Event;
        public static string current_captain_name = "msdhoni";
        public static string new_captain_name;
        public static string previous_captain_name;

        public void new_captain()
        {
            Console.WriteLine("enter new captain name");
            new_captain_name = Console.ReadLine();
            if(!(current_captain_name.Equals(new_captain_name)))
            {
                previous_captain_name = current_captain_name;
                current_captain_name = new_captain_name;
               
                notify();
                Console.WriteLine("========================================================");
                Console.WriteLine("previous captain name:" + previous_captain_name);
                Console.WriteLine("new captain name:" + current_captain_name);
            }
            else
            {
                Console.WriteLine("========================================================");
                Console.WriteLine("captain remains unchanged and it is:" + current_captain_name);
              
            }
        }
        public static void notify()
        {
            if (Event != null)
            {
                Event();
            }
        }
        static void Main(string[] args)
        {
            BCCI p1 = new BCCI();
            changed c1 = p1.new_captain;
            Event += TeamIndia.RohitSharma;
            Event += TeamIndia.ShikarDhawan;
            Event += TeamIndia.ViratKohli;
            Event += TeamIndia.ManishPandey;
            Event += TeamIndia.SureshRaina;
            Event += TeamIndia.MSDhoni;
            Event += TeamIndia.HardikPandya;
            Event += TeamIndia.BhuvaneshwarKumar;
            Event += TeamIndia.JaspritBumrah;
            Event += TeamIndia.UmeshYadav;
            c1.Invoke();
            
            Console.ReadKey();

        }

    }
    class TeamIndia
    {
        public static void RohitSharma()
        {
            if(BCCI.current_captain_name.Equals("RohitSharma", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats Rohit! u are the new captain of Indian Cricket Team");
            }
            else
            {
                Console.WriteLine("Rohit, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
            }
            
        }
        public static void ShikarDhawan()
        {
            if (BCCI.current_captain_name.Equals("ShikarDhawan", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats Dhawan! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("Rohit, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }
        public static void ViratKohli()
        {
            if (BCCI.current_captain_name.Equals("ViratKohli", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats virat! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("Virat, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }
        public static void ManishPandey()
        {
            if (BCCI.current_captain_name.Equals("ManishPandey", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats Manish! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("Manish, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }
        public static void SureshRaina()
        {
            if (BCCI.current_captain_name.Equals("SureshRaina", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats Raina! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("Raina, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }
        public static void MSDhoni()
        {
            if (BCCI.current_captain_name.Equals("MSDhoni", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats Mahi! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("Dhoni, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }
        public static void HardikPandya()
        {
            if (BCCI.current_captain_name.Equals("HardikPandya", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats pandya! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("pandya, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }
        public static void BhuvaneshwarKumar()
        {
            if (BCCI.current_captain_name.Equals("BhuvaneshwarKumar", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats Bhuvi! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("Bhuvi, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }
        public static void JaspritBumrah()
        {
            if (BCCI.current_captain_name.Equals("JaspritBumrah", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats Bumrah! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("Bumrah, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }
        public static void UmeshYadav()
        {
            if (BCCI.current_captain_name.Equals("UmeshYadav", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("congrats Umesh! u are the new captain of Indian Cricket Team");
            }
            else
            Console.WriteLine("Umesh, new captain of Indian cricket Team  is:" + BCCI.current_captain_name);
        }     

    }
}
