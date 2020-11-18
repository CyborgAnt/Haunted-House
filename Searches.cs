using System;
using System.Text;
using static System.Console;
using HouseStory;

namespace Searches
{
    public class LivingRoomSearch
    {
        public void livingRoomSearch()
        {
            WriteLine("What would you like to do?");
            WriteLine("1. Search the Living Room, 2. Check the Mantle, 3. Check the Couch, 4. Check the Loveseat, 5. Head to the Damaged Door, 6. Head back to the Hall.");

            var livingRoomChoice = Int32.Parse(Console.ReadLine());
            switch(livingRoomChoice)
            {
                case 1:
                {    
                    WriteLine("You do a search of the Living Room but find nothing of interest.");
                    break;
                }
                case 2:
                {
                    WriteLine("On the Mantle, you find a pamphlet: 'Reverse the Curse!'. There is a lot of occult information and drawings about various curses, their causes, and if they are reverseable.");
                    WriteLine("One passage particularly catches your attention, as most of it is highlighted:");
                    string[] lines = System.IO.File.ReadAllLines(@"pamphlet.txt");

                    System.Console.WriteLine("Contents of WriteLines2.txt = ");
                    foreach (string line in lines)
                    {
                        Console.WriteLine("\t" + line);
                    }

                    // Keep the console window open in debug mode.
                    Console.WriteLine("Press any key to exit.");
                    System.Console.ReadKey();

                    WriteLine("You pocket the disturbing pamphlet - it might be of use, later.");
                    break;
                }   
                case 3:
                {
                    WriteLine("You search the Couch. There's nothing on the Couch but you see a silver-grey glint in between two of the cushions. Removing the cushions, you find a LOCKET. Opening it, you see a photograph of a tall man and an equally tall woman. On the back of the Locket is an inscription: 'May you always be protected by love and family.'");
                    WriteLine("You also notice that the Locket felt... warm... when you opened it. As you close the Locket, it goes back to a normal temperature. You slip the Locket around your neck and leave the Living Room.");
                    bool protection = true;
                    FirstFloor.hall();
                    break;
                } 
                case 4:
                {
                    WriteLine("You search the Loveseat. You find nothing under the cushions or in the back of the seat.");
                    break;
                }
                case 5:
                {
                    WriteLine("You force the Damaged Door open enough to squeeze through, and up in a small hallway.");
                    FirstFloor.smallerHall();    
                    break;
                }
                case 6:
                {
                    WriteLine("You decide to head back to the Hallway.");
                    FirstFloor.hall();
                    break;
                }
                default:
                    // code
                    break;
            }
        }
    }
   
    public class masterBedroomSearch
    {
        public static void wardrobeSearch()
        {
            WriteLine("As you move towards the Wardrobe, that odor gets stronger. You grab the handles, open the door...");
            WriteLine("... and a body tumbles out!!");
            WriteLine("\nIt appears to be a man, at least 6 and half feet tall, with long, salt-and-pepper hair. His lower body seems fine - wearing gray slacks - but his upper body is a mess. Deep slashes cover his chest and mid-section. There is a deep gash between his left shoulder and neck - possibly a bite mark?. His face is frozen in a mix of fright and... recognition?");
            WriteLine("This is a very disturbing site! Do you stay in the Master Bedroom?");

            WriteLine("1. Yes, 2. No");
            int wardrobeChoice = Int32.Parse(ReadLine());

            if(wardrobeChoice != 1)
                FirstFloor.hallContinue();
            else
                FirstFloor.masterBedroom();    

        }
    }

    public class EntertainmentRoom
    {
        public static void entRoomSearch(int choice)
        {        
            switch(choice)
            {
                case 1:
                    // Chamber - FINAL BATTLE(S)
                    break;
                case 2:
                    Console.WriteLine("There are bottles of various liquors behind the bar but nothing else of interest.");
                    // link back to Ent. Room
                    break;
                case 3:
                    // bathroom2
                    WriteLine("This bathroom is surprisngly intact, compare to other parts of the house. You don't find anything of interest ");
                    // link back to Ent. Room
                    break;
                case 4:
                    WriteLine("You take a closer look at the safe. Under the numerical keypad, there is a hand-written strip of paper: you only get 3 chances. Number 4 won't end well.");
                    WriteLine("Do you try to enter the code?");

                    
                    int safeOpen = Int32.Parse(ReadLine());
                    

                    safe();                    
                    break;
                case 5:
                    Basement.stairs();
                    break;
                default:
                    break;
            }
        }

        public static void safe()
        {
            
        }






    }
    public class KitchenSearch
    {
        public static void kitchenSearch(int choice)
        {
            switch (choice)
            {
                case 1:
                    //oven
                    //red herring?
                    break;
                case 2:
                    //green glow - BAD
                    break;
                case 3:
                    //yellow glow - GOOD, Safe code '7521'
                    break;
                case 4:
                    //method to Second Floor; new File and Classes
                    break;
                case 5:
                    //counter; flavor text
                    break;
                default:
                    break;
            }
        } 
    }

}