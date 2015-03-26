using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace COMP100_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            SpookyCave();
        }


        // UTILITY METHODS
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Start Over.....................>");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
            Console.Clear();
        }

        // Main menu Utility Method
        private static void SpookyCave()
        {
            int selection = 0; // default selection
            string introText = "You are on a planet full of dragons. In front of you,\n";
            introText += "you see two caves. In one cave, the dragon is friendly\n";
            introText += "and will share his treasure with you. The other dragon\n";
            introText += "is greedy and hungry, and will eat you on sight.\n\n";
            string bodyText = "";


            while (selection != 3)
            {
                Console.ResetColor();
                Console.WriteLine(introText);
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                              +");
                Console.WriteLine("+  WHICH CAVE DO YOU GO INTO?  +");
                Console.WriteLine("+                              +");
                Console.WriteLine("+  1. Cave 1                   +");
                Console.WriteLine("+  2. Cave 2                   +");
                Console.WriteLine("+  3. Give Up :(               +");
                Console.WriteLine("+                              +");
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.Write("Please make your selection: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Cave 1 - Player Dies
                        Cave1();
                        break;
                    case 2: // Cave 2 - Player Lives
                        Cave2();
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Incorrect entry - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }
        }


        // 2nd Decision Level Cave 1
        private static void Cave1()
        {
            string introText = "";
            int selection = 0;

            Console.Clear();
            introText = "You approach the cave,";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "it is dark and spooky.\n";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "A large red dragon is sleeping in front of you!\n";
            introText += "You see a lit tunnel but it's blocked by the dragon's tail.\n";
            introText += "You also see a dark tunnel.\n\n";
            Console.ResetColor();


            while (selection != 3)
            {
                Console.ResetColor();
                Console.BackgroundColor = System.ConsoleColor.Cyan;
                Console.ForegroundColor = System.ConsoleColor.Black;
                Console.WriteLine(introText);
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                              +");
                Console.WriteLine("+  WHICH TUNNEL DO YOU TAKE?   +");
                Console.WriteLine("+                              +");
                Console.WriteLine("+  1. Lit Tunnel               +");
                Console.WriteLine("+  2. Dark Tunnel              +");
                Console.WriteLine("+  3. Give Up :(               +");
                Console.WriteLine("+                              +");
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.Write("Please make your selection: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Player takes Lit tunnel - across dragon's tail.
                        LitTunnel();
                        selection = 3;
                        break;
                    case 2: // Player takes Dark tunnel
                        DarkTunnel();
                        selection = 3;
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Incorrect entry - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }

        }

        // Positive Outcome 1 - Player Lives - WIN
        private static void Cave2()
        {
            string bodyText = "";
            Console.Clear();
            bodyText = "You approach the cave, it is bright and cheerful.\n";
            bodyText += "A large white dragon approaches you...\n\n";
            bodyText += "And... \n\n... gives you his treasure!\n";
            Console.ResetColor();
            Console.WriteLine(bodyText);
            Thread.Sleep(5000);

            bodyText = ".......... .M?78IIIIIIIII77M?. .........\n";
            bodyText += ".......... MMMMII.+?I,7=??MMMMMM........\n";
            bodyText += ".......... ..MMM=??OMMMMMM.MOMMM7.......\n";
            bodyText += "......... .... MMOZ.=,Z,Z.ZMMMMMM.......\n";
            bodyText += "...............MM+?M?MM??MMMZIMM........\n";
            bodyText += "............M?MMM.MMI+ID~?,Z8MI.........\n";
            bodyText += "..........MIM??ZZ?7?~M,MMM?IINI.........\n";
            bodyText += "..........??IIIIMMIIIZ$MII7IM7Z.........\n";
            bodyText += "..........?=IIIIIMNMZMM7MMIM7MN ........\n";
            bodyText += "..........?+IMMIIIIII=I?MMIMMIM ........\n";
            bodyText += "..... .NM I+IIIIIIIII?I+MMMZ8MM.........\n";
            bodyText += "8 .D?M.?M.I7MMIIIII7M+IIMDMMM??..M?+....\n";
            bodyText += ".......  ..+?M?MM7III7DZMMMM.~NMM....   \n";
            bodyText += "...........:M. MMM.I??+MM.M+?MMM,.......\n";
            bodyText += "......MMM....DM...??M...M?.MD..:M.......\n";
            bodyText += "....................... ....... .......\n";
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine(bodyText);
            WaitForKey();
        }

        // Negative Outcome 1 - Player Dies
        private static void LitTunnel()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "You jump across the dragon's tail and trip.\n";
            introText += "You fall in front of the dragon and...\n\n";
            introText += "And... \n\n... he gobbles you down with one bite.\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(5000);

            // INSERT INTERESTING BODY TEXT HERE

            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }


        // Negative Outcome 1 - Player Dies
        private static void DarkTunnel()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "You bravely go into the dark tunnel.\n";
            introText += "You slip on some watery rocks...\n\n";
            introText += "And... \n\n... you fall to your death!\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(5000);

            // INSERT INTERESTING BODY TEXT ART HERE

            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }



    }
}
