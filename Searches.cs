using System;
using System.Text;
using static System.Console;
using HouseStory;
using FinalBoss;

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
    
    public class EntertainmentRoom
    {
        public static void entRoomSearch(int choice)
        {        
            switch(choice)
            {
                case 1:
                {    
                    // Chamber - FINAL BATTLE(S)
                    Console.Clear();
                    WriteLine("You approach the large metal door; upon closer inspection, you see that the door is very thick and made of iron.\nAnd it’s a good thing because you hear a bellow from the other side of the door that is not remotely human.\nDespite that, you decide to open the door.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    WriteLine("You see a very large room, mostly empty - basically a chamber. Most of the walls are stone.\nIn front of the far wall is a table, possibly an altar, covered by some kind of dark purple cloth, trimmed in silver.\nOn that table are some leather-bound books and a couple of silver candle holders; there are tall, twin lit candles in each holder.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    WriteLine("You notice chalk or charcoal sketches on the left and right walls, on the inside of the door, and a very large drawing in front of the table.\nThese appear to be some form of Protection glyphs that you may have seen in a pamphlet earlier. \nThey consist of a triangle, small circles drawn around the points of the triangle, and a large circle surrounding the triangle-circle figure. The one on the floor is drawn in black and white chalk, is about 10-12 feet in diameter, and surrounds a monstrosity.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    WriteLine("Inside the floor glyph, in front of the table, stands a gaunt, humanoid figure, well over 7 feet tall. The tattered remains of pants and shoes cling to the lower body of the figure.\nThe upper body is lean muscle, covered by a sleek, grey coat of fur. The head… it LOOKS vaguely like a wolf, if a slightly feminine face was put on a wolf head and muzzle, and the jaws were about three times too wide and long.");
                    
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    WriteLine("THIS is the source of the strange occurrences in this house.");
                    WriteLine("This is a Loup-Garou!");
                    
                    // more code
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();

                    BossEncounter.battleNoLocket();
                }    
                    break;
                case 2:
                    Console.WriteLine("There are bottles of various liquors behind the bar but nothing else of interest.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Basement.entertainmentRoom();
                    break;
                case 3:
                    // bathroom2
                    WriteLine("This bathroom is surprisngly intact, compare to other parts of the house. You don't find anything of interest.");
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Basement.entertainmentRoom();
                    // link back to Ent. Room
                    break;
                case 4:
                {   
                    WriteLine("You take a closer look at the safe. Under the numerical keypad, there is a hand-written strip of paper: 'You only get 3 chances'.");
                    WriteLine("Do you try to enter the code?");
                    WriteLine("1. Yes, 2. No");
                    int safeOpen = Int32.Parse(ReadLine());
                    
                    safe(safeOpen);                    
                    break;
                }    
                case 5:
                    Basement.stairs();
                    break;
                default:
                    break;
            }
        }

        public static void safe(int open)
        {
            if(open == 1)
            {
                WriteLine("You decide to try and open the safe.");

                // variables
                int attemptsLeft = 3;       // number of attempts to open the safe
                int safeCode = 7520;
                int enteredCode = 0;    // initialized

                while(attemptsLeft > 0)
                {
                    WriteLine("Enter the 4-digit code: ");
                    enteredCode = Int32.Parse(ReadLine());
                    if(enteredCode != safeCode)
                    {
    
                        WriteLine("Incorrect!");
                        attemptsLeft -= 1;
                        WriteLine("{0} attempts left.", attemptsLeft);
                        if(attemptsLeft == 0)
                        {
                            WriteLine("You have tried to open the safe 3 times and failed. As you start to turn around to leave, you feel several sharp, piercing points go into your back and side. On the opposite side of the room, 4 small openings are now evident on the wall. You almost immediately feel dizzy and heavy-limbed. You've been drugged or poisoned!");
                            WriteLine("You collapse to the ground, consciousness slipping away. You are still alive but you will be out of commission for quite awhile, as the sleeping poison works its way through your system. You hope that 'she' doesn't find you before you wake up....");

                            // 'end program' code
                        }
                    }
                    if(enteredCode == safeCode)
                    {
                        WriteLine("Correct!");

                        WriteLine("\nThe internal lock of the safe clicks open. You open the door and see 3 items: a folded piece of paper, a newspaper clip, and a large, sliver-plated GUN.");
                        WriteLine("The newspaper clip describes a murder that happened near this house: 5 people were brutally murdered, about 4 weeks ago. 2 bodies were hard to identify, due to the amount of damage inflicted.");
                        WriteLine("The folded piece of paper contains a hand-written message, in a tight, small, cursive hand: She killed them! She is cursed! If you find this, leave this house before it is too late!");
                        WriteLine("You take the clip but leave the note. You also take the GUN. Whoever 'she' is, it sounds like you might need the gun if you find her.");
                        WriteLine("You return your attention to the Entertainment Room. Press 'Enter' to continue.");
                        Console.ReadLine();
                        var weapon = 1;     // signifying that you found the Gun

                        Basement.entertainmentRoom();
                    }
                }
            }
            if(open == 2)
            {
                WriteLine("You decide to not press your luck and ignore the keypad on the safe.\n");
                WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                Basement.entertainmentRoom();
            }
        }






    }
    public class KitchenSearch
    {
        public static void kitchenSearch(int choice)
        {
            Console.Clear();
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
                    WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
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