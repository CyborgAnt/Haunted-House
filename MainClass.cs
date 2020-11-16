/* Anthony Bonner
    11/1/2020 */

/* Can you survive the Haunted House?
 * You choose your path through the various rooms of the 2-story house,
 * trying to find - and survive - the source of the haunting. */

 // Pseudocode
 /* Classes:
    FirstFloor
    SecondFloor
    Chamber
    */

using System;
using System.Text;
using static System.Console;

namespace HouseStory
{
    class FirstFloor
    {
        public static void entry()
        {
            Console.WriteLine("You start in a small entryway. There are a couple of small end tables in the entry, with pictures and and flowers on them.");
            Console.WriteLine("There is a closet in the left corner on the entry, with it's door open. Inside are a few coats, jackets, and pairs of dress shoes. Directly ahead of you is a long, narrow hallway.");
            Console.WriteLine("To your left is a door that's closed. To your right, there is a partially opened door that opens onto a large, dimly lit room, possibly a Living Room.");

            Console.WriteLine("What would you like to do? Enter a number: ");
            WriteLine("1. Contine down the Hall, 2. Open the door to the left, 3. Go into the Living Room, 4. Check the Closet, Anything else to Quit");

            var roomChoice = Int32.Parse(ReadLine());

            // need to test the 'switch' and methods with it
            switch (roomChoice)
            {
                case 1:
                    mainHall();
                    break;
                case 2:
                    diningRoom();
                    break;
                case 3:
                    livingRoom();
                    break;
                case 4:
                    WriteLine("You see some old clothes and shoes, but nothing else of interest.");
                    entry();
                    break;
                default:
                    WriteLine("You have exited the program.");
                    return;
            }
        }

        static void mainHall()
        {
            // code
            Console.WriteLine("You start down the hallway.\n");
            Console.WriteLine("The hall passes by the Living Room. As you continue down the hall, there are a couple of doors on your left, probably closets or storage areas. A little further ahead, a smaller hallway branches off to the right. The main hallway ends at a T-section.");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check the first closet, 2.Check the second closet, 3.Take the smaller hall branch, 4.Continue down the main hallway to the T-section.");

            var hallwayChoice = Int32.Parse(Console.ReadLine());

            switch (hallwayChoice)
            {
                case 1:
                    closetOneSearch(); // use for other choices
                    break;
                case 2:
                    closetTwoSearch(); // encounter
                    break;
                case 3:
                    smallerHall();
                    break;
                case 4:
                    hallContinue();
                    break;
            }
        }
        
        static void diningRoom()
        {
            // code
        }
                
        static void livingRoom()
        {
            // code
        }










    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("Welcome to The Dark House, a Choose-Your-Own-Adventure Story!");
            WriteLine("You are investigating rumors of strange sights and sounds coming from an old house.");
            WriteLine("Will you find out the source of the problems? Will you survive the night? it all depends on what choices you make!");
            WriteLine("Press '1' to continue, '0' to quit:");

            var playerChoice = Int32.Parse(ReadLine());     // should convert input to an integer
            // var entryHall = new FirstFloor();

            if (playerChoice != 1)
                return;
            else
                FirstFloor.entry();
        }
    }




}   

    
/*
    public void mainHall()
        {
            
        }
        
        public void bedroom1()
        {
            Console.WriteLine("You enter the Bedroom.");
            Console.WriteLine("It's a large, nice bedroom, not suffering from the ramsacked appearance of most of the rest of the house. There is a Queen-sized bed, a couple of night stands, and a dresser. On top of one stand is a small lamp and an alarm clock. There's not much of interest on the other stand. A large mirror is on top of the dresser.\n");
            Console.WriteLine("There are a couple of closets in the bedroom, one to the left of the door, one on the opposite right corner; both closet doors are closed.")
            var bedroom1Search = 0;

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Investigate the Bed. \n
                                2.Investigate the Left Closet.\n
                                3.Investigate the Right Closet.\n
                                4.Investigate the Dresser.\n
                                5.Leave the Bedroom.");
            //switch and cases: noth, Trap, Trap-Roll, noth
        }
        public void diningRoom()
        {
            Console.WriteLine("You enter the Dining Room.");
            Console.WriteLine("There is a large wooden table in the center of the room. Most of the chairs around the table were overturned. There are some china cabinets in 2 of the corners of the room. Other than a large, draped window, there is nothing of note in the Dining Room.");

            var diningRoomChoice = 0;
            Console.WriteLine("What do you do next?\n");
            Console.WriteLine("1. Return to Bedroom.\n
                                2.Return to Hallway.\n

            // switch and cases

        }

        
        public void kitchen()
        {
            kitchenPortalSkull = 0;
            var kitchenChoice = 0;

            Console.WriteLine("You enter the Kitchen.");
            Console.WriteLine("There is an... odd aire about the room: it feels like the room is electrically charged. You see your standard Kitchen equipment: stove, refrigerator, cabintes, and dishes. There is nothing special about them, although you keep getting drawn to the stove.\n There is a center island, with a few tall stools around it. There are some odds and ends on the island counter. There is also a small room-within-a-room, in the far corner; there appear to be stairs that lead down into darkness.");
            Console.WriteLine("As you continue your search, you notice some odd things about the room: there are two spots on the wall, next to the stairs, that seem to be glowing. One is glowing a pale green, the other a pale, sickly yellow. There is also a large, red stain on the floor, in front of the room with the stairs.");
            Console.WriteLine("You have a lot of choices - what do you do?");

            kitchenChoice = Console.ReadLine();
            //loop back to this menu
            Console.WriteLine("1. Investigate the Red Stain. \n
                                2.Investigate the Green glow.\n
                                3.Investigate the Yellow glow.\n
                                4.Check the room with the Stairs.\n
                                5.Check the Island Counter.\n
                                6.Leave the kitcken.");
            //switch and cases: herring/descr., gd, bd, avg, flavor



        }
        public void masterBedoom()
        {
            Console.WriteLine("You enter a bedroom that is as large as many apartments - the Master Bedroom. Even in a dissheveled state, it is a remarkable room.\n");
            Console.WriteLine("There is a King-sized bed in the center of the room, with dark blue sheets, a blue and black comforter, and many pillows. There are 2 large windows - one on the far wall, one on the right wall - each floor-to-near-ceiling. ")
            Console.WriteLine("There is a large, walk-in closet in the far left corner of the room. There is a large fan-and-light-fixture on the ceiling, and a floor lamp next to the door. There is also a Dresser - although it's been overturned - and a large Cabinet - although it's als been overturned. The cabinet has scratches on the front and top of it.")
        }
        public void study()
        {
            Console.WriteLine("You open the door to the left of the hallway and enter the room. It appears to be a large study or library.\n There are shelves and shelves of books, books of every size and bindings. There is a very large window that looks out on the neighborhood, to the left.");
            Console.WriteLine("There are very comfortable-looking chairs throughout the room, as well as benches along the walls.");
            Console.WriteLine("Do you search the room? ");

            Console.WriteLine("1. Yes.\n
                            2.No - Leave the Study.\n");
            var int studySearch = Console.ReadLine();

            switch (studySearch)
            {
                case 1:
                // code
                case 2:
                    {
                        Console.WriteLine("The room is nice, cozy, almost inviting you to sit for a spell... but you resist. You return to the Entry.");
                        entry();
                        // maybe code this to return to the Entry Decision, instead
                    }

            }
        }
    }


    }
    */