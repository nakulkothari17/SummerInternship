using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ----- Basic prints --------
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            /* ------ Basic string --------
            Console.WriteLine("What is your name ?");
            Console.Write("Type your first name \n");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("What is your last name ? \n");
            string myLastName;
            myLastName = Console.ReadLine();

            Console.WriteLine("Hey, " + myFirstName + " " + myLastName);
            Console.ReadLine();
            */

            /* -------- if else if else --------
            Console.WriteLine("Nakul's Giveaway");
            Console.Write("Choose the number of present you want to open from 1,2 and 3.");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
                message = "You won a PS5!";
            else if (userValue == "2")
                message = "you won a XBOX!";
            else if (userValue == "3")
                message = "You won a Netendo!";
            else
            {
                message = "You angry me you won nothing. HAHAHAHA!!!!";
                message += "\nYou Lose!!";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */

            // ------ condition operators 
            Console.WriteLine("Nakul's Giveaway");
            Console.Write("Choose the number of present you want to open from 1,2 and 3.");
            string userValue = Console.ReadLine();
            // only if IF ELSE statement is there or use the else if
            string message = (userValue == "1")? "PS5" : "Strand of lint";
            Console.Write("You won a " + message + ".\n");
            //Console.Write(message);
            //Console.Write(".");
            Console.WriteLine("You entered {0}, so, You won a {1}.", userValue, message);
            Console.ReadLine();
        }
    }
}
