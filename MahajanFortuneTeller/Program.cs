using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahajanFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART ONE

            Console.WriteLine("HELLO gentle MORTAL! I am Elvira, the Great and WONDROUS Oracle of CLEVELAND!");
            Console.WriteLine("If you'd like to gaze into the future, I can help you with that!");
            Console.WriteLine("Would you like to gaze into the future with me?");
            string answer = Console.ReadLine().ToLower().Trim();
                if (answer == "yes")
                { Console.WriteLine("Let's proceed!");
                }
                else
                { Console.WriteLine("TOO BAD! You're in my clutches now!");
                }
            Console.WriteLine("Enter your first name for the Great Elvira.");
            string userFirstName = Console.ReadLine().Trim();

            Console.WriteLine("And now can I have your last name? Promise I won't google you.");
            string userSecondName = Console.ReadLine().Trim();

            Console.WriteLine("How about your age? I'll never tell another... living... soul!");
            int userAge = int.Parse(Console.ReadLine().Trim());

            //PART II
                string retire;
                    if (userAge % 2 == 0)
                    { retire = "5";
                    }
                    else 
                    { retire ="2";
                    }
       
            Console.WriteLine("If I could also have your birth month as a NUMBER 1-12.");
            Console.WriteLine("Not that I don't already KNOW... I'm just bad with number conversion.");
            int userMonth = int.Parse(Console.ReadLine().Trim());
            //PART II
            string money;
            if (userMonth == 1 && userMonth <= 4)
            { money = "$1,045,070";
            }
            else if (userMonth >= 5 && userMonth <= 8)
            { money = "$4,876,347";
            }
            else if (userMonth >= 9 && userMonth <= 12)
            { money = "$3,409,132";
            }
            else
            { money = "$0.00";
            }

            Console.WriteLine("And now.. tell me your MOST FAVORITE of the colors of the ROYGBIV rainbow!");
            Console.WriteLine("If you don't know what ROYGBIV stands for, let me know by entering \"HELP.\"");
            string userFavColor = Console.ReadLine().ToLower().Trim();
                if (userFavColor == "help")
                { Console.WriteLine("R O Y G B I V stands for the colors of the rainbow as \nRed, Orange, Yellow, Green, Blue, Indigo, and Violet.");
                    userFavColor = Console.ReadLine().ToLower().Trim();
                }
            //PART II
            string transport;
            if (userFavColor == "red")
            {
                transport = "a sparkling unicorn";
            }
            else if (userFavColor == "orange")
            {
                transport = "Apona";
            }
            else if (userFavColor == "yellow")
            {
                transport = "Buckbeak";
            }
            else if (userFavColor == "green")
            {
                transport = "a unicycle";
            }
            else if (userFavColor == "blue")
            {
                transport = "a rusty old Rambler";
            }
            else if (userFavColor == "indigo")
            {
                transport = "your trusty two feet";
            }
            else
            {
                transport = "Floo Powder";
            }

            Console.WriteLine("And now, for the final FLOURISH, the last piece of the puzzle... \nHow many siblings do you have, my dearie?");
            int userSibs = int.Parse(Console.ReadLine().Trim());
            
            //PART II
            string vacaHome;
            if (userSibs == 0)
                {vacaHome = "Australia";
                }
            else if (userSibs == 1)
                {vacaHome = "Vancouver";
                }
            else if (userSibs == 2)
                {vacaHome = "Colorado";
                }
            else if (userSibs == 3)
                {vacaHome = "England";
                }
            else if (userSibs < 0)
                {vacaHome = "Pennywise's Dance Studio";
                }
            else
                { vacaHome = "the Caribbean Islands, so you will all have your own space";
                }

            //PART III
            Console.WriteLine(userFirstName + " " + userSecondName + ", you will retire in " + retire + " years with " + money);
            Console.WriteLine("in your bank account with a vacation home in " + vacaHome + " and " + transport + " will get you from place to place.");


        }
    }
}
