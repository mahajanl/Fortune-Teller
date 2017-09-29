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
            Console.WriteLine("Enter your first name for the Great Elvira.");
            string userFirstName = Console.ReadLine().ToLower().Trim();
            Console.WriteLine(userFirstName);

            Console.WriteLine("And now can I have your last name? Promise I won't google you.");
            string userSecondName = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("How about your age? I'll never tell another... living... soul!");
            int userAge = int.Parse(Console.ReadLine().Trim());

            string retire;
                if (userAge % 2 == 0)
                { retire = "5";
                }
                else if (userAge % 2 != 0)
                { retire ="2";
                }
       
            Console.WriteLine("If I could also have your birth month as a NUMBER 1-12.");
            Console.WriteLine("Not that I don't already KNOW... I'm just bad with number conversion.");
            int userMonth = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("And now.. tell me your MOST FAVORITE of the colors of the ROYGBIV rainbow!");
            Console.WriteLine("If you don't know what ROYGBIV stands for, let me know by entering \"HELP.\"");
            string userFavColor = Console.ReadLine().ToLower().Trim();
                if (userFavColor == "help")
                { Console.WriteLine("R O Y G B I V stands for the colors of the rainbow as \nRed, Orange, Yellow, Green, Blue, Indigo, and Violet.");
                }

            Console.WriteLine("And now, for the final FLOURISH, the last piece of the puzzle... \nHow many siblings do you have, my dearie?");
            int userSibs = int.Parse(Console.ReadLine().Trim());

            ////PART TWO
            //int ageModulus = userAge % 2;
            //if (ageModulus == 0)
            //{ int retireEven = 5;
            //}         

            //if (userSibs == 0)
            //{ string zeroSibs = "Australia";
            //}
            //else if (userSibs == 1)
            //{ string oneSib = "Vancouver";
            //}
            //else if (userSibs == 2)
            //{ string twoSibs = "Colorado";
            //}
            //else (userSibs == 3)
            //{ string threeSibs = "England";
            //}

            Console.WriteLine(userFirstName + " " + userSecondName + " will retire in " + retire);


        }
    }
}
