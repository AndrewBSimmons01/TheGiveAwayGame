using System;
using System.Threading;

namespace BIGGame
{
    class options
    {
        
        
    }
    class ProgramBIGG
    {
       
        static void Main(string[] args)
        {
            ProgramBIGG ui = new ProgramBIGG();
            ui.menu();
            
            
                options ui2 = new options();
                ui.menu2();
            





        }

        public void menu()
        {

            Console.WriteLine("Log-in to this program by providing your name");
            Console.WriteLine(" ");
            Console.WriteLine("Type your first name");
            string myFIrstName;
            myFIrstName = Console.ReadLine();
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("What is your last name?");
            string myLastName;
            myLastName = Console.ReadLine();
            Thread.Sleep(300);
            Console.Clear();


            Console.WriteLine("Hello " + myFIrstName + " " + myLastName + "!");
            Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine("Let us play a game.....yes?");
            Console.WriteLine("This game is called 'The BIG Giveaway'");
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("choose a door! Door 1, Door 2, or Door 3?");
        }
        public void menu2()
        { 
            bool runningbigGive = true;
            var userValue = Console.ReadLine();
            while (runningbigGive)
            {
                switch (userValue)
                {
                    case "1":
                        option1();

                        break;


                    case "2":
                        option2();
                        runningbigGive = !true;
                        break;

                    case "3":
                        option3();
                        break;

                    case "4":
                        option4();
                        break;

                    default:
                        Console.WriteLine("Whoops!");
                        menu2();

                        break;
                }

            }
        }
        
        public void option1()
        {
            string doorchosenmessage = "Eww! A Box of dirty underwear";
            Console.WriteLine(doorchosenmessage);
            Console.WriteLine(" ");
            string tryAgain = "Try again!";
            Console.WriteLine(tryAgain);
            menu2();
        }
        public void option2()
        {
            string doorchosesnmessage2 = "A gold star! You Win!";
            Console.WriteLine(doorchosesnmessage2);
            Thread.Sleep(1500);
            
            Console.Clear();
            
            Thread.Sleep(1500);
            Console.Clear();
            menu2();
        }
        public void option3()
        {
            string doorchosenmessage3 = "AWWW! NASTY! A pile of soiled baby diapers!";
            Console.WriteLine(doorchosenmessage3);
            Console.WriteLine(" ");
            string tryAgain = "Try again!";
            Console.WriteLine(tryAgain);
            Thread.Sleep(1500);
            Console.Clear();
            menu2();
        }
        public void option4()
        {
            string notAnOption = "That was not an option....get it together";
            Console.WriteLine(notAnOption);
            Thread.Sleep(1500);
            Console.Clear();
        
            Thread.Sleep(1500);
            Console.Clear();
            menu2();
        }

      





       
    }


}   
      
