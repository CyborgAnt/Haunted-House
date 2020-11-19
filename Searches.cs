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
                    WriteLine("You go to the oven. it's a standard gas stovetop-gas oven. You open the oven door and see... writing? ");
                    WriteLine("In a red marker or paint, on the back wall, is a message:");
                    WriteLine("She is cursed!");
                    WriteLine("You don't know who 'she' is. You shut the oven door.");
                    FirstFloor.kitchen();
                    break;
                case 2:
                    WriteLine("You walk up to the spot on the wall where the green glow is coming from. There's no heat or cold in the area, just the glow. You push on the wall but nothing happens.");
                    WriteLine("You then notice a discolored spot on wall, a few feet to the left. You press on it, and a section of the wall swings open, revealing the green glow....");
                    WriteLine("Multiple arms shoot from the glow! They grab onto your arms, you hair, anywhere that they can find a grip! You are yanked into the green light... and land in the front yard of another house. As you sit up, the front door of this house opens up and 3 figures - 2 women and a man - rush out to meet you.");
                    WriteLine("'Thank goodness we snagged you in time!', one of the women exclaim. 'You are not prepared to take on what's in that house - come with us!', the man states. You follow them into the house, where you fate is put on hold until Part II....");
                    break;
                case 3:
                    //yellow glow - GOOD
                    WriteLine("You walk up to the spot on the wall where the yellow glow is coming from. You don't see any kind of opening but you do see a small, slightly discolored spot on the wall, a few feet away. You push it and a stone slab slides down into an until-then unseen groove. Inside the opening is what appears to be a small altar or shrine. There are dozens of small, lit candles - the source of the yellow light. There is a medium-sized silver cross on top of a two-tiered table. There are smaller crosses on either end of the lower tier, set into bases. On the top tier is... a box of bullets?");
                    WriteLine("You open the box and see 12 long, silver bullets. This is not a coincidence, you think to your self. You also realize that silver bullets need some kind of Gun to go with them... and possibly some target to use them on.");
                    WriteLine("You take the box of bullets and leave the shrine, heading back into the kitchen.");
                    FirstFloor.kitchen();
                    break;
                case 4:
                    Basement.stairs();
                    break;
                case 5:
                    WriteLine("You find some odds and ends: a couple of take-out menus, a few receipts, a newspaper. You don't see anything else of importance.");
                    FirstFloor.kitchen();
                    break;
                case 6:
                    WriteLine("You leave the Kitchen and head back into the main Hall.");
                    FirstFloor.hall();
                    break;
                default:
                    break;
            }
        } 
    }

}