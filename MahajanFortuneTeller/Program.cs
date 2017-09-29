﻿using System;
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

            Console.WriteLine("And now can I have your last name? Promise I won't google you.");
            string userSecondName = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("How about your age? I'll never tell another... living... soul!");
            int userAge = int.Parse(Console.ReadLine().Trim());

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
                

            Console.WriteLine("And now.. tell me your MOST FAVORITE of the colors of the ROYGBIV rainbow!");
            Console.WriteLine("If you don't know what ROYGBIV stands for, let me know by entering \"HELP.\"");
            string userFavColor = Console.ReadLine().ToLower().Trim();
                if (userFavColor == "help")
                { Console.WriteLine("R O Y G B I V stands for the colors of the rainbow as \nRed, Orange, Yellow, Green, Blue, Indigo, and Violet.");
                }
                string transport;
                    if (userFavColor == "red")
            { transport = "a sparkling unicorn";
            }
                    else if (userFavColor == "orange")
            { transport = "Apona";
            }
                    else if (userFavColor == "yellow")
            { transport = "Buckbeak";
            }
                    else if (userFavColor == "green")
            { transport = "a unicycle";
            }
                    else if (userFavColor == "blue")
            { transport = "a rusty old Rambler";
            }
                    else if (userFavColor == "indigo")
            { transport = "your trusty two feet";
            }
                    else
            { transport = "Floo Powder";
            }


            Console.WriteLine("And now, for the final FLOURISH, the last piece of the puzzle... \nHow many siblings do you have, my dearie?");
            int userSibs = int.Parse(Console.ReadLine().Trim());

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
                { vacaHome = "Caribbean Islands, so you will all have your own space";
                }


            Console.WriteLine(userFirstName + " " + userSecondName + " will retire in " + retire + " with a vacation home in " + vacaHome);


        }
    }
}
