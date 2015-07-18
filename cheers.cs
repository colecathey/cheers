using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    public class Cheers
    {

        

        static void Main()
        {
            Console.WriteLine("Whats your name?");
            string cheer = Console.ReadLine();

            

            
            string anChar = "HalfNorseMix";
            
            foreach (char letter in cheer)
            {
                string article;
                if (anChar.Contains(letter))
                {
                    article = "an ";
                }
                else
                {
                    article = "a ";
                }
                var message = String.Concat("give me ", article, letter);
                Console.WriteLine(message);
                
                
            }
            Console.ReadLine();

            string cheerFinish = String.Concat("what does it spell?", "....", cheer);

            Console.WriteLine(cheerFinish);

            Console.ReadLine();

            Console.WriteLine("What is your birthday?");
            string birthday = Console.ReadLine();
            DateTime MyDateTime = DateTime.Parse(birthday);
            DateTime currentDate = DateTime.Now;
            int daysUntil = (MyDateTime - currentDate).Days;

            if (daysUntil < 0)
            {
                daysUntil = daysUntil + 365;
            }

            var dateDif = String.Concat("you have ", daysUntil, " days until your birthday");

            Console.WriteLine(dateDif);
            Console.ReadLine();
        }
    }
}
